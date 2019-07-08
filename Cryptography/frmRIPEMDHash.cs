using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Cryptography
{
    public partial class frmRIPEMDHash : Form
    {
        public frmRIPEMDHash()
        {
            InitializeComponent();
        }

        private void frmRIPEMDHash_Load(object sender, EventArgs e)
        {

        }

        private string GetRIPEHash(string password)
        {
            // create a ripemd160 object
            RIPEMD160 r160 = RIPEMD160Managed.Create();
            // convert the string to byte
            byte[] myByte = System.Text.Encoding.ASCII.GetBytes(password);
            // compute the byte to RIPEMD160 hash
            byte[] encrypted = r160.ComputeHash(myByte);
            // create a new StringBuilder process the hash byte
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encrypted.Length; i++)
            {
                sb.Append(encrypted[i].ToString("X2"));
            }
            // convert the StringBuilder to String and convert it to lower case and return it.
            return sb.ToString().ToLower();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "2490383CD65D960C3FCC44A1A25576DCC0AE0E626BB7F5E11174A244DC7305FD";

            string hashValue = GetRIPEHash(password);

        }
    }
}
