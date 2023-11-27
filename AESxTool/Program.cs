using LoadingDots;
using OutputColorizer;
using System.IO;
using System.Runtime;

namespace AESxTool
{
    internal class Program
    {
        private static readonly string ORIGINAL_FILENAME = "OFN";

        static async Task Main(string[] args)
        {
            DefaultProfile? defaultProfile = null;
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
            bool ProfileExists = false;

            #region 读取 Profile setting
            if (!System.IO.File.Exists(defaultProfileName))
            {
                Console.WriteLine("未检测到profile文件，将生成默认的配置文件，请注意！");
                defaultProfile = new DefaultProfile()
                {
                    OutputDir = ".",
                    Pwd = new PasswordGenerator.Password(12).IncludeLowercase()
                            .IncludeNumeric()
                            .IncludeSpecial()
                            .IncludeUppercase().Next(),
                UseHashValueAsTargetFileName = true,
                };
                SaveProfileSetting(defaultProfile);//第一次运行，生成默认的配置文件Profile Setting
            }
            else
            {
                ProfileExists = true;
                defaultProfile = LoadDefaultProfile();
            }
            #endregion

            #region 配置提示
            if (defaultProfile != null)
            {
                if (!Directory.Exists(defaultProfile.OutputDir))
                    Directory.CreateDirectory(defaultProfile.OutputDir);
                OutputColorizer.Colorizer.WriteLine("[Green!目标输出目录：{0}]", defaultProfile.OutputDir);

                if (!ProfileExists)
                {
                    OutputColorizer.Colorizer.WriteLine("[Yellow!尚未手动指定ProfileSetting，系统生成默认的配置文件，请注意！]");
                    //Console.WriteLine("尚未手动指定ProfileSetting，系统生成默认的配置文件，请注意！");
                    OutputColorizer.Colorizer.WriteLine("[Green!随机密码：{0}]", defaultProfile.Pwd);
                }
                else
                {
                    OutputColorizer.Colorizer.WriteLine("[Green!密码：{0}]", defaultProfile.Pwd);
                    OutputColorizer.Colorizer.WriteLine("[Yellow!请牢记密码或保存密码!]");
                }
                Console.Write("是否继续【Y/Other key】:");
                var key = Console.ReadKey();
                if (key.Key != ConsoleKey.Y)
                {
                    return;
                }
                Console.WriteLine();
            }
            #endregion

            if (args != null && args.Length > 0)
            {
                if(args.Length == 1)
                {
                    if (Directory.Exists(args[0]))
                    {
                        var dots = new Dots("encrypting files");
                        dots.Start();
                        //TODO: 目录操作
                        await EncryptFolder(args[0], defaultProfile.OutputDir, defaultProfile.Pwd, defaultProfile.IncludeSubFolders);
                        dots.End();
                    }
                    if (File.Exists(args[0]))
                    {
                        var dots = new Dots("encrypting file");
                        dots.Start();
                        //TODO:单个文件操作
                        await EncryptSingleFile(args[0],null, defaultProfile.Pwd);
                        dots.End();
                    }
                }
            }
            else
            {
                Console.WriteLine("empty args");
            }
            Console.WriteLine("press any key to exit!");
            Console.ReadKey();

        }

        static Xakml.Common.Toolkit.MD5Helper md5Helper = new Xakml.Common.Toolkit.MD5Helper();

        /// <summary>
        /// 加密单个文件
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="password"></param>
        static async Task EncryptSingleFile(string inputFile, string? outputFile, string password)
        {
            if (md5Helper == null)
                md5Helper = new Xakml.Common.Toolkit.MD5Helper();
            string? folder = Path.GetDirectoryName(inputFile);
            string fileName = Path.GetFileName(inputFile);
            var fileName_data = SharpAESCrypt.Core.SharpAESCrypt.EncryptStringData(password, fileName);
            KeyValuePair<string, byte[]> extension_header = new KeyValuePair<string, byte[]>(ORIGINAL_FILENAME, fileName_data);

            //string outputfile = Path.Combine(folder,fileName + ".aes");
            //string outputfile = path + ".aes";
            Console.WriteLine("正在计算文件校验和,请稍后...");
            string original_file_hash_value = await Task.Run(() =>
            {
                var stopwatch_hash = System.Diagnostics.Stopwatch.StartNew();
                string hashString = md5Helper.GetMD5HexOfFile(inputFile);
                stopwatch_hash.Stop();
                Console.WriteLine("文件校验和耗时:" + stopwatch_hash.Elapsed);
                return hashString;
            });

            string outputfile = Path.Combine(folder, original_file_hash_value + ".aes");
            if (File.Exists(outputfile))
                outputfile = Xakml.Common.StringTools.Strings.GetNextFileName(folder, original_file_hash_value, "aes");
            using (FileStream outfs = File.Create(outputfile))
            {
                var aes = new SharpAESCrypt.Core.SharpAESCrypt(password, outfs, extension_header, SharpAESCrypt.Core.OperationMode.Encrypt);
                //aes.BeginEncrypt += Aes_BeginEncrypt;
                //aes.EncryptProgressReport += Aes_EncryptProgressReport;
                //aes.EncryptOrDeEncryptCompleteReport += Aes_EncryptOrDeEncryptCompleteReport;
                await aes.EncryptFileAsync(inputFile);
            }
            await Console.Out.WriteLineAsync(Path.GetFileName(inputFile) + " Encrypted." + outputfile);
        }

        static async Task EncryptFolder(string inputFolder,string? outputFolder,string password,bool followSubDirs = false)
        {
            var allfiles = inputFolder.GetFolderFilesPaths(followSubDirs);
            if (allfiles == null || allfiles.Count == 0)
            {
                Colorizer.WriteLine("[Red!未发现任何文件,在目录: {0}]", inputFolder);
                return;
            }
            //this.progressEncryptAllFiles.Maximum = allfiles.Count();
            //this.progressEncryptAllFiles.Minimum = 0;
            //this.progressEncryptAllFiles.Value = 0;
            //this.progressEncryptAllFiles.Step = 1;
            //this.progressEncryptAllFiles.Visible = true;// = 1;
            //string outputFolder = this.txtOutputFolder.Text;
            if (!string.IsNullOrEmpty(outputFolder) && !Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);
            var totalSize = inputFolder.GetDirectorySize(out int totalFiles);
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            await Task.Run(() =>
            {
                Parallel.For(
                    0,
                    allfiles.Count,
                    new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount - 1 },
               async i =>
               {
                   string output_dir = null;
                   if (Directory.Exists(outputFolder))
                       output_dir = Path.Combine(outputFolder, Path.GetDirectoryName(allfiles[i].Substring(inputFolder.Length + 1)));
                   await EncryptFile(allfiles[i], output_dir, password);
                   //this.progressEncryptAllFilesPerformStep();
               });
            });
            stopwatch.Stop();
            await Console.Out.WriteLineAsync($"总耗时：{stopwatch.Elapsed}, 处理文件总量：{totalSize.GetFriendlyReadStyle()}, 处理速率：{((long)(totalSize / stopwatch.Elapsed.TotalSeconds)).GetFriendlyReadStyle()}/s" );
        }

        /// <summary>
        /// 加密文件（单个文件）
        /// </summary>
        /// <param name="file_fullname"></param>
        private static async Task EncryptFile(string file_fullname, string output_dir, string password)
        {
            var file_extension = Path.GetExtension(file_fullname);
            var file_name = Path.GetFileName(file_fullname);
            if (file_extension.Equals(".aes", StringComparison.CurrentCultureIgnoreCase))
            {
                return;
            }

            var fileName_data = SharpAESCrypt.Core.SharpAESCrypt.EncryptStringData(password, file_name);
            KeyValuePair<string, byte[]> extension_header = new KeyValuePair<string, byte[]>(ORIGINAL_FILENAME, fileName_data);

            string folder = Path.GetDirectoryName(file_fullname);
            if (!string.IsNullOrEmpty(output_dir))
                folder = output_dir;
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            //compute hash value of file
            string original_file_hash_value = md5Helper.GetMD5HexOfFile(file_fullname);
            string outputfile = Path.Combine(folder, original_file_hash_value + ".aes");
            using (FileStream outfs = File.Create(outputfile))
            {
                var aes = new SharpAESCrypt.Core.SharpAESCrypt(password, outfs, extension_header, SharpAESCrypt.Core.OperationMode.Encrypt);
                //aes.BeginEncrypt += Aes_BeginEncrypt;
                //aes.EncryptProgressReport += Aes_EncryptProgressReport;
                //aes.EncryptOrDeEncryptCompleteReport += Aes_EncryptOrDeEncryptCompleteReport;
                await aes.EncryptFileAsync(file_fullname);
                //this.Log(Path.GetFileName(file_fullname) + " Encrypted.");
            }
        }

        #region 保存，读取默认配置文件
        static string defaultProfileName = "profile.json";
        static DefaultProfile LoadDefaultProfile()
        {
            string jsonData = System.IO.File.ReadAllText(defaultProfileName);
            DefaultProfile? profile = System.Text.Json.JsonSerializer.Deserialize<DefaultProfile>(jsonData);
            return profile;
        }

        static void SaveProfileSetting(DefaultProfile profile)
        {
            string jsonData = System.Text.Json.JsonSerializer.Serialize(profile,new System.Text.Json.JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(defaultProfileName,jsonData);
        }
        #endregion

    }
}