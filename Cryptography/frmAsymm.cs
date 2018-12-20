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
    public partial class frmAsymm : Form
    {
        private string _password = "";
        public frmAsymm()
        {
            InitializeComponent();
        }

        public void LoadPassword(string password)
        {
            _password = password;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string privateKey = "";
            string publicKey = "";

          AsymmetricEncryption.GenerateKeys(out publicKey, out privateKey);

            txtPrivate.Text = privateKey;
            txtPublic.Text = publicKey;
            txtPubLen.Text = publicKey.Length.ToString();
            txtPrivateLen.Text = privateKey.Length.ToString();


        }

        private void frmAsymm_Load(object sender, EventArgs e)
        {
            txtPassword.Text = _password;
        }

        private void btnSpeedTest_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime t1 = DateTime.Now;

                for(int i=0;i<100;i++)
                {
                    string encrypted = AsymmetricEncryption.EncryptText(txtPassword.Text, txtPublic.Text);
                    string decrypted = AsymmetricEncryption.DecryptText(encrypted, txtPrivate.Text);

                }

                DateTime t2 = DateTime.Now;

                TimeSpan timeSpan = t2.Subtract(t1);

                var elapsedMS = timeSpan.TotalMilliseconds;
                txtTime.Text = elapsedMS.ToString();


            }catch
            {

            }
        }
    }
}
