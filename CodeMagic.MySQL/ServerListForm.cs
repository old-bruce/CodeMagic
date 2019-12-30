using CodeMagic.MySQL.Config;
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
    public partial class ServerListForm : Form
    {
        public ServerListForm()
        {
            InitializeComponent();
            dgv1.AutoGenerateColumns = false;
            dgv1.DataError += (s, e) => { };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new NewServerForm().ShowDialog() == DialogResult.OK)
            {
                LoadServerList();
            }
        }

        private void ServerListForm_Load(object sender, EventArgs e)
        {
            LoadServerList();
        }

        private void LoadServerList()
        {
            dgv1.DataSource = null;
            dgv1.DataSource = AppConfig.Instance.ServerList;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0) return;
            if (MsgBox.Confirm("确定删除选中的记录吗？") != DialogResult.Yes) return;

            foreach (DataGridViewRow row in dgv1.SelectedRows)
            {
                var server = row.DataBoundItem as Server;
                var model = AppConfig.Instance.ServerList.Find(m => m.Id == server.Id);
                if (model != null)
                {
                    AppConfig.Instance.ServerList.Remove(model);
                }
            }

            AppConfig.Instance.Save();
            LoadServerList();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0) return;

            var server = dgv1.SelectedRows[0].DataBoundItem as Server;
            if (new ModifyServerForm(server).ShowDialog() == DialogResult.OK)
            {
                LoadServerList();
            }
        }
    }
}
