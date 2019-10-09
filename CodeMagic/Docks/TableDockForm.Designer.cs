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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpModel = new System.Windows.Forms.TabPage();
            this.tecModel = new ICSharpCode.TextEditor.TextEditorControlEx();
            this.tpDAL = new System.Windows.Forms.TabPage();
            this.tecDAL = new ICSharpCode.TextEditor.TextEditorControlEx();
            this.tpBLL = new System.Windows.Forms.TabPage();
            this.tecBLL = new ICSharpCode.TextEditor.TextEditorControlEx();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAdminLTEList = new System.Windows.Forms.Button();
            this.btnAdminLTEAdd = new System.Windows.Forms.Button();
            this.btnAdminLTEModify = new System.Windows.Forms.Button();
            this.btnAdminLTEInfo = new System.Windows.Forms.Button();
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
            this.tabPage4.SuspendLayout();
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
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(584, 561);
            this.splitContainer1.SplitterDistance = 180;
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
            this.dgvColumn.Location = new System.Drawing.Point(5, 5);
            this.dgvColumn.Name = "dgvColumn";
            this.dgvColumn.ReadOnly = true;
            this.dgvColumn.Size = new System.Drawing.Size(574, 170);
            this.dgvColumn.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新RToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // 刷新RToolStripMenuItem
            // 
            this.刷新RToolStripMenuItem.Image = global::CodeMagic.Properties.Resources.Refresh;
            this.刷新RToolStripMenuItem.Name = "刷新RToolStripMenuItem";
            this.刷新RToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.刷新RToolStripMenuItem.Text = "刷新(&R)";
            this.刷新RToolStripMenuItem.Click += new System.EventHandler(this.刷新RToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpModel);
            this.tabControl1.Controls.Add(this.tpDAL);
            this.tabControl1.Controls.Add(this.tpBLL);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tpModel
            // 
            this.tpModel.Controls.Add(this.tecModel);
            this.tpModel.Location = new System.Drawing.Point(4, 22);
            this.tpModel.Name = "tpModel";
            this.tpModel.Padding = new System.Windows.Forms.Padding(3);
            this.tpModel.Size = new System.Drawing.Size(566, 341);
            this.tpModel.TabIndex = 3;
            this.tpModel.Text = "Model";
            this.tpModel.UseVisualStyleBackColor = true;
            // 
            // tecModel
            // 
            this.tecModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecModel.Font = new System.Drawing.Font("Courier New", 10F);
            this.tecModel.Location = new System.Drawing.Point(3, 3);
            this.tecModel.Name = "tecModel";
            this.tecModel.Size = new System.Drawing.Size(560, 335);
            this.tecModel.TabIndex = 1;
            // 
            // tpDAL
            // 
            this.tpDAL.Controls.Add(this.tecDAL);
            this.tpDAL.Location = new System.Drawing.Point(4, 22);
            this.tpDAL.Name = "tpDAL";
            this.tpDAL.Padding = new System.Windows.Forms.Padding(3);
            this.tpDAL.Size = new System.Drawing.Size(566, 341);
            this.tpDAL.TabIndex = 0;
            this.tpDAL.Text = "DAL";
            this.tpDAL.UseVisualStyleBackColor = true;
            // 
            // tecDAL
            // 
            this.tecDAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecDAL.Font = new System.Drawing.Font("Courier New", 10F);
            this.tecDAL.Location = new System.Drawing.Point(3, 3);
            this.tecDAL.Name = "tecDAL";
            this.tecDAL.Size = new System.Drawing.Size(560, 335);
            this.tecDAL.TabIndex = 1;
            // 
            // tpBLL
            // 
            this.tpBLL.Controls.Add(this.tecBLL);
            this.tpBLL.Location = new System.Drawing.Point(4, 22);
            this.tpBLL.Name = "tpBLL";
            this.tpBLL.Padding = new System.Windows.Forms.Padding(3);
            this.tpBLL.Size = new System.Drawing.Size(566, 341);
            this.tpBLL.TabIndex = 1;
            this.tpBLL.Text = "BLL";
            this.tpBLL.UseVisualStyleBackColor = true;
            // 
            // tecBLL
            // 
            this.tecBLL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecBLL.Font = new System.Drawing.Font("Courier New", 10F);
            this.tecBLL.Location = new System.Drawing.Point(3, 3);
            this.tecBLL.Name = "tecBLL";
            this.tecBLL.Size = new System.Drawing.Size(560, 335);
            this.tecBLL.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAdminLTEInfo);
            this.tabPage4.Controls.Add(this.btnAdminLTEModify);
            this.tabPage4.Controls.Add(this.btnAdminLTEAdd);
            this.tabPage4.Controls.Add(this.btnAdminLTEList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(566, 341);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "UI";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAdminLTEList
            // 
            this.btnAdminLTEList.Location = new System.Drawing.Point(20, 20);
            this.btnAdminLTEList.Name = "btnAdminLTEList";
            this.btnAdminLTEList.Size = new System.Drawing.Size(120, 23);
            this.btnAdminLTEList.TabIndex = 0;
            this.btnAdminLTEList.Text = "AdminLTE List";
            this.btnAdminLTEList.UseVisualStyleBackColor = true;
            this.btnAdminLTEList.Click += new System.EventHandler(this.btnAdminLTEList_Click);
            // 
            // btnAdminLTEAdd
            // 
            this.btnAdminLTEAdd.Location = new System.Drawing.Point(20, 49);
            this.btnAdminLTEAdd.Name = "btnAdminLTEAdd";
            this.btnAdminLTEAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdminLTEAdd.TabIndex = 1;
            this.btnAdminLTEAdd.Text = "AdminLTE Add";
            this.btnAdminLTEAdd.UseVisualStyleBackColor = true;
            this.btnAdminLTEAdd.Click += new System.EventHandler(this.btnAdminLTEAdd_Click);
            // 
            // btnAdminLTEModify
            // 
            this.btnAdminLTEModify.Location = new System.Drawing.Point(20, 78);
            this.btnAdminLTEModify.Name = "btnAdminLTEModify";
            this.btnAdminLTEModify.Size = new System.Drawing.Size(120, 23);
            this.btnAdminLTEModify.TabIndex = 2;
            this.btnAdminLTEModify.Text = "AdminLTE Modify";
            this.btnAdminLTEModify.UseVisualStyleBackColor = true;
            this.btnAdminLTEModify.Click += new System.EventHandler(this.btnAdminLTEModify_Click);
            // 
            // btnAdminLTEInfo
            // 
            this.btnAdminLTEInfo.Location = new System.Drawing.Point(20, 107);
            this.btnAdminLTEInfo.Name = "btnAdminLTEInfo";
            this.btnAdminLTEInfo.Size = new System.Drawing.Size(120, 23);
            this.btnAdminLTEInfo.TabIndex = 3;
            this.btnAdminLTEInfo.Text = "AdminLTE Info";
            this.btnAdminLTEInfo.UseVisualStyleBackColor = true;
            this.btnAdminLTEInfo.Click += new System.EventHandler(this.btnAdminLTEInfo_Click);
            // 
            // TableDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.tabPage4.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnAdminLTEInfo;
        private System.Windows.Forms.Button btnAdminLTEModify;
        private System.Windows.Forms.Button btnAdminLTEAdd;
        private System.Windows.Forms.Button btnAdminLTEList;
    }
}