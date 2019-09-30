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
    public partial class TemplateSibebarDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public TemplateSibebarDockForm()
        {
            InitializeComponent();
        }

        private void TemplateSibebarDockForm_Load(object sender, EventArgs e)
        {
            LoadTemplates();
        }

        private void LoadTemplates()
        {
            string templateDir = Application.StartupPath + "\\Templates";
            string[] files = Directory.GetFiles(templateDir, "*.tpl");
            tvTemplates.Nodes.Clear();
            TreeNode rootNode = new TreeNode("模板");
            rootNode.ImageIndex = 0;
            rootNode.SelectedImageIndex = 0;
            tvTemplates.Nodes.Add(rootNode);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                TreeNode newNode = new TreeNode(fileInfo.Name);
                newNode.Tag = fileInfo;
                newNode.ImageIndex = 1;
                newNode.SelectedImageIndex = 1;
                rootNode.Nodes.Add(newNode);
            }
            tvTemplates.ExpandAll();
        }

        private void 刷新FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTemplates();
        }

        private void tvTemplates_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FileInfo fileInfo = e.Node.Tag as FileInfo;
            if (fileInfo == null) return;
            Program.MainForm.OpenTemplateEditForm(fileInfo);
        }
    }
}
