namespace CodeMagic.MySQL
{
    partial class ColumnDockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnDockForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvColumn = new System.Windows.Forms.DataGridView();
            this.COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_NULLABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_KEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_COMMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.tecTable = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpTableQuery = new System.Windows.Forms.TabPage();
            this.tecTableQuery = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpController = new System.Windows.Forms.TabPage();
            this.tecController = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpAppDb = new System.Windows.Forms.TabPage();
            this.tecAppDb = new ICSharpCode.TextEditor.TextEditorControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumn)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.tpTableQuery.SuspendLayout();
            this.tpController.SuspendLayout();
            this.tpAppDb.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvColumn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(804, 631);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvColumn
            // 
            this.dgvColumn.AllowUserToAddRows = false;
            this.dgvColumn.AllowUserToDeleteRows = false;
            this.dgvColumn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColumn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLUMN_NAME,
            this.IS_NULLABLE,
            this.DATA_TYPE,
            this.COLUMN_TYPE,
            this.COLUMN_KEY,
            this.EXTRA,
            this.COLUMN_COMMENT});
            this.dgvColumn.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumn.Location = new System.Drawing.Point(0, 0);
            this.dgvColumn.Name = "dgvColumn";
            this.dgvColumn.ReadOnly = true;
            this.dgvColumn.RowHeadersWidth = 51;
            this.dgvColumn.RowTemplate.Height = 24;
            this.dgvColumn.Size = new System.Drawing.Size(804, 200);
            this.dgvColumn.TabIndex = 0;
            // 
            // COLUMN_NAME
            // 
            this.COLUMN_NAME.DataPropertyName = "COLUMN_NAME";
            this.COLUMN_NAME.HeaderText = "COLUMN_NAME";
            this.COLUMN_NAME.MinimumWidth = 6;
            this.COLUMN_NAME.Name = "COLUMN_NAME";
            this.COLUMN_NAME.ReadOnly = true;
            // 
            // IS_NULLABLE
            // 
            this.IS_NULLABLE.DataPropertyName = "IS_NULLABLE";
            this.IS_NULLABLE.HeaderText = "IS_NULLABLE";
            this.IS_NULLABLE.MinimumWidth = 6;
            this.IS_NULLABLE.Name = "IS_NULLABLE";
            this.IS_NULLABLE.ReadOnly = true;
            // 
            // DATA_TYPE
            // 
            this.DATA_TYPE.DataPropertyName = "DATA_TYPE";
            this.DATA_TYPE.HeaderText = "DATA_TYPE";
            this.DATA_TYPE.MinimumWidth = 6;
            this.DATA_TYPE.Name = "DATA_TYPE";
            this.DATA_TYPE.ReadOnly = true;
            // 
            // COLUMN_TYPE
            // 
            this.COLUMN_TYPE.DataPropertyName = "COLUMN_TYPE";
            this.COLUMN_TYPE.HeaderText = "COLUMN_TYPE";
            this.COLUMN_TYPE.MinimumWidth = 6;
            this.COLUMN_TYPE.Name = "COLUMN_TYPE";
            this.COLUMN_TYPE.ReadOnly = true;
            // 
            // COLUMN_KEY
            // 
            this.COLUMN_KEY.DataPropertyName = "COLUMN_KEY";
            this.COLUMN_KEY.HeaderText = "COLUMN_KEY";
            this.COLUMN_KEY.MinimumWidth = 6;
            this.COLUMN_KEY.Name = "COLUMN_KEY";
            this.COLUMN_KEY.ReadOnly = true;
            // 
            // EXTRA
            // 
            this.EXTRA.DataPropertyName = "EXTRA";
            this.EXTRA.HeaderText = "EXTRA";
            this.EXTRA.MinimumWidth = 6;
            this.EXTRA.Name = "EXTRA";
            this.EXTRA.ReadOnly = true;
            // 
            // COLUMN_COMMENT
            // 
            this.COLUMN_COMMENT.DataPropertyName = "COLUMN_COMMENT";
            this.COLUMN_COMMENT.HeaderText = "COLUMN_COMMENT";
            this.COLUMN_COMMENT.MinimumWidth = 6;
            this.COLUMN_COMMENT.Name = "COLUMN_COMMENT";
            this.COLUMN_COMMENT.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Controls.Add(this.tpTable);
            this.tabControl1.Controls.Add(this.tpTableQuery);
            this.tabControl1.Controls.Add(this.tpController);
            this.tabControl1.Controls.Add(this.tpAppDb);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(48, 26);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.tecTable);
            this.tpTable.ImageIndex = 0;
            this.tpTable.Location = new System.Drawing.Point(4, 30);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(796, 393);
            this.tpTable.TabIndex = 0;
            this.tpTable.Text = "Table";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // tecTable
            // 
            this.tecTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecTable.IsReadOnly = false;
            this.tecTable.Location = new System.Drawing.Point(3, 3);
            this.tecTable.Name = "tecTable";
            this.tecTable.Size = new System.Drawing.Size(790, 387);
            this.tecTable.TabIndex = 0;
            this.tecTable.VRulerRow = 120;
            // 
            // tpTableQuery
            // 
            this.tpTableQuery.Controls.Add(this.tecTableQuery);
            this.tpTableQuery.ImageIndex = 0;
            this.tpTableQuery.Location = new System.Drawing.Point(4, 30);
            this.tpTableQuery.Name = "tpTableQuery";
            this.tpTableQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tpTableQuery.Size = new System.Drawing.Size(796, 393);
            this.tpTableQuery.TabIndex = 1;
            this.tpTableQuery.Text = "TableQuery";
            this.tpTableQuery.UseVisualStyleBackColor = true;
            // 
            // tecTableQuery
            // 
            this.tecTableQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecTableQuery.IsReadOnly = false;
            this.tecTableQuery.Location = new System.Drawing.Point(3, 3);
            this.tecTableQuery.Name = "tecTableQuery";
            this.tecTableQuery.Size = new System.Drawing.Size(790, 387);
            this.tecTableQuery.TabIndex = 1;
            // 
            // tpController
            // 
            this.tpController.Controls.Add(this.tecController);
            this.tpController.ImageIndex = 0;
            this.tpController.Location = new System.Drawing.Point(4, 30);
            this.tpController.Name = "tpController";
            this.tpController.Padding = new System.Windows.Forms.Padding(3);
            this.tpController.Size = new System.Drawing.Size(796, 393);
            this.tpController.TabIndex = 3;
            this.tpController.Text = "Controller";
            this.tpController.UseVisualStyleBackColor = true;
            // 
            // tecController
            // 
            this.tecController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecController.IsReadOnly = false;
            this.tecController.Location = new System.Drawing.Point(3, 3);
            this.tecController.Name = "tecController";
            this.tecController.Size = new System.Drawing.Size(790, 387);
            this.tecController.TabIndex = 3;
            // 
            // tpAppDb
            // 
            this.tpAppDb.Controls.Add(this.tecAppDb);
            this.tpAppDb.ImageIndex = 0;
            this.tpAppDb.Location = new System.Drawing.Point(4, 30);
            this.tpAppDb.Name = "tpAppDb";
            this.tpAppDb.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppDb.Size = new System.Drawing.Size(796, 393);
            this.tpAppDb.TabIndex = 2;
            this.tpAppDb.Text = "AppDb";
            this.tpAppDb.UseVisualStyleBackColor = true;
            // 
            // tecAppDb
            // 
            this.tecAppDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecAppDb.IsReadOnly = false;
            this.tecAppDb.Location = new System.Drawing.Point(3, 3);
            this.tecAppDb.Name = "tecAppDb";
            this.tecAppDb.Size = new System.Drawing.Size(790, 387);
            this.tecAppDb.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "code.png");
            // 
            // ColumnDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 631);
            this.Controls.Add(this.splitContainer1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColumnDockForm";
            this.TabText = "ColumnDockForm";
            this.Text = "ColumnDockForm";
            this.Load += new System.EventHandler(this.ColumnDockForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumn)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.tpTableQuery.ResumeLayout(false);
            this.tpController.ResumeLayout(false);
            this.tpAppDb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_NULLABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_KEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_COMMENT;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tpTableQuery;
        private ICSharpCode.TextEditor.TextEditorControl tecTable;
        private ICSharpCode.TextEditor.TextEditorControl tecTableQuery;
        private System.Windows.Forms.TabPage tpAppDb;
        private ICSharpCode.TextEditor.TextEditorControl tecAppDb;
        private System.Windows.Forms.TabPage tpController;
        private ICSharpCode.TextEditor.TextEditorControl tecController;
        private System.Windows.Forms.ImageList imageList1;
    }
}