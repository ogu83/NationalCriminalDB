using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace NationalCriminalDB.EmailService.Helpers.Tests
{
    [TestClass]
    public class EmailHelperTests
    {
        [TestMethod]
        public void SendGroupMailWithAttachmentsTest()
        {
            try
            {
                //Create Files
                var to = "oguz@artwalkmobile.com";
                var filecount = 20;
                var maxFileCount = 10;
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var filenames = new List<string>();
                for (int i = 0; i < filecount; i++)
                {
                    var filename = string.Format("{0}\\mail_test_file_{1}.txt", appDataPath, i);
                    var content = string.Format("This is a demo file number {0}", i);
                    filenames.Add(filename);
                    File.WriteAllText(filename, content);
                    Assert.IsTrue(File.Exists(filename), "File couldn't be created FileName : " + filename);
                }
                //Mail Files
                EmailHelper.SendGroupMailWithAttachments(to, filenames.ToArray(), maxFileCount);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                Assert.Fail(ex.StackTrace);
            }
        }
    }
}