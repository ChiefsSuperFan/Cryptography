using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Cryptography.Algorithms;

namespace Cryptography
{
    public partial class frmAES : Form
    {
        public frmAES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plainText = txtInput.Text;

            string encrypted = KCAESymmCrypto.EncryptText(plainText, "12345");

            string decrypted = KCAESymmCrypto.DecryptText(encrypted, "12345");
         
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSourceFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(txtSourceFile.Text);

            if(fileInfo.Exists)
            {
                string fileName = fileInfo.Name;
                string fileName1 = fileName.Split('.').FirstOrDefault();

                string outfile = fileInfo.Directory +"\\"+ fileName1 + ".enc";

                string encryptFile = KCAESymmCrypto.EncryptFile(txtSourceFile.Text, outfile);
                txtOutput.Text = encryptFile;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(txtSourceFile.Text);
            string key = txtInput.Text;

            if (fileInfo.Exists)
            {
                string fileName = fileInfo.Name;
                string fileName1 = fileName.Split('.').FirstOrDefault();

                string outfile = fileInfo.Directory + "\\" + fileName1 + "1.txt";

                bool decrypt = KCAESymmCrypto.DecryptFile(txtSourceFile.Text, outfile, key);
              

            }
        }
    }
}
