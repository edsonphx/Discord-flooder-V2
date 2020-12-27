using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DiscordFlooder
{
    class Program
    {
        private static IConfigurationRoot Configuration;
        private static IEnumerable<string> _tokenList;
        private static int _delay = 1000;
        private readonly int _discordInviteCodeLenght = 8;
        private readonly string _discordApiUrlBase = "https://discord.com/api/v8";

        static void Main(string[] args)
        {
            if(args.Length < 3)
            {
                Console.WriteLine("Invalid number of parameters");
                Console.WriteLine("Usage: [InviteLink] [IdChannel]");
                Console.WriteLine("Optional: [Delay] [Message]");
                Environment.Exit(0);
            }

            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            _tokenList = Configuration.GetSection("DiscordTokenList").AsEnumerable()
                .Select(x => x.Value)
                .Where(x => x != null);

            int delay;
            if(int.TryParse(args[2], out delay))
            {
                _delay = delay;
            }

            new Program().Run(args);
        }
        private void Run(string[] args)
        {
            var inviteLink = args[0];
            var idChannel = args[1];
            var message = args[3] ?? "Discord Flooder by https://github.com/edsonphx";

            if (inviteLink.Length < 8)
            {
                Console.WriteLine($"Invalid invite link. {inviteLink}");
                Environment.Exit(0);
            }
            var inviteCode = inviteLink.Substring(inviteLink.Length - _discordInviteCodeLenght);

            var urlToJoinChannel = $"{_discordApiUrlBase}/invites/{inviteCode}";
            JoinChannelAsync(urlToJoinChannel).Wait();

            var urlToSendMessage = $"{_discordApiUrlBase}/channels/{idChannel}/messages";
            SendMessage(urlToSendMessage, message).Wait();
        }
        private async Task JoinChannelAsync(string uri)
        {
            foreach (var token in _tokenList)
            {
                var httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Add("Authorization", token);
                var response = await httpClient.PostAsync(uri,null);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine($"Error while trying to join in server. Status: {response.StatusCode} Token: {token}");
                }
                else
                {
                    Console.WriteLine($"{token} joined the server.");
                }
            }
        }
        private async Task SendMessage(string uri, string message)
        {
            while (true)
            {
                foreach (var token in _tokenList)
                {
                    var httpClient = new HttpClient();

                    httpClient.DefaultRequestHeaders.Add("Authorization", token);

                    var content = new StringContent( $"{{\"content\": \"{message}\"}}",System.Text.Encoding.UTF8,"application/json");

                    var response = await httpClient.PostAsync(uri, content);

                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Console.WriteLine($"Error while sending message to channel. Status: {response.StatusCode} Token: {token}");
                    }
                    else
                    {
                        Console.WriteLine($"{token} sended message to channel.");
                    }
                }
                await Task.Delay(_delay);
            }
        }
    }
}