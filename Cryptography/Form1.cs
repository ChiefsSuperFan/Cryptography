﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            

            try
            {
                int keySize = Convert.ToInt32(txtKeySize.Text);
                RandomKeyGenerator keyGen = new RandomKeyGenerator(keySize);

                if(keyGen.ValidKeyLength)
                {
                    string pk = keyGen.RandomKey;
                    txtRandomKey.Text = pk;
                    var privateKey = Encoding.UTF8.GetBytes(pk);
                }
                else
                {
                    MessageBox.Show("Key length too short!");
                }


            }
            catch
            {

            }


        }

        private void btnSymmEncrypt_Click(object sender, EventArgs e)
        {
            if(txtRandomKey.Text.Length>9)
            {
                frmSymm symm = new frmSymm();
                symm.LoadKey(txtRandomKey.Text);
                symm.ShowDialog();
            }else
            {
                MessageBox.Show("Please enter or generate a strong random key!");
            }
        }

        private void btnAsymm_Click(object sender, EventArgs e)
        {
            frmAsymm asymm = new frmAsymm();
            asymm.LoadPassword(txtRandomKey.Text);

            asymm.Show();
        }

        private void btnHashCompare_Click(object sender, EventArgs e)
        {
            frmHashComparison hashComparison = new frmHashComparison();
            hashComparison.Show();

        }

        private void btnMerkle_Click(object sender, EventArgs e)
        {
            
            frmMerkleRoot merkleRoot = new frmMerkleRoot();
            merkleRoot.Show();

        }

        private void btnFileEncrypt_Click(object sender, EventArgs e)
        {
            frmSymmFiles symmFiles = new frmSymmFiles();
            symmFiles.LoadKey(txtRandomKey.Text);
            symmFiles.Show();

        }

        private void btnRIPEMD_Click(object sender, EventArgs e)
        {
            frmRIPEMDHash frmRIPEMDHash = new frmRIPEMDHash();
            frmRIPEMDHash.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAES aesExample = new frmAES();
            aesExample.Show();
     
        }
    }
}
