using CodeMagic.BLL;
using CodeMagic.DAL;
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
    public partial class TableDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private int _tableObjectID;
        private string _tableName;

        private CommonDAL _dal = new CommonDAL();

        public TableDockForm(int tableObjectID, string tableName)
        {
            _tableObjectID = tableObjectID;
            _tableName = tableName;
            InitializeComponent();
            this.Text = _tableName;

            tecModel.SetHighlighting("C#");
            tecDAL.SetHighlighting("C#");
            tecBLL.SetHighlighting("C#");
            tecAdminLTE.SetHighlighting("HTML");
        }

        private void TableDockForm_Load(object sender, EventArgs e)
        {
            LoadColumnsAsync();
        }

        private void LoadColumnsAsync()
        {
            Task.Factory.StartNew(new Action(() =>
            {
                this.Invoke(new Action(() =>
                {
                    this.Text += "正在加载列...";
                }));
                DataTable dtColumns = _dal.GetColumns(_tableObjectID);
                this.Invoke(new Action(()=> 
                {
                    dgvColumn.DataSource = null;
                    dgvColumn.DataSource = dtColumns;
                    this.Text = _tableName;

                    CreateModelCode(dtColumns);
                    CreateDALCode(dtColumns);
                    CreateBLLCode(dtColumns);
                }));
            }));
        }

        private void CreateModelCode(DataTable table)
        {
            string file = Application.StartupPath + "\\Templates\\Model.cs.tpl";
            tecModel.Text = new ModelCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                Program.CurrentDBInfo.CodeGenerate.ModelSuffix,
                table);
        }

        private void CreateDALCode(DataTable table)
        {
            string file = Application.StartupPath + "\\Templates\\DAL.cs.tpl";
            tecDAL.Text = new DALCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                Program.CurrentDBInfo.CodeGenerate.DALSuffix,
                new ModelCreateBLL().GetModelClassName(_tableName, Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                table);
        }

        private void CreateBLLCode(DataTable table)
        {
            string file = Application.StartupPath + "\\Templates\\BLL.cs.tpl";
            tecBLL.Text = new BLLCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                Program.CurrentDBInfo.CodeGenerate.DALSuffix,
                new DALCreateBLL().GetDALClassName(_tableName, Program.CurrentDBInfo.CodeGenerate.DALSuffix),
                new ModelCreateBLL().GetModelClassName(_tableName, Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                table);
        }

        private void 刷新RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadColumnsAsync();
        }
    }
}
