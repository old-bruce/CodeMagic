namespace CodeMagic.Docks
{
    partial class SidebarDockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SidebarDockForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.新建数据库连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.代码生成设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvTables = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQL查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建数据库连接ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::CodeMagic.Properties.Resources.database2;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(101, 22);
            this.toolStripDropDownButton1.Text = "数据库连接";
            // 
            // 新建数据库连接ToolStripMenuItem
            // 
            this.新建数据库连接ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.add_database1;
            this.新建数据库连接ToolStripMenuItem.Name = "新建数据库连接ToolStripMenuItem";
            this.新建数据库连接ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.新建数据库连接ToolStripMenuItem.Text = "新建数据库连接";
            this.新建数据库连接ToolStripMenuItem.Click += new System.EventHandler(this.新建数据库连接ToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.代码生成设置ToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::CodeMagic.Properties.Resources.code__1_;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            // 
            // 代码生成设置ToolStripMenuItem
            // 
            this.代码生成设置ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.setting;
            this.代码生成设置ToolStripMenuItem.Name = "代码生成设置ToolStripMenuItem";
            this.代码生成设置ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.代码生成设置ToolStripMenuItem.Text = " 代码生成设置";
            this.代码生成设置ToolStripMenuItem.Click += new System.EventHandler(this.代码生成设置ToolStripMenuItem_Click);
            // 
            // tvTables
            // 
            this.tvTables.ContextMenuStrip = this.contextMenuStrip1;
            this.tvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTables.ImageIndex = 0;
            this.tvTables.ImageList = this.imageList1;
            this.tvTables.Indent = 21;
            this.tvTables.ItemHeight = 19;
            this.tvTables.Location = new System.Drawing.Point(0, 25);
            this.tvTables.Name = "tvTables";
            this.tvTables.SelectedImageIndex = 0;
            this.tvTables.Size = new System.Drawing.Size(284, 236);
            this.tvTables.TabIndex = 1;
            this.tvTables.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTables_NodeMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新FToolStripMenuItem,
            this.sQL查询ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            // 
            // 刷新FToolStripMenuItem
            // 
            this.刷新FToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.Refresh;
            this.刷新FToolStripMenuItem.Name = "刷新FToolStripMenuItem";
            this.刷新FToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.刷新FToolStripMenuItem.Text = "刷新(&R)";
            this.刷新FToolStripMenuItem.Click += new System.EventHandler(this.刷新FToolStripMenuItem_Click);
            // 
            // sQL查询ToolStripMenuItem
            // 
            this.sQL查询ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.query;
            this.sQL查询ToolStripMenuItem.Name = "sQL查询ToolStripMenuItem";
            this.sQL查询ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sQL查询ToolStripMenuItem.Text = "SQL查询";
            this.sQL查询ToolStripMenuItem.Click += new System.EventHandler(this.sQL查询ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "101-database.png");
            this.imageList1.Images.SetKeyName(1, "table.png");
            // 
            // SidebarDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.tvTables);
            this.Controls.Add(this.toolStrip1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SidebarDockForm";
            this.Text = "数据库";
            this.Load += new System.EventHandler(this.SidebarDockForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.TreeView tvTables;
        private System.Windows.Forms.ToolStripMenuItem 新建数据库连接ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新FToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 代码生成设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQL查询ToolStripMenuItem;
    }
}