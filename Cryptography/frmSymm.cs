using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoClasses;

namespace Cryptography
{
    public partial class frmSymm : Form
    {
        private string _encryptionKey = "";
        public frmSymm()
        {
            InitializeComponent();
        }

        public void LoadKey(string EncryptionKey)
        {
            _encryptionKey = EncryptionKey;
        }

        private void frmSymm_Load(object sender, EventArgs e)
        {
            txtEncryptionKey.Text = _encryptionKey;

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string plainText = txtPlain.Text;
                if(plainText.Length>0)
                {
                    string encryptedText = SymmCrypto.Encrypt(plainText, txtEncryptionKey.Text);
                    txtEncrypted.Text = encryptedText;
                   
                }

            }
            catch
            {

            }


         

           
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtPlain.Text = "";
            string encryptedText = txtEncrypted.Text;
            string privateKey=txtEncryptionKey.Text;

            string plain = SymmCrypto.Decrypt(encryptedText, txtEncryptionKey.Text);

            txtPlain.Text = plain;




        }
    }
}
