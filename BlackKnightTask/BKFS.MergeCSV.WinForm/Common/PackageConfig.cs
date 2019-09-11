using BKFS.MergeCSV.WinForm.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BKFS.MergeCSV.WinForm.Common
{
    public class PackageConfig
    {
        public static string PackageFileName = Directory.GetCurrentDirectory() + @"\BKFS_MergeCSV.config";
        public static MergeCSVData ReadMergeCSVData()
        {
            MergeCSVData obj = new MergeCSVData();
            try
            {
                if (File.Exists(PackageFileName))
                {
                    XmlDocument configDoc = new XmlDocument();
                    configDoc.Load(PackageFileName);
                    obj.CSVFilePath1 = configDoc.GetElementsByTagName("CSVFilePath1").Item(0) != null ? configDoc.GetElementsByTagName("CSVFilePath1").Item(0).InnerText : string.Empty;
                    obj.CSVFilePath2 = configDoc.GetElementsByTagName("CSVFilePath2").Item(0) != null ? configDoc.GetElementsByTagName("CSVFilePath2").Item(0).InnerText : string.Empty;
                    obj.HeaderExists = configDoc.GetElementsByTagName("HeaderExists").Item(0) != null ? configDoc.GetElementsByTagName("HeaderExists").Item(0).InnerText : string.Empty;
                    obj.JsonFilePath = configDoc.GetElementsByTagName("JsonFilePath").Item(0) != null ? configDoc.GetElementsByTagName("JsonFilePath").Item(0).InnerText : string.Empty;
                    MergeLog.Loginformation("Read the configuration values are successful.");
                }
            }
            catch (Exception e)
            {
                MergeLog.LogError(e);
                throw e;
            }

            return obj;
        }

        public static void WriteMergeCSVData(MergeCSVData data)
        {
            try
            {
                if (!File.Exists(PackageFileName))
                    File.Create(PackageFileName).Close();

                StringBuilder sbPackageConfig = new StringBuilder();
                sbPackageConfig.AppendLine("<configuration>");
                sbPackageConfig.AppendLine("\t" + "<CSVFilePath1>" + data.CSVFilePath1 + "</CSVFilePath1>");
                sbPackageConfig.AppendLine("\t" + "<CSVFilePath2>" + data.CSVFilePath2 + "</CSVFilePath2>");
                sbPackageConfig.AppendLine("\t" + "<HeaderExists>" + data.HeaderExists + "</HeaderExists>");
                sbPackageConfig.AppendLine("\t" + "<JsonFilePath>" + data.JsonFilePath + "</JsonFilePath>");
                sbPackageConfig.AppendLine("</configuration>");

                File.WriteAllText(PackageFileName, sbPackageConfig.ToString());
                MergeLog.Loginformation("Write the configuration details are successful.");
            }
            catch (Exception e)
            {
                MergeLog.LogError(e);
                throw e;
            }
        }
    }
}
