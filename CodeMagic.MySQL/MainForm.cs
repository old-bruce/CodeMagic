using CodeMagic.MySQL.Config;
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

namespace CodeMagic.MySQL
{
    public partial class MainForm : Form
    {
        private TableDockForm _tableDockForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadServerList()
        {
            lblstatus.Text = "正在加载服务器列表...";
            cbxServerList.ComboBox.Items.Clear();
            cbxServerList.ComboBox.Items.AddRange(AppConfig.Instance.ServerList.ToArray());
            cbxServerList.ComboBox.DisplayMember = "DbName";
            cbxServerList.ComboBox.ValueMember = "Id";
            lblstatus.Text = "就绪";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadServerList();
        }

        private void 新建服务器ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (new NewServerForm().ShowDialog() == DialogResult.OK)
            {
                LoadServerList();
            }
        }

        private void 模型类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeDockForm codeForm = new CodeDockForm();
            codeForm.Text = "Table.cs.tpl";
            codeForm.teCode.Text = File.ReadAllText(Application.StartupPath + @"\Templates\Table.cs.tpl");
            codeForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        private void 查询类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeDockForm codeForm = new CodeDockForm();
            codeForm.Text = "TableQuery.cs.tpl";
            codeForm.teCode.Text = File.ReadAllText(Application.StartupPath + @"\Templates\TableQuery.cs.tpl");
            codeForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        private void appDBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CodeDockForm codeForm = new CodeDockForm();
            codeForm.Text = "AppDb.cs.tpl";
            codeForm.teCode.Text = File.ReadAllText(Application.StartupPath + @"\Templates\AppDb.cs.tpl");
            codeForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        private void 管理服务器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new ServerListForm().ShowDialog() == DialogResult.OK)
            {
                LoadServerList();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cbxServerList.SelectedIndex == -1) return;

            var currentServer = cbxServerList.SelectedItem as Server;
            if(_tableDockForm == null)
            {
                _tableDockForm = new TableDockForm();
            }
            _tableDockForm.LoadTablesAsync(currentServer);
            _tableDockForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadServerList();
        }
    }
}
