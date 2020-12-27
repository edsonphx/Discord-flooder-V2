using System;
using System.Windows.Forms;
using DiscordFlooder.BackEnd.DTO;
using Core = DiscordFlooder.BackEnd.Core;

namespace DiscordFlooder.FrontEnd.View
{
    public partial class ApplicationView : Form
    {
        private string TokenPath { get; set; }
        private string ProxyPath { get; set; }
        private int Delay { get; set; } = 500;
        private string InviteLink { get; set; }
        private string ChannelId { get; set; }
        private string Message { get; set; } = "https://github.com/edsonphx/Discord-flooder-V2";
        private bool SkipJoin { get; set; }

        public ApplicationView()
        {
            InitializeComponent();
        }

        private void FilePathToTokenList_Click(object sender, EventArgs e)
        {
            openFilePathTokenList.ShowDialog();
            TokenPath = openFilePathTokenList.FileName;
        }

        private void FilePathToProxyList_Click(object sender, EventArgs e)
        {
            openFilePathProxyList.ShowDialog();
            ProxyPath = openFilePathProxyList.FileName;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (!Core.DiscordFlooder.IsRunning)
            {
                var inbound = new DiscordFlooderInbound(TokenPath,
                ProxyPath,
                Delay,
                InviteLink,
                ChannelId,
                Message,
                SkipJoin);

                new Core.DiscordFlooder(inbound).Start();
                executeButton.Text = "Stop";
            }
            else 
            {
                BackEnd.Core.DiscordFlooder.Stop();
                executeButton.Text = "Start";
            }
        }
       
        private void Delay_TextChanged(object sender, EventArgs e)
        {
            int delay;
            if(int.TryParse(messageDelayTextBox.Text, out delay))
            {
                Delay = delay;
            }
        }

        private void Invite_TextChanged(object sender, EventArgs e)
        {
            InviteLink = inviteTextBox.Text;
        }

        private void ChannelId_TextChanged(object sender, EventArgs e)
        {
            ChannelId = channelIdTextBox.Text;
        }

        private void TextMessage_TextChanged(object sender, EventArgs e)
        {
            Message = messageTextBox.Text;
        }

        private void Form_Close(object sender, FormClosingEventArgs e)
        {
            Core.DiscordFlooder.Stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SkipJoin = skipJoinCheckBox.Checked;
        }
    }
}
