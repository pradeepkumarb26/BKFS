using BKFS.MergeCSV.WinForm.Common;
using BKFS.MergeCSV.WinForm.Contracts;
using BKFS.MergeCSV.WinForm.Entities;
using BKFS.MergeCSV.WinForm.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace BKFS.MergeCSV.WinForm.Forms
{
    public partial class MergeCSVToJson : Form
    {
        BusinessClient businessClient;
        MergeCSVData mergeCSVData;
        public MergeCSVToJson()
        {
            InitializeComponent();
            businessClient = new BusinessClient();

        }

        private void btnJsonFolderPath_Click(object sender, EventArgs e)
        {
            try
            {
                if (fldBrowDlgJsonFolderPath.ShowDialog() == DialogResult.OK)
                {
                    txtJsonFolderPath.Text = fldBrowDlgJsonFolderPath.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MergeLog.LogError(ex);
                MessageBox.Show(ex.Message, "MergeCSVTool");
            }
        }

        private void btnCSVFilePath2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openCSVFileDlg.ShowDialog() == DialogResult.OK)
                {
                    txtCSVFilePath2.Text = openCSVFileDlg.FileName;
                }
                
            }
            catch (Exception ex)
            {
                MergeLog.LogError(ex);
                MessageBox.Show(ex.Message, "MergeCSVTool");
            }
        }

        private void btnCSVFilePath1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openCSVFileDlg.ShowDialog() == DialogResult.OK)
                {
                    txtCSVFilePath1.Text = openCSVFileDlg.FileName;
                }

            }
            catch (Exception ex)
            {
                MergeLog.LogError(ex);
                MessageBox.Show(ex.Message, "MergeCSVTool");
            }
        }

        

        private void MergeCSVToJson_Load(object sender, EventArgs e)
        {
            openCSVFileDlg.Filter = "CSV files (*.csv)|*.csv";
            openCSVFileDlg.FileName = "";

            MergeCSVData data = PackageConfig.ReadMergeCSVData();
            txtCSVFilePath1.Text = data.CSVFilePath1;
            txtCSVFilePath2.Text = data.CSVFilePath2;
            txtJsonFolderPath.Text = data.JsonFilePath;
            chkHeader.Checked = (data.HeaderExists == string.Empty) ? false : Convert.ToBoolean(data.HeaderExists);
        }

        private bool ValidateFields()
        {
            bool retValidate = true;

            if (string.IsNullOrEmpty(txtCSVFilePath1.Text.Trim()) || string.IsNullOrEmpty(txtCSVFilePath2.Text.Trim()))
            {
                MessageBox.Show("Please select CSV file.", "MergeCSVTool");
                return false;
            }
            if (string.IsNullOrEmpty(txtJsonFolderPath.Text.Trim()))
            {
                MessageBox.Show("Please select Json file path.", "MergeCSVTool");
                return false;
            }

            return retValidate;
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate the form fields
                if (ValidateFields())
                {
                    //Ask the enduser to confirm csv file header information
                    DialogResult dialogResult = MessageBox.Show("Given CSV files are going to merged " + (chkHeader.Checked ? "with " : "without ") + " header.  Are you sure you want to begin?",
                              "Confirm to begin merge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.No) return;

                    //Save the enduser selection information in tool configuration file
                    CollectAndSaveConfigDetails();

                    //Call the merge method
                    businessClient.MergeCsvToJson(mergeCSVData);
                    MessageBox.Show("Given CSV files are merged successfully.", "MergeCSVTool");
                }
            }
            catch (Exception ex)
            {
                MergeLog.LogError(ex); 
                MessageBox.Show(ex.Message, "MergeCSVTool");
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    DialogResult dialogResult = MessageBox.Show("You opted CSV files are " + (chkHeader.Checked ? "having " : "not having ") + " header.  Are you sure you want to Save?",
                              "Confirm to begin save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.No) return;
                    CollectAndSaveConfigDetails();
                    MergeLog.Loginformation("End user selection details are saved successfully.");
                    MessageBox.Show("Form input details are saved successfully.", "MergeCSVTool");
                }
            }
            catch (Exception ex)
            {
                MergeLog.LogError(ex);
                MessageBox.Show(ex.Message, "MergeCSVTool");
            }
        }

        private void CollectAndSaveConfigDetails()
        {
            try
            {
                mergeCSVData = new MergeCSVData();
                mergeCSVData.CSVFilePath1 = txtCSVFilePath1.Text;
                mergeCSVData.CSVFilePath2 = txtCSVFilePath2.Text;
                mergeCSVData.JsonFilePath = txtJsonFolderPath.Text;
                mergeCSVData.HeaderExists = chkHeader.Checked.ToString();
                PackageConfig.WriteMergeCSVData(mergeCSVData);
            }
            catch (Exception e)
            {
                MergeLog.LogError(e);
                throw e;
            }
        }

        private void btnShowLogFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Directory.GetCurrentDirectory() + @"\" + MergeLog.LogFileName))
                {
                    System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\" + MergeLog.LogFileName);
                }
                else
                {
                    MessageBox.Show("Log file does not exists.", "MergeCSVTool");
                }
            }
            catch (Exception ex)
            {
                MergeLog.LogError(ex);
                throw ex;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
