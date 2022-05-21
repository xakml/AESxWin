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
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemovePath = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lstPaths = new System.Windows.Forms.ListBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chkUseMd5ValueAsOutputFileName = new System.Windows.Forms.CheckBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.chkSplit = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBlockSizeList = new System.Windows.Forms.ComboBox();
            this.nudCustomBlockSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.progressEncryptAllFiles = new AESxWin.ProgressAll();
            this.llblClearOutput = new System.Windows.Forms.LinkLabel();
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
            this.gbPaths.Controls.Add(this.btnSelectFolder);
            this.gbPaths.Controls.Add(this.txtOutputFolder);
            this.gbPaths.Controls.Add(this.label4);
            this.gbPaths.Controls.Add(this.btnRemovePath);
            this.gbPaths.Controls.Add(this.btnAddFolder);
            this.gbPaths.Controls.Add(this.btnAddFile);
            this.gbPaths.Controls.Add(this.lstPaths);
            this.gbPaths.Location = new System.Drawing.Point(12, 11);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Size = new System.Drawing.Size(743, 181);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "Paths";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(492, 128);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(46, 23);
            this.btnSelectFolder.TabIndex = 6;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(88, 130);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(398, 21);
            this.txtOutputFolder.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "output folder";
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
            this.lstPaths.Size = new System.Drawing.Size(731, 64);
            this.lstPaths.TabIndex = 0;
            this.lstPaths.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstPaths_DragDrop);
            this.lstPaths.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstPaths_DragEnter);
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.chkUseMd5ValueAsOutputFileName);
            this.gbOptions.Controls.Add(this.chkIgnoreEncryptedFiles);
            this.gbOptions.Controls.Add(this.label1);
            this.gbOptions.Controls.Add(this.lstExts);
            this.gbOptions.Controls.Add(this.chkSubFolders);
            this.gbOptions.Controls.Add(this.chkDeleteOrg);
            this.gbOptions.Location = new System.Drawing.Point(12, 198);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(743, 64);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chkUseMd5ValueAsOutputFileName
            // 
            this.chkUseMd5ValueAsOutputFileName.AutoSize = true;
            this.chkUseMd5ValueAsOutputFileName.Location = new System.Drawing.Point(433, 18);
            this.chkUseMd5ValueAsOutputFileName.Name = "chkUseMd5ValueAsOutputFileName";
            this.chkUseMd5ValueAsOutputFileName.Size = new System.Drawing.Size(312, 16);
            this.chkUseMd5ValueAsOutputFileName.TabIndex = 5;
            this.chkUseMd5ValueAsOutputFileName.Text = "&Use original file hash value as output file name";
            this.chkUseMd5ValueAsOutputFileName.UseVisualStyleBackColor = true;
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
            this.gbPassword.Location = new System.Drawing.Point(12, 344);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(747, 44);
            this.gbPassword.TabIndex = 2;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Password";
            // 
            // btnGeneratePwd
            // 
            this.btnGeneratePwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePwd.Location = new System.Drawing.Point(720, 16);
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
            this.txtPassword.Size = new System.Drawing.Size(711, 27);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnEncrypt.Location = new System.Drawing.Point(9, 393);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(90, 40);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrypt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnDecrypt.Location = new System.Drawing.Point(665, 408);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(90, 40);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInfo.Location = new System.Drawing.Point(0, 703);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(771, 18);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "by : Eslam Hamouda (@EslaMx7) - www.eslamx.com";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // gbLog
            // 
            this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Location = new System.Drawing.Point(6, 474);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(749, 195);
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
            this.txtLog.Size = new System.Drawing.Size(743, 175);
            this.txtLog.TabIndex = 0;
            this.txtLog.WordWrap = false;
            // 
            // progressEncrypt
            // 
            this.progressEncrypt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressEncrypt.Location = new System.Drawing.Point(0, 678);
            this.progressEncrypt.Name = "progressEncrypt";
            this.progressEncrypt.Size = new System.Drawing.Size(771, 10);
            this.progressEncrypt.TabIndex = 7;
            this.progressEncrypt.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSplit);
            this.groupBox1.Controls.Add(this.chkSplit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbBlockSizeList);
            this.groupBox1.Controls.Add(this.nudCustomBlockSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 65);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Split options";
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnSplit.Location = new System.Drawing.Point(448, 15);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(90, 40);
            this.btnSplit.TabIndex = 11;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.Split_Click);
            // 
            // chkSplit
            // 
            this.chkSplit.AutoSize = true;
            this.chkSplit.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSplit.Location = new System.Drawing.Point(375, 27);
            this.chkSplit.Name = "chkSplit";
            this.chkSplit.Size = new System.Drawing.Size(61, 18);
            this.chkSplit.TabIndex = 4;
            this.chkSplit.Text = "Split";
            this.chkSplit.UseVisualStyleBackColor = true;
            this.chkSplit.CheckedChanged += new System.EventHandler(this.chkSplit_CheckedChanged);
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
            100,
            0,
            0,
            0});
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
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(231, 408);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 12);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "label4";
            // 
            // progressEncryptAllFiles
            // 
            this.progressEncryptAllFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressEncryptAllFiles.Location = new System.Drawing.Point(0, 688);
            this.progressEncryptAllFiles.Maximum = 100;
            this.progressEncryptAllFiles.Minimum = 0;
            this.progressEncryptAllFiles.Name = "progressEncryptAllFiles";
            this.progressEncryptAllFiles.Size = new System.Drawing.Size(771, 15);
            this.progressEncryptAllFiles.Step = 10;
            this.progressEncryptAllFiles.TabIndex = 8;
            this.progressEncryptAllFiles.Value = 0;
            this.progressEncryptAllFiles.Visible = false;
            // 
            // llblClearOutput
            // 
            this.llblClearOutput.AutoSize = true;
            this.llblClearOutput.Location = new System.Drawing.Point(72, 459);
            this.llblClearOutput.Name = "llblClearOutput";
            this.llblClearOutput.Size = new System.Drawing.Size(53, 12);
            this.llblClearOutput.TabIndex = 11;
            this.llblClearOutput.TabStop = true;
            this.llblClearOutput.Text = "清除输出";
            this.llblClearOutput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblClearOutput_LinkClicked);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 721);
            this.Controls.Add(this.llblClearOutput);
            this.Controls.Add(this.lblSpeed);
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
            this.Text = "AESxWin(v1.0.0)";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbPaths.ResumeLayout(false);
            this.gbPaths.PerformLayout();
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
            this.PerformLayout();

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
        private ProgressAll progressEncryptAllFiles;
        private System.Windows.Forms.CheckBox chkIgnoreEncryptedFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBlockSizeList;
        private System.Windows.Forms.NumericUpDown nudCustomBlockSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.CheckBox chkSplit;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.CheckBox chkUseMd5ValueAsOutputFileName;
        private System.Windows.Forms.LinkLabel llblClearOutput;
    }
}

