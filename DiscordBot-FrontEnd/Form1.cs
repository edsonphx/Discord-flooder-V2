using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBot_FrontEnd
{
    public partial class Form1 : Form
    {
        static bool flood = false;
        static int delay;
        static string inviteLink;
        static string channelId;
        static string message;
        static string tokenPath;
        static string proxyPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tokenPath = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            proxyPath = openFileDialog2.FileName;
        }

        private void start_Click(object sender, EventArgs e)
        {
            flood = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            flood = false;
        }

        private void delay_TextChanged(object sender, EventArgs e)
        {
            delay = int.Parse(txtdelay.Text);
        }

        private void invite_TextChanged(object sender, EventArgs e)
        {
            inviteLink = invite.Text;
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            channelId = id.Text;
        }

        private void txtmessage_TextChanged(object sender, EventArgs e)
        {
            message = txtmessage.Text;
        }
    }
}
