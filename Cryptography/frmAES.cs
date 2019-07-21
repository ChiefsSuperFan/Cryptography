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
            string ivAsBase64 = "";
            string encryptedTextAsBase64 = "";
            string keyAsBase64 = "";
            string output = "";

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                // Store the IV (they can be stored if you don't re-use a key)
                aes.GenerateIV();
                byte[] iv = aes.IV;
                ivAsBase64 = Convert.ToBase64String(iv);
                //Console.WriteLine("IV base64: {0}", ivAsBase64);
                output += string.Format("IV base64: {0}", ivAsBase64) + Environment.NewLine;
                

                // See how long the default key length is
                aes.GenerateKey();
                //Console.WriteLine("Algorithm key length should be: {0}", aes.Key.Length);
                //output += string.Format("Algorithm key length should be: {0}", aes.Key.Length) + Environment.NewLine;
                // Set a key
                //string key = "a very long sentence for a key that should exceed the max length of a key for AES therefore " +
                //    "we're going to need to substring it based on the GenerateKey length we're given";
                ////Console.WriteLine("Key length: {0}", key.Length);
                //output += string.Format("Key length: {0}", key.Length) + Environment.NewLine;
                keyAsBase64 = Convert.ToBase64String(aes.Key);

                //byte[] keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, aes.Key.Length));
                //aes.Key = keyBytes;
                //Console.WriteLine("The random key is: {0}", keyAsBase64);

                // Base64 the key for storage
                //keyAsBase64 = Convert.ToBase64String(aes.Key);
                //Console.WriteLine("Key base64: {0}", keyAsBase64);
                output += string.Format("Key base64: {0}", keyAsBase64) + Environment.NewLine;

                // Encrypt the text
                byte[] textBytes = Encoding.UTF8.GetBytes("chris áááéééééé óóóó 💩");
                var cryptor = aes.CreateEncryptor();
                byte[] encryptedBytes = cryptor.TransformFinalBlock(textBytes, 0, textBytes.Length);
                encryptedTextAsBase64 = Convert.ToBase64String(encryptedBytes);
                Console.WriteLine("Encrypted (base64'd): {0}", encryptedTextAsBase64);
            }

            Console.WriteLine("==================================================");

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                // Decrypt the text
                byte[] iv = Convert.FromBase64String(ivAsBase64);
                byte[] keyBytes = Convert.FromBase64String(keyAsBase64);
                byte[] fromBase64ToBytes = Convert.FromBase64String(encryptedTextAsBase64);
                var decryptor = aes.CreateDecryptor(keyBytes, iv);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(fromBase64ToBytes, 0, fromBase64ToBytes.Length);

                Console.WriteLine("Decrypted: {0}", Encoding.UTF8.GetString(decryptedBytes));
            }

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
