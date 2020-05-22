using CodeMagic.PGSql.DevTool.DbHelper;
using CodeMagic.PGSql.DevTool.Model;
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
using Newtonsoft.Json;
using ICSharpCode.TextEditor.Actions;

namespace CodeMagic.PGSql.DevTool
{
    public partial class ThreeCodeGenerateForm : Form
    {
        private DAL.PGDAL dal;

        public ThreeCodeGenerateForm()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            dal = new DAL.PGDAL(tbxHost.Text.Trim(), (int)numPort.Value, tbxUser.Text.Trim(), tbxPassword.Text.Trim(), tbxDatabase.Text.Trim());
            Task.Factory.StartNew(() =>
            {
                try
                {
                    List<Model.TableModel> tables = dal.GetTableModelList();
                    this.Invoke(new Action(() =>
                    {
                        lblStatus.Text = "就绪";
                        AddTableNodes(tables);
                        BtnConnect.Enabled = true;
                    }));
                }
                catch(Exception ex)
                {
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show(ex.Message);
                        lblStatus.Text = ex.Message;
                        BtnConnect.Enabled = true;
                    }));
                }
            });
            BtnConnect.Enabled = false;
            lblStatus.Text = "正在加载表...";
        }

        private void AddTableNodes(List<Model.TableModel> tables)
        {
            tvTables.Nodes.Clear();
            TreeNode rootNode = new TreeNode(tbxDatabase.Text.Trim());
            rootNode.ImageIndex = 0;
            rootNode.SelectedImageIndex = 0;
            tvTables.Nodes.Add(rootNode);

            TreeNode publicNode = new TreeNode("public");
            publicNode.ImageIndex = 1;
            publicNode.SelectedImageIndex = 1;

            rootNode.Nodes.Add(publicNode);
            foreach (var item in tables)
            {
                TreeNode node = new TreeNode(item.tablename);
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
                node.Tag = item;
                publicNode.Nodes.Add(node);
            }
            tvTables.ExpandAll();
        }

        private void tvTables_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null) return;
            TableModel tableModel = e.Node.Tag as TableModel;
            if (tableModel == null) return;

            // Load Table Columns
            Task.Factory.StartNew(() =>
            {
                List<Model.ColumnModel> columns = dal.GetColumnModelList(tableModel.tablename);
                this.Invoke(new Action(() =>
                {
                    lblStatus.Text = "就绪";
                    AddColumns(e.Node, columns);
                    GenerateCode((Model.TableModel)e.Node.Tag, columns);
                    e.Node.ExpandAll();
                    BtnRefresh.Enabled = true;
                    tabControl1.Enabled = true;
                }));
            });
            lblStatus.Text = "正在加载列...";
            tabControl1.Enabled = false;
        }

        private void AddColumns(TreeNode tableNode, List<Model.ColumnModel> columns)
        {
            tableNode.Nodes.Clear();
            foreach (var item in columns)
            {
                TreeNode columnNode = new TreeNode(string.Format("{0} ({1})", item.name, item.type));
                columnNode.ImageIndex = 3;
                columnNode.SelectedImageIndex = 3;
                columnNode.Tag = item;
                tableNode.Nodes.Add(columnNode);
            }
        }

        private void GenerateCode(Model.TableModel table, List<Model.ColumnModel> columns)
        {
            string nameSpace = tbxNameSpace.Text.Trim();
            string modelSuffix = tbxModel.Text.Trim();
            string dalSuffix = tbxDAL.Text.Trim();
            string bllSuffix = tbxBLL.Text.Trim();

            BLL.ModelGenerateBLL model = new BLL.ModelGenerateBLL();
            tecModel.Text = model.GetCode(Application.StartupPath + "/Templates/Model.cs.tpl", 
                nameSpace, modelSuffix, table, columns);

            BLL.DALGenerateBLL dal = new BLL.DALGenerateBLL();
            tecDAL.Text = dal.GetCode(Application.StartupPath + "/Templates/DAL.cs.tpl",
                nameSpace, dalSuffix, modelSuffix, table, columns);

            BLL.BLLGenerateBLL bll = new BLL.BLLGenerateBLL();
            tecBLL.Text = bll.GetCode(Application.StartupPath + "/Templates/BLL.cs.tpl",
                nameSpace, bllSuffix, dalSuffix, modelSuffix, table, columns);

            tecSqlQuery.Text = string.Format("SELECT * FROM {0}.{1} WHERE {2}=0",
                table.schemaname, table.tablename, columns[0].name);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if (tvTables.SelectedNode == null) return;
            TableModel tableModel = tvTables.SelectedNode.Tag as TableModel;
            Task.Factory.StartNew(() =>
            {
                List<Model.ColumnModel> columns = dal.GetColumnModelList(tableModel.tablename);
                this.Invoke(new Action(() =>
                {
                    lblStatus.Text = "就绪";
                    GenerateCode((Model.TableModel)tvTables.SelectedNode.Tag, columns);
                    BtnRefresh.Enabled = true;
                    tabControl1.Enabled = true;
                }));
            });
            lblStatus.Text = "正在加载列...";
            BtnRefresh.Enabled = false;
            tabControl1.Enabled = false;
        }

        private void tsBtnRun_Click(object sender, EventArgs e)
        {
            string sql = tecSqlQuery.Text;
            if (string.IsNullOrEmpty(sql)) return;

            dal = new DAL.PGDAL(tbxHost.Text.Trim(), (int)numPort.Value, tbxUser.Text.Trim(), tbxPassword.Text.Trim(), tbxDatabase.Text.Trim());

            if (sql.Trim().ToUpper().StartsWith("SELECT"))
            {
                DateTime dtStart = DateTime.Now;
                Task.Factory.StartNew(()=> 
                {
                    DataTable result = dal.QueryDataTable(sql);
                    this.Invoke(new Action(() =>
                    {
                        lblStatus.Text = string.Format("共 {0} 条记录，耗时 {1} 毫秒",
                            result.Rows.Count,
                            (DateTime.Now - dtStart).TotalMilliseconds);
                        tecSqlQuery.Enabled = true;
                        tsBtnRun.Enabled = true;
                        dgvQueryResult.DataSource = result;
                        CodeGenerateByQuery();
                    }));
                });
                lblStatus.Text = "正在查询...";
                tecSqlQuery.Enabled = false;
                tsBtnRun.Enabled = false;
            }
            else
            {
                //TODO: INSERT UPDATE DELETE
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dirPath = Application.StartupPath + "/DB";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            string filePath = string.Format("{0}/{1}.{2}.config",
                dirPath, tbxHost.Text.Trim(), tbxDatabase.Text.Trim());
            PgConnectionString connString = new PgConnectionString(tbxHost.Text.Trim(), (int)numPort.Value, tbxUser.Text.Trim(), tbxPassword.Text.Trim(), tbxDatabase.Text.Trim());
            File.WriteAllText(filePath, JsonConvert.SerializeObject(connString), Encoding.UTF8);
            MessageBox.Show("已保存");
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SelectFormDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PgConnectionString cs = dialog.ConnectionString;
                tbxHost.Text = cs.Host;
                numPort.Value = (decimal)cs.Port;
                tbxUser.Text = cs.DBUser;
                tbxPassword.Text = cs.DBPassword;
                tbxDatabase.Text = cs.DBName;
            }
        }

        private void CodeGenerateByQuery()
        {
            if (tvTables.SelectedNode.Tag == null) return;
            TableModel tableModel = tvTables.SelectedNode.Tag as TableModel;
            if (tableModel == null) return;

            // Load Table Columns
            Task.Factory.StartNew(() =>
            {
                List<Model.ColumnModel> columns = dal.GetColumnModelList(tableModel.tablename);
                this.Invoke(new Action(() =>
                {
                    lblStatus.Text = "就绪";
                    string modelSuffix = tbxModel.Text.Trim();
                    BLL.DALQueryGenerateBLL dalQuery = new BLL.DALQueryGenerateBLL();
                    tecQueryCode.Text = dalQuery.GetCode(Application.StartupPath + "/Templates/DAL.Query.cs.tpl", modelSuffix, tableModel, columns, tecSqlQuery.Text);
                }));
            });
            lblStatus.Text = "正在生成单表查询代码...";
        }
    }
}
