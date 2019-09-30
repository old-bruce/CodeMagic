namespace CodeMagic.Docks
{
    partial class TemplateEditDockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateEditDockForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tslFilePath = new System.Windows.Forms.ToolStripLabel();
            this.tecCode = new ICSharpCode.TextEditor.TextEditorControlEx();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSave,
            this.tslFilePath});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(284, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = global::CodeMagic.Properties.Resources.save;
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(23, 20);
            this.tsBtnSave.Text = "保存";
            this.tsBtnSave.Click += new System.EventHandler(this.tsBtnSave_Click);
            // 
            // tslFilePath
            // 
            this.tslFilePath.Name = "tslFilePath";
            this.tslFilePath.Size = new System.Drawing.Size(47, 20);
            this.tslFilePath.Text = "filepath";
            // 
            // tecCode
            // 
            this.tecCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecCode.FoldingStrategy = null;
            this.tecCode.Font = new System.Drawing.Font("Courier New", 10F);
            this.tecCode.Location = new System.Drawing.Point(0, 27);
            this.tecCode.Name = "tecCode";
            this.tecCode.Size = new System.Drawing.Size(284, 234);
            this.tecCode.SyntaxHighlighting = null;
            this.tecCode.TabIndex = 1;
            // 
            // TemplateEditDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tecCode);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemplateEditDockForm";
            this.Text = "编辑模板";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TemplateEditDockForm_FormClosing);
            this.Load += new System.EventHandler(this.TemplateEditDockForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripLabel tslFilePath;
        private ICSharpCode.TextEditor.TextEditorControlEx tecCode;
    }
}