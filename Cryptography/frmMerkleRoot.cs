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

            foreach(string hash in lines)
            {
                string hashValue = hash.Trim();

            }


        }
    }
}
