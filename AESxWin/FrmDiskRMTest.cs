using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESxWin
{
    public partial class FrmDiskRMTest : Form
    {
        public FrmDiskRMTest()
        {
            InitializeComponent();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            this.progressBar1.Style = ProgressBarStyle.Marquee;
            this.btnStartTest.Enabled = false;
            Task.Run(() =>
            {
               return CreateRandomFile(1024 * 1024 * 1024);
            }).ContinueWith(tsk => 
            {
                if(tsk.IsCompleted)
                {
                    this.Invoke(new Action(async () =>
                    {
                        this.progressBar1.Style = ProgressBarStyle.Continuous;
                        this.progressBar1.Value = 0;
                        var result = await tsk;
                        var writeSpeed = result.WriteDataSize / result.ElapsedSeconds;
                        this.btnStartTest.Enabled = true;
                        MessageBox.Show("测试写入速度: " + writeSpeed / (1024 * 1024) + "\r\n耗时：" + result.ElapsedSeconds + "秒");
                    }));
                }
            });
        }
        /// <summary>
        /// 随机创建文件（文件内容随机）
        /// </summary>
        /// <param name="fileSize">文件大小（单位：字节）</param>
        /// <param name="targetFileName">生成的目标文件保存位置</param>
        private WriteTestResult CreateRandomFile(long fileSize, string targetFileName = "")
        {
            //参考代码： https://github.com/kakhovsky/BigFileZIP/blob/master/bigfiletest/BigFileCompression/Program.cs

            int bufferSize = 1024 * 1024; //默认缓冲区数据大小为1K
            byte[] buffer = new byte[bufferSize];
            Random rnd = new Random();
            if (string.IsNullOrEmpty(targetFileName))
                targetFileName = Guid.NewGuid().ToString("N") + ".temp";
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                if (fileSize > bufferSize) //指定文件大于缓存时
                {
                    long count = fileSize / bufferSize;
                    long count_mod = fileSize % bufferSize;

                    using (Stream output = File.Create(targetFileName, 1024, FileOptions.WriteThrough))
                    {
                        do
                        {
                            Array.Clear(buffer, 0, buffer.Length); //是否需要清空上次生产的数据
                            rnd.NextBytes(buffer);
                            output.Write(buffer, 0, buffer.Length);
                            count--;
                        } while (count > 0);

                        if (count_mod > 0)
                        {
                            Array.Clear(buffer, 0, buffer.Length); //是否需要清空上次生产的数据
                            rnd.NextBytes(buffer);
                            output.Write(buffer, 0, (int)count_mod);
                        }
                        output.Flush();
                        output.Close();
                    }
                }
                else //指定文件小于等于缓存时
                {
                    using (Stream output = File.Create(Guid.NewGuid().ToString("N"), 1024, FileOptions.WriteThrough))
                    {
                        rnd.NextBytes(buffer);
                        if (bufferSize - fileSize == 0)
                        {
                            output.Write(buffer, 0, buffer.Length);
                        }
                        else
                        {
                            output.Write(buffer, 0, (int)fileSize);
                        }
                        output.Flush();
                        output.Close();
                    }
                }
                stopwatch.Stop();
                //var writeSpeed = fileSize / stopwatch.Elapsed.TotalSeconds;

                return new WriteTestResult() { ElapsedSeconds = stopwatch.Elapsed.TotalSeconds, WriteDataSize = fileSize };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal class WriteTestResult
        {
            /// <summary>
            /// 写入数据的长度（字节单位）
            /// </summary>
            public long WriteDataSize { get; set; }

            /// <summary>
            /// 耗费的时间
            /// </summary>
            public double ElapsedSeconds { get; set; }
        }
    }
}
