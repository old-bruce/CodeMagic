using CodeMagic.MySQL.Config;
using CodeMagic.MySQL.DataAccess;
using CodeMagic.MySQL.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic.MySQL
{
    public partial class TableDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public TableDockForm()
        {
            InitializeComponent();
        }

        private void TableDockForm_Load(object sender, EventArgs e)
        {

        }

        private Server _currentServer;
        public void LoadTablesAsync(Server server)
        {
            _currentServer = server;
            tv.Nodes.Clear();
            Task.Factory.StartNew(() =>
            {
                try
                {
                    using (var db = new AppDb(server.GetInformation_chemaConnectString()))
                    {
                        db.Open();

                        TablesDal dal = new TablesDal(db);
                        List<TableModel> modelList = dal.GetListBySchemaName(server.DbName);
                        this.Invoke(new Action(() =>
                        {
                            SetUI(server, modelList);
                            this.TabText = "数据库";
                        }));
                    }
                }
                catch(Exception ex)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.TabText = "数据库";
                        MsgBox.Error(string.Format("[{0}]：加载表异常！\n{1}", server.DbName, ex.Message));
                    }));
                }
            });
            this.TabText = "loading...";
        }

        private void SetUI(Server server, List<TableModel> modelList)
        {
            TreeNode hostNode = new TreeNode(server.Host);
            hostNode.ImageIndex = 0;
            hostNode.SelectedImageIndex = 0;
            tv.Nodes.Clear();
            tv.Nodes.Add(hostNode);

            TreeNode dbNode = new TreeNode(server.DbName);
            dbNode.ImageIndex = 1;
            dbNode.SelectedImageIndex = 1;
            hostNode.Nodes.Add(dbNode);

            foreach (var model in modelList)
            {
                TreeNode tableNode = new TreeNode(model.TABLE_NAME);
                tableNode.ToolTipText = string.Format("{0}\n\n存储引擎：{1}",
                    model.TABLE_COMMENT, model.ENGINE);
                tableNode.Tag = model;
                dbNode.Nodes.Add(tableNode);
            }

            tv.ExpandAll();
        }

        private void tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TableModel model = e.Node.Tag as TableModel;
            if (model == null) return;

            new ColumnDockForm(_currentServer, model).Show(Program.DockMainForm.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }
    }
}
