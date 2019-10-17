using CodeMagic.Common;
using CodeMagic.Config;
using CodeMagic.DAL;
using CodeMagic.Dialogs;
using CodeMagic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic.Docks
{
    public partial class SidebarDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private CommonConfig _config = Program.CommonConfig;

        public SidebarDockForm()
        {
            InitializeComponent();
        }

        private void SidebarDockForm_Load(object sender, EventArgs e)
        {
        }

        private void 新建数据库连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBInfoDialogForm dialog = new DBInfoDialogForm();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Program.CurrentDBInfo = _config.Add(dialog.DBInfo);
                CommonConfig.Save(_config);
                LoadTablesAsync();
            }
        }

        private void LoadTablesAsync()
        {
            Task.Factory.StartNew(()=> 
            {
                DataTable dtTables = new CommonDAL().GetTables();
                if (dtTables == null) return;

                DataTable dtViews = new CommonDAL().GetViewTables();

                this.Invoke(new Action(() =>
                {
                    tvTables.Nodes.Clear();

                    TreeNode rootNode = new TreeNode(string.Format("{0}", Program.CurrentDBInfo.DBName));
                    rootNode.ImageIndex = 0;
                    rootNode.SelectedImageIndex = 0;
                    tvTables.Nodes.Add(rootNode);

                    TreeNode tablesNode = new TreeNode(string.Format("Tables ({0})", dtTables.Rows.Count));
                    tablesNode.ImageIndex = 1;
                    tablesNode.SelectedImageIndex = 1;
                    rootNode.Nodes.Add(tablesNode);

                    TreeNode viewsNode = new TreeNode(string.Format("Views ({0})", dtViews.Rows.Count));
                    viewsNode.ImageIndex = 1;
                    viewsNode.SelectedImageIndex = 1;
                    rootNode.Nodes.Add(viewsNode);

                    foreach (DataRow row in dtTables.Rows)
                    {
                        TreeNode tableNode = new TreeNode(row["name"].ToString());
                        tableNode.ImageIndex = 1;
                        tableNode.SelectedImageIndex = 1;
                        tableNode.Tag = row;
                        tablesNode.Nodes.Add(tableNode);
                    }

                    foreach (DataRow row in dtViews.Rows)
                    {
                        TreeNode tableNode = new TreeNode(row["name"].ToString());
                        tableNode.ImageIndex = 1;
                        tableNode.SelectedImageIndex = 1;
                        tableNode.Tag = row;
                        viewsNode.Nodes.Add(tableNode);
                    }
                    tvTables.ExpandAll();
                }));
            });
        }

        private void 刷新FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.CurrentDBInfo == null) return;
            LoadTablesAsync();
        }

        private void sQL查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.CurrentDBInfo == null) return;
            Program.MainForm.OpenSQLQuery();
        }

        private void tvTables_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DataRow row = e.Node.Tag as DataRow;
            if (row == null) return;

            int objectID = int.Parse(row["object_id"].ToString());
            string tableName = row["name"].ToString();

            if (Program.MainForm.ExistTableForm(tableName))
            {
                Program.MainForm.OpenOrCreateTableForm(tableName, null);
            }
            else
            {
                TableDockForm tableForm = new TableDockForm(objectID, tableName);
                Program.MainForm.OpenOrCreateTableForm(tableName, tableForm);
            }
        }

        private void 代码生成设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.CurrentDBInfo != null)
            {
                CodeGenerateConfigDialogForm cgDialog = new CodeGenerateConfigDialogForm();
                if (cgDialog.ShowDialog() == DialogResult.OK)
                {
                    Program.CurrentDBInfo.CodeGenerate = cgDialog.CodeGenerateConfig;
                    CommonConfig.Save(Program.CommonConfig);
                }
            }
        }
    }
}
