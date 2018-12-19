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
            this.SuspendLayout();
            // 
            // txtEncryptionKey
            // 
            this.txtEncryptionKey.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEncryptionKey.Enabled = false;
            this.txtEncryptionKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptionKey.ForeColor = System.Drawing.Color.Black;
            this.txtEncryptionKey.Location = new System.Drawing.Point(176, 84);
            this.txtEncryptionKey.Name = "txtEncryptionKey";
            this.txtEncryptionKey.Size = new System.Drawing.Size(707, 38);
            this.txtEncryptionKey.TabIndex = 0;
            // 
            // frmSymm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 611);
            this.Controls.Add(this.txtEncryptionKey);
            this.Name = "frmSymm";
            this.Text = "frmSymm";
            this.Load += new System.EventHandler(this.frmSymm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncryptionKey;
    }
}