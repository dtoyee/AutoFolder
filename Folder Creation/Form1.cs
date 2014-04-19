using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Folder_Creation
{
    public partial class Form1 : Form
    {

        public string path = "";
        public string folderName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtDirectory.Text.Trim() != "" || txtFolderName.Text.Trim() != "")
            {
                folderName = txtFolderName.Text;
                createDirectory(path, folderName);
            }
            else
            {
                MessageBox.Show("Directory and folder name cannot be empty!");
            }
        }

        public void createDirectory(string path, string folderName)
        {
            try
            {
                if (Directory.Exists(path + folderName))
                {
                    MessageBox.Show("Directory already exists.");
                }
                else
                {
                    Directory.CreateDirectory(path + folderName);
                    MessageBox.Show(path + folderName + " created.");
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDirSearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog search = new FolderBrowserDialog();

            if(search.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = search.SelectedPath + "\\";
                txtDirectory.Text = path;
            }
        }
    }
}
