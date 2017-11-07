namespace Hash_Utilities
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GithubOpen = new System.Windows.Forms.PictureBox();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.StringHash = new System.Windows.Forms.TabPage();
            this.CopyButtonStringSHA512 = new System.Windows.Forms.Button();
            this.CopyButtonStringSHA384 = new System.Windows.Forms.Button();
            this.CopyButtonStringSHA256 = new System.Windows.Forms.Button();
            this.CopyButtonStringSHA1 = new System.Windows.Forms.Button();
            this.CopyButtonStringMD5 = new System.Windows.Forms.Button();
            this.DisplayHashFileSHA512 = new System.Windows.Forms.Button();
            this.DisplayHashFileSHA384 = new System.Windows.Forms.Button();
            this.DisplayHashFileSHA256 = new System.Windows.Forms.Button();
            this.DisplayHashFileSHA1 = new System.Windows.Forms.Button();
            this.DisplayHashFileMD5 = new System.Windows.Forms.Button();
            this.StringExportToFileButton = new System.Windows.Forms.Button();
            this.SHA512CheckBox = new System.Windows.Forms.CheckBox();
            this.SHA384CheckBox = new System.Windows.Forms.CheckBox();
            this.SHA256CheckBox = new System.Windows.Forms.CheckBox();
            this.SHA1CheckBox = new System.Windows.Forms.CheckBox();
            this.MD5CheckBox = new System.Windows.Forms.CheckBox();
            this.SHA512Label = new System.Windows.Forms.Label();
            this.SHA384Label = new System.Windows.Forms.Label();
            this.SHA256Label = new System.Windows.Forms.Label();
            this.SHA1Label = new System.Windows.Forms.Label();
            this.MD5Label = new System.Windows.Forms.Label();
            this.StringInputLabel = new System.Windows.Forms.Label();
            this.StringInputTextBox = new System.Windows.Forms.TextBox();
            this.FileHash = new System.Windows.Forms.TabPage();
            this.WIPLabel = new System.Windows.Forms.Label();
            this.StringSaveToFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GithubOpen)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.StringHash.SuspendLayout();
            this.FileHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(745, 37);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Hash Utilities";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.UseCompatibleTextRendering = true;
            // 
            // GithubOpen
            // 
            this.GithubOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GithubOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GithubOpen.Image = global::Hash_Utilities.Properties.Resources.Github_Logo;
            this.GithubOpen.Location = new System.Drawing.Point(713, 0);
            this.GithubOpen.Name = "GithubOpen";
            this.GithubOpen.Size = new System.Drawing.Size(32, 32);
            this.GithubOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GithubOpen.TabIndex = 1;
            this.GithubOpen.TabStop = false;
            this.GithubOpen.Click += new System.EventHandler(this.GithubOpenClicked);
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(474, 22);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(79, 13);
            this.SubtitleLabel.TabIndex = 2;
            this.SubtitleLabel.Text = "by unixLikee";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.StringHash);
            this.MainTabControl.Controls.Add(this.FileHash);
            this.MainTabControl.Location = new System.Drawing.Point(12, 40);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(721, 347);
            this.MainTabControl.TabIndex = 3;
            // 
            // StringHash
            // 
            this.StringHash.Controls.Add(this.CopyButtonStringSHA512);
            this.StringHash.Controls.Add(this.CopyButtonStringSHA384);
            this.StringHash.Controls.Add(this.CopyButtonStringSHA256);
            this.StringHash.Controls.Add(this.CopyButtonStringSHA1);
            this.StringHash.Controls.Add(this.CopyButtonStringMD5);
            this.StringHash.Controls.Add(this.DisplayHashFileSHA512);
            this.StringHash.Controls.Add(this.DisplayHashFileSHA384);
            this.StringHash.Controls.Add(this.DisplayHashFileSHA256);
            this.StringHash.Controls.Add(this.DisplayHashFileSHA1);
            this.StringHash.Controls.Add(this.DisplayHashFileMD5);
            this.StringHash.Controls.Add(this.StringExportToFileButton);
            this.StringHash.Controls.Add(this.SHA512CheckBox);
            this.StringHash.Controls.Add(this.SHA384CheckBox);
            this.StringHash.Controls.Add(this.SHA256CheckBox);
            this.StringHash.Controls.Add(this.SHA1CheckBox);
            this.StringHash.Controls.Add(this.MD5CheckBox);
            this.StringHash.Controls.Add(this.SHA512Label);
            this.StringHash.Controls.Add(this.SHA384Label);
            this.StringHash.Controls.Add(this.SHA256Label);
            this.StringHash.Controls.Add(this.SHA1Label);
            this.StringHash.Controls.Add(this.MD5Label);
            this.StringHash.Controls.Add(this.StringInputLabel);
            this.StringHash.Controls.Add(this.StringInputTextBox);
            this.StringHash.Location = new System.Drawing.Point(4, 22);
            this.StringHash.Name = "StringHash";
            this.StringHash.Padding = new System.Windows.Forms.Padding(3);
            this.StringHash.Size = new System.Drawing.Size(713, 321);
            this.StringHash.TabIndex = 0;
            this.StringHash.Text = "From string";
            this.StringHash.UseVisualStyleBackColor = true;
            // 
            // CopyButtonStringSHA512
            // 
            this.CopyButtonStringSHA512.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButtonStringSHA512.Location = new System.Drawing.Point(668, 231);
            this.CopyButtonStringSHA512.Name = "CopyButtonStringSHA512";
            this.CopyButtonStringSHA512.Size = new System.Drawing.Size(39, 36);
            this.CopyButtonStringSHA512.TabIndex = 26;
            this.CopyButtonStringSHA512.Text = "COPY";
            this.CopyButtonStringSHA512.UseVisualStyleBackColor = true;
            this.CopyButtonStringSHA512.Click += new System.EventHandler(this.CopyButtonStringSHA512_Click);
            // 
            // CopyButtonStringSHA384
            // 
            this.CopyButtonStringSHA384.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButtonStringSHA384.Location = new System.Drawing.Point(668, 186);
            this.CopyButtonStringSHA384.Name = "CopyButtonStringSHA384";
            this.CopyButtonStringSHA384.Size = new System.Drawing.Size(39, 36);
            this.CopyButtonStringSHA384.TabIndex = 25;
            this.CopyButtonStringSHA384.Text = "COPY";
            this.CopyButtonStringSHA384.UseVisualStyleBackColor = true;
            this.CopyButtonStringSHA384.Click += new System.EventHandler(this.CopyButtonStringSHA384_Click);
            // 
            // CopyButtonStringSHA256
            // 
            this.CopyButtonStringSHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButtonStringSHA256.Location = new System.Drawing.Point(668, 140);
            this.CopyButtonStringSHA256.Name = "CopyButtonStringSHA256";
            this.CopyButtonStringSHA256.Size = new System.Drawing.Size(39, 35);
            this.CopyButtonStringSHA256.TabIndex = 24;
            this.CopyButtonStringSHA256.Text = "COPY";
            this.CopyButtonStringSHA256.UseVisualStyleBackColor = true;
            this.CopyButtonStringSHA256.Click += new System.EventHandler(this.CopyButtonStringSHA256_Click);
            // 
            // CopyButtonStringSHA1
            // 
            this.CopyButtonStringSHA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButtonStringSHA1.Location = new System.Drawing.Point(668, 94);
            this.CopyButtonStringSHA1.Name = "CopyButtonStringSHA1";
            this.CopyButtonStringSHA1.Size = new System.Drawing.Size(39, 36);
            this.CopyButtonStringSHA1.TabIndex = 23;
            this.CopyButtonStringSHA1.Text = "COPY";
            this.CopyButtonStringSHA1.UseVisualStyleBackColor = true;
            this.CopyButtonStringSHA1.Click += new System.EventHandler(this.CopyButtonStringSHA1_Click);
            // 
            // CopyButtonStringMD5
            // 
            this.CopyButtonStringMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButtonStringMD5.Location = new System.Drawing.Point(668, 52);
            this.CopyButtonStringMD5.Name = "CopyButtonStringMD5";
            this.CopyButtonStringMD5.Size = new System.Drawing.Size(39, 36);
            this.CopyButtonStringMD5.TabIndex = 22;
            this.CopyButtonStringMD5.Text = "COPY";
            this.CopyButtonStringMD5.UseVisualStyleBackColor = true;
            this.CopyButtonStringMD5.Click += new System.EventHandler(this.CopyButtonStringMD5_Click);
            // 
            // DisplayHashFileSHA512
            // 
            this.DisplayHashFileSHA512.Location = new System.Drawing.Point(141, 231);
            this.DisplayHashFileSHA512.Name = "DisplayHashFileSHA512";
            this.DisplayHashFileSHA512.Size = new System.Drawing.Size(521, 36);
            this.DisplayHashFileSHA512.TabIndex = 21;
            this.DisplayHashFileSHA512.UseVisualStyleBackColor = true;
            // 
            // DisplayHashFileSHA384
            // 
            this.DisplayHashFileSHA384.Location = new System.Drawing.Point(141, 186);
            this.DisplayHashFileSHA384.Name = "DisplayHashFileSHA384";
            this.DisplayHashFileSHA384.Size = new System.Drawing.Size(521, 36);
            this.DisplayHashFileSHA384.TabIndex = 20;
            this.DisplayHashFileSHA384.UseVisualStyleBackColor = true;
            // 
            // DisplayHashFileSHA256
            // 
            this.DisplayHashFileSHA256.Location = new System.Drawing.Point(141, 140);
            this.DisplayHashFileSHA256.Name = "DisplayHashFileSHA256";
            this.DisplayHashFileSHA256.Size = new System.Drawing.Size(521, 35);
            this.DisplayHashFileSHA256.TabIndex = 19;
            this.DisplayHashFileSHA256.UseVisualStyleBackColor = true;
            // 
            // DisplayHashFileSHA1
            // 
            this.DisplayHashFileSHA1.Location = new System.Drawing.Point(141, 94);
            this.DisplayHashFileSHA1.Name = "DisplayHashFileSHA1";
            this.DisplayHashFileSHA1.Size = new System.Drawing.Size(521, 36);
            this.DisplayHashFileSHA1.TabIndex = 18;
            this.DisplayHashFileSHA1.UseVisualStyleBackColor = true;
            // 
            // DisplayHashFileMD5
            // 
            this.DisplayHashFileMD5.Location = new System.Drawing.Point(141, 52);
            this.DisplayHashFileMD5.Name = "DisplayHashFileMD5";
            this.DisplayHashFileMD5.Size = new System.Drawing.Size(521, 36);
            this.DisplayHashFileMD5.TabIndex = 17;
            this.DisplayHashFileMD5.UseVisualStyleBackColor = false;
            // 
            // StringExportToFileButton
            // 
            this.StringExportToFileButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.StringExportToFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringExportToFileButton.Location = new System.Drawing.Point(543, 277);
            this.StringExportToFileButton.Name = "StringExportToFileButton";
            this.StringExportToFileButton.Size = new System.Drawing.Size(164, 40);
            this.StringExportToFileButton.TabIndex = 16;
            this.StringExportToFileButton.Text = "Export to file...";
            this.StringExportToFileButton.UseVisualStyleBackColor = true;
            this.StringExportToFileButton.Click += new System.EventHandler(this.StringExportToFileButton_Click);
            // 
            // SHA512CheckBox
            // 
            this.SHA512CheckBox.AutoSize = true;
            this.SHA512CheckBox.Checked = true;
            this.SHA512CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SHA512CheckBox.Location = new System.Drawing.Point(14, 241);
            this.SHA512CheckBox.Name = "SHA512CheckBox";
            this.SHA512CheckBox.Size = new System.Drawing.Size(15, 14);
            this.SHA512CheckBox.TabIndex = 15;
            this.SHA512CheckBox.UseVisualStyleBackColor = true;
            this.SHA512CheckBox.CheckedChanged += new System.EventHandler(this.SHA512CheckBox_CheckedChanged);
            // 
            // SHA384CheckBox
            // 
            this.SHA384CheckBox.AutoSize = true;
            this.SHA384CheckBox.Checked = true;
            this.SHA384CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SHA384CheckBox.Location = new System.Drawing.Point(14, 195);
            this.SHA384CheckBox.Name = "SHA384CheckBox";
            this.SHA384CheckBox.Size = new System.Drawing.Size(15, 14);
            this.SHA384CheckBox.TabIndex = 14;
            this.SHA384CheckBox.UseVisualStyleBackColor = true;
            this.SHA384CheckBox.CheckedChanged += new System.EventHandler(this.SHA384CheckBox_CheckedChanged);
            // 
            // SHA256CheckBox
            // 
            this.SHA256CheckBox.AutoSize = true;
            this.SHA256CheckBox.Checked = true;
            this.SHA256CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SHA256CheckBox.Location = new System.Drawing.Point(15, 149);
            this.SHA256CheckBox.Name = "SHA256CheckBox";
            this.SHA256CheckBox.Size = new System.Drawing.Size(15, 14);
            this.SHA256CheckBox.TabIndex = 13;
            this.SHA256CheckBox.UseVisualStyleBackColor = true;
            this.SHA256CheckBox.CheckedChanged += new System.EventHandler(this.SHA256CheckBox_CheckedChanged);
            // 
            // SHA1CheckBox
            // 
            this.SHA1CheckBox.AutoSize = true;
            this.SHA1CheckBox.Checked = true;
            this.SHA1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SHA1CheckBox.Location = new System.Drawing.Point(14, 104);
            this.SHA1CheckBox.Name = "SHA1CheckBox";
            this.SHA1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.SHA1CheckBox.TabIndex = 12;
            this.SHA1CheckBox.UseVisualStyleBackColor = true;
            this.SHA1CheckBox.CheckedChanged += new System.EventHandler(this.SHA1CheckBox_CheckedChanged);
            // 
            // MD5CheckBox
            // 
            this.MD5CheckBox.AutoSize = true;
            this.MD5CheckBox.Checked = true;
            this.MD5CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MD5CheckBox.Location = new System.Drawing.Point(14, 65);
            this.MD5CheckBox.Name = "MD5CheckBox";
            this.MD5CheckBox.Size = new System.Drawing.Size(15, 14);
            this.MD5CheckBox.TabIndex = 11;
            this.MD5CheckBox.UseVisualStyleBackColor = true;
            this.MD5CheckBox.CheckedChanged += new System.EventHandler(this.MD5CheckBox_CheckedChanged);
            // 
            // SHA512Label
            // 
            this.SHA512Label.AutoSize = true;
            this.SHA512Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA512Label.Location = new System.Drawing.Point(37, 236);
            this.SHA512Label.Name = "SHA512Label";
            this.SHA512Label.Size = new System.Drawing.Size(98, 25);
            this.SHA512Label.TabIndex = 10;
            this.SHA512Label.Text = "SHA-512";
            // 
            // SHA384Label
            // 
            this.SHA384Label.AutoSize = true;
            this.SHA384Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA384Label.Location = new System.Drawing.Point(37, 190);
            this.SHA384Label.Name = "SHA384Label";
            this.SHA384Label.Size = new System.Drawing.Size(98, 25);
            this.SHA384Label.TabIndex = 8;
            this.SHA384Label.Text = "SHA-384";
            // 
            // SHA256Label
            // 
            this.SHA256Label.AutoSize = true;
            this.SHA256Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA256Label.Location = new System.Drawing.Point(38, 144);
            this.SHA256Label.Name = "SHA256Label";
            this.SHA256Label.Size = new System.Drawing.Size(98, 25);
            this.SHA256Label.TabIndex = 6;
            this.SHA256Label.Text = "SHA-256";
            // 
            // SHA1Label
            // 
            this.SHA1Label.AutoSize = true;
            this.SHA1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA1Label.Location = new System.Drawing.Point(37, 99);
            this.SHA1Label.Name = "SHA1Label";
            this.SHA1Label.Size = new System.Drawing.Size(74, 25);
            this.SHA1Label.TabIndex = 4;
            this.SHA1Label.Text = "SHA-1";
            // 
            // MD5Label
            // 
            this.MD5Label.AutoSize = true;
            this.MD5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD5Label.Location = new System.Drawing.Point(37, 60);
            this.MD5Label.Name = "MD5Label";
            this.MD5Label.Size = new System.Drawing.Size(57, 25);
            this.MD5Label.TabIndex = 2;
            this.MD5Label.Text = "MD5";
            // 
            // StringInputLabel
            // 
            this.StringInputLabel.AutoSize = true;
            this.StringInputLabel.Location = new System.Drawing.Point(6, 19);
            this.StringInputLabel.Name = "StringInputLabel";
            this.StringInputLabel.Size = new System.Drawing.Size(59, 13);
            this.StringInputLabel.TabIndex = 1;
            this.StringInputLabel.Text = "Input string";
            // 
            // StringInputTextBox
            // 
            this.StringInputTextBox.Location = new System.Drawing.Point(75, 16);
            this.StringInputTextBox.Name = "StringInputTextBox";
            this.StringInputTextBox.Size = new System.Drawing.Size(623, 20);
            this.StringInputTextBox.TabIndex = 0;
            this.StringInputTextBox.TextChanged += new System.EventHandler(this.StringInputTextBox_TextChanged);
            // 
            // FileHash
            // 
            this.FileHash.Controls.Add(this.WIPLabel);
            this.FileHash.Location = new System.Drawing.Point(4, 22);
            this.FileHash.Name = "FileHash";
            this.FileHash.Padding = new System.Windows.Forms.Padding(3);
            this.FileHash.Size = new System.Drawing.Size(713, 321);
            this.FileHash.TabIndex = 1;
            this.FileHash.Text = "From file";
            this.FileHash.UseVisualStyleBackColor = true;
            // 
            // WIPLabel
            // 
            this.WIPLabel.AutoSize = true;
            this.WIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WIPLabel.Location = new System.Drawing.Point(70, 117);
            this.WIPLabel.Name = "WIPLabel";
            this.WIPLabel.Size = new System.Drawing.Size(589, 55);
            this.WIPLabel.TabIndex = 0;
            this.WIPLabel.Text = "Not avaible in beta version";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(745, 391);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.GithubOpen);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Hash Utilities";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GithubOpen)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.StringHash.ResumeLayout(false);
            this.StringHash.PerformLayout();
            this.FileHash.ResumeLayout(false);
            this.FileHash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox GithubOpen;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage StringHash;
        private System.Windows.Forms.TabPage FileHash;
        private System.Windows.Forms.Label StringInputLabel;
        private System.Windows.Forms.TextBox StringInputTextBox;
        private System.Windows.Forms.Label MD5Label;
        private System.Windows.Forms.Label SHA512Label;
        private System.Windows.Forms.Label SHA384Label;
        private System.Windows.Forms.Label SHA256Label;
        private System.Windows.Forms.Label SHA1Label;
        private System.Windows.Forms.CheckBox SHA512CheckBox;
        private System.Windows.Forms.CheckBox SHA384CheckBox;
        private System.Windows.Forms.CheckBox SHA256CheckBox;
        private System.Windows.Forms.CheckBox SHA1CheckBox;
        private System.Windows.Forms.CheckBox MD5CheckBox;
        private System.Windows.Forms.Button StringExportToFileButton;
        private System.Windows.Forms.Button DisplayHashFileMD5;
        private System.Windows.Forms.Button DisplayHashFileSHA512;
        private System.Windows.Forms.Button DisplayHashFileSHA384;
        private System.Windows.Forms.Button DisplayHashFileSHA256;
        private System.Windows.Forms.Button DisplayHashFileSHA1;
        private System.Windows.Forms.Button CopyButtonStringSHA512;
        private System.Windows.Forms.Button CopyButtonStringSHA384;
        private System.Windows.Forms.Button CopyButtonStringSHA256;
        private System.Windows.Forms.Button CopyButtonStringSHA1;
        private System.Windows.Forms.Button CopyButtonStringMD5;
        private System.Windows.Forms.SaveFileDialog StringSaveToFile;
        private System.Windows.Forms.Label WIPLabel;
    }
}

