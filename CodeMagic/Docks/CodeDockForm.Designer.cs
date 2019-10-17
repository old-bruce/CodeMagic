namespace CodeMagic.Docks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeDockForm));
            this.tvTemplates = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvTemplates
            // 
            this.tvTemplates.ContextMenuStrip = this.contextMenuStrip1;
            this.tvTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTemplates.ImageIndex = 0;
            this.tvTemplates.ImageList = this.imageList1;
            this.tvTemplates.Indent = 21;
            this.tvTemplates.ItemHeight = 19;
            this.tvTemplates.Location = new System.Drawing.Point(0, 0);
            this.tvTemplates.Name = "tvTemplates";
            this.tvTemplates.SelectedImageIndex = 0;
            this.tvTemplates.Size = new System.Drawing.Size(284, 261);
            this.tvTemplates.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新FToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // 刷新FToolStripMenuItem
            // 
            this.刷新FToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.Refresh;
            this.刷新FToolStripMenuItem.Name = "刷新FToolStripMenuItem";
            this.刷新FToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.刷新FToolStripMenuItem.Text = "刷新(&R)";
            this.刷新FToolStripMenuItem.Click += new System.EventHandler(this.刷新FToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "文件夹.png");
            this.imageList1.Images.SetKeyName(1, "language-csharp.png");
            this.imageList1.Images.SetKeyName(2, "html.png");
            this.imageList1.Images.SetKeyName(3, "css.png");
            this.imageList1.Images.SetKeyName(4, "符号-JSX.png");
            this.imageList1.Images.SetKeyName(5, "page.png");
            // 
            // CodeDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tvTemplates);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeDockForm";
            this.Text = "代码段";
            this.Load += new System.EventHandler(this.CodeDockForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvTemplates;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新FToolStripMenuItem;
    }
}