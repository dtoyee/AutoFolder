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
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblFolderDirectory = new System.Windows.Forms.Label();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.lblSubDirectory = new System.Windows.Forms.Label();
            this.txtSubDirectory = new System.Windows.Forms.TextBox();
            this.btnSubDirectory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(98, 23);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(222, 20);
            this.txtDirectory.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(16, 175);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(152, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Folder";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblFolderDirectory
            // 
            this.lblFolderDirectory.AutoSize = true;
            this.lblFolderDirectory.Location = new System.Drawing.Point(13, 23);
            this.lblFolderDirectory.Name = "lblFolderDirectory";
            this.lblFolderDirectory.Size = new System.Drawing.Size(79, 13);
            this.lblFolderDirectory.TabIndex = 2;
            this.lblFolderDirectory.Text = "Folder directory";
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Location = new System.Drawing.Point(13, 55);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(65, 13);
            this.lblFolderName.TabIndex = 3;
            this.lblFolderName.Text = "Folder name";
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(98, 55);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(222, 20);
            this.txtFolderName.TabIndex = 4;
            // 
            // lblSubDirectory
            // 
            this.lblSubDirectory.AutoSize = true;
            this.lblSubDirectory.Location = new System.Drawing.Point(13, 120);
            this.lblSubDirectory.Name = "lblSubDirectory";
            this.lblSubDirectory.Size = new System.Drawing.Size(71, 13);
            this.lblSubDirectory.TabIndex = 5;
            this.lblSubDirectory.Text = "Sub Directory";
            // 
            // txtSubDirectory
            // 
            this.txtSubDirectory.Location = new System.Drawing.Point(98, 120);
            this.txtSubDirectory.Name = "txtSubDirectory";
            this.txtSubDirectory.Size = new System.Drawing.Size(222, 20);
            this.txtSubDirectory.TabIndex = 6;
            // 
            // btnSubDirectory
            // 
            this.btnSubDirectory.Location = new System.Drawing.Point(174, 175);
            this.btnSubDirectory.Name = "btnSubDirectory";
            this.btnSubDirectory.Size = new System.Drawing.Size(146, 23);
            this.btnSubDirectory.TabIndex = 7;
            this.btnSubDirectory.Text = "Add Sub Directory";
            this.btnSubDirectory.UseVisualStyleBackColor = true;
            this.btnSubDirectory.Click += new System.EventHandler(this.btnSubDirectory_Click);
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
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 51);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sub Directory";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(3, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 56);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 236);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubDirectory);
            this.Controls.Add(this.txtSubDirectory);
            this.Controls.Add(this.lblSubDirectory);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.lblFolderName);
            this.Controls.Add(this.lblFolderDirectory);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblFolderDirectory;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label lblSubDirectory;
        private System.Windows.Forms.TextBox txtSubDirectory;
        private System.Windows.Forms.Button btnSubDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

