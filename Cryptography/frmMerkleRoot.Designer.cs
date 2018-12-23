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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHashValues
            // 
            this.txtHashValues.Location = new System.Drawing.Point(50, 83);
            this.txtHashValues.Multiline = true;
            this.txtHashValues.Name = "txtHashValues";
            this.txtHashValues.Size = new System.Drawing.Size(1678, 641);
            this.txtHashValues.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(509, 768);
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
            this.txtMerkleRoot.Location = new System.Drawing.Point(263, 937);
            this.txtMerkleRoot.Name = "txtMerkleRoot";
            this.txtMerkleRoot.Size = new System.Drawing.Size(1389, 38);
            this.txtMerkleRoot.TabIndex = 3;
            // 
            // txtMLength
            // 
            this.txtMLength.Location = new System.Drawing.Point(273, 996);
            this.txtMLength.Name = "txtMLength";
            this.txtMLength.Size = new System.Drawing.Size(100, 38);
            this.txtMLength.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of Hash Values:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 937);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Merkle Root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 1002);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Length:";
            // 
            // frmMerkleRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 1268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}