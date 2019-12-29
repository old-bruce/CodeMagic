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
    public partial class TableDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public TableDockForm()
        {
            InitializeComponent();
        }

        private void TableDockForm_Load(object sender, EventArgs e)
        {

        }

        public void LoadTablesAsync(Server server)
        {
            TreeNode hostNode = new TreeNode(server.Host);
            hostNode.ImageIndex = 0;
            hostNode.SelectedImageIndex = 0;
            tv.Nodes.Clear();
            tv.Nodes.Add(hostNode);

            TreeNode dbNode = new TreeNode(server.DbName);
            dbNode.ImageIndex = 1;
            dbNode.SelectedImageIndex = 1;
            hostNode.Nodes.Add(dbNode);

            tv.ExpandAll();
        }
    }
}
