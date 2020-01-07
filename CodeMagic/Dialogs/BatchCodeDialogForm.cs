using CodeMagic.BLL;
using CodeMagic.Config;
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

namespace CodeMagic.Dialogs
{
    public partial class BatchCodeDialogForm : Form
    {
        private CommonDAL _dal = new CommonDAL();

        public BatchCodeDialogForm()
        {
            InitializeComponent();
        }

        private void BatchCodeDialogForm_Load(object sender, EventArgs e)
        {
            tbxModel.Text = Program.CurrentDBInfo.CodeGenerate.ModelPath;
            cbxModel.Checked = Program.CurrentDBInfo.CodeGenerate.ModelCreate;
            tbxDAL.Text = Program.CurrentDBInfo.CodeGenerate.DALPath;
            cbxDAL.Checked = Program.CurrentDBInfo.CodeGenerate.DALCreate;
            tbxBLL.Text = Program.CurrentDBInfo.CodeGenerate.BLLPath;
            cbxBLL.Checked = Program.CurrentDBInfo.CodeGenerate.BLLCreate;
            tbxController.Text = Program.CurrentDBInfo.CodeGenerate.ControllerPath;
            cbxController.Checked = Program.CurrentDBInfo.CodeGenerate.ControllerCreate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxModel.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnDAL_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxDAL.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBLL_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxBLL.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnController_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxController.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Program.CurrentDBInfo.CodeGenerate.ModelCreate = cbxModel.Checked;
            Program.CurrentDBInfo.CodeGenerate.ModelPath = tbxModel.Text;

            Program.CurrentDBInfo.CodeGenerate.DALCreate = cbxDAL.Checked;
            Program.CurrentDBInfo.CodeGenerate.DALPath = tbxDAL.Text;

            Program.CurrentDBInfo.CodeGenerate.BLLCreate = cbxBLL.Checked;
            Program.CurrentDBInfo.CodeGenerate.BLLPath = tbxBLL.Text;

            Program.CurrentDBInfo.CodeGenerate.ControllerCreate = cbxController.Checked;
            Program.CurrentDBInfo.CodeGenerate.ControllerPath = tbxController.Text;

            CommonConfig.Save(Program.CommonConfig);

            string modelFolder = tbxModel.Text;
            string dalFolder = tbxDAL.Text;
            string bllFolder = tbxBLL.Text;
            string controllerFolder = tbxController.Text;
            bool createModel = cbxModel.Checked;
            bool createDAL = cbxDAL.Checked;
            bool createBLL = cbxBLL.Checked;
            bool createController = cbxController.Checked;

            Task.Factory.StartNew(() => 
            {
                if (!string.IsNullOrEmpty(modelFolder) && !Directory.Exists(modelFolder))
                {
                    Directory.CreateDirectory(modelFolder);
                }
                if (!string.IsNullOrEmpty(dalFolder) && !Directory.Exists(dalFolder))
                {
                    Directory.CreateDirectory(dalFolder);
                }
                if (!string.IsNullOrEmpty(bllFolder) && !Directory.Exists(bllFolder))
                {
                    Directory.CreateDirectory(bllFolder);
                }
                if (!string.IsNullOrEmpty(controllerFolder) && !Directory.Exists(controllerFolder))
                {
                    Directory.CreateDirectory(controllerFolder);
                }

                this.Invoke(new Action(() =>
                {
                    pb1.Value = 1;
                    lblProgress.Text = "1";
                }));

                var dtTables = _dal.GetTables();
                if (dtTables == null) return;
                DataTable dtViews = _dal.GetViewTables();

                this.Invoke(new Action(() =>
                {
                    pb1.Value = 2;
                    lblProgress.Text = "2";
                }));

                int i = 0;
                int all = dtTables.Rows.Count + ((dtViews == null || dtViews.Rows.Count == 0) ? 0 : dtViews.Rows.Count);
                foreach (DataRow row in dtTables.Rows)
                {
                    i++;
                    int objectID = int.Parse(row["object_id"].ToString());
                    string tableName = row["name"].ToString();
                    var dtColumns = _dal.GetColumns(objectID);

                    if (createModel && !string.IsNullOrEmpty(modelFolder))
                    {
                        var file = modelFolder + "/" + GetModelClassName(tableName) + ".cs";
                        File.WriteAllText(file, CreateModelCode(tableName, dtColumns), Encoding.UTF8);
                    }

                    if (createDAL && !string.IsNullOrEmpty(dalFolder))
                    {
                        var file = dalFolder + "/" + GetDALClassName(tableName) + ".cs";
                        File.WriteAllText(file, CreateDALCode(tableName, dtColumns), Encoding.UTF8);
                    }

                    if (createBLL && !string.IsNullOrEmpty(bllFolder))
                    {
                        var file = bllFolder + "/" + GetBLLClassName(tableName) + ".cs";
                        File.WriteAllText(file, CreateBLLCode(tableName, dtColumns), Encoding.UTF8);
                    }

                    if (createController && !string.IsNullOrEmpty(controllerFolder))
                    {
                        var file = controllerFolder + "/" + GetControllerName(tableName) + ".cs";
                        File.WriteAllText(file, CreateControllerCode(tableName, dtColumns), Encoding.UTF8);
                    }

                    this.Invoke(new Action(() =>
                    {
                        pb1.Value = (int)(i / all * 100);
                        lblProgress.Text = ((int)(i / all * 100)).ToString();
                    }));
                }

                
                if (dtViews != null)
                {
                    foreach (DataRow row in dtViews.Rows)
                    {
                        i++;
                        int objectID = int.Parse(row["object_id"].ToString());
                        string tableName = row["name"].ToString();
                        var dtColumns = _dal.GetColumns(objectID);

                        if (!string.IsNullOrEmpty(modelFolder))
                        {
                            var file = modelFolder + "/" + GetModelClassName(tableName) + ".cs";
                            File.WriteAllText(file, CreateModelCode(tableName, dtColumns), Encoding.UTF8);
                        }

                        if (!string.IsNullOrEmpty(dalFolder))
                        {
                            var file = dalFolder + "/" + GetDALClassName(tableName) + ".cs";
                            File.WriteAllText(file, CreateDALCode(tableName, dtColumns), Encoding.UTF8);
                        }

                        if (!string.IsNullOrEmpty(bllFolder))
                        {
                            var file = bllFolder + "/" + GetBLLClassName(tableName) + ".cs";
                            File.WriteAllText(file, CreateBLLCode(tableName, dtColumns), Encoding.UTF8);
                        }

                        if (createController && !string.IsNullOrEmpty(controllerFolder))
                        {
                            var file = controllerFolder + "/" + GetControllerName(tableName) + ".cs";
                            File.WriteAllText(file, CreateControllerCode(tableName, dtColumns), Encoding.UTF8);
                        }

                        this.Invoke(new Action(() =>
                        {
                            pb1.Value = (int)(i / all * 100);
                            lblProgress.Text = ((int)(i / all * 100)).ToString();
                        }));
                    }
                }

                this.Invoke(new Action(() =>
                {
                    pb1.Value = 100;
                    lblProgress.Text = "100";
                    MsgBox.Info("生成代码已完成");
                    btnCreate.Enabled = true;
                }));
            });
            pb1.ProgressBar.Value = 0;
            lblProgress.Text = "正在准备...";
            btnCreate.Enabled = false;
        }

        private string GetModelClassName(string tableName)
        {
            return new ModelCreateBLL().GetModelClassName(tableName, Program.CurrentDBInfo.CodeGenerate.ModelSuffix);
        }

        private string GetDALClassName(string tableName)
        {
            return new DALCreateBLL().GetDALClassName(tableName, Program.CurrentDBInfo.CodeGenerate.DALSuffix);
        }

        private string GetBLLClassName(string tableName)
        {
            return new BLLCreateBLL().GetBLLClassName(tableName, Program.CurrentDBInfo.CodeGenerate.BLLSuffix);
        }

        private string GetControllerName(string tableName)
        {
            return new ControllerCreateBLL().GetControllerClassName(tableName);
        }

        private string CreateModelCode(string tableName, DataTable dtColumns)
        {
            string file = Application.StartupPath + "\\Templates\\Model.cs.tpl";
            return new ModelCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                tableName,
                Program.CurrentDBInfo.CodeGenerate.ModelSuffix,
                dtColumns);
        }

        private string CreateDALCode(string tableName, DataTable dtColumns)
        {
            string file = Application.StartupPath + "\\Templates\\DAL.cs.tpl";
            return new DALCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                tableName,
                Program.CurrentDBInfo.CodeGenerate.DALSuffix,
                new ModelCreateBLL().GetModelClassName(tableName, Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                dtColumns);
        }

        private string CreateBLLCode(string tableName, DataTable dtColumns)
        {
            string file = Application.StartupPath + "\\Templates\\BLL.cs.tpl";
            return new BLLCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                tableName,
                Program.CurrentDBInfo.CodeGenerate.BLLSuffix,
                new DALCreateBLL().GetDALClassName(tableName, Program.CurrentDBInfo.CodeGenerate.DALSuffix),
                new ModelCreateBLL().GetModelClassName(tableName, Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                dtColumns);
        }

        private string CreateControllerCode(string tableName, DataTable dtColumns)
        {
            string file = Application.StartupPath + "\\Templates\\Controller.cs.tpl";
            return new ControllerCreateBLL().GetCode(
                file,
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName,
                tableName,
                Program.CurrentDBInfo.CodeGenerate.BLLSuffix,
                new BLLCreateBLL().GetBLLClassName(tableName, Program.CurrentDBInfo.CodeGenerate.BLLSuffix),
                new ModelCreateBLL().GetModelClassName(tableName, Program.CurrentDBInfo.CodeGenerate.ModelSuffix),
                dtColumns);
        }
    }
}
