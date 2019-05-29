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
            this.button1 = new System.Windows.Forms.Button();
            this.labelCurrentDevice = new System.Windows.Forms.Label();
            this.textBoxDeviceName = new System.Windows.Forms.TextBox();
            this.labelAudioDevice = new System.Windows.Forms.Label();
            this.buttonAddDevice = new System.Windows.Forms.Button();
            this.checkedListBoxDevices = new System.Windows.Forms.CheckedListBox();
            this.buttonRemoveDevice = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto", 12F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(205, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelCurrentDevice
            // 
            this.labelCurrentDevice.AutoSize = true;
            this.labelCurrentDevice.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDevice.ForeColor = System.Drawing.Color.White;
            this.labelCurrentDevice.Location = new System.Drawing.Point(13, 9);
            this.labelCurrentDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentDevice.Name = "labelCurrentDevice";
            this.labelCurrentDevice.Size = new System.Drawing.Size(212, 33);
            this.labelCurrentDevice.TabIndex = 1;
            this.labelCurrentDevice.Text = "Current Device: ";
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxDeviceName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxDeviceName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDeviceName.Location = new System.Drawing.Point(690, 56);
            this.textBoxDeviceName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDeviceName.Name = "textBoxDeviceName";
            this.textBoxDeviceName.Size = new System.Drawing.Size(181, 27);
            this.textBoxDeviceName.TabIndex = 2;
            this.textBoxDeviceName.Visible = false;
            this.textBoxDeviceName.TextChanged += new System.EventHandler(this.TextBoxDeviceName_TextChanged);
            // 
            // labelAudioDevice
            // 
            this.labelAudioDevice.AutoSize = true;
            this.labelAudioDevice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAudioDevice.ForeColor = System.Drawing.Color.White;
            this.labelAudioDevice.Location = new System.Drawing.Point(705, 33);
            this.labelAudioDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAudioDevice.Name = "labelAudioDevice";
            this.labelAudioDevice.Size = new System.Drawing.Size(150, 19);
            this.labelAudioDevice.TabIndex = 3;
            this.labelAudioDevice.Text = "Audio Device Name";
            this.labelAudioDevice.Visible = false;
            // 
            // buttonAddDevice
            // 
            this.buttonAddDevice.BackColor = System.Drawing.Color.White;
            this.buttonAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDevice.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonAddDevice.ForeColor = System.Drawing.Color.Black;
            this.buttonAddDevice.Location = new System.Drawing.Point(691, 91);
            this.buttonAddDevice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDevice.Name = "buttonAddDevice";
            this.buttonAddDevice.Size = new System.Drawing.Size(180, 54);
            this.buttonAddDevice.TabIndex = 4;
            this.buttonAddDevice.Text = "Add Device";
            this.buttonAddDevice.UseVisualStyleBackColor = false;
            this.buttonAddDevice.Click += new System.EventHandler(this.ButtonAddDevice_Click);
            // 
            // checkedListBoxDevices
            // 
            this.checkedListBoxDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxDevices.CheckOnClick = true;
            this.checkedListBoxDevices.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxDevices.FormattingEnabled = true;
            this.checkedListBoxDevices.Location = new System.Drawing.Point(4, 4);
            this.checkedListBoxDevices.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxDevices.Name = "checkedListBoxDevices";
            this.checkedListBoxDevices.Size = new System.Drawing.Size(299, 506);
            this.checkedListBoxDevices.Sorted = true;
            this.checkedListBoxDevices.TabIndex = 6;
            this.checkedListBoxDevices.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedListBoxDevices_MouseUp);
            // 
            // buttonRemoveDevice
            // 
            this.buttonRemoveDevice.BackColor = System.Drawing.Color.Silver;
            this.buttonRemoveDevice.Enabled = false;
            this.buttonRemoveDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveDevice.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonRemoveDevice.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveDevice.Location = new System.Drawing.Point(691, 153);
            this.buttonRemoveDevice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveDevice.Name = "buttonRemoveDevice";
            this.buttonRemoveDevice.Size = new System.Drawing.Size(180, 54);
            this.buttonRemoveDevice.TabIndex = 7;
            this.buttonRemoveDevice.Text = "Remove Device";
            this.buttonRemoveDevice.UseVisualStyleBackColor = false;
            this.buttonRemoveDevice.EnabledChanged += new System.EventHandler(this.ButtonRemoveDevice_EnabledChanged);
            this.buttonRemoveDevice.Click += new System.EventHandler(this.ButtonRemoveDevice_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(690, 91);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 54);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(781, 91);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 54);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessage.Location = new System.Drawing.Point(875, 59);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(164, 19);
            this.labelErrorMessage.TabIndex = 10;
            this.labelErrorMessage.Text = "Device already added";
            this.labelErrorMessage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkedListBoxDevices);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(879, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 555);
            this.panel1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRemoveDevice);
            this.Controls.Add(this.buttonAddDevice);
            this.Controls.Add(this.labelAudioDevice);
            this.Controls.Add(this.textBoxDeviceName);
            this.Controls.Add(this.labelCurrentDevice);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Device Switcher";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCurrentDevice;
        private System.Windows.Forms.TextBox textBoxDeviceName;
        private System.Windows.Forms.Label labelAudioDevice;
        private System.Windows.Forms.Button buttonAddDevice;
        private System.Windows.Forms.CheckedListBox checkedListBoxDevices;
        private System.Windows.Forms.Button buttonRemoveDevice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Panel panel1;
    }
}

