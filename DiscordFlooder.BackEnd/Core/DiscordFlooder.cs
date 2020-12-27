using DiscordFlooder.BackEnd.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;

namespace DiscordFlooder.BackEnd.Core
{
    public class DiscordFlooder
    {
        public static bool IsRunning { get; set; }
        private IEnumerable<string> TokenList { get; set; }
        private IEnumerable<string> ProxyList { get; set; }
        private int Delay { get; set; }
        private string InviteLink { get; set; }
        private string InviteCode { get; set; }
        private string ChannelId { get; set; }
        private string Message { get; set; }
        private bool SkipJoin { get; set; }

        private readonly int _discordInviteCodeLenght = 8;
        private readonly string _discordApiUrlBase = "https://discord.com/api/v8";

        public DiscordFlooder(DiscordFlooderInbound inbound)
        {
            IsRunning = true;
            TokenList = GetList(inbound.TokenListPath);
            ProxyList = GetList(inbound.ProxyListPath);
            Delay = inbound.Delay;
            InviteLink = inbound.InviteLink;
            ChannelId = inbound.ChannelId;
            Message = inbound.Message;
            SkipJoin = inbound.SkipJoin;
        }

        private IEnumerable<string> GetList(string filePath)
        {
            var result = new List<string>();

            if (filePath == null)
                return result;
            
            var lines = File.ReadAllLines(filePath);

            foreach (var item in lines)
            {
                result.Add(item);
            }

            return result;
        }
        public static void Stop()
        {
            IsRunning = false;
        }

        public void Start()
        {
            if (!SkipJoin)
            {
                if (InviteLink.Length < 8)
                {
                    Console.WriteLine($"Invalid invite link. {InviteLink}");
                    Environment.Exit(0);
                }
                InviteCode = InviteLink.Substring(InviteLink.Length - _discordInviteCodeLenght);

                var urlToJoinChannel = $"{_discordApiUrlBase}/invites/{InviteCode}";
                JoinChannel(urlToJoinChannel);
            }

            var urlToSendMessage = $"{_discordApiUrlBase}/channels/{ChannelId}/messages";
            var t = new Thread(() => SendMessage(urlToSendMessage));

            t.Start();
        }

        private void JoinChannel(string uri)
        {
            foreach (var token in TokenList)
            {
                var httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Add("Authorization", token);
                var response = httpClient.PostAsync(uri, null).Result;

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
        private void SendMessage(string uri)
        {
            while (IsRunning)
            {
                foreach (var token in TokenList)
                {
                    var httpClient = new HttpClient();

                    httpClient.DefaultRequestHeaders.Add("Authorization", token);

                    var content = new StringContent($"{{\"content\": \"{Message}\"}}", System.Text.Encoding.UTF8, "application/json");

                    var response = httpClient.PostAsync(uri, content).Result;

                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Console.WriteLine($"Error while sending message to channel. Status: {response.StatusCode} Token: {token}");
                    }
                    else
                    {
                        Console.WriteLine($"{token} sended message to channel.");
                    }
                    Thread.Sleep(Delay);
                }
            }
        }
    }
}
