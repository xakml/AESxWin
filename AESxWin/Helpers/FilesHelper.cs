using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AESxWin.Helpers
{
    public static class FilesHelper
    {

        public static async Task EncryptFileAsync(this string path, string password)
        {
            await Task.Run(() =>
            {
                SharpAESCrypt.SharpAESCrypt.Encrypt(password, path, path + ".aes");
            });
        }
        public static async Task EncryptFilesAsync(this IEnumerable<string> paths, string password)
        {
            await Task.Run(async () =>
            {
                foreach (var path in paths)
                {
                    await path.EncryptFileAsync(password);
                    TextBoxLogHelper.Log(path + " Encrypted.");

                }
            });
        }

        public static async Task DecryptFileAsync(this string path, string password)
        {
            var outputpath = path.RemoveExtension();
            await Task.Run(() =>
            {

                SharpAESCrypt.SharpAESCrypt.Decrypt(password, path, outputpath);
            });
        }

        public static string RemoveExtension(this string path)
        {
            var outputpath = Path.ChangeExtension(path, "").TrimEnd(new char[] { '.' });
            return outputpath;
        }

        public static async Task DecryptFilesAsync(this IEnumerable<string> paths, string password)
        {
            await Task.Run(async () =>
            {
                foreach (var path in paths)
                {
                    await path.DecryptFileAsync(password);

                }
            });
        }


        public static List<string> GetFolderFilesPaths(this string folder, bool followSubDirs = true)
        {
            var paths = new List<string>();
            if (!Directory.Exists(folder))
                return paths;
            if (followSubDirs)
            {
                var subFolders = Directory.GetDirectories(folder);
                if (subFolders != null)
                {

                    foreach (var path in subFolders)
                    {
                        paths.AddRange(GetFolderFilesPaths(path));
                    }

                }
            }
            var subFiles = Directory.GetFiles(folder);
            if (subFiles != null)
            {
                paths.AddRange(subFiles);
            }


            return paths;
        }

        /// <summary>
        /// 查询目录的磁盘空间占用
        /// </summary>
        /// <param name="dir_path"></param>
        /// <returns></returns>
        public static long GetDirectorySize(this string dir_path,out int filesCount)
        {
            filesCount = 0;
            if (!System.IO.Directory.Exists(dir_path))
                return 0;
            long len = 0;
            DirectoryInfo di = new DirectoryInfo(dir_path);
            var filesInfo = di.GetFiles();
            if (filesInfo != null && filesInfo.Length > 0)
            {
                foreach (FileInfo item in filesInfo)
                {
                    filesCount++;
                    len += item.Length;
                }
            }
            DirectoryInfo[] dis = di.GetDirectories();
            if (dis.Length > 0)
            {
                for (int i = 0; i < dis.Length; i++)
                {
                    len += GetDirectorySize(dis[i].FullName,out int subFilesCount);//递归dis.Length个文件夹,得到每隔dis[i]下面所有文件的大小
                    filesCount += subFilesCount;
                }
            }
            return len;
        }

        /// <summary>
        /// 读取指定路径所属磁盘的剩余空间
        /// </summary>
        /// <param name="path">路径可以是文件夹或文件</param>
        /// <returns></returns>
        public static long GetFreespaceOfDisk(this string path)
        {
            if (!System.IO.File.Exists(path) && !System.IO.Directory.Exists(path))
                throw new IOException("invalid path");
            if (System.IO.File.Exists(path))
            {
                var fileInfo = new FileInfo(path);
                DriveInfo di = new DriveInfo(fileInfo.Directory.Root.FullName);
                return di.AvailableFreeSpace;
            }
            if (System.IO.Directory.Exists(path))
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                DriveInfo di = new DriveInfo(dir.Root.FullName);
                return di.AvailableFreeSpace;
            }
            return -1;
        }

        /// <summary>
        /// 获取文件的扩展名
        /// </summary>
        /// <param name="extentions">文件路径</param>
        /// <returns></returns>
        public static IEnumerable<string> ParseExtensions(this string extentions)
        {
            var exts = new List<string>();
            var type = Regex.Match(extentions, @"\(.+\)").Value;
            if (!String.IsNullOrWhiteSpace(type))
                extentions = extentions.Replace(type, String.Empty);

            var matches = Regex.Matches(extentions, @"\b(\w+)\b");

            foreach (var ext in matches)
            {
                exts.Add("." + ext.ToString());
                
            }

            return exts;
        }


        public static bool CheckExtension(this string path, IEnumerable<string> extensions)
        {
            if (extensions == null)
                return true;
            if (extensions.Count() == 0)
                return true;

            foreach (var ext in extensions)
            {
                if (path.ToLower().EndsWith(ext.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
        private static readonly long MB_Value = 1024 * 1024; //1MB对应的字节数
        private static readonly long GB_Value = 1024 * 1024 * 1024; //1MB对应的字节数
        /// <summary>
        /// 转换字节数对应的友好书写方式(精确到两位小数)
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string GetFriendlyReadStyle(this long bytes)
        {
            string friendlyText = "";
            if (bytes < 1024)
            {
                friendlyText = $"{bytes} Byte/s";
            }
            else if (bytes >= 1024 && bytes < (MB_Value))
            {
                friendlyText = Math.Round((double)bytes / 1024, 2) + " KB";
            }
            else if(bytes >= MB_Value && bytes < GB_Value)
            {
                friendlyText = Math.Round((double)bytes / (MB_Value), 2) + " MB";
            }
            else
            {
                friendlyText = Math.Round((double)bytes / (GB_Value), 2) + " GB";
            }
            return friendlyText;

        }

    }

    //public class AESCryptHelper
    //{
    //    public long MaxValue { get; set; }

    //    public long MinValue { get; set; }

    //    public async Task<AESCryptHelper> ReadyToStart(Action<ReadyArguments> action)
    //    {

    //    }

    //    public async Task<AESCryptHelper> Start()
    //    {

    //    }

    //    public async Task Complete()
    //    {

    //    }

    //    public class ReadyArguments
    //    {
    //        public long MaxValue { get; set; }

    //        public long MinValue { get; set; }
    //    }
    //}
}
