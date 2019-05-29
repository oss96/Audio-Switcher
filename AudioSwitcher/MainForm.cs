using AudioSwitcher.Properties;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioSwitcher
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(54, 57, 63);
            checkedListBoxDevices.BackColor = Color.FromArgb(47, 49, 54);
            panel1.BackColor = Color.FromArgb(47, 49, 54);
            if (Settings.Default.Devices == null)
            {
                Settings.Default.Devices = new System.Collections.Specialized.StringCollection();
            }
            RefreshDevices();
        }

        #region Events
        private void Button1_Click(object sender, EventArgs e)
        {
            /*if (Settings.Default.CurrentDevice == "none")
            {
                Settings.Default.CurrentDevice = "Sound System";
                Settings.Default.Save();
            }

            if (Settings.Default.CurrentDevice == "Sound System")
            {
                Settings.Default.CurrentDevice = "Beyerdynamic DT 770 Pro";
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.CurrentDevice = "Sound System";
                Settings.Default.Save();
            }
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "nircmd.exe",
                    Arguments = $"setdefaultsounddevice \"{Settings.Default.CurrentDevice}\" 0",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            proc.Start();*/
            this.labelCurrentDevice.Text = $"Current Device: {Settings.Default.CurrentDevice}";
            Settings.Default.Save();
            List<string> s = Settings.Default.Devices.Cast<string>().ToList();
        }
        private void ButtonAddDevice_Click(object sender, EventArgs e)
        {
            buttonAddDevice.Hide();
            buttonCancel.Show();
            buttonSave.Show();
            textBoxDeviceName.Show();
            labelAudioDevice.Show();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            buttonSave.Hide();
            buttonCancel.Hide();
            textBoxDeviceName.Hide();
            labelAudioDevice.Hide();
            buttonAddDevice.Show();
            Settings.Default.Devices.Add(textBoxDeviceName.Text);
            Settings.Default.Save();
            RefreshDevices();
            textBoxDeviceName.Text = "";
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            buttonSave.Hide();
            buttonCancel.Hide();
            textBoxDeviceName.Hide();
            labelAudioDevice.Hide();
            buttonAddDevice.Show();
            RefreshDevices();
            textBoxDeviceName.Text = "";
        }
        private void ButtonRemoveDevice_Click(object sender, EventArgs e)
        {
            foreach (string item in checkedListBoxDevices.CheckedItems)
            {
                if (Settings.Default.Devices.Contains(item))
                {
                    Settings.Default.Devices.Remove(item);
                }
            }
            Settings.Default.Save();
            RefreshDevices();
            buttonRemoveDevice.Enabled = false;
            buttonRemoveDevice.BackColor = Color.Silver;
        }
        private void TextBoxDeviceName_TextChanged(object sender, EventArgs e)
        {
            if (checkedListBoxDevices.Items.Contains(textBoxDeviceName.Text))
            {
                labelErrorMessage.Show();
                buttonSave.Enabled = false;
                buttonSave.BackColor = Color.Silver;
            }
            else
            {
                labelErrorMessage.Hide();
                buttonSave.Enabled = true;
                buttonSave.BackColor = Color.White;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshDevices();
        }
        private void CheckedListBoxDevices_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkedListBoxDevices.CheckedItems.Count != 0)
            {
                buttonRemoveDevice.Enabled = true;
            }
            else
            {
                buttonRemoveDevice.Enabled = false;
            }
        }
        private void ButtonRemoveDevice_EnabledChanged(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled)
            {
                buttonRemoveDevice.BackColor = Color.White;
            }
            else
            {
                buttonRemoveDevice.BackColor = Color.Silver;
            }
        }
        #endregion

        internal void RefreshDevices()
        {
            checkedListBoxDevices.Items.Clear();
            checkedListBoxDevices.Items.AddRange(Settings.Default.Devices.Cast<string>().ToArray());
            checkedListBoxDevices.Refresh();
            var enumerator = new MMDeviceEnumerator();
            MMDevice mMDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
            string deviceName = mMDevice.FriendlyName.Remove(mMDevice.FriendlyName.IndexOf("(")).TrimEnd();
            labelCurrentDevice.Text = $"Current Device: {deviceName}";
        }
    }
}
