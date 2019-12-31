namespace CodeMagic.MySQL
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.模板TToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.模型类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appDBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.新建服务器ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.管理服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxServerList = new System.Windows.Forms.ToolStripComboBox();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.cbxServerList,
            this.btnOpen,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1093, 45);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模板TToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 28);
            // 
            // 模板TToolStripMenuItem1
            // 
            this.模板TToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模型类ToolStripMenuItem,
            this.查询类ToolStripMenuItem,
            this.appDBToolStripMenuItem1});
            this.模板TToolStripMenuItem1.Name = "模板TToolStripMenuItem1";
            this.模板TToolStripMenuItem1.Size = new System.Drawing.Size(126, 24);
            this.模板TToolStripMenuItem1.Text = "模板(&T)";
            // 
            // 模型类ToolStripMenuItem
            // 
            this.模型类ToolStripMenuItem.Image = global::CodeMagic.MySQL.Properties.Resources.code_tags_16px_15782_easyicon_net;
            this.模型类ToolStripMenuItem.Name = "模型类ToolStripMenuItem";
            this.模型类ToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.模型类ToolStripMenuItem.Text = "模型类";
            this.模型类ToolStripMenuItem.Click += new System.EventHandler(this.模型类ToolStripMenuItem_Click);
            // 
            // 查询类ToolStripMenuItem
            // 
            this.查询类ToolStripMenuItem.Image = global::CodeMagic.MySQL.Properties.Resources.code_tags_16px_15782_easyicon_net;
            this.查询类ToolStripMenuItem.Name = "查询类ToolStripMenuItem";
            this.查询类ToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.查询类ToolStripMenuItem.Text = "查询类";
            this.查询类ToolStripMenuItem.Click += new System.EventHandler(this.查询类ToolStripMenuItem_Click);
            // 
            // appDBToolStripMenuItem1
            // 
            this.appDBToolStripMenuItem1.Image = global::CodeMagic.MySQL.Properties.Resources.code_tags_16px_15782_easyicon_net;
            this.appDBToolStripMenuItem1.Name = "appDBToolStripMenuItem1";
            this.appDBToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.appDBToolStripMenuItem1.Text = "AppDb";
            this.appDBToolStripMenuItem1.Click += new System.EventHandler(this.appDBToolStripMenuItem1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建服务器ToolStripMenuItem1,
            this.管理服务器ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.刷新ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(69, 32);
            this.toolStripDropDownButton1.Text = "服务器";
            // 
            // 新建服务器ToolStripMenuItem1
            // 
            this.新建服务器ToolStripMenuItem1.Image = global::CodeMagic.MySQL.Properties.Resources.add__1_;
            this.新建服务器ToolStripMenuItem1.Name = "新建服务器ToolStripMenuItem1";
            this.新建服务器ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.新建服务器ToolStripMenuItem1.Size = new System.Drawing.Size(280, 26);
            this.新建服务器ToolStripMenuItem1.Text = "新建服务器连接";
            this.新建服务器ToolStripMenuItem1.Click += new System.EventHandler(this.新建服务器ToolStripMenuItem1_Click);
            // 
            // 管理服务器ToolStripMenuItem
            // 
            this.管理服务器ToolStripMenuItem.Name = "管理服务器ToolStripMenuItem";
            this.管理服务器ToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.管理服务器ToolStripMenuItem.Text = "管理服务器连接";
            this.管理服务器ToolStripMenuItem.Click += new System.EventHandler(this.管理服务器ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(277, 6);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // cbxServerList
            // 
            this.cbxServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServerList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxServerList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cbxServerList.Name = "cbxServerList";
            this.cbxServerList.Size = new System.Drawing.Size(400, 35);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOpen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpen.Image = global::CodeMagic.MySQL.Properties.Resources.ok_24px_1211043_easyicon_net;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(63, 32);
            this.btnOpen.Text = "打开";
            this.btnOpen.ToolTipText = "连接到服务器";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(188, 32);
            this.toolStripLabel1.Text = "CodeMagic 让生活更美好";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1093, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblstatus
            // 
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(40, 20);
            this.lblstatus.Text = "就绪";
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel1.Location = new System.Drawing.Point(0, 45);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(1093, 626);
            this.dockPanel1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 697);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeMagic.MySQL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbxServerList;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 新建服务器ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 管理服务器ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 模板TToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 模型类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appDBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        internal WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
    }
}

