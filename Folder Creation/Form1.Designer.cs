namespace Folder_Creation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDirSearch = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.lblFolderDirectory = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Location = new System.Drawing.Point(3, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 50);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 19);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(152, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Folder";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDirSearch
            // 
            this.btnDirSearch.Location = new System.Drawing.Point(223, 23);
            this.btnDirSearch.Name = "btnDirSearch";
            this.btnDirSearch.Size = new System.Drawing.Size(97, 23);
            this.btnDirSearch.TabIndex = 11;
            this.btnDirSearch.Text = "Directory Search";
            this.btnDirSearch.UseVisualStyleBackColor = true;
            this.btnDirSearch.Click += new System.EventHandler(this.btnDirSearch_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(98, 58);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(222, 20);
            this.txtFolderName.TabIndex = 15;
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Location = new System.Drawing.Point(13, 58);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(65, 13);
            this.lblFolderName.TabIndex = 14;
            this.lblFolderName.Text = "Folder name";
            // 
            // lblFolderDirectory
            // 
            this.lblFolderDirectory.AutoSize = true;
            this.lblFolderDirectory.Location = new System.Drawing.Point(13, 26);
            this.lblFolderDirectory.Name = "lblFolderDirectory";
            this.lblFolderDirectory.Size = new System.Drawing.Size(79, 13);
            this.lblFolderDirectory.TabIndex = 13;
            this.lblFolderDirectory.Text = "Folder directory";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(98, 26);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(119, 20);
            this.txtDirectory.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 160);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.lblFolderName);
            this.Controls.Add(this.lblFolderDirectory);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.btnDirSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Folder";
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDirSearch;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.Label lblFolderDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnCreate;
    }
}

