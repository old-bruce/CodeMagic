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

        private DataTable _dtColumns;

        public TableDockForm(int tableObjectID, string tableName)
        {
            _tableObjectID = tableObjectID;
            _tableName = tableName;
            InitializeComponent();
            this.Text = _tableName;

            tecModel.SetHighlighting("C#");
            tecDAL.SetHighlighting("C#");
            tecBLL.SetHighlighting("C#");
            tecController.SetHighlighting("C#");
            teViewModel.SetHighlighting("C#");
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
                _dtColumns = _dal.GetColumns(_tableObjectID);
                this.Invoke(new Action(()=> 
                {
                    dgvColumn.DataSource = null;
                    dgvColumn.DataSource = _dtColumns;
                    this.Text = _tableName;

                    CreateModelCode(_dtColumns);
                    CreateDALCode(_dtColumns);
                    CreateBLLCode(_dtColumns);
                    CreateControllerCode(_dtColumns);
                    CreateViewModelCode(_dtColumns);
                }));
            }));
        }

        private void CreateModelCode(DataTable dtColumns)
        {
            string file = Application.StartupPath + "\\Templates\\Model.cs.tpl";
            tecModel.Text = new ModelCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                Program.CurrentDBInfo.CodeGenerate.ModelSuffix,
                dtColumns);
        }

        private void CreateDALCode(DataTable dtColumns)
        {
            string file = Application.StartupPath + "\\Templates\\DAL.cs.tpl";
            tecDAL.Text = new DALCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                Program.CurrentDBInfo.CodeGenerate.DALSuffix,
                new ModelCreateBLL().GetModelClassName(_tableName, Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                dtColumns);
        }

        private void CreateBLLCode(DataTable dtColumns)
        {
            string file = Application.StartupPath + "\\Templates\\BLL.cs.tpl";
            tecBLL.Text = new BLLCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                Program.CurrentDBInfo.CodeGenerate.BLLSuffix,
                new DALCreateBLL().GetDALClassName(_tableName, Program.CurrentDBInfo.CodeGenerate.DALSuffix),
                new ModelCreateBLL().GetModelClassName(_tableName, Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                dtColumns);
        }

        private void CreateControllerCode(DataTable dtColumns)
        {
            string file = Application.StartupPath + "\\Templates\\Controller.cs.tpl";
            tecController.Text = new ControllerCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                Program.CurrentDBInfo.CodeGenerate.BLLSuffix,
                new BLLCreateBLL().GetBLLClassName(_tableName, Program.CurrentDBInfo.CodeGenerate.BLLSuffix),
                new ModelCreateBLL().GetModelClassName(_tableName, Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                dtColumns);
        }

        private void CreateViewModelCode(DataTable dtColumns)
        {
            string file = Application.StartupPath + "\\Templates\\ViewModel.cs.tpl";
            teViewModel.Text = new ViewModelCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                dtColumns);
        }

        private string CreateAdminLTEListCode(DataTable table)
        {
            string file = Application.StartupPath + "\\Templates\\AdminLTE.List.cshtml.tpl";
            return new AdminLTEListCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                new ModelCreateBLL().GetModelClassName(_tableName,
                Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                _dtColumns);
        }

        private string CreateAdminLTEAddCode(DataTable table)
        {
            string file = Application.StartupPath + "\\Templates\\AdminLTE.Add.cshtml.tpl";
            return new AdminLTEAddCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                new ModelCreateBLL().GetModelClassName(_tableName,
                Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                _dtColumns);
        }

        private string CreateVUEDefaultCode(DataTable table)
        {
            string file = Application.StartupPath + "\\Templates\\VUE\\Default.vue.tpl";
            return new VueDefaultCreateBLL().GetCode(
                file,
                _tableName,
                new List<string>());
        }

        private string CreateBootstrapListCode(DataTable table)
        {
            string file = Application.StartupPath + "\\Templates\\Bootstrap.List.cshtml.tpl";
            return new BootstrapListCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                new ModelCreateBLL().GetModelClassName(_tableName,
                Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                _dtColumns);
        }

        private string CreateBootstrapAddCode(DataTable table)
        {
            string file = Application.StartupPath + "\\Templates\\Bootstrap.Add.cshtml.tpl";
            return new BootstrapAddCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                new ModelCreateBLL().GetModelClassName(_tableName,
                Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                _dtColumns);
        }

        private string CreateBootstrapModifyCode(DataTable table)
        {
            string file = Application.StartupPath + "\\Templates\\Bootstrap.Modify.cshtml.tpl";
            return new BootstrapModifyCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                _tableName,
                new ModelCreateBLL().GetModelClassName(_tableName,
                Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                _dtColumns);
        }

        private void 刷新RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadColumnsAsync();
        }

        private void 列表页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codeText = CreateAdminLTEListCode(_dtColumns);
            var dialog = new Dialogs.CodeDialogForm("HTML", codeText);
            dialog.Text = "AdminLTE List Code";
            dialog.ShowDialog();
        }

        private void 新增页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codeText = CreateAdminLTEAddCode(_dtColumns);
            var dialog = new Dialogs.CodeDialogForm("HTML", codeText);
            dialog.Text = "AdminLTE Add Code";
            dialog.ShowDialog();
        }

        private void 编辑页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = Application.StartupPath + "\\Templates\\AdminLTE.Modify.cshtml.tpl";
            string codeText = File.Exists(file) ? File.ReadAllText(file) : string.Empty;
            var dialog = new Dialogs.CodeDialogForm("HTML", codeText);
            dialog.Text = "AdminLTE Modify Code";
            dialog.ShowDialog();
        }

        private void 详情页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = Application.StartupPath + "\\Templates\\AdminLTE.Info.cshtml.tpl";
            string codeText = File.Exists(file) ? File.ReadAllText(file) : string.Empty;
            var dialog = new Dialogs.CodeDialogForm("HTML", codeText);
            dialog.Text = "AdminLTE Info Code";
            dialog.ShowDialog();
        }

        private void defaultvueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codeText = CreateVUEDefaultCode(_dtColumns);
            var dialog = new Dialogs.CodeDialogForm("HTML", codeText);
            dialog.Text = "VUE Default";
            dialog.ShowDialog();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codeText = CreateBootstrapListCode(_dtColumns);
            var dialog = new Dialogs.CodeDialogForm("HTML", codeText);
            dialog.Text = "Bootstrap List Code";
            dialog.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codeText = CreateBootstrapAddCode(_dtColumns);
            var dialog = new Dialogs.CodeDialogForm("HTML", codeText);
            dialog.Text = "Bootstrap Add Code";
            dialog.ShowDialog();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codeText = CreateBootstrapModifyCode(_dtColumns);
            var dialog = new Dialogs.CodeDialogForm("HTML", codeText);
            dialog.Text = "Bootstrap Modify Code";
            dialog.ShowDialog();
        }
    }
}
