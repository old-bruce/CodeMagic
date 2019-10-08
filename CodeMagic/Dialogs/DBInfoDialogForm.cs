using CodeMagic.Config;
using CodeMagic.DAL;
using CodeMagic.Model;
using CodeMagic.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic.Dialogs
{
    public partial class DBInfoDialogForm : Form
    {
        private CommonConfig _config = Program.CommonConfig;

        public DBInfoModel DBInfo
        {
            get
            {
                return new DBInfoModel()
                {
                    ServerName = cbxServerNames.Text,
                    UserID = tbxUserID.Text.Trim(),
                    Password = tbxPassword.Text.Trim(),
                    DBName = tbxDBName.Text.Trim()
                };
            }
        }

        public DBInfoDialogForm()
        {
            InitializeComponent();
        }

        private void DBInfoDialogForm_Load(object sender, EventArgs e)
        {
            cbxServerNames.DataSource = _config.DBInfoList;
            cbxServerNames.DisplayMember = "ServerName";
            cbxServerNames.ValueMember = "ServerName";
        }

        private void cbxServerNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBInfoModel dbInfo = cbxServerNames.SelectedItem as DBInfoModel;
            if (dbInfo == null) return;

            tbxUserID.Text = dbInfo.UserID;
            tbxPassword.Text = dbInfo.Password;
            tbxDBName.Text = dbInfo.DBName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxServerNames.Text))
            {
                errorProvider1.SetError(cbxServerNames, "不能为空");
                return;
            }

            if (string.IsNullOrEmpty(tbxUserID.Text))
            {
                errorProvider1.SetError(tbxUserID, "不能为空");
                return;
            }

            if (string.IsNullOrEmpty(tbxPassword.Text))
            {
                errorProvider1.SetError(tbxPassword, "不能为空");
                return;
            }

            if (string.IsNullOrEmpty(tbxDBName.Text))
            {
                errorProvider1.SetError(tbxDBName, "不能为空");
                return;
            }

            DbHelperSQL.connectionString = this.DBInfo.ToSqlConnectString();

            btnConnect.Enabled = false;
            this.Text = "正在连接数据库...";
            Task.Factory.StartNew(()=> 
            {
                string errorMsg;
                if (!new CommonDAL().TestConnection(out errorMsg))
                {
                    this.Invoke(new Action(() =>
                    {
                        MsgBox.Error("数据库连接失败！\n" + errorMsg);
                        btnConnect.Enabled = true;
                        this.Text = "数据库连接";
                    }));
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        MsgBox.Info("数据库连接成功！");
                        btnConnect.Enabled = true;
                        Program.CurrentDBInfo = DBInfo;
                        DialogResult = DialogResult.OK;
                        this.Text = "数据库连接";
                    }));

                }
            });
        }
    }
}
