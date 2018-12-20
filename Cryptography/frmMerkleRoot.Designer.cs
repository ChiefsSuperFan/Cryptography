namespace Cryptography
{
    partial class frmMerkleRoot
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
            this.txtHashValues = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtMerkleRoot = new System.Windows.Forms.TextBox();
            this.txtMLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHashValues
            // 
            this.txtHashValues.Location = new System.Drawing.Point(50, 64);
            this.txtHashValues.Multiline = true;
            this.txtHashValues.Name = "txtHashValues";
            this.txtHashValues.Size = new System.Drawing.Size(980, 641);
            this.txtHashValues.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(1147, 545);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(347, 75);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Merkle Root";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtMerkleRoot
            // 
            this.txtMerkleRoot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMerkleRoot.ForeColor = System.Drawing.Color.Black;
            this.txtMerkleRoot.Location = new System.Drawing.Point(72, 850);
            this.txtMerkleRoot.Name = "txtMerkleRoot";
            this.txtMerkleRoot.Size = new System.Drawing.Size(1389, 38);
            this.txtMerkleRoot.TabIndex = 3;
            // 
            // txtMLength
            // 
            this.txtMLength.Location = new System.Drawing.Point(1497, 849);
            this.txtMLength.Name = "txtMLength";
            this.txtMLength.Size = new System.Drawing.Size(100, 38);
            this.txtMLength.TabIndex = 4;
            // 
            // frmMerkleRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1738, 972);
            this.Controls.Add(this.txtMLength);
            this.Controls.Add(this.txtMerkleRoot);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHashValues);
            this.Name = "frmMerkleRoot";
            this.Text = "frmMerkleRoot";
            this.Load += new System.EventHandler(this.frmMerkleRoot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHashValues;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtMerkleRoot;
        private System.Windows.Forms.TextBox txtMLength;
    }
}