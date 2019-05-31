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
                tmp.Remove(args[0]);
                string arguments = "";
                foreach (var item in tmp)
                {
                    arguments += item + " ";
                }
                tmp = arguments.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<Device> devices = new List<Device>();
                int i = 1;
                foreach (string item in tmp)
                {
                    devices.Add(new Device(i, item.TrimEnd()));
                    i++;
                }
                AudioSwitcher.AudioManager.SwitchActiveDevice(devices);
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
