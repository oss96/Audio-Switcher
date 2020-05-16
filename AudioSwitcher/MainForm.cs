using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AudioSwitcher
{
    public partial class MainForm : Form
    {
        List<Device> devices = new List<Device>();


        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            RefreshDevices();
        }


        private void InitializeControls()
        {
            this.MinimumSize = new Size(600, 600);
            this.BackColor = Color.FromArgb(54, 57, 63);
            checkedListBoxDevices.BackColor = Color.FromArgb(47, 49, 54);
            menuStrip1.Renderer = new MyRenderer();
            menuStrip1.BackColor = Color.FromArgb(54, 57, 63);
            menuStrip1.ForeColor = Color.White;
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.FromArgb(54, 57, 63);
                item.ForeColor = Color.White;
                foreach (ToolStripMenuItem dropDownItems in item.DropDown.Items)
                {
                    dropDownItems.BackColor = Color.FromArgb(54, 57, 63);
                    dropDownItems.ForeColor = Color.White;
                    dropDownItems.BackgroundImage = null;
                    dropDownItems.DisplayStyle = ToolStripItemDisplayStyle.Text;
                }
            }
        }

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            devices = AudioManager.ActiveDevices;
            RefreshDevices();
            foreach (Device item in devices)
            {
                checkedListBoxDevices.Items.Add(item.Name);
            }
        }
        private void CheckedListBoxDevices_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkedListBoxDevices.CheckedItems.Count == 1)
            {
                buttonCreateShortcut.Enabled = false;
            }
            else if (checkedListBoxDevices.CheckedItems.Count > 1)
            {
                buttonCreateShortcut.Enabled = true;
            }
            else
            {
                buttonCreateShortcut.Enabled = false;
            }
        }
        private void ButtonCreateShortcut_EnabledChanged(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled)
            {
                buttonCreateShortcut.BackColor = Color.White;
            }
            else
            {
                buttonCreateShortcut.BackColor = Color.Silver;
            }

        }
        private void ButtonCreateShortcut_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog = new SaveFileDialog
            {
                Filter = "Shortcuts | *.lnk",
                RestoreDirectory = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Please choose a folder where the Shortcut should be created",
                AddExtension = false,
                OverwritePrompt = true
            };
            DialogResult r = openFileDialog.ShowDialog();

            if (r == DialogResult.OK)
            {
                string checkedDevices = "";
                foreach (var item in checkedListBoxDevices.CheckedItems)
                {
                    checkedDevices += $" \"{item}\" ";
                }
                checkedDevices.TrimEnd();
                CreateShortcut(openFileDialog.FileName, Path.GetDirectoryName(Application.ExecutablePath) + "\\" + Path.GetFileName(Application.ExecutablePath), checkedDevices, Path.GetDirectoryName(Application.ExecutablePath), "");
            }
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info about = new Info();
            Thread showAbout = new Thread(() => { about.ShowDialog(); });
            showAbout.Start();
        }
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/oss96/Audio-Switcher/blob/master/README.md");
        }
        #endregion
        internal void RefreshDevices()
        {
            checkedListBoxDevices.Items.Clear();
            checkedListBoxDevices.Refresh();
            labelCurrentDevice.Text = $"Current Device: {AudioManager.DefaultDevice}";
        }
        internal void CreateShortcut(string creationPath, string targetPath, string devices, string targetDirectory, string iconLocation)
        {
            WshShell wsh = new WshShell();
            IWshShortcut shortcut = wsh.CreateShortcut(creationPath) as IWshShortcut;
            shortcut.Arguments = devices;
            shortcut.TargetPath = targetPath;
            shortcut.WindowStyle = 1;
            shortcut.WorkingDirectory = targetDirectory;
            shortcut.IconLocation = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\Icon black.ico";
            shortcut.Save();
        }
    }

    class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() : base(new MyColors()) { }
    }

    class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(47, 49, 54);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(47, 49, 54);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(47, 49, 54);
        public override Color MenuBorder => Color.FromArgb(47, 49, 54);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(47, 49, 54);
        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(47, 49, 54);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(47, 49, 54);
        public override Color ToolStripDropDownBackground => Color.FromArgb(47, 49, 54);
        public override Color ToolStripBorder => Color.FromArgb(54, 57, 63);
        public override Color ToolStripGradientBegin => Color.FromArgb(54, 57, 63);
        public override Color ToolStripGradientEnd => Color.FromArgb(54, 57, 63);
        public override Color ToolStripGradientMiddle => Color.FromArgb(54, 57, 63);
        public override Color MenuItemBorder => Color.FromArgb(54, 57, 63);
        public override Color ToolStripContentPanelGradientBegin => Color.FromArgb(54, 57, 63);
    }


}
