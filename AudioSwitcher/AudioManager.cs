using NAudio.CoreAudioApi;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace AudioSwitcher
{
    internal static class AudioManager
    {
        internal static void SwitchActiveDevice(List<Device> devices)
        {
            Device nextDevice = new Device();
            if (Properties.Settings.Default.LastAudioDevice == "")
            {
                Properties.Settings.Default.LastAudioDevice = devices.First().Name;
            }
            foreach (Device item in devices)
            {
                if (Properties.Settings.Default.LastAudioDevice == item.Name)
                {
                    if (devices.Last() != item)
                    {
                        nextDevice = devices.ElementAt(devices.IndexOf(item) + 1);
                    }
                    else
                    {
                        nextDevice = devices.First();
                    }
                    break;
                }
            }
            Properties.Settings.Default.LastAudioDevice = nextDevice.Name;
            Properties.Settings.Default.Save();
            Thread threadNotification = new Thread(() => ShowNotification("Active Audio Device: " + nextDevice.Name));
            threadNotification.Start();
            SetActiveDevice(nextDevice);
            threadNotification.Join();
        }
        private static void ShowNotification(string text)
        {
            var notification = new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipTitle = "Audio Device Switcher",
                BalloonTipText = text,
            };
            notification.ShowBalloonTip(3000);
            Thread.Sleep(3000);
            notification.Dispose();
        }
        internal static List<Device> ActiveDevices
        {
            get
            {
                var enumerator = new MMDeviceEnumerator();
                MMDeviceCollection mMDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
                List<Device> devices = new List<Device>();
                int i = 1;
                foreach (var item in mMDevices)
                {
                    string deviceName = item.FriendlyName.Substring(0, item.FriendlyName.IndexOf("(")).TrimEnd();
                    devices.Add(new Device(i, deviceName));
                    i++;
                }
                return devices;
            }
        }
        internal static string DefaultDevice
        {
            get
            {
                var enumerator = new MMDeviceEnumerator();
                MMDevice mMDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
                string deviceName = mMDevice.FriendlyName.Remove(mMDevice.FriendlyName.IndexOf("(")).TrimEnd();
                return deviceName;
            }
        }
        internal static void SetActiveDevice(Device device)
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "nircmd.exe",
                    Arguments = $"setdefaultsounddevice \"{device.Name}\" 0",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "nircmd.exe",
                    Arguments = $"setdefaultsounddevice \"{device.Name}\" 1",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "nircmd.exe",
                    Arguments = $"setdefaultsounddevice DFX Speakers 2",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            proc.Start();
        }
    }
}
