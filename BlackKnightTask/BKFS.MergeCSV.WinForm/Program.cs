using BKFS.MergeCSV.WinForm.Common;
using BKFS.MergeCSV.WinForm.Contracts;
using BKFS.MergeCSV.WinForm.Entities;
using BKFS.MergeCSV.WinForm.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKFS.MergeCSV.WinForm
{
    static class Program
    {
        private static Mutex mutex = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                MergeLog.Loginformation("Main - Start");
                
                //Create Mutex object & its related varibale to avoid running multiple instances
                const string appName = "SingleCSVInstanceApp";
                bool createdNew;
                mutex = new Mutex(true, appName, out createdNew);
                MergeLog.Loginformation("Mutex thread created.");
                if (!createdNew)
                {
                    //Prompt the message to enduser and close the current instance 
                    MessageBox.Show("Application is already running.");
                    MergeLog.Loginformation("Mutex thread identified already win form instance is running.");
                    return;
                }

                //Identify the Windows form exe is launched with/without parameters
                if (args.Length > 0)
                {
                    //Declare client object and which will create all required object at runtime
                    BusinessClient businessClient = new BusinessClient();

                    //Read the saved selection of CSV files and destination paths
                    MergeCSVData data = PackageConfig.ReadMergeCSVData();

                    //Validating saved tool configuration values
                    if (string.IsNullOrEmpty(data.CSVFilePath1) || string.IsNullOrEmpty(data.CSVFilePath2) ||
                        string.IsNullOrEmpty(data.HeaderExists) || string.IsNullOrEmpty(data.JsonFilePath))
                    {
                        //Prompt the validation message to enduser and close the current instance 
                        MessageBox.Show("Invalid Configuration values. Please use UI execution.", "MergeCSVTool");
                        MergeLog.Loginformation("Invalid Configuration values.");
                        return;
                    }

                    // Call the merge method
                    businessClient.MergeCsvToJson(data);
                    MessageBox.Show("Given CSV files are merged successfully.", "MergeCSVTool");
                }
                else
                {
                    //Open Merge win form 
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MergeCSVToJson());
                }
                MergeLog.Loginformation("Main - End");
            }
            catch (Exception ex)
            {
                MergeLog.LogError(ex);
                MessageBox.Show(ex.Message, "MergeCSVTool");
            }
        }
    }
}
