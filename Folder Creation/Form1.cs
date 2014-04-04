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
        public string subDirectory = "";

        public Form1()
        {
            InitializeComponent();

            lblFolderDirectory.BringToFront();
            txtDirectory.BringToFront();
            lblFolderName.BringToFront();
            txtFolderName.BringToFront();

            lblSubDirectory.BringToFront();
            txtSubDirectory.BringToFront();

            btnCreate.BringToFront();
            btnSubDirectory.BringToFront();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtDirectory.Text != "" || txtFolderName.Text != "")
            {
                path = @txtDirectory.Text + "/";
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

        private void btnSubDirectory_Click(object sender, EventArgs e)
        {
            if(txtSubDirectory.Text != "")
            {
                subDirectory = txtSubDirectory.Text;
                createSubDirectory(path + folderName, subDirectory);
            }
            else
            {
                MessageBox.Show("Sub directory box cannot be empty!");
            }
        }

        private void createSubDirectory(string path, string subDirectory)
        {
            DirectoryInfo directory = new DirectoryInfo(path);

            try
            {
                if (Directory.Exists(subDirectory))
                {
                    MessageBox.Show(subDirectory + " already exists!");
                }
                else
                {
                    directory.CreateSubdirectory(subDirectory);
                    txtSubDirectory.Clear();
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
