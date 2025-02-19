﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AESxWin.Test
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void GetPathWithoutAESExtension()
        {
            var path = @"D:\Projects\Visual Studio 2013\Projects\AESxWin\AESxWin\bin\Debug\test.txt.aes";

            Console.WriteLine(Path.ChangeExtension(path, "").TrimEnd(new char[]{ '.'}));

            var ext = Path.GetExtension(path);

            var extIndex = path.LastIndexOf(ext);

            path = path.Substring(0, extIndex);

            Console.WriteLine(path);

            Assert.AreEqual(".aes", ext);

        }

        [TestMethod]
        public void TestEncryptString()
        {
            string content = "JC-CNHM.2022-09-01.15.log";
            byte[] data = SharpAESCrypt.SharpAESCrypt.EncryptStringData("!GlPM!nt#1NO", content);
            Console.WriteLine(BitConverter.ToString(data).Replace("-", ""));
        }
    }
}
