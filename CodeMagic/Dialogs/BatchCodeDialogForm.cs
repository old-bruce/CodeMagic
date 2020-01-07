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
            if (bgWorker.IsBusy)
            {
                bgWorker.CancelAsync();
            }
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

        string modelFolder;
        string dalFolder;
        string bllFolder;
        string controllerFolder;
        bool createModel;
        bool createDAL;
        bool createBLL;
        bool createController;

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

            modelFolder = tbxModel.Text;
            dalFolder = tbxDAL.Text;
            bllFolder = tbxBLL.Text;
            controllerFolder = tbxController.Text;
            createModel = cbxModel.Checked;
            createDAL = cbxDAL.Checked;
            createBLL = cbxBLL.Checked;
            createController = cbxController.Checked;

            progressBar1.Value = 0;
            bgWorker.RunWorkerAsync();
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

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bgWorker.ReportProgress(0);

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

            var dtTables = _dal.GetTables();
            if (dtTables == null) return;
            DataTable dtViews = _dal.GetViewTables();

            int i = 0;
            int all = dtTables.Rows.Count + ((dtViews == null || dtViews.Rows.Count == 0) ? 0 : dtViews.Rows.Count);
            foreach (DataRow row in dtTables.Rows)
            {
                if (bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
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

                int progress = (int)(i * 100 / all);
                bgWorker.ReportProgress(progress);
            }


            if (dtViews != null)
            {
                foreach (DataRow row in dtViews.Rows)
                {
                    if (bgWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
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

                    int progress = (int)(i * 100 / all);
                    bgWorker.ReportProgress(progress);
                }
            }

            bgWorker.ReportProgress(100);
            e.Result = true;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MsgBox.Warn("已取消代码生成！\n\n已经生成的代码不会撤销，需要您手动处理。");
            }
            else if (e.Error != null)
            {
                MsgBox.Error(e.Error.Message);
            }
            else
            {
                MsgBox.Info("代码批量生成成功");
            }
            btnCreate.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (bgWorker.IsBusy)
            {
                MsgBox.Warn("正在执行任务，请取消成功后再关闭此窗体！");
                return;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
