using CodeMagic.MySQL.Bll;
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
    public partial class ColumnDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private Server _server;
        private TablesModel _model;
        public ColumnDockForm(Server serverInfo, TablesModel model)
        {
            _server = serverInfo;
            _model = model;
            InitializeComponent();
            dgvColumn.AutoGenerateColumns = false;
            dgvColumn.DataError += (s, e) => { };
            tpTable.Text = CodeHelp.CamelCase(_model.TABLE_NAME);
            tpTableQuery.Text = CodeHelp.CamelCase(_model.TABLE_NAME) + "Query";
            tpController.Text = CodeHelp.CamelCase(_model.TABLE_NAME) + "Controller";
        }

        private void ColumnDockForm_Load(object sender, EventArgs e)
        {
            this.TabText = _model.TABLE_NAME;
            LoadColumnsAsync();
        }

        private void LoadColumnsAsync()
        {
            Task.Factory.StartNew(()=> 
            {
                try
                {
                    using (var db = new AppDb(_server.GetInformation_chemaConnectString()))
                    {
                        db.Open();

                        ColumnsDal dal = new ColumnsDal(db);
                        List<ColumnsModel> modelList = dal.GetListBySchemaAndTable(_server.DbName, _model.TABLE_NAME);
                        this.Invoke(new Action(() =>
                        {
                            dgvColumn.DataSource = modelList;
                            CreateCode(modelList);
                        }));
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() =>
                    {
                        MsgBox.Error(string.Format("[{0}]：加载列异常！\n{1}", _model.TABLE_NAME, ex.Message));
                    }));
                }
            });
        }

        private void CreateCode(List<ColumnsModel> modelList)
        {
            tecTable.Text = new TableCodeBll(_server, _model.TABLE_NAME, modelList).CreateCode(Application.StartupPath + @"/Templates/Table.cs.tpl");
            tecTableQuery.Text = new TableQueryCodeBll(_server, _model.TABLE_NAME,  modelList).CreateCode(Application.StartupPath + @"/Templates/TableQuery.cs.tpl");
            tecController.Text = new ControllerCodeBll(_server, _model.TABLE_NAME, modelList).CreateCode(Application.StartupPath + @"/Templates/Controller.cs.tpl");
            tecAppDb.Text = new AppDbCodeBll(_server).CreateCode(Application.StartupPath + @"/Templates/AppDb.cs.tpl");
            
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadColumnsAsync();
        }
    }
}
