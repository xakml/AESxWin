namespace AESxWin
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.btnRemovePath = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lstPaths = new System.Windows.Forms.ListBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chkIgnoreEncryptedFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstExts = new System.Windows.Forms.ComboBox();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.chkDeleteOrg = new System.Windows.Forms.CheckBox();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.btnGeneratePwd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.progressEncrypt = new System.Windows.Forms.ProgressBar();
            this.progressEncryptAllFiles = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCustomBlockSize = new System.Windows.Forms.NumericUpDown();
            this.cmbBlockSizeList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPaths.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomBlockSize)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPaths
            // 
            this.gbPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPaths.Controls.Add(this.btnRemovePath);
            this.gbPaths.Controls.Add(this.btnAddFolder);
            this.gbPaths.Controls.Add(this.btnAddFile);
            this.gbPaths.Controls.Add(this.lstPaths);
            this.gbPaths.Location = new System.Drawing.Point(12, 11);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Size = new System.Drawing.Size(544, 120);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "Paths";
            // 
            // btnRemovePath
            // 
            this.btnRemovePath.Location = new System.Drawing.Point(323, 88);
            this.btnRemovePath.Name = "btnRemovePath";
            this.btnRemovePath.Size = new System.Drawing.Size(75, 21);
            this.btnRemovePath.TabIndex = 3;
            this.btnRemovePath.Text = "Remove";
            this.btnRemovePath.UseVisualStyleBackColor = true;
            this.btnRemovePath.Click += new System.EventHandler(this.btnRemovePath_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(88, 88);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(75, 21);
            this.btnAddFolder.TabIndex = 2;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(7, 88);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 21);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "Add File(s)";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lstPaths
            // 
            this.lstPaths.AllowDrop = true;
            this.lstPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPaths.FormattingEnabled = true;
            this.lstPaths.HorizontalScrollbar = true;
            this.lstPaths.ItemHeight = 12;
            this.lstPaths.Location = new System.Drawing.Point(6, 18);
            this.lstPaths.Name = "lstPaths";
            this.lstPaths.Size = new System.Drawing.Size(532, 64);
            this.lstPaths.TabIndex = 0;
            this.lstPaths.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstPaths_DragDrop);
            this.lstPaths.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstPaths_DragEnter);
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.chkIgnoreEncryptedFiles);
            this.gbOptions.Controls.Add(this.label1);
            this.gbOptions.Controls.Add(this.lstExts);
            this.gbOptions.Controls.Add(this.chkSubFolders);
            this.gbOptions.Controls.Add(this.chkDeleteOrg);
            this.gbOptions.Location = new System.Drawing.Point(12, 137);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(544, 64);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chkIgnoreEncryptedFiles
            // 
            this.chkIgnoreEncryptedFiles.AutoSize = true;
            this.chkIgnoreEncryptedFiles.Checked = true;
            this.chkIgnoreEncryptedFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreEncryptedFiles.Enabled = false;
            this.chkIgnoreEncryptedFiles.Location = new System.Drawing.Point(199, 18);
            this.chkIgnoreEncryptedFiles.Name = "chkIgnoreEncryptedFiles";
            this.chkIgnoreEncryptedFiles.Size = new System.Drawing.Size(156, 16);
            this.chkIgnoreEncryptedFiles.TabIndex = 4;
            this.chkIgnoreEncryptedFiles.Text = "Ignore Encrypted Files";
            this.chkIgnoreEncryptedFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Extensions :";
            // 
            // lstExts
            // 
            this.lstExts.FormattingEnabled = true;
            this.lstExts.Items.AddRange(new object[] {
            "(Images) jpg jpeg png gif bmp",
            "(Videos) avi flv mov mp4 mpg rm rmvb mkv swf vob wmv 3g2 3gp asf ogv",
            "(Audio) mp3 wav acc ogg amr wma",
            "(Documents) pdf txt rtf doc docx ppt pptx xls xlsx",
            "(Compresed) zip rar 7z tar gzip",
            "(Code) cs vb java py rb cpp html css js",
            "(All Files)"});
            this.lstExts.Location = new System.Drawing.Point(277, 37);
            this.lstExts.Name = "lstExts";
            this.lstExts.Size = new System.Drawing.Size(121, 20);
            this.lstExts.TabIndex = 2;
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.Location = new System.Drawing.Point(6, 39);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(132, 16);
            this.chkSubFolders.TabIndex = 1;
            this.chkSubFolders.Text = "Follow Sub Folders";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // chkDeleteOrg
            // 
            this.chkDeleteOrg.AutoSize = true;
            this.chkDeleteOrg.Location = new System.Drawing.Point(7, 18);
            this.chkDeleteOrg.Name = "chkDeleteOrg";
            this.chkDeleteOrg.Size = new System.Drawing.Size(144, 16);
            this.chkDeleteOrg.TabIndex = 0;
            this.chkDeleteOrg.Text = "Delete Orignal Files";
            this.chkDeleteOrg.UseVisualStyleBackColor = true;
            // 
            // gbPassword
            // 
            this.gbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPassword.Controls.Add(this.btnGeneratePwd);
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.Location = new System.Drawing.Point(12, 283);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(548, 44);
            this.gbPassword.TabIndex = 2;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Password";
            // 
            // btnGeneratePwd
            // 
            this.btnGeneratePwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePwd.Location = new System.Drawing.Point(521, 16);
            this.btnGeneratePwd.Name = "btnGeneratePwd";
            this.btnGeneratePwd.Size = new System.Drawing.Size(27, 27);
            this.btnGeneratePwd.TabIndex = 1;
            this.btnGeneratePwd.Text = ">*";
            this.btnGeneratePwd.UseVisualStyleBackColor = true;
            this.btnGeneratePwd.Click += new System.EventHandler(this.GeneratePwd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(3, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(512, 27);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnEncrypt.Location = new System.Drawing.Point(12, 333);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(163, 38);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnDecrypt.Location = new System.Drawing.Point(397, 332);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(163, 38);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInfo.Location = new System.Drawing.Point(0, 513);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(572, 18);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "by : Eslam Hamouda (@EslaMx7) - www.eslamx.com";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // gbLog
            // 
            this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Location = new System.Drawing.Point(6, 373);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(550, 106);
            this.gbLog.TabIndex = 6;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 17);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(544, 86);
            this.txtLog.TabIndex = 0;
            this.txtLog.WordWrap = false;
            // 
            // progressEncrypt
            // 
            this.progressEncrypt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressEncrypt.Location = new System.Drawing.Point(0, 488);
            this.progressEncrypt.Name = "progressEncrypt";
            this.progressEncrypt.Size = new System.Drawing.Size(572, 10);
            this.progressEncrypt.TabIndex = 7;
            // 
            // progressEncryptAllFiles
            // 
            this.progressEncryptAllFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressEncryptAllFiles.Location = new System.Drawing.Point(0, 498);
            this.progressEncryptAllFiles.Name = "progressEncryptAllFiles";
            this.progressEncryptAllFiles.Size = new System.Drawing.Size(572, 15);
            this.progressEncryptAllFiles.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbBlockSizeList);
            this.groupBox1.Controls.Add(this.nudCustomBlockSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 65);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Split options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Block Size";
            // 
            // nudCustomBlockSize
            // 
            this.nudCustomBlockSize.Enabled = false;
            this.nudCustomBlockSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCustomBlockSize.Location = new System.Drawing.Point(252, 26);
            this.nudCustomBlockSize.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudCustomBlockSize.Name = "nudCustomBlockSize";
            this.nudCustomBlockSize.Size = new System.Drawing.Size(77, 21);
            this.nudCustomBlockSize.TabIndex = 1;
            this.nudCustomBlockSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cmbBlockSizeList
            // 
            this.cmbBlockSizeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlockSizeList.FormattingEnabled = true;
            this.cmbBlockSizeList.Items.AddRange(new object[] {
            "10M",
            "50M",
            "100M",
            "200M",
            "500M",
            "自定义"});
            this.cmbBlockSizeList.Location = new System.Drawing.Point(100, 27);
            this.cmbBlockSizeList.Name = "cmbBlockSizeList";
            this.cmbBlockSizeList.Size = new System.Drawing.Size(146, 20);
            this.cmbBlockSizeList.TabIndex = 2;
            this.cmbBlockSizeList.SelectedIndexChanged += new System.EventHandler(this.cmbBlockSizeList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "MB";
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressEncrypt);
            this.Controls.Add(this.progressEncryptAllFiles);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.gbPassword);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbPaths);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AESxWin";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbPaths.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomBlockSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ListBox lstPaths;
        private System.Windows.Forms.Button btnRemovePath;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private System.Windows.Forms.CheckBox chkDeleteOrg;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox lstExts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnGeneratePwd;
        private System.Windows.Forms.ProgressBar progressEncrypt;
        private System.Windows.Forms.ProgressBar progressEncryptAllFiles;
        private System.Windows.Forms.CheckBox chkIgnoreEncryptedFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBlockSizeList;
        private System.Windows.Forms.NumericUpDown nudCustomBlockSize;
        private System.Windows.Forms.Label label3;
    }
}

