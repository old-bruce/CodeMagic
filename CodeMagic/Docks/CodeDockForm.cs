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
    public partial class CodeDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public CodeDockForm()
        {
            InitializeComponent();
        }

        private void CodeDockForm_Load(object sender, EventArgs e)
        {
            LoadCodes();
        }

        private void LoadCodes()
        {
            string templateDir = Application.StartupPath + "\\Codes";
            string[] files = Directory.GetFiles(templateDir, "*.*");
            tvTemplates.Nodes.Clear();
            TreeNode rootNode = new TreeNode(new DirectoryInfo(templateDir).Name);
            rootNode.ToolTipText = new DirectoryInfo(templateDir).FullName;
            rootNode.ImageIndex = 0;
            rootNode.SelectedImageIndex = 0;
            tvTemplates.Nodes.Add(rootNode);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                TreeNode newNode = new TreeNode(fileInfo.Name);
                newNode.Tag = fileInfo;
                if (file.EndsWith(".cs"))
                {
                    newNode.ImageIndex = 1;
                    newNode.SelectedImageIndex = 1;
                }
                else if (file.EndsWith(".html") || file.EndsWith(".htm"))
                {
                    newNode.ImageIndex = 2;
                    newNode.SelectedImageIndex = 2;
                }
                else if (file.EndsWith(".css"))
                {
                    newNode.ImageIndex = 3;
                    newNode.SelectedImageIndex = 3;
                }
                else if (file.EndsWith(".js"))
                {
                    newNode.ImageIndex = 4;
                    newNode.SelectedImageIndex = 4;
                }
                else
                {
                    newNode.ImageIndex = 5;
                    newNode.SelectedImageIndex = 5;
                }
                rootNode.Nodes.Add(newNode);
            }
            tvTemplates.ExpandAll();
        }

        private void 刷新FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCodes();
        }
    }
}
