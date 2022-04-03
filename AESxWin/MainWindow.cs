using AESxWin.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AESxWin
{
    public partial class MainWindow : Form
    {
        private static readonly string ORIGINAL_FILENAME = "OFN";

        public MainWindow()
        {
            InitializeComponent();
            this.SetLogViewer(txtLog);
        }

        public MainWindow(string[] args)
        {
            InitializeComponent();
            this.SetLogViewer(txtLog);

            foreach (var path in args)
            {
                if (File.Exists(path) || Directory.Exists(path))
                    lstPaths.Items.Add(path);
            }

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lstExts.SelectedIndex = 6;
            this.lblSpeed.Text = string.Empty;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Select your File(s)";
                fileDialog.CheckFileExists = true;
                fileDialog.CheckPathExists = true;
                fileDialog.Multiselect = true;
                fileDialog.SupportMultiDottedExtensions = true;
                fileDialog.InitialDirectory = Application.StartupPath;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var files = fileDialog.FileNames;

                    if (files != null && files.Length > 0)
                    {
                        foreach (var filePath in files)
                        {
                            var items = lstPaths.Items;
                            if (!items.Contains(filePath))
                                lstPaths.Items.Add(filePath);
                            else
                                this.Log(filePath + " is already exist in the list.");
                        }
                    }
                }
            }
        }

        private void btnRemovePath_Click(object sender, EventArgs e)
        {
            var selectedIndex = lstPaths.SelectedIndex;
            if (selectedIndex != -1)
            {
                lstPaths.Items.RemoveAt(selectedIndex);

                lstPaths.SelectedIndex = selectedIndex < lstPaths.Items.Count ? selectedIndex : selectedIndex - 1;
                lstPaths.Focus();
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select A Folder";
                folderDialog.ShowNewFolderButton = true;
                folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    var folderPath = folderDialog.SelectedPath;
                    if (!String.IsNullOrEmpty(folderPath))
                    {
                        var items = lstPaths.Items;
                        if (!items.Contains(folderPath))
                            lstPaths.Items.Add(folderPath);
                        else
                            this.Log(folderPath + " is already exist in the list.");
                    }
                }


            }
        }

        private async void btnEncrypt_Click(object sender, EventArgs e)
        {
            var count = 0;
            var paths = lstPaths.Items;

            this.Log("Encryption Started.");
            this.lblSpeed.Text = string.Empty;
            if (paths != null && paths.Count > 0)
            {
                this.btnEncrypt.Enabled = false;
                foreach (string path in paths)
                {
                    if (File.Exists(path)) // Is File 
                    {
                        if (path.CheckExtension(lstExts.Text.ParseExtensions()))
                        {
                            try
                            {
                                string folder = Path.GetDirectoryName(path);
                                string fileName = Path.GetFileName(path);
                                var fileName_data = SharpAESCrypt.SharpAESCrypt.EncryptStringData(txtPassword.Text,fileName);
                                KeyValuePair<string, byte[]> extension_header = new KeyValuePair<string, byte[]>(ORIGINAL_FILENAME, fileName_data);

                                //string outputfile = Path.Combine(folder,fileName + ".aes");
                                //string outputfile = path + ".aes";
                                string outputfile = Path.Combine(folder, Guid.NewGuid().ToString("N") + ".aes");

                                using (FileStream outfs = File.Create(outputfile))
                                {
                                    var aes = new SharpAESCrypt.SharpAESCrypt(txtPassword.Text, outfs, extension_header, SharpAESCrypt.OperationMode.Encrypt);
                                    aes.BeginEncrypt += Aes_BeginEncrypt;
                                    aes.EncryptProgressReport += Aes_EncryptProgressReport;
                                    aes.EncryptOrDeEncryptCompleteReport += Aes_EncryptOrDeEncryptCompleteReport;
                                    await aes.EncryptFileAsync(path);
                                }


                                //await path.EncryptFileAsync(txtPassword.Text);
                                this.Log(Path.GetFileName(path) + " Encrypted.");
                                //this.Log(Xakml.Common.StringTools.Strings.SubMasked(Path.GetFileName(path), '*') + " Encrypted.");

                                count++;

                                if (chkDeleteOrg.Checked)
                                    File.Delete(path);
                            }
                            catch (Exception ex)
                            {

                                this.Log(path + " " + ex.Message);
                            }
                        }
                    }
                    if (Directory.Exists(path)) // Is Folder
                    {
                        var followSubDirs = chkSubFolders.Checked ? true : false;

                        var allfiles = path.GetFolderFilesPaths(followSubDirs);
                        this.progressEncryptAllFiles.Maximum = allfiles.Count();
                        this.progressEncryptAllFiles.Minimum = 0;
                        this.progressEncryptAllFiles.Value = 0;
                        this.progressEncryptAllFiles.Step = 1;
                        foreach (var file in allfiles)
                        {
                            if (file.CheckExtension(lstExts.Text.ParseExtensions()))
                            {
                                if (!file.EndsWith(".aes"))
                                {
                                    try
                                    {
                                        string folder = path;
                                        string fileName = Path.GetFileName(file);
                                        var fileName_data = SharpAESCrypt.SharpAESCrypt.EncryptStringData(txtPassword.Text, fileName);
                                        KeyValuePair<string, byte[]> extension_header = new KeyValuePair<string, byte[]>(ORIGINAL_FILENAME, fileName_data);

                                        //await file.EncryptFileAsync(txtPassword.Text);
                                        //string outputfile = file + ".aes";

                                        string outputfile = Path.Combine(folder, Path.GetRandomFileName() + ".aes");
                                        using (FileStream outfs = File.Create(outputfile))
                                        {
                                            var aes = new SharpAESCrypt.SharpAESCrypt(txtPassword.Text, outfs, extension_header, SharpAESCrypt.OperationMode.Encrypt);
                                            aes.BeginEncrypt += Aes_BeginEncrypt;
                                            aes.EncryptProgressReport += Aes_EncryptProgressReport;
                                            aes.EncryptOrDeEncryptCompleteReport += Aes_EncryptOrDeEncryptCompleteReport;
                                            await aes.EncryptFileAsync(file);
                                        }
                                        this.Log (Xakml.Common.StringTools.Strings.SubMasked(file,'*')  + " Encrypted.");
                                        count++;

                                        if (chkDeleteOrg.Checked)
                                            File.Delete(file);
                                    }
                                    catch (Exception ex)
                                    {

                                        this.Log(file + " " + ex.Message);
                                    }
                                }
                                else
                                {
                                    //  this.Log(file + " Ignored.");
                                }
                            }
                            this.progressEncryptAllFiles.PerformStep();
                        }


                    }
                }
            }

            this.Log($"Finished : {count} File(s) Encrypted.");
            if (!this.btnEncrypt.Enabled)
                this.btnEncrypt.Enabled = true;
        }

        private void Aes_EncryptProgressReport(SharpAESCrypt.EncryptProgressReportEventArgs obj)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(()=> 
                {
                if (obj.EncryptedDataSize > this.progressEncrypt.Maximum) return;
                this.progressEncrypt.Value = (int)obj.EncryptedDataSize;
                }));
            }
            else
            {
                Aes_EncryptProgressReport(obj);
            }
        }

        private void Aes_BeginEncrypt(SharpAESCrypt.BeginEnryptEventArgs obj)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    long max_value = (long)obj.OriginalFileSize;
                    if (max_value > int.MaxValue)
                        this.progressEncrypt.Maximum = int.MaxValue;
                    else
                        this.progressEncrypt.Maximum = (int)max_value;

                    this.progressEncrypt.Minimum = 0;
                    this.progressEncrypt.Value = 0;
                    this.progressEncrypt.Visible = true;
                    this.progressEncryptAllFiles.Visible = true;
                }));
            }
            else
            {
                Aes_BeginEncrypt(obj);
            }
         
        }

        private void Aes_EncryptOrDeEncryptCompleteReport(SharpAESCrypt.EncryptCompleteReportEventArgs obj)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.lblSpeed.Text = obj.WriteSpeedReadable;
                    this.progressEncrypt.Visible = false;
                    this.progressEncryptAllFiles.Visible = false;
                }));
            }
            else
            {
                Aes_EncryptOrDeEncryptCompleteReport(obj);
            }
        }

        private async void btnDecrypt_Click(object sender, EventArgs e)
        {
            var count = 0;
            var paths = lstPaths.Items;

            this.Log("Decryption Started.");
            this.lblSpeed.Text = string.Empty;
            if (paths.Count > 0)
            {
                this.btnDecrypt.Enabled = false;
                foreach (string path in paths)
                {

                    if (File.Exists(path) && path.EndsWith(".aes")) // Is Encrypted File 
                    {
                        try
                        {
                            var folder = Path.GetDirectoryName(path);

                            var outputfile = path.RemoveExtension();

                            using (FileStream infs = File.OpenRead(path))
                            {
                                var aes = new SharpAESCrypt.SharpAESCrypt(txtPassword.Text, infs, SharpAESCrypt.OperationMode.Decrypt);
                                aes.BeginEncrypt += Aes_BeginEncrypt;
                                aes.EncryptProgressReport += Aes_EncryptProgressReport;
                                aes.EncryptOrDeEncryptCompleteReport += Aes_EncryptOrDeEncryptCompleteReport;
                                await aes.DecryptFileAsync(outputfile);
                                if(null != aes.Extensions && aes.Extensions.Count > 0)
                                {
                                    foreach (var item in aes.Extensions)
                                    {
                                        Console.WriteLine(item.Key + " ----> " +  System.Text.Encoding.UTF8.GetString(item.Value));
                                    }

                                    if (aes.Extensions.Any(ext => ext.Key.Equals(ORIGINAL_FILENAME)))
                                    {
                                        var filename_extension = aes.Extensions.First(ext => ext.Key.Equals(ORIGINAL_FILENAME));
                                        var original_file_name = SharpAESCrypt.SharpAESCrypt.DecryptStringData(this.txtPassword.Text, filename_extension.Value);
                                        string target_fileName = Path.Combine(folder, original_file_name);
                                        File.Move(outputfile, target_fileName);
                                    }
                                }
                            }
                            //await path.DecryptFileAsync(txtPassword.Text);
                            this.Log(path + " Decrypted.");
                            count++;

                            if (chkDeleteOrg.Checked)
                                File.Delete(path);
                        }
                        catch (Exception ex)
                        {
                            this.Log(path + " " + ex.Message);
                            if (File.Exists(path.RemoveExtension()))
                                File.Delete(path.RemoveExtension());
                        }


                    }
                    if (Directory.Exists(path)) // Is Folder
                    {
                        var followSubDirs = chkSubFolders.Checked ? true : false;

                        var allfiles = path.GetFolderFilesPaths(followSubDirs);

                        foreach (var file in allfiles)
                        {
                            if (file.RemoveExtension().CheckExtension(lstExts.Text.ParseExtensions()))
                            {
                                if (file.EndsWith(".aes"))
                                {
                                    try
                                    {
                                        await file.DecryptFileAsync(txtPassword.Text);
                                        this.Log(file + " Decrypted.");
                                        count++;

                                        if (chkDeleteOrg.Checked)
                                            File.Delete(file);
                                    }
                                    catch (Exception ex)
                                    {
                                        this.Log(file + " " + ex.Message);
                                        if(File.Exists(file.RemoveExtension()))
                                            File.Delete(file.RemoveExtension());
                                    }
                                }

                            }
                            else
                            {
                               // this.Log(file + " Ignored.");
                            }
                        }


                    }


                }
            }

            this.Log($"Finished : {count} File(s) Decrypted.");
            if (!this.btnDecrypt.Enabled)
                this.btnDecrypt.Enabled = true;
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            Process.Start("http://eslamx.com");
        }

        private void lstPaths_DragDrop(object sender, DragEventArgs e)
        {
            var fileList = e.Data.GetData(DataFormats.FileDrop, false);

            var paths = fileList as IEnumerable<string>;
            if (paths != null)
                foreach (var path in paths)
                {
                    lstPaths.Items.Add(path);
                }
        }

        private void lstPaths_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void GeneratePwd_Click(object sender, EventArgs e)
        {
           var pwd = new PasswordGenerator.Password(12).IncludeLowercase()
                .IncludeNumeric()
                .IncludeSpecial()
                .IncludeUppercase().Next();
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Text = pwd;
            File.WriteAllText(Path.Combine(Application.StartupPath, "PWD-"+DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt"), pwd);
        }

        int blockSize = -1; 
        private void cmbBlockSizeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBlockSize = this.cmbBlockSizeList.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedBlockSize))
            {
                switch (selectedBlockSize)
                {
                    case "10M":
                        blockSize = 1024 * 1024 * 10;
                        break;
                    case "50M":
                        blockSize = 1024 * 1024 * 40;
                        break;
                    case "100M":
                        blockSize = 1024 * 1024 * 100;
                        break;
                    case "200M":
                        blockSize = 1024 * 1024 * 200;
                        break;
                    case "500M":
                        blockSize = 1024 * 1024 * 500;
                        break;
                    case "自定义":
                            blockSize = 1024 * 1024 * (int)this.nudCustomBlockSize.Value;
                        break;
                    default:
                        break;
                }

                if (selectedBlockSize == "自定义")
                {
                    this.nudCustomBlockSize.Enabled = true;
                    this.nudCustomBlockSize.Focus();
                }
                else
                {
                    if (this.nudCustomBlockSize.Enabled)
                        this.nudCustomBlockSize.Enabled = false;
                }
            }
        }

        private void chkSplit_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkSplit.Checked)
            {
                this.btnSplit.Enabled = true;
                this.cmbBlockSizeList.Enabled = true;
            }
            else
                this.cmbBlockSizeList.Enabled = false;

        }

        /// <summary>
        /// split file
        /// </summary>
        /// <param name="original_file"></param>
        /// <param name="perFileSize">output per file size</param>
        private void SplitFile(string original_file, long perFileSize)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(original_file);
            if (file.Length < perFileSize)
                return;
            long splited_file_count = file.Length / perFileSize;
            if (file.Length % perFileSize > 0)
                splited_file_count += 1;

            string original_file_name = System.IO.Path.GetFileNameWithoutExtension(original_file);
            string original_file_extension = System.IO.Path.GetExtension(original_file);

            string[] splied_files = new string[splited_file_count];
            for (int i = 1; i <= splited_file_count; i++)
            {
                splied_files[i - 1] = $"{original_file_name}_{i}({splited_file_count}){original_file_extension}";
            }

            using (var streamReader = file.OpenRead())
            {
                int bytes_readed = 0;
                int total_bytes_readed = 0;
                int buffer_length = 1024 * 1024 * 1; //缓冲区1M
                byte[] buffer = new byte[buffer_length];
                foreach (string split_file_name in splied_files)
                {
                    using (System.IO.FileStream fs = new System.IO.FileStream(split_file_name, System.IO.FileMode.CreateNew,
                        System.IO.FileAccess.Write))
                    {
                        do
                        {
                            if (buffer_length + total_bytes_readed > perFileSize)
                            {
                                var buffer1 = new byte[buffer_length - (buffer_length + total_bytes_readed - perFileSize)];
                                bytes_readed = streamReader.Read(buffer1, 0, buffer1.Length);
                                fs.Write(buffer1, 0, bytes_readed);
                            }
                            else
                            {
                                bytes_readed = streamReader.Read(buffer, 0, buffer_length);
                                fs.Write(buffer, 0, bytes_readed);
                            }
                            total_bytes_readed += bytes_readed;

                        } while ((total_bytes_readed < perFileSize) && bytes_readed > 0);
                        fs.Flush();
                        fs.Close();
                    }
                    total_bytes_readed = 0;
                }
            }
        }

        private long GetSplitedPerFileSize()
        {
            long blockSize = 1024 * 1024 * 100;
            string seleted_block_size = this.cmbBlockSizeList.SelectedItem as string;
            switch (seleted_block_size)
            {
                case "10M":
                    blockSize = 1024 * 1024 * 10;
                    break;
                case "50M":
                    blockSize = 1024 * 1024 * 50;
                    break;
                case "100M":
                    blockSize = 1024 * 1024 * 100;
                    break;
                case "200M":
                    blockSize = 1024 * 1024 * 200;
                    break;
                case "500M":
                    blockSize = 1024 * 1024 * 500;
                    break;
                case "自定义":
                    blockSize = 1024 * 1024 * (int)this.nudCustomBlockSize.Value;
                    break;
            }
            return blockSize;
        }
        private void Split_Click(object sender, EventArgs e)
        {
            if (!this.chkSplit.Checked)
                return;

            var count = 0;
            var paths = lstPaths.Items;

            this.Log("Encryption Started.");
            this.lblSpeed.Text = string.Empty;
            if (paths != null && paths.Count > 0)
            {
                foreach (string path in paths)
                {
                    if (File.Exists(path))
                    {

                        if (path.CheckExtension(lstExts.Text.ParseExtensions()))
                        {
                            this.btnSplit.Enabled = false;

                            long perFileSize = GetSplitedPerFileSize();
                            System.Threading.Tasks.Task.Run(()=> this.SplitFile(path, perFileSize))
                                .ContinueWith(tsk=> 
                                {
                                    this.Invoke(new Action(()=> 
                                    {
                                        this.btnSplit.Enabled = true;
                                    }));
                                });
                        }
                    }
                    if (Directory.Exists(path))
                    {

                    }
                }
            }
        }


    }
}
