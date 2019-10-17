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
            this.tvCodes = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCS文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlhtml文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSScss文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSjs文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其它文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvCodes
            // 
            this.tvCodes.ContextMenuStrip = this.contextMenuStrip1;
            this.tvCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCodes.ImageIndex = 0;
            this.tvCodes.ImageList = this.imageList1;
            this.tvCodes.Indent = 21;
            this.tvCodes.ItemHeight = 19;
            this.tvCodes.Location = new System.Drawing.Point(0, 0);
            this.tvCodes.Name = "tvCodes";
            this.tvCodes.SelectedImageIndex = 0;
            this.tvCodes.Size = new System.Drawing.Size(284, 261);
            this.tvCodes.TabIndex = 3;
            this.tvCodes.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvCodes_NodeMouseDoubleClick);
            this.tvCodes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvCodes_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新FToolStripMenuItem,
            this.新增ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 70);
            // 
            // 刷新FToolStripMenuItem
            // 
            this.刷新FToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.Refresh;
            this.刷新FToolStripMenuItem.Name = "刷新FToolStripMenuItem";
            this.刷新FToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.刷新FToolStripMenuItem.Text = "刷新(&R)";
            this.刷新FToolStripMenuItem.Click += new System.EventHandler(this.刷新FToolStripMenuItem_Click);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cCS文件ToolStripMenuItem,
            this.htmlhtml文件ToolStripMenuItem,
            this.cSScss文件ToolStripMenuItem,
            this.jSjs文件ToolStripMenuItem,
            this.其它文件ToolStripMenuItem});
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            // 
            // cCS文件ToolStripMenuItem
            // 
            this.cCS文件ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.language_csharp;
            this.cCS文件ToolStripMenuItem.Name = "cCS文件ToolStripMenuItem";
            this.cCS文件ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cCS文件ToolStripMenuItem.Text = "C#(*.cs)文件";
            this.cCS文件ToolStripMenuItem.Click += new System.EventHandler(this.cCS文件ToolStripMenuItem_Click);
            // 
            // htmlhtml文件ToolStripMenuItem
            // 
            this.htmlhtml文件ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.html;
            this.htmlhtml文件ToolStripMenuItem.Name = "htmlhtml文件ToolStripMenuItem";
            this.htmlhtml文件ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.htmlhtml文件ToolStripMenuItem.Text = "Html(*.html)文件";
            this.htmlhtml文件ToolStripMenuItem.Click += new System.EventHandler(this.htmlhtml文件ToolStripMenuItem_Click);
            // 
            // cSScss文件ToolStripMenuItem
            // 
            this.cSScss文件ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.css;
            this.cSScss文件ToolStripMenuItem.Name = "cSScss文件ToolStripMenuItem";
            this.cSScss文件ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cSScss文件ToolStripMenuItem.Text = "CSS(*.css)文件";
            this.cSScss文件ToolStripMenuItem.Click += new System.EventHandler(this.cSScss文件ToolStripMenuItem_Click);
            // 
            // jSjs文件ToolStripMenuItem
            // 
            this.jSjs文件ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.符号_JSX;
            this.jSjs文件ToolStripMenuItem.Name = "jSjs文件ToolStripMenuItem";
            this.jSjs文件ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.jSjs文件ToolStripMenuItem.Text = "JS(*.js)文件";
            this.jSjs文件ToolStripMenuItem.Click += new System.EventHandler(this.jSjs文件ToolStripMenuItem_Click);
            // 
            // 其它文件ToolStripMenuItem
            // 
            this.其它文件ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.page;
            this.其它文件ToolStripMenuItem.Name = "其它文件ToolStripMenuItem";
            this.其它文件ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.其它文件ToolStripMenuItem.Text = "(*.*)其它文件";
            this.其它文件ToolStripMenuItem.Click += new System.EventHandler(this.其它文件ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.del;
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
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
            this.Controls.Add(this.tvCodes);
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

        private System.Windows.Forms.TreeView tvCodes;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCS文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlhtml文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSScss文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSjs文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其它文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}