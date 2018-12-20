namespace Cryptography
{
    partial class frmHashComparison
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFileURL = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtInputData = new System.Windows.Forms.TextBox();
            this.btnComputeFile = new System.Windows.Forms.Button();
            this.btnComputeData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt256 = new System.Windows.Forms.TextBox();
            this.txt512 = new System.Windows.Forms.TextBox();
            this.txt256Length = new System.Windows.Forms.TextBox();
            this.txt512Length = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(1156, 72);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(107, 49);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "button1";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFileURL
            // 
            this.txtFileURL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFileURL.Enabled = false;
            this.txtFileURL.ForeColor = System.Drawing.Color.Black;
            this.txtFileURL.Location = new System.Drawing.Point(67, 78);
            this.txtFileURL.Name = "txtFileURL";
            this.txtFileURL.Size = new System.Drawing.Size(1044, 38);
            this.txtFileURL.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtInputData
            // 
            this.txtInputData.Location = new System.Drawing.Point(44, 172);
            this.txtInputData.Multiline = true;
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.Size = new System.Drawing.Size(1262, 407);
            this.txtInputData.TabIndex = 2;
            // 
            // btnComputeFile
            // 
            this.btnComputeFile.Location = new System.Drawing.Point(94, 640);
            this.btnComputeFile.Name = "btnComputeFile";
            this.btnComputeFile.Size = new System.Drawing.Size(180, 68);
            this.btnComputeFile.TabIndex = 3;
            this.btnComputeFile.Text = "HashFile";
            this.btnComputeFile.UseVisualStyleBackColor = true;
            this.btnComputeFile.Click += new System.EventHandler(this.btnComputeFile_Click);
            // 
            // btnComputeData
            // 
            this.btnComputeData.Location = new System.Drawing.Point(449, 640);
            this.btnComputeData.Name = "btnComputeData";
            this.btnComputeData.Size = new System.Drawing.Size(189, 68);
            this.btnComputeData.TabIndex = 4;
            this.btnComputeData.Text = "Hash Data";
            this.btnComputeData.UseVisualStyleBackColor = true;
            this.btnComputeData.Click += new System.EventHandler(this.btnComputeData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 768);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "SHA 256:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 834);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "SHA 512:";
            // 
            // txt256
            // 
            this.txt256.Location = new System.Drawing.Point(240, 768);
            this.txt256.Name = "txt256";
            this.txt256.Size = new System.Drawing.Size(1006, 38);
            this.txt256.TabIndex = 7;
            // 
            // txt512
            // 
            this.txt512.Location = new System.Drawing.Point(240, 834);
            this.txt512.Name = "txt512";
            this.txt512.Size = new System.Drawing.Size(1013, 38);
            this.txt512.TabIndex = 8;
            // 
            // txt256Length
            // 
            this.txt256Length.Location = new System.Drawing.Point(1327, 768);
            this.txt256Length.Name = "txt256Length";
            this.txt256Length.Size = new System.Drawing.Size(100, 38);
            this.txt256Length.TabIndex = 9;
            // 
            // txt512Length
            // 
            this.txt512Length.Location = new System.Drawing.Point(1317, 834);
            this.txt512Length.Name = "txt512Length";
            this.txt512Length.Size = new System.Drawing.Size(100, 38);
            this.txt512Length.TabIndex = 10;
            // 
            // frmHashComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 920);
            this.Controls.Add(this.txt512Length);
            this.Controls.Add(this.txt256Length);
            this.Controls.Add(this.txt512);
            this.Controls.Add(this.txt256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComputeData);
            this.Controls.Add(this.btnComputeFile);
            this.Controls.Add(this.txtInputData);
            this.Controls.Add(this.txtFileURL);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "frmHashComparison";
            this.Text = "frmHashComparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileURL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtInputData;
        private System.Windows.Forms.Button btnComputeFile;
        private System.Windows.Forms.Button btnComputeData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt256;
        private System.Windows.Forms.TextBox txt512;
        private System.Windows.Forms.TextBox txt256Length;
        private System.Windows.Forms.TextBox txt512Length;
    }
}