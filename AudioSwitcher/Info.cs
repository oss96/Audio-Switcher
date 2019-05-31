using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioSwitcher
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(54, 57, 63);
            this.ForeColor = Color.White;
        }

        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/oss96");
        }
        private void ButtonOk_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
