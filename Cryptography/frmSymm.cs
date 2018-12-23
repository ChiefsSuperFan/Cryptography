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
                    txtPlainLength.Text = plainText.Length.ToString();
                    txtEncryptedLength.Text = encryptedText.Length.ToString();

                   
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

        private void btnSpeedTest_Click(object sender, EventArgs e)
        {
            if(txtEncrypted.Text.Length>0)
            {
                DateTime t1 = DateTime.Now;
                //string plain = txtPlain.Text;

                for(int i=0;i<200;i++)
                {
                    //string encrypt = SymmCrypto.Encrypt(plain, txtEncryptionKey.Text);
                    string decrypt = SymmCrypto.Decrypt(txtEncrypted.Text, txtEncryptionKey.Text);

                }

                DateTime t2 = DateTime.Now;
                TimeSpan time = t2.Subtract(t1);
                txtElapsedTime.Text = time.TotalMilliseconds.ToString();


            }
        }
    }
}
