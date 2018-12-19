﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}