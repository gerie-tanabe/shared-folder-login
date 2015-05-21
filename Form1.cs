using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Shared_Folder_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string sharedFolderPath = txtSharedFolder.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            NetworkCredential readCredentials = new NetworkCredential(username, password);
            using (new NetworkConnection(sharedFolderPath, readCredentials))           
            {
                
                MessageBox.Show(Directory.Exists(sharedFolderPath).ToString());
File.Copy("sample.txt",sharedFolderPath + "\\sample.txt");
            }
        }
    }
}
