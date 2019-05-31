namespace AudioSwitcher
{
    partial class Info
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
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelMadeBy = new System.Windows.Forms.Label();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(18, 18);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(150, 73);
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelMadeBy
            // 
            this.labelMadeBy.AutoSize = true;
            this.labelMadeBy.Location = new System.Drawing.Point(176, 49);
            this.labelMadeBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMadeBy.Name = "labelMadeBy";
            this.labelMadeBy.Size = new System.Drawing.Size(168, 19);
            this.labelMadeBy.TabIndex = 3;
            this.labelMadeBy.Text = "Made by Ossama Alali";
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfile.BackColor = System.Drawing.Color.White;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonProfile.ForeColor = System.Drawing.Color.Black;
            this.buttonProfile.Location = new System.Drawing.Point(109, 99);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(173, 54);
            this.buttonProfile.TabIndex = 13;
            this.buttonProfile.Text = "Github Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.ButtonProfile_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.BackColor = System.Drawing.Color.White;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.Location = new System.Drawing.Point(159, 176);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(64, 34);
            this.buttonOk.TabIndex = 14;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click_1);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 223);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.labelMadeBy);
            this.Controls.Add(this.pictureBoxIcon);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelMadeBy;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonOk;
    }
}