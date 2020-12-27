using System;
using System.Windows.Forms;
using DiscordFloodCore;
using DiscordFlooderCore.DTO;

namespace DiscordBot_FrontEnd
{
    public partial class Form1 : Form
    {
        private string TokenPath { get; set; }
        private string ProxyPath { get; set; }
        private int Delay { get; set; } = 500;
        private string InviteLink { get; set; }
        private string ChannelId { get; set; }
        private string Message { get; set; } = "https://github.com/edsonphx/Discord-flooder-V2";

        public Form1()
        {
            InitializeComponent();
        }

        private void FilePathToTokenList_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            TokenPath = openFileDialog1.FileName;
        }

        private void FilePathToProxyList_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            ProxyPath = openFileDialog2.FileName;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!Core.IsRunning) 
            {
                var inbound = new DataDTO(TokenPath,
                ProxyPath,
                Delay,
                InviteLink,
                ChannelId,
                Message);

                new Core(inbound).Start();
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Core.Stop();
        }

        private void Delay_TextChanged(object sender, EventArgs e)
        {
            int delay;
            if(int.TryParse(txtdelay.Text, out delay))
            {
                Delay = delay;
            }
        }

        private void Invite_TextChanged(object sender, EventArgs e)
        {
            InviteLink = invite.Text;
        }

        private void ChannelId_TextChanged(object sender, EventArgs e)
        {
            ChannelId = id.Text;
        }

        private void TextMessage_TextChanged(object sender, EventArgs e)
        {
            Message = txtmessage.Text;
        }

        private void Form_Close(object sender, FormClosingEventArgs e)
        {
            Core.Stop();
        }
    }
}
