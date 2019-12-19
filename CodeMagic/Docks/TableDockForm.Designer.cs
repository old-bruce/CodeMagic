namespace CodeMagic.Docks
{
    partial class TableDockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableDockForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvColumn = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uI代码生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminLTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详情页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vUEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultvueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpModel = new System.Windows.Forms.TabPage();
            this.tecModel = new ICSharpCode.TextEditor.TextEditorControlEx();
            this.tpDAL = new System.Windows.Forms.TabPage();
            this.tecDAL = new ICSharpCode.TextEditor.TextEditorControlEx();
            this.tpBLL = new System.Windows.Forms.TabPage();
            this.tecBLL = new ICSharpCode.TextEditor.TextEditorControlEx();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tecController = new ICSharpCode.TextEditor.TextEditorControlEx();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumn)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpModel.SuspendLayout();
            this.tpDAL.SuspendLayout();
            this.tpBLL.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvColumn);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.splitContainer1.Size = new System.Drawing.Size(779, 690);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvColumn
            // 
            this.dgvColumn.AllowUserToAddRows = false;
            this.dgvColumn.AllowUserToDeleteRows = false;
            this.dgvColumn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumn.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumn.Location = new System.Drawing.Point(7, 6);
            this.dgvColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvColumn.Name = "dgvColumn";
            this.dgvColumn.ReadOnly = true;
            this.dgvColumn.Size = new System.Drawing.Size(765, 209);
            this.dgvColumn.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新RToolStripMenuItem,
            this.uI代码生成ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 56);
            // 
            // 刷新RToolStripMenuItem
            // 
            this.刷新RToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.Refresh;
            this.刷新RToolStripMenuItem.Name = "刷新RToolStripMenuItem";
            this.刷新RToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.刷新RToolStripMenuItem.Text = "刷新(&R)";
            this.刷新RToolStripMenuItem.Click += new System.EventHandler(this.刷新RToolStripMenuItem_Click);
            // 
            // uI代码生成ToolStripMenuItem
            // 
            this.uI代码生成ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminLTEToolStripMenuItem,
            this.vUEToolStripMenuItem});
            this.uI代码生成ToolStripMenuItem.Name = "uI代码生成ToolStripMenuItem";
            this.uI代码生成ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.uI代码生成ToolStripMenuItem.Text = "UI代码生成";
            // 
            // adminLTEToolStripMenuItem
            // 
            this.adminLTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.列表页ToolStripMenuItem,
            this.新增页ToolStripMenuItem,
            this.编辑页ToolStripMenuItem,
            this.详情页ToolStripMenuItem});
            this.adminLTEToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.A;
            this.adminLTEToolStripMenuItem.Name = "adminLTEToolStripMenuItem";
            this.adminLTEToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.adminLTEToolStripMenuItem.Text = "AdminLTE";
            // 
            // 列表页ToolStripMenuItem
            // 
            this.列表页ToolStripMenuItem.Name = "列表页ToolStripMenuItem";
            this.列表页ToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.列表页ToolStripMenuItem.Text = "列表页";
            this.列表页ToolStripMenuItem.Click += new System.EventHandler(this.列表页ToolStripMenuItem_Click);
            // 
            // 新增页ToolStripMenuItem
            // 
            this.新增页ToolStripMenuItem.Name = "新增页ToolStripMenuItem";
            this.新增页ToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.新增页ToolStripMenuItem.Text = "新增页";
            this.新增页ToolStripMenuItem.Click += new System.EventHandler(this.新增页ToolStripMenuItem_Click);
            // 
            // 编辑页ToolStripMenuItem
            // 
            this.编辑页ToolStripMenuItem.Name = "编辑页ToolStripMenuItem";
            this.编辑页ToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.编辑页ToolStripMenuItem.Text = "编辑页";
            this.编辑页ToolStripMenuItem.Click += new System.EventHandler(this.编辑页ToolStripMenuItem_Click);
            // 
            // 详情页ToolStripMenuItem
            // 
            this.详情页ToolStripMenuItem.Name = "详情页ToolStripMenuItem";
            this.详情页ToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.详情页ToolStripMenuItem.Text = "详情页";
            this.详情页ToolStripMenuItem.Click += new System.EventHandler(this.详情页ToolStripMenuItem_Click);
            // 
            // vUEToolStripMenuItem
            // 
            this.vUEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultvueToolStripMenuItem});
            this.vUEToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.Vue16;
            this.vUEToolStripMenuItem.Name = "vUEToolStripMenuItem";
            this.vUEToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.vUEToolStripMenuItem.Text = "VUE";
            // 
            // defaultvueToolStripMenuItem
            // 
            this.defaultvueToolStripMenuItem.Name = "defaultvueToolStripMenuItem";
            this.defaultvueToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.defaultvueToolStripMenuItem.Text = "Default.vue";
            this.defaultvueToolStripMenuItem.Click += new System.EventHandler(this.defaultvueToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpModel);
            this.tabControl1.Controls.Add(this.tpDAL);
            this.tabControl1.Controls.Add(this.tpBLL);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(7, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tpModel
            // 
            this.tpModel.Controls.Add(this.tecModel);
            this.tpModel.Location = new System.Drawing.Point(4, 25);
            this.tpModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpModel.Name = "tpModel";
            this.tpModel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpModel.Size = new System.Drawing.Size(757, 423);
            this.tpModel.TabIndex = 3;
            this.tpModel.Text = "Model";
            this.tpModel.UseVisualStyleBackColor = true;
            // 
            // tecModel
            // 
            this.tecModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecModel.FoldingStrategy = "CSharp";
            this.tecModel.Font = new System.Drawing.Font("Courier New", 10F);
            this.tecModel.Location = new System.Drawing.Point(4, 4);
            this.tecModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tecModel.Name = "tecModel";
            this.tecModel.Size = new System.Drawing.Size(749, 415);
            this.tecModel.TabIndex = 1;
            // 
            // tpDAL
            // 
            this.tpDAL.Controls.Add(this.tecDAL);
            this.tpDAL.Location = new System.Drawing.Point(4, 25);
            this.tpDAL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpDAL.Name = "tpDAL";
            this.tpDAL.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpDAL.Size = new System.Drawing.Size(757, 423);
            this.tpDAL.TabIndex = 0;
            this.tpDAL.Text = "DAL";
            this.tpDAL.UseVisualStyleBackColor = true;
            // 
            // tecDAL
            // 
            this.tecDAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecDAL.FoldingStrategy = "CSharp";
            this.tecDAL.Font = new System.Drawing.Font("Courier New", 10F);
            this.tecDAL.Location = new System.Drawing.Point(4, 4);
            this.tecDAL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tecDAL.Name = "tecDAL";
            this.tecDAL.Size = new System.Drawing.Size(749, 415);
            this.tecDAL.TabIndex = 1;
            // 
            // tpBLL
            // 
            this.tpBLL.Controls.Add(this.tecBLL);
            this.tpBLL.Location = new System.Drawing.Point(4, 25);
            this.tpBLL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpBLL.Name = "tpBLL";
            this.tpBLL.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpBLL.Size = new System.Drawing.Size(757, 423);
            this.tpBLL.TabIndex = 1;
            this.tpBLL.Text = "BLL";
            this.tpBLL.UseVisualStyleBackColor = true;
            // 
            // tecBLL
            // 
            this.tecBLL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecBLL.FoldingStrategy = "CSharp";
            this.tecBLL.Font = new System.Drawing.Font("Courier New", 10F);
            this.tecBLL.Location = new System.Drawing.Point(4, 4);
            this.tecBLL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tecBLL.Name = "tecBLL";
            this.tecBLL.Size = new System.Drawing.Size(749, 415);
            this.tecBLL.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tecController);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 423);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Controller";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tecController
            // 
            this.tecController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecController.FoldingStrategy = "CSharp";
            this.tecController.Font = new System.Drawing.Font("Courier New", 10F);
            this.tecController.Location = new System.Drawing.Point(3, 3);
            this.tecController.Margin = new System.Windows.Forms.Padding(4);
            this.tecController.Name = "tecController";
            this.tecController.Size = new System.Drawing.Size(751, 417);
            this.tecController.TabIndex = 2;
            // 
            // TableDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 690);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TableDockForm";
            this.Text = "TableDockForm";
            this.Load += new System.EventHandler(this.TableDockForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumn)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpModel.ResumeLayout(false);
            this.tpDAL.ResumeLayout(false);
            this.tpBLL.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新RToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDAL;
        private System.Windows.Forms.TabPage tpBLL;
        private System.Windows.Forms.TabPage tpModel;
        private ICSharpCode.TextEditor.TextEditorControlEx tecModel;
        private ICSharpCode.TextEditor.TextEditorControlEx tecDAL;
        private ICSharpCode.TextEditor.TextEditorControlEx tecBLL;
        private System.Windows.Forms.ToolStripMenuItem uI代码生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminLTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vUEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultvueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详情页ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private ICSharpCode.TextEditor.TextEditorControlEx tecController;
    }
}