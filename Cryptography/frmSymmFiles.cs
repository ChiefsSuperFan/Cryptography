using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptography.Algorithms;
using System.IO;

namespace Cryptography
{
    public partial class frmSymmFiles : Form
    {

        private string _encryptionKey = "";

        public frmSymmFiles()
        {
            InitializeComponent();
        }

        public void LoadKey(string EncryptionKey)
        {
            _encryptionKey = EncryptionKey;
        }


        private void btnSelect1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPlainFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEncryptedfile.Text = openFileDialog1.FileName;
            }
        }

        private void frmSymmFiles_Load(object sender, EventArgs e)
        {
            txtSymmKey.Text = _encryptionKey;

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //first, create the new file name and url

            FileInfo file = new FileInfo(txtPlainFile.Text);
            
            if(file.Exists)
            {
                string fileDir = file.DirectoryName;

                string fileName = file.Name;
                string fileExt = file.Extension;

                string fileName2 = fileName.Split('.').FirstOrDefault();
                fileName2 += " Encrypt";
                string file2URL = fileDir + "\\" + fileName2 + fileExt;
               

                bool encrypt = SymmCrypto.EncryptFile(txtPlainFile.Text, file2URL, _encryptionKey);



            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(txtEncryptedfile.Text);

            if(file.Exists)
            {
                string fileDir = file.DirectoryName;

                string fileName = file.Name;
                string fileExt = file.Extension;

                string fileName2 = fileName.Split('.').FirstOrDefault();
                fileName2 += " Decrypt";
                string file2URL = fileDir + "\\" +fileName2 + fileExt;

                bool decrypt = SymmCrypto.DecryptFile(txtEncryptedfile.Text, file2URL, _encryptionKey);

            }
        }
    }
}
