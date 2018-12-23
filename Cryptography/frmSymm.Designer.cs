namespace Cryptography
{
    partial class frmSymm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEncryptionKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtEncryptedLength = new System.Windows.Forms.TextBox();
            this.txtPlainLength = new System.Windows.Forms.TextBox();
            this.btnSpeedTest = new System.Windows.Forms.Button();
            this.txtElapsedTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEncryptionKey
            // 
            this.txtEncryptionKey.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEncryptionKey.Enabled = false;
            this.txtEncryptionKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptionKey.ForeColor = System.Drawing.Color.Black;
            this.txtEncryptionKey.Location = new System.Drawing.Point(134, 63);
            this.txtEncryptionKey.Name = "txtEncryptionKey";
            this.txtEncryptionKey.Size = new System.Drawing.Size(707, 38);
            this.txtEncryptionKey.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(110, 240);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(239, 69);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(44, 331);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(720, 475);
            this.txtPlain.TabIndex = 2;
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(810, 331);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(784, 475);
            this.txtEncrypted.TabIndex = 3;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(889, 259);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(269, 50);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtEncryptedLength
            // 
            this.txtEncryptedLength.Location = new System.Drawing.Point(1392, 834);
            this.txtEncryptedLength.Name = "txtEncryptedLength";
            this.txtEncryptedLength.Size = new System.Drawing.Size(100, 38);
            this.txtEncryptedLength.TabIndex = 5;
            // 
            // txtPlainLength
            // 
            this.txtPlainLength.Location = new System.Drawing.Point(631, 834);
            this.txtPlainLength.Name = "txtPlainLength";
            this.txtPlainLength.Size = new System.Drawing.Size(100, 38);
            this.txtPlainLength.TabIndex = 6;
            // 
            // btnSpeedTest
            // 
            this.btnSpeedTest.Location = new System.Drawing.Point(208, 980);
            this.btnSpeedTest.Name = "btnSpeedTest";
            this.btnSpeedTest.Size = new System.Drawing.Size(200, 66);
            this.btnSpeedTest.TabIndex = 7;
            this.btnSpeedTest.Text = "Speed Test";
            this.btnSpeedTest.UseVisualStyleBackColor = true;
            this.btnSpeedTest.Click += new System.EventHandler(this.btnSpeedTest_Click);
            // 
            // txtElapsedTime
            // 
            this.txtElapsedTime.Location = new System.Drawing.Point(568, 995);
            this.txtElapsedTime.Name = "txtElapsedTime";
            this.txtElapsedTime.Size = new System.Drawing.Size(299, 38);
            this.txtElapsedTime.TabIndex = 8;
            // 
            // frmSymm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 1124);
            this.Controls.Add(this.txtElapsedTime);
            this.Controls.Add(this.btnSpeedTest);
            this.Controls.Add(this.txtPlainLength);
            this.Controls.Add(this.txtEncryptedLength);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtEncryptionKey);
            this.Name = "frmSymm";
            this.Text = "frmSymm";
            this.Load += new System.EventHandler(this.frmSymm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncryptionKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtEncryptedLength;
        private System.Windows.Forms.TextBox txtPlainLength;
        private System.Windows.Forms.Button btnSpeedTest;
        private System.Windows.Forms.TextBox txtElapsedTime;
    }
}