using System;
using System.Windows.Forms;
using DiscordFlooder.FrontEnd.View;

namespace DiscordFlooder.FrontEnd
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApplicationView());
        }
    }
}
