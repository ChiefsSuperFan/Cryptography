namespace Cryptography
{
    partial class frmAsymm
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
            this.txtPublic = new System.Windows.Forms.TextBox();
            this.txtPrivate = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPubLen = new System.Windows.Forms.TextBox();
            this.txtPrivateLen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSpeedTest = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtLen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPublic
            // 
            this.txtPublic.Location = new System.Drawing.Point(56, 53);
            this.txtPublic.Multiline = true;
            this.txtPublic.Name = "txtPublic";
            this.txtPublic.Size = new System.Drawing.Size(1047, 682);
            this.txtPublic.TabIndex = 0;
            // 
            // txtPrivate
            // 
            this.txtPrivate.Location = new System.Drawing.Point(1205, 53);
            this.txtPrivate.Multiline = true;
            this.txtPrivate.Name = "txtPrivate";
            this.txtPrivate.Size = new System.Drawing.Size(947, 682);
            this.txtPrivate.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(68, 793);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(172, 64);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPubLen
            // 
            this.txtPubLen.Location = new System.Drawing.Point(1003, 741);
            this.txtPubLen.Name = "txtPubLen";
            this.txtPubLen.Size = new System.Drawing.Size(100, 38);
            this.txtPubLen.TabIndex = 4;
            // 
            // txtPrivateLen
            // 
            this.txtPrivateLen.Location = new System.Drawing.Point(2052, 750);
            this.txtPrivateLen.Name = "txtPrivateLen";
            this.txtPrivateLen.Size = new System.Drawing.Size(100, 38);
            this.txtPrivateLen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Public Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1215, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Private Key:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(395, 931);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(1459, 38);
            this.txtPassword.TabIndex = 8;
            // 
            // btnSpeedTest
            // 
            this.btnSpeedTest.Location = new System.Drawing.Point(327, 1122);
            this.btnSpeedTest.Name = "btnSpeedTest";
            this.btnSpeedTest.Size = new System.Drawing.Size(371, 51);
            this.btnSpeedTest.TabIndex = 9;
            this.btnSpeedTest.Text = "Test";
            this.btnSpeedTest.UseVisualStyleBackColor = true;
            this.btnSpeedTest.Click += new System.EventHandler(this.btnSpeedTest_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(1364, 1120);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(246, 38);
            this.txtTime.TabIndex = 10;
            // 
            // txtLen
            // 
            this.txtLen.Location = new System.Drawing.Point(1386, 1208);
            this.txtLen.Name = "txtLen";
            this.txtLen.Size = new System.Drawing.Size(224, 38);
            this.txtLen.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1029, 1132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Elapsed Time (MS):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(997, 1214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Encrypted Text Length:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 931);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Plain Text:";
            // 
            // frmAsymm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2439, 1400);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLen);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnSpeedTest);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrivateLen);
            this.Controls.Add(this.txtPubLen);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPrivate);
            this.Controls.Add(this.txtPublic);
            this.Name = "frmAsymm";
            this.Text = "frmAsymm";
            this.Load += new System.EventHandler(this.frmAsymm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPublic;
        private System.Windows.Forms.TextBox txtPrivate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPubLen;
        private System.Windows.Forms.TextBox txtPrivateLen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSpeedTest;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtLen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}