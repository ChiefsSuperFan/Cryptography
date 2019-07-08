namespace Cryptography
{
    partial class Form1
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
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.txtRandomKey = new System.Windows.Forms.TextBox();
            this.txtKeySize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSymmEncrypt = new System.Windows.Forms.Button();
            this.btnAsymm = new System.Windows.Forms.Button();
            this.btnHashCompare = new System.Windows.Forms.Button();
            this.btnMerkle = new System.Windows.Forms.Button();
            this.btnFileEncrypt = new System.Windows.Forms.Button();
            this.btnRIPEMD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(31, 34);
            this.btnGenerateKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(156, 25);
            this.btnGenerateKey.TabIndex = 0;
            this.btnGenerateKey.Text = "Generate Key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // txtRandomKey
            // 
            this.txtRandomKey.Location = new System.Drawing.Point(31, 107);
            this.txtRandomKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRandomKey.Name = "txtRandomKey";
            this.txtRandomKey.Size = new System.Drawing.Size(268, 22);
            this.txtRandomKey.TabIndex = 1;
            // 
            // txtKeySize
            // 
            this.txtKeySize.Location = new System.Drawing.Point(310, 37);
            this.txtKeySize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKeySize.Name = "txtKeySize";
            this.txtKeySize.Size = new System.Drawing.Size(52, 22);
            this.txtKeySize.TabIndex = 2;
            this.txtKeySize.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key Length:";
            // 
            // btnSymmEncrypt
            // 
            this.btnSymmEncrypt.Location = new System.Drawing.Point(38, 176);
            this.btnSymmEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSymmEncrypt.Name = "btnSymmEncrypt";
            this.btnSymmEncrypt.Size = new System.Drawing.Size(180, 33);
            this.btnSymmEncrypt.TabIndex = 4;
            this.btnSymmEncrypt.Text = "Symmetric Encryption";
            this.btnSymmEncrypt.UseVisualStyleBackColor = true;
            this.btnSymmEncrypt.Click += new System.EventHandler(this.btnSymmEncrypt_Click);
            // 
            // btnAsymm
            // 
            this.btnAsymm.Location = new System.Drawing.Point(44, 250);
            this.btnAsymm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAsymm.Name = "btnAsymm";
            this.btnAsymm.Size = new System.Drawing.Size(174, 30);
            this.btnAsymm.TabIndex = 5;
            this.btnAsymm.Text = "Asymmetric Encryption";
            this.btnAsymm.UseVisualStyleBackColor = true;
            this.btnAsymm.Click += new System.EventHandler(this.btnAsymm_Click);
            // 
            // btnHashCompare
            // 
            this.btnHashCompare.Location = new System.Drawing.Point(346, 176);
            this.btnHashCompare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHashCompare.Name = "btnHashCompare";
            this.btnHashCompare.Size = new System.Drawing.Size(156, 33);
            this.btnHashCompare.TabIndex = 6;
            this.btnHashCompare.Text = "Hash Compare";
            this.btnHashCompare.UseVisualStyleBackColor = true;
            this.btnHashCompare.Click += new System.EventHandler(this.btnHashCompare_Click);
            // 
            // btnMerkle
            // 
            this.btnMerkle.Location = new System.Drawing.Point(346, 250);
            this.btnMerkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMerkle.Name = "btnMerkle";
            this.btnMerkle.Size = new System.Drawing.Size(179, 36);
            this.btnMerkle.TabIndex = 7;
            this.btnMerkle.Text = "Merkle Roots";
            this.btnMerkle.UseVisualStyleBackColor = true;
            this.btnMerkle.Click += new System.EventHandler(this.btnMerkle_Click);
            // 
            // btnFileEncrypt
            // 
            this.btnFileEncrypt.Location = new System.Drawing.Point(44, 318);
            this.btnFileEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFileEncrypt.Name = "btnFileEncrypt";
            this.btnFileEncrypt.Size = new System.Drawing.Size(164, 28);
            this.btnFileEncrypt.TabIndex = 8;
            this.btnFileEncrypt.Text = "File Encryption";
            this.btnFileEncrypt.UseVisualStyleBackColor = true;
            this.btnFileEncrypt.Click += new System.EventHandler(this.btnFileEncrypt_Click);
            // 
            // btnRIPEMD
            // 
            this.btnRIPEMD.Location = new System.Drawing.Point(364, 318);
            this.btnRIPEMD.Name = "btnRIPEMD";
            this.btnRIPEMD.Size = new System.Drawing.Size(75, 23);
            this.btnRIPEMD.TabIndex = 9;
            this.btnRIPEMD.Text = "button1";
            this.btnRIPEMD.UseVisualStyleBackColor = true;
            this.btnRIPEMD.Click += new System.EventHandler(this.btnRIPEMD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 417);
            this.Controls.Add(this.btnRIPEMD);
            this.Controls.Add(this.btnFileEncrypt);
            this.Controls.Add(this.btnMerkle);
            this.Controls.Add(this.btnHashCompare);
            this.Controls.Add(this.btnAsymm);
            this.Controls.Add(this.btnSymmEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKeySize);
            this.Controls.Add(this.txtRandomKey);
            this.Controls.Add(this.btnGenerateKey);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.TextBox txtRandomKey;
        private System.Windows.Forms.TextBox txtKeySize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSymmEncrypt;
        private System.Windows.Forms.Button btnAsymm;
        private System.Windows.Forms.Button btnHashCompare;
        private System.Windows.Forms.Button btnMerkle;
        private System.Windows.Forms.Button btnFileEncrypt;
        private System.Windows.Forms.Button btnRIPEMD;
    }
}

