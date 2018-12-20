using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptography.Algorithms;

namespace Cryptography
{
    public partial class frmMerkleRoot : Form
    {
        public frmMerkleRoot()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //TextReader read = new System.IO.StringReader(txtHashValues.Text);

            string[] lines = txtHashValues.Lines;
            bool hash256 = true;
            bool valid = true;
            int hashLength = 0;
            int previousLength = 0;
            int lineCount = 0;
            List<BCHashValue> hashValues = new List<BCHashValue>();

            foreach(string hash in lines)
            {
                string hashValue = hash.Trim();
                hashLength = hashValue.Length;
                lineCount++;
                if (hashLength == 128)
                {
                    BCHashValue hashValue512 = new BCHashValue(hashValue, HashAlgorithm.Sha512);
                    hashValues.Add(hashValue512);
                    hash256 = false;
                }
                else
                {
                    BCHashValue hashValue256 = new BCHashValue(hashValue);
                    hashValues.Add(hashValue256);
                    if(!hash256)
                    {
                        //this means a 512 hash has been added and you can't mix 
                        valid = false;
                    }
                }

                previousLength = hashLength;



            }

            string merkleRoot = MerkleRoot.GetMerkleRoot(hashValues);
            txtMerkleRoot.Text = merkleRoot;


        }

        private void frmMerkleRoot_Load(object sender, EventArgs e)
        {

        }
    }
}
