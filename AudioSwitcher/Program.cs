using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AudioSwitcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                //run program without an interface
                List<string> tmp = args.ToList();
                tmp.Remove(tmp.First());
                List<Device> devices = new List<Device>();
                int i = 1;
                foreach (string item in tmp)
                {
                    devices.Add(new Device(i, item.TrimEnd()));
                    i++;
                }
                AudioManager.SwitchActiveDevice(devices);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
