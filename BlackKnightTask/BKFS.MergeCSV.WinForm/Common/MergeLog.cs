using System;
using System.IO;

namespace BKFS.MergeCSV.WinForm.Common
{
    public static class MergeLog
    {
        public const string LogFileName = "MergeCSV.log";
        public static void Loginformation(string logMessage)
        {
            try
            {
                if (!File.Exists(Directory.GetCurrentDirectory() + @"\" + LogFileName))
                    File.Create(Directory.GetCurrentDirectory() + @"\"+ LogFileName).Close();

                using (StreamWriter writer = File.AppendText(Directory.GetCurrentDirectory() + @"\"+ LogFileName))
                {
                    writer.WriteLine("---------------------------------------------------------------------------------------");
                    writer.WriteLine("{0} | INFO | {1}", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), logMessage);
                    writer.Flush();
                }
            }
            catch (Exception)
            {
            }
        }

        public static void LogError(Exception logEx)
        {
            try
            {
                if (!File.Exists(Directory.GetCurrentDirectory() + @"\"+ LogFileName))
                    File.Create(Directory.GetCurrentDirectory() + @"\"+ LogFileName).Close();

                using (StreamWriter writer = File.AppendText(Directory.GetCurrentDirectory() + @"\"+ LogFileName))
                {
                    writer.WriteLine("---------------------------------------------------------------------------------------");
                    writer.WriteLine("{0} | ERROR | {1} ", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), logEx.Message);
                    writer.WriteLine(logEx.GetBaseException().StackTrace);
                    writer.Flush();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
