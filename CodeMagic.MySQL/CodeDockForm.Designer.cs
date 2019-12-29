namespace CodeMagic.MySQL
{
    partial class CodeDockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeDockForm));
            this.teCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.SuspendLayout();
            // 
            // teCode
            // 
            this.teCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teCode.IsReadOnly = false;
            this.teCode.Location = new System.Drawing.Point(0, 0);
            this.teCode.Name = "teCode";
            this.teCode.Size = new System.Drawing.Size(800, 450);
            this.teCode.TabIndex = 0;
            // 
            // CodeDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeDockForm";
            this.TabText = "CodeDockForm";
            this.Text = "CodeDockForm";
            this.ResumeLayout(false);

        }

        #endregion

        internal ICSharpCode.TextEditor.TextEditorControl teCode;
    }
}