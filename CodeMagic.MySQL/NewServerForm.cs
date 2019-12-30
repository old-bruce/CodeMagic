using CodeMagic.MySQL.Config;
using CodeMagic.MySQL.DataAccess;
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
    public partial class NewServerForm : Form
    {
        public NewServerForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckUI()) return;

            AppConfig.Instance.ServerList.Add(new Server()
            {
                Id = Guid.NewGuid().ToString(),
                Host = tbxHost.Text,
                Port = int.Parse(tbxPort.Text.Trim()),
                User = tbxUserID.Text,
                Password = tbxPassword.Text,
                DbName = tbxDBName.Text,
                NameSpace = tbxNameSpace.Text
            });
            AppConfig.Instance.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!CheckUI()) return;

            var server = new Server()
            {
                Host = tbxHost.Text,
                Port = int.Parse(tbxPort.Text.Trim()),
                User = tbxUserID.Text,
                Password = tbxPassword.Text,
                DbName = tbxDBName.Text
            };

            try
            {
                Task.Factory.StartNew(() =>
                {
                    using (var db = new AppDb(server.GetConnectString()))
                    {
                        db.Open();
                    }
                    this.Invoke(new Action(()=> 
                    {
                        MsgBox.Info("测试连接成功");
                        btnTest.Enabled = true;
                    }));
                    
                });
                btnTest.Enabled = false;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
                btnTest.Enabled = true;
            }
        }

        private bool CheckUI()
        {
            if (string.IsNullOrEmpty(tbxHost.Text))
            {
                errorProvider1.SetError(tbxHost, "服务器名称不能为空");
                return false;
            }

            if (string.IsNullOrEmpty(tbxPort.Text))
            {
                errorProvider1.SetError(tbxPort, "服务器端口不能为空");
                return false;
            }

            if (string.IsNullOrEmpty(tbxUserID.Text))
            {
                errorProvider1.SetError(tbxUserID, "数据库登录用户名不能为空");
                return false;
            }

            if (string.IsNullOrEmpty(tbxPassword.Text))
            {
                errorProvider1.SetError(tbxPassword, "数据库登录密码不能为空");
                return false;
            }

            if (string.IsNullOrEmpty(tbxDBName.Text))
            {
                errorProvider1.SetError(tbxDBName, "数据库名称不能为空");
                return false;
            }

            return true;
        }
    }
}
