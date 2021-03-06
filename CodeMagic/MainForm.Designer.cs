﻿namespace CodeMagic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代码段ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览器BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.codeCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.视图VToolStripMenuItem,
            this.codeCToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 视图VToolStripMenuItem
            // 
            this.视图VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库ToolStripMenuItem,
            this.模板ToolStripMenuItem,
            this.代码段ToolStripMenuItem});
            this.视图VToolStripMenuItem.Name = "视图VToolStripMenuItem";
            this.视图VToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.视图VToolStripMenuItem.Text = "视图(&V)";
            // 
            // 数据库ToolStripMenuItem
            // 
            this.数据库ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.database2;
            this.数据库ToolStripMenuItem.Name = "数据库ToolStripMenuItem";
            this.数据库ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.数据库ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.数据库ToolStripMenuItem.Text = "数据库(&D)";
            this.数据库ToolStripMenuItem.Click += new System.EventHandler(this.数据库ToolStripMenuItem_Click);
            // 
            // 模板ToolStripMenuItem
            // 
            this.模板ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.notepad;
            this.模板ToolStripMenuItem.Name = "模板ToolStripMenuItem";
            this.模板ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.V)));
            this.模板ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.模板ToolStripMenuItem.Text = "模板(&T)";
            this.模板ToolStripMenuItem.Click += new System.EventHandler(this.模板ToolStripMenuItem_Click);
            // 
            // 代码段ToolStripMenuItem
            // 
            this.代码段ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.code;
            this.代码段ToolStripMenuItem.Name = "代码段ToolStripMenuItem";
            this.代码段ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.I)));
            this.代码段ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.代码段ToolStripMenuItem.Text = "代码段(&C)";
            this.代码段ToolStripMenuItem.Click += new System.EventHandler(this.代码段ToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浏览器BToolStripMenuItem,
            this.iEToolStripMenuItem,
            this.chromeToolStripMenuItem,
            this.计算器ToolStripMenuItem,
            this.记事本ToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 浏览器BToolStripMenuItem
            // 
            this.浏览器BToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.web;
            this.浏览器BToolStripMenuItem.Name = "浏览器BToolStripMenuItem";
            this.浏览器BToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.浏览器BToolStripMenuItem.Text = "浏览器(&B)";
            this.浏览器BToolStripMenuItem.Click += new System.EventHandler(this.浏览器BToolStripMenuItem_Click);
            // 
            // iEToolStripMenuItem
            // 
            this.iEToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.ie;
            this.iEToolStripMenuItem.Name = "iEToolStripMenuItem";
            this.iEToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.iEToolStripMenuItem.Text = "IE";
            this.iEToolStripMenuItem.Click += new System.EventHandler(this.iEToolStripMenuItem_Click);
            // 
            // chromeToolStripMenuItem
            // 
            this.chromeToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.brand_brands_chrome_logo_16px_1212918_easyicon1;
            this.chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
            this.chromeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.chromeToolStripMenuItem.Text = "Chrome";
            this.chromeToolStripMenuItem.Click += new System.EventHandler(this.chromeToolStripMenuItem_Click);
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.计算器;
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.计算器ToolStripMenuItem.Text = "计算器";
            this.计算器ToolStripMenuItem.Click += new System.EventHandler(this.计算器ToolStripMenuItem_Click);
            // 
            // 记事本ToolStripMenuItem
            // 
            this.记事本ToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.notepad;
            this.记事本ToolStripMenuItem.Name = "记事本ToolStripMenuItem";
            this.记事本ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.记事本ToolStripMenuItem.Text = "记事本";
            this.记事本ToolStripMenuItem.Click += new System.EventHandler(this.记事本ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.关于AToolStripMenuItem.Text = "关于 Code Magic(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // dockPanel1
            // 
            this.dockPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.DockBackColor = System.Drawing.SystemColors.ControlDark;
            this.dockPanel1.DockLeftPortion = 0.2D;
            this.dockPanel1.DockRightPortion = 0.2D;
            this.dockPanel1.Location = new System.Drawing.Point(0, 24);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.ShowDocumentIcon = true;
            this.dockPanel1.Size = new System.Drawing.Size(784, 537);
            this.dockPanel1.TabIndex = 3;
            // 
            // codeCToolStripMenuItem
            // 
            this.codeCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vueToolStripMenuItem});
            this.codeCToolStripMenuItem.Name = "codeCToolStripMenuItem";
            this.codeCToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.codeCToolStripMenuItem.Text = "Code(&C)";
            // 
            // vueToolStripMenuItem
            // 
            this.vueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem});
            this.vueToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.Vue16;
            this.vueToolStripMenuItem.Name = "vueToolStripMenuItem";
            this.vueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vueToolStripMenuItem.Text = "Vue";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Magic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        public WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览器BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记事本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代码段ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
    }
}

