namespace SPUploadDocs2Lib
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbSiteUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbListName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFilesCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWordText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFilenamePref = new System.Windows.Forms.TextBox();
            this.btCreateWordFiles = new System.Windows.Forms.Button();
            this.tbExcelText = new System.Windows.Forms.TextBox();
            this.tbExcFilenamePref = new System.Windows.Forms.TextBox();
            this.btCreateExcelFiles = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // tbSiteUrl
            // 
            resources.ApplyResources(this.tbSiteUrl, "tbSiteUrl");
            this.tbSiteUrl.Name = "tbSiteUrl";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Name = "label2";
            // 
            // tbListName
            // 
            resources.ApplyResources(this.tbListName, "tbListName");
            this.tbListName.Name = "tbListName";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Name = "label3";
            // 
            // tbFilesCount
            // 
            resources.ApplyResources(this.tbFilesCount, "tbFilesCount");
            this.tbFilesCount.Name = "tbFilesCount";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tbWordText
            // 
            resources.ApplyResources(this.tbWordText, "tbWordText");
            this.tbWordText.Name = "tbWordText";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tbFilenamePref
            // 
            resources.ApplyResources(this.tbFilenamePref, "tbFilenamePref");
            this.tbFilenamePref.Name = "tbFilenamePref";
            // 
            // btCreateWordFiles
            // 
            resources.ApplyResources(this.btCreateWordFiles, "btCreateWordFiles");
            this.btCreateWordFiles.Image = global::SPUploadDocs2Lib.Properties.Resources.word;
            this.btCreateWordFiles.Name = "btCreateWordFiles";
            this.btCreateWordFiles.UseVisualStyleBackColor = true;
            this.btCreateWordFiles.Click += new System.EventHandler(this.btCreateWordFiles_Click);
            // 
            // tbExcelText
            // 
            resources.ApplyResources(this.tbExcelText, "tbExcelText");
            this.tbExcelText.Name = "tbExcelText";
            // 
            // tbExcFilenamePref
            // 
            resources.ApplyResources(this.tbExcFilenamePref, "tbExcFilenamePref");
            this.tbExcFilenamePref.Name = "tbExcFilenamePref";
            // 
            // btCreateExcelFiles
            // 
            resources.ApplyResources(this.btCreateExcelFiles, "btCreateExcelFiles");
            this.btCreateExcelFiles.Image = global::SPUploadDocs2Lib.Properties.Resources.excel;
            this.btCreateExcelFiles.Name = "btCreateExcelFiles";
            this.btCreateExcelFiles.UseVisualStyleBackColor = true;
            this.btCreateExcelFiles.Click += new System.EventHandler(this.btCreateExcelFiles_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.tbWordText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbFilenamePref);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btCreateWordFiles);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.btCreateExcelFiles);
            this.groupBox2.Controls.Add(this.tbExcelText);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbExcFilenamePref);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbFilesCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbListName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSiteUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSiteUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbListName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFilesCount;
        private System.Windows.Forms.Button btCreateWordFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWordText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFilenamePref;
        private System.Windows.Forms.TextBox tbExcelText;
        private System.Windows.Forms.TextBox tbExcFilenamePref;
        private System.Windows.Forms.Button btCreateExcelFiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}

