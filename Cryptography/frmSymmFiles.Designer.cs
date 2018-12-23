namespace Cryptography
{
    partial class frmSymmFiles
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
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.txtPlainFile = new System.Windows.Forms.TextBox();
            this.txtEncryptedfile = new System.Windows.Forms.TextBox();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.txtSymmKey = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelect1
            // 
            this.btnSelect1.Location = new System.Drawing.Point(916, 261);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(75, 46);
            this.btnSelect1.TabIndex = 0;
            this.btnSelect1.Text = "...";
            this.btnSelect1.UseVisualStyleBackColor = true;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // txtPlainFile
            // 
            this.txtPlainFile.Location = new System.Drawing.Point(58, 261);
            this.txtPlainFile.Name = "txtPlainFile";
            this.txtPlainFile.Size = new System.Drawing.Size(800, 38);
            this.txtPlainFile.TabIndex = 1;
            // 
            // txtEncryptedfile
            // 
            this.txtEncryptedfile.Location = new System.Drawing.Point(58, 369);
            this.txtEncryptedfile.Name = "txtEncryptedfile";
            this.txtEncryptedfile.Size = new System.Drawing.Size(800, 38);
            this.txtEncryptedfile.TabIndex = 2;
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(916, 367);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(75, 41);
            this.btnSelect2.TabIndex = 3;
            this.btnSelect2.Text = "...";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // txtSymmKey
            // 
            this.txtSymmKey.Location = new System.Drawing.Point(85, 96);
            this.txtSymmKey.Name = "txtSymmKey";
            this.txtSymmKey.Size = new System.Drawing.Size(729, 38);
            this.txtSymmKey.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(1099, 234);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(237, 64);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(1099, 367);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(237, 74);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Encryption Key:";
            // 
            // frmSymmFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 928);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtSymmKey);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.txtEncryptedfile);
            this.Controls.Add(this.txtPlainFile);
            this.Controls.Add(this.btnSelect1);
            this.Name = "frmSymmFiles";
            this.Text = "frmSymmFiles";
            this.Load += new System.EventHandler(this.frmSymmFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.TextBox txtPlainFile;
        private System.Windows.Forms.TextBox txtEncryptedfile;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.TextBox txtSymmKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
    }
}