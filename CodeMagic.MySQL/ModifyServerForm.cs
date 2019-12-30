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
    public partial class ModifyServerForm : Form
    {
        private Server _server;
        public ModifyServerForm(Server server)
        {
            _server = server;
            InitializeComponent();
        }

        private void ModifyServerForm_Load(object sender, EventArgs e)
        {
            tbxHost.Text = _server.Host;
            tbxPort.Text = _server.Port.ToString();
            tbxUserID.Text = _server.User;
            tbxPassword.Text = _server.Password;
            tbxDBName.Text = _server.DbName;
            tbxNameSpace.Text = _server.NameSpace;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckUI()) return;

            _server.Id = Guid.NewGuid().ToString();
            _server.Host = tbxHost.Text;
            _server.Port = int.Parse(tbxPort.Text.Trim());
            _server.User = tbxUserID.Text;
            _server.Password = tbxPassword.Text;
            _server.DbName = tbxDBName.Text;
            _server.NameSpace = tbxNameSpace.Text;

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
