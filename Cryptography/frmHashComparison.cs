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
    public partial class frmHashComparison : Form
    {
        public frmHashComparison()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileURL.Text = openFileDialog1.FileName;
            }
        }

        private void btnComputeData_Click(object sender, EventArgs e)
        {
            string inputData = txtInputData.Text.Trim();

            if(inputData.Length>0)
            {
                string hash256 = CryptoHash.GetSHA256StringHash(inputData);
                string hash512 = CryptoHash.GetSHA512StringHash(inputData);

                txt256.Text = hash256;
                txt512.Text = hash512;

                txt256Length.Text = hash256.Length.ToString();
                txt512Length.Text = hash512.Length.ToString();

            }
        }

        private void btnComputeFile_Click(object sender, EventArgs e)
        {
            if(txtFileURL.Text.Length>0)
            {
                string hash256 = CryptoHash.GetSha256FileHash(txtFileURL.Text);
                string hash512 = CryptoHash.GetSha512FileHash(txtFileURL.Text);

                txt256.Text = hash256;
                txt512.Text = hash512;

                txt256Length.Text = hash256.Length.ToString();
                txt512Length.Text = hash512.Length.ToString();

            }
        }
    }
}
