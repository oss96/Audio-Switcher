namespace AudioSwitcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelCurrentDevice = new System.Windows.Forms.Label();
            this.buttonCreateShortcut = new System.Windows.Forms.Button();
            this.checkedListBoxDevices = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentDevice
            // 
            this.labelCurrentDevice.AutoSize = true;
            this.labelCurrentDevice.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDevice.ForeColor = System.Drawing.Color.White;
            this.labelCurrentDevice.Location = new System.Drawing.Point(13, 51);
            this.labelCurrentDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentDevice.Name = "labelCurrentDevice";
            this.labelCurrentDevice.Size = new System.Drawing.Size(212, 33);
            this.labelCurrentDevice.TabIndex = 1;
            this.labelCurrentDevice.Text = "Current Device: ";
            // 
            // buttonCreateShortcut
            // 
            this.buttonCreateShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateShortcut.BackColor = System.Drawing.Color.Silver;
            this.buttonCreateShortcut.Enabled = false;
            this.buttonCreateShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateShortcut.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonCreateShortcut.ForeColor = System.Drawing.Color.Black;
            this.buttonCreateShortcut.Location = new System.Drawing.Point(200, 494);
            this.buttonCreateShortcut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateShortcut.Name = "buttonCreateShortcut";
            this.buttonCreateShortcut.Size = new System.Drawing.Size(180, 54);
            this.buttonCreateShortcut.TabIndex = 12;
            this.buttonCreateShortcut.Text = "Create Shortcut";
            this.buttonCreateShortcut.UseVisualStyleBackColor = false;
            this.buttonCreateShortcut.EnabledChanged += new System.EventHandler(this.ButtonCreateShortcut_EnabledChanged);
            this.buttonCreateShortcut.Click += new System.EventHandler(this.ButtonCreateShortcut_Click);
            // 
            // checkedListBoxDevices
            // 
            this.checkedListBoxDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxDevices.CheckOnClick = true;
            this.checkedListBoxDevices.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxDevices.FormattingEnabled = true;
            this.checkedListBoxDevices.Location = new System.Drawing.Point(13, 88);
            this.checkedListBoxDevices.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxDevices.Name = "checkedListBoxDevices";
            this.checkedListBoxDevices.Size = new System.Drawing.Size(558, 398);
            this.checkedListBoxDevices.Sorted = true;
            this.checkedListBoxDevices.TabIndex = 6;
            this.checkedListBoxDevices.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedListBoxDevices_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(584, 23);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(42, 19);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.checkedListBoxDevices);
            this.Controls.Add(this.buttonCreateShortcut);
            this.Controls.Add(this.labelCurrentDevice);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Device Switcher";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentDevice;
        private System.Windows.Forms.Button buttonCreateShortcut;
        private System.Windows.Forms.CheckedListBox checkedListBoxDevices;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

