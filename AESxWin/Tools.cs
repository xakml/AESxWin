using System.Windows.Forms;

namespace AESxWin
{
    internal class Tools
    {
        internal string[] ShowOpenFileDialog()
        {
            string selectedFile = string.Empty;
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
                    return fileDialog.FileNames;

                    //var files =
                    //if (files != null && files.Length > 0)
                    //{
                    //    foreach (var filePath in files)
                    //    {
                    //        var items = lstPaths.Items;
                    //        if (!items.Contains(filePath))
                    //            lstPaths.Items.Add(filePath);
                    //        else
                    //            this.Log(filePath + " is already exist in the list.");
                    //    }
                    //}
                }
                else
                    return null;
            }
        }
    }
}
