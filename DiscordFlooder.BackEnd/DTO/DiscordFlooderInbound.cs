namespace DiscordFlooder.BackEnd.DTO
{
    public class DiscordFlooderInbound
    {
        public DiscordFlooderInbound(string tokenListPath,
            string proxyListPath,
            int delay, 
            string inviteLink,
            string channelId,
            string message,
            bool skipJoin)
        {
            TokenListPath = tokenListPath;
            ProxyListPath = proxyListPath;
            Delay = delay;
            InviteLink = inviteLink;
            ChannelId = channelId;
            Message = message;
            SkipJoin = skipJoin;
        }

        public string TokenListPath { get; private set; }
        public string ProxyListPath { get; private set; }
        public int Delay { get; private set; }
        public string InviteLink { get; private set; }
        public string ChannelId { get; private set; }
        public string Message { get; private set; }
        public bool SkipJoin { get; private set; }
    }
}
