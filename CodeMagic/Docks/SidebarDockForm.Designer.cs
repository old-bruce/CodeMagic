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
            this.批量生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvTables = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询分析器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代码批量生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(379, 27);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(120, 24);
            this.toolStripDropDownButton1.Text = "数据库连接";
            // 
            // 新建数据库连接ToolStripMenuItem
            // 
            this.新建数据库连接ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.add_database1;
            this.新建数据库连接ToolStripMenuItem.Name = "新建数据库连接ToolStripMenuItem";
            this.新建数据库连接ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.新建数据库连接ToolStripMenuItem.Text = "新建数据库连接";
            this.新建数据库连接ToolStripMenuItem.Click += new System.EventHandler(this.新建数据库连接ToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.代码生成设置ToolStripMenuItem,
            this.批量生成ToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::CodeMagic.Properties.Resources.code__1_;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            // 
            // 代码生成设置ToolStripMenuItem
            // 
            this.代码生成设置ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.setting;
            this.代码生成设置ToolStripMenuItem.Name = "代码生成设置ToolStripMenuItem";
            this.代码生成设置ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.代码生成设置ToolStripMenuItem.Text = "代码生成设置";
            this.代码生成设置ToolStripMenuItem.Click += new System.EventHandler(this.代码生成设置ToolStripMenuItem_Click);
            // 
            // 批量生成ToolStripMenuItem
            // 
            this.批量生成ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.magic_hat_64px_1217410_easyicon_net;
            this.批量生成ToolStripMenuItem.Name = "批量生成ToolStripMenuItem";
            this.批量生成ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.批量生成ToolStripMenuItem.Text = "代码批量生成";
            this.批量生成ToolStripMenuItem.Click += new System.EventHandler(this.批量生成ToolStripMenuItem_Click);
            // 
            // tvTables
            // 
            this.tvTables.ContextMenuStrip = this.contextMenuStrip1;
            this.tvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTables.ImageIndex = 0;
            this.tvTables.ImageList = this.imageList1;
            this.tvTables.Indent = 21;
            this.tvTables.ItemHeight = 19;
            this.tvTables.Location = new System.Drawing.Point(0, 27);
            this.tvTables.Margin = new System.Windows.Forms.Padding(4);
            this.tvTables.Name = "tvTables";
            this.tvTables.SelectedImageIndex = 0;
            this.tvTables.Size = new System.Drawing.Size(379, 294);
            this.tvTables.TabIndex = 1;
            this.tvTables.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTables_NodeMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新FToolStripMenuItem,
            this.查询分析器ToolStripMenuItem,
            this.代码批量生成ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 82);
            // 
            // 刷新FToolStripMenuItem
            // 
            this.刷新FToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.Refresh;
            this.刷新FToolStripMenuItem.Name = "刷新FToolStripMenuItem";
            this.刷新FToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.刷新FToolStripMenuItem.Text = "刷新(&R)";
            this.刷新FToolStripMenuItem.Click += new System.EventHandler(this.刷新FToolStripMenuItem_Click);
            // 
            // 查询分析器ToolStripMenuItem
            // 
            this.查询分析器ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.query;
            this.查询分析器ToolStripMenuItem.Name = "查询分析器ToolStripMenuItem";
            this.查询分析器ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.查询分析器ToolStripMenuItem.Text = "查询分析器(&Q)";
            this.查询分析器ToolStripMenuItem.Click += new System.EventHandler(this.查询分析器ToolStripMenuItem_Click);
            // 
            // 代码批量生成ToolStripMenuItem
            // 
            this.代码批量生成ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.build;
            this.代码批量生成ToolStripMenuItem.Name = "代码批量生成ToolStripMenuItem";
            this.代码批量生成ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.代码批量生成ToolStripMenuItem.Text = "代码批量生成(&B)";
            this.代码批量生成ToolStripMenuItem.Click += new System.EventHandler(this.代码批量生成ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "101-database.png");
            this.imageList1.Images.SetKeyName(1, "文件夹.png");
            this.imageList1.Images.SetKeyName(2, "table.png");
            // 
            // SidebarDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.tvTables);
            this.Controls.Add(this.toolStrip1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem 查询分析器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代码批量生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量生成ToolStripMenuItem;
    }
}