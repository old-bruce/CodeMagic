namespace CodeMagic.Tool
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSource = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tbxDest = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database connection string encryption and decryption";
            // 
            // tbxSource
            // 
            this.tbxSource.Location = new System.Drawing.Point(28, 39);
            this.tbxSource.Multiline = true;
            this.tbxSource.Name = "tbxSource";
            this.tbxSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxSource.Size = new System.Drawing.Size(564, 90);
            this.tbxSource.TabIndex = 1;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(436, 246);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 26);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // tbxDest
            // 
            this.tbxDest.Location = new System.Drawing.Point(28, 140);
            this.tbxDest.Multiline = true;
            this.tbxDest.Name = "tbxDest";
            this.tbxDest.ReadOnly = true;
            this.tbxDest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDest.Size = new System.Drawing.Size(564, 90);
            this.tbxDest.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(517, 246);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 26);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 312);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbxDest);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.tbxSource);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeMagic.Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSource;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox tbxDest;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

