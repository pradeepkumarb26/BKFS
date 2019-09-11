namespace BKFS.MergeCSV.WinForm.Forms
{
    partial class MergeCSVToJson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeCSVToJson));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblCSVFilePath1 = new System.Windows.Forms.Label();
            this.lblCSVFilePath2 = new System.Windows.Forms.Label();
            this.lblJsonFolderPath = new System.Windows.Forms.Label();
            this.txtCSVFilePath1 = new System.Windows.Forms.TextBox();
            this.txtCSVFilePath2 = new System.Windows.Forms.TextBox();
            this.txtJsonFolderPath = new System.Windows.Forms.TextBox();
            this.btnCSVFilePath1 = new System.Windows.Forms.Button();
            this.btnCSVFilePath2 = new System.Windows.Forms.Button();
            this.btnJsonFolderPath = new System.Windows.Forms.Button();
            this.fldBrowDlgJsonFolderPath = new System.Windows.Forms.FolderBrowserDialog();
            this.openCSVFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowLogFile = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.chkHeader = new System.Windows.Forms.CheckBox();
            this.grpbox1 = new System.Windows.Forms.GroupBox();
            this.grbbox2 = new System.Windows.Forms.GroupBox();
            this.grpbox1.SuspendLayout();
            this.grbbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(250, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(286, 24);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Black Knight Merge CSV Tool";
            // 
            // lblCSVFilePath1
            // 
            this.lblCSVFilePath1.AutoSize = true;
            this.lblCSVFilePath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSVFilePath1.Location = new System.Drawing.Point(16, 23);
            this.lblCSVFilePath1.Name = "lblCSVFilePath1";
            this.lblCSVFilePath1.Size = new System.Drawing.Size(85, 15);
            this.lblCSVFilePath1.TabIndex = 1;
            this.lblCSVFilePath1.Text = "CSVFilePath1:";
            // 
            // lblCSVFilePath2
            // 
            this.lblCSVFilePath2.AutoSize = true;
            this.lblCSVFilePath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSVFilePath2.Location = new System.Drawing.Point(16, 52);
            this.lblCSVFilePath2.Name = "lblCSVFilePath2";
            this.lblCSVFilePath2.Size = new System.Drawing.Size(85, 15);
            this.lblCSVFilePath2.TabIndex = 2;
            this.lblCSVFilePath2.Text = "CSVFilePath2:";
            // 
            // lblJsonFolderPath
            // 
            this.lblJsonFolderPath.AutoSize = true;
            this.lblJsonFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJsonFolderPath.Location = new System.Drawing.Point(4, 28);
            this.lblJsonFolderPath.Name = "lblJsonFolderPath";
            this.lblJsonFolderPath.Size = new System.Drawing.Size(96, 15);
            this.lblJsonFolderPath.TabIndex = 3;
            this.lblJsonFolderPath.Text = "JsonFolderPath:";
            // 
            // txtCSVFilePath1
            // 
            this.txtCSVFilePath1.Enabled = false;
            this.txtCSVFilePath1.Location = new System.Drawing.Point(113, 19);
            this.txtCSVFilePath1.Name = "txtCSVFilePath1";
            this.txtCSVFilePath1.Size = new System.Drawing.Size(538, 20);
            this.txtCSVFilePath1.TabIndex = 4;
            // 
            // txtCSVFilePath2
            // 
            this.txtCSVFilePath2.Enabled = false;
            this.txtCSVFilePath2.Location = new System.Drawing.Point(113, 51);
            this.txtCSVFilePath2.Name = "txtCSVFilePath2";
            this.txtCSVFilePath2.Size = new System.Drawing.Size(538, 20);
            this.txtCSVFilePath2.TabIndex = 5;
            // 
            // txtJsonFolderPath
            // 
            this.txtJsonFolderPath.Enabled = false;
            this.txtJsonFolderPath.Location = new System.Drawing.Point(113, 27);
            this.txtJsonFolderPath.Name = "txtJsonFolderPath";
            this.txtJsonFolderPath.Size = new System.Drawing.Size(538, 20);
            this.txtJsonFolderPath.TabIndex = 6;
            // 
            // btnCSVFilePath1
            // 
            this.btnCSVFilePath1.Location = new System.Drawing.Point(648, 16);
            this.btnCSVFilePath1.Name = "btnCSVFilePath1";
            this.btnCSVFilePath1.Size = new System.Drawing.Size(75, 23);
            this.btnCSVFilePath1.TabIndex = 7;
            this.btnCSVFilePath1.Text = "Browse";
            this.btnCSVFilePath1.UseVisualStyleBackColor = true;
            this.btnCSVFilePath1.Click += new System.EventHandler(this.btnCSVFilePath1_Click);
            // 
            // btnCSVFilePath2
            // 
            this.btnCSVFilePath2.Location = new System.Drawing.Point(648, 49);
            this.btnCSVFilePath2.Name = "btnCSVFilePath2";
            this.btnCSVFilePath2.Size = new System.Drawing.Size(75, 23);
            this.btnCSVFilePath2.TabIndex = 8;
            this.btnCSVFilePath2.Text = "Browse";
            this.btnCSVFilePath2.UseVisualStyleBackColor = true;
            this.btnCSVFilePath2.Click += new System.EventHandler(this.btnCSVFilePath2_Click);
            // 
            // btnJsonFolderPath
            // 
            this.btnJsonFolderPath.Location = new System.Drawing.Point(648, 24);
            this.btnJsonFolderPath.Name = "btnJsonFolderPath";
            this.btnJsonFolderPath.Size = new System.Drawing.Size(75, 23);
            this.btnJsonFolderPath.TabIndex = 9;
            this.btnJsonFolderPath.Text = "Browse";
            this.btnJsonFolderPath.UseVisualStyleBackColor = true;
            this.btnJsonFolderPath.Click += new System.EventHandler(this.btnJsonFolderPath_Click);
            // 
            // openCSVFileDlg
            // 
            this.openCSVFileDlg.FileName = "openFileDialog1";
            // 
            // btnMerge
            // 
            this.btnMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.Location = new System.Drawing.Point(503, 297);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(132, 25);
            this.btnMerge.TabIndex = 10;
            this.btnMerge.Text = "Save && Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(656, 297);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 25);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowLogFile
            // 
            this.btnShowLogFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLogFile.Location = new System.Drawing.Point(46, 297);
            this.btnShowLogFile.Name = "btnShowLogFile";
            this.btnShowLogFile.Size = new System.Drawing.Size(132, 25);
            this.btnShowLogFile.TabIndex = 12;
            this.btnShowLogFile.Text = "Show Log";
            this.btnShowLogFile.UseVisualStyleBackColor = true;
            this.btnShowLogFile.Click += new System.EventHandler(this.btnShowLogFile_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfig.Location = new System.Drawing.Point(352, 297);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(132, 25);
            this.btnSaveConfig.TabIndex = 13;
            this.btnSaveConfig.Text = "Save Selection";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // chkHeader
            // 
            this.chkHeader.AutoSize = true;
            this.chkHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeader.Location = new System.Drawing.Point(113, 75);
            this.chkHeader.Name = "chkHeader";
            this.chkHeader.Size = new System.Drawing.Size(92, 19);
            this.chkHeader.TabIndex = 15;
            this.chkHeader.Text = "Has Header";
            this.chkHeader.UseVisualStyleBackColor = true;
            // 
            // grpbox1
            // 
            this.grpbox1.Controls.Add(this.txtCSVFilePath1);
            this.grpbox1.Controls.Add(this.chkHeader);
            this.grpbox1.Controls.Add(this.lblCSVFilePath1);
            this.grpbox1.Controls.Add(this.lblCSVFilePath2);
            this.grpbox1.Controls.Add(this.txtCSVFilePath2);
            this.grpbox1.Controls.Add(this.btnCSVFilePath1);
            this.grpbox1.Controls.Add(this.btnCSVFilePath2);
            this.grpbox1.Location = new System.Drawing.Point(46, 64);
            this.grpbox1.Name = "grpbox1";
            this.grpbox1.Size = new System.Drawing.Size(741, 100);
            this.grpbox1.TabIndex = 16;
            this.grpbox1.TabStop = false;
            this.grpbox1.Text = "Select CSV Files";
            // 
            // grbbox2
            // 
            this.grbbox2.Controls.Add(this.txtJsonFolderPath);
            this.grbbox2.Controls.Add(this.lblJsonFolderPath);
            this.grbbox2.Controls.Add(this.btnJsonFolderPath);
            this.grbbox2.Location = new System.Drawing.Point(46, 182);
            this.grbbox2.Name = "grbbox2";
            this.grbbox2.Size = new System.Drawing.Size(741, 66);
            this.grbbox2.TabIndex = 17;
            this.grbbox2.TabStop = false;
            this.grbbox2.Text = "Select Json Destination Path";
            // 
            // MergeCSVToJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 375);
            this.Controls.Add(this.grbbox2);
            this.Controls.Add(this.grpbox1);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnShowLogFile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.lblHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MergeCSVToJson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Knight Task";
            this.Load += new System.EventHandler(this.MergeCSVToJson_Load);
            this.grpbox1.ResumeLayout(false);
            this.grpbox1.PerformLayout();
            this.grbbox2.ResumeLayout(false);
            this.grbbox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblCSVFilePath1;
        private System.Windows.Forms.Label lblCSVFilePath2;
        private System.Windows.Forms.Label lblJsonFolderPath;
        private System.Windows.Forms.TextBox txtCSVFilePath1;
        private System.Windows.Forms.TextBox txtCSVFilePath2;
        private System.Windows.Forms.TextBox txtJsonFolderPath;
        private System.Windows.Forms.Button btnCSVFilePath1;
        private System.Windows.Forms.Button btnCSVFilePath2;
        private System.Windows.Forms.Button btnJsonFolderPath;
        private System.Windows.Forms.FolderBrowserDialog fldBrowDlgJsonFolderPath;
        private System.Windows.Forms.OpenFileDialog openCSVFileDlg;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowLogFile;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.CheckBox chkHeader;
        private System.Windows.Forms.GroupBox grpbox1;
        private System.Windows.Forms.GroupBox grbbox2;
    }
}