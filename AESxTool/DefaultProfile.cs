namespace AESxTool
{
    internal class DefaultProfile
    {
        /// <summary>
        /// 加密后的文件保存位置
        /// </summary>
        public string OutputDir { get; set; }

        /// <summary>
        /// 使用文件校验和值作为目标文件的文件名
        /// </summary>
        public bool UseHashValueAsTargetFileName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }

        /// <summary>
        /// 包含子目录文件
        /// </summary>
        public bool IncludeSubFolders { get; set; }
    }
}
