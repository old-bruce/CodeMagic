using CodeMagic.Dialogs;
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
            tvCodes.Nodes.Clear();
            string templateDir = Application.StartupPath + "\\Codes";

            TreeNode rootNode = new TreeNode(new DirectoryInfo(templateDir).Name);
            rootNode.ToolTipText = new DirectoryInfo(templateDir).FullName;
            rootNode.ImageIndex = 0;
            rootNode.SelectedImageIndex = 0;
            tvCodes.Nodes.Add(rootNode);

            LoadChildNodes(rootNode, templateDir);

            tvCodes.ExpandAll();
        }

        private void LoadChildNodes(TreeNode rootNode, string directoryPath)
        {
            rootNode.Nodes.Clear();
            //子目录
            DirectoryInfo[] dirs = new DirectoryInfo(directoryPath).GetDirectories();
            foreach (var dir in dirs)
            {
                TreeNode childDirNode = new TreeNode(dir.Name);
                childDirNode.Tag = dir;
                childDirNode.ImageIndex = 0;
                childDirNode.SelectedImageIndex = 0;
                rootNode.Nodes.Add(childDirNode);
            }

            string[] files = Directory.GetFiles(directoryPath, "*.*");
            //子文件
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
                rootNode.ExpandAll();
            }
        }

        private void 刷新FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCodes();
        }

        private void cCS文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCodeDialogForm dialog = new CreateCodeDialogForm("C#");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadCodes();
            }
        }

        private void htmlhtml文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCodeDialogForm dialog = new CreateCodeDialogForm("HTML");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadCodes();
            }
        }

        private void cSScss文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCodeDialogForm dialog = new CreateCodeDialogForm("HTML");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadCodes();
            }
        }

        private void jSjs文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCodeDialogForm dialog = new CreateCodeDialogForm("HTML");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadCodes();
            }
        }

        private void tvCodes_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo)
            {
                LoadChildNodes(e.Node, ((DirectoryInfo)e.Node.Tag).FullName);
            }
            else if (e.Node.Tag is FileInfo)
            {
                FileInfo fileInfo = e.Node.Tag as FileInfo;
                Program.MainForm.OpenCodeEditForm(fileInfo);
            }
        }

        private void 其它文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCodeDialogForm dialog = new CreateCodeDialogForm("");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadCodes();
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvCodes.SelectedNode == null) return;

            if (tvCodes.SelectedNode.Tag is DirectoryInfo)
            {
                if (MsgBox.Confirm(string.Format("您确定删除 {0} 文件夹吗?\n\n此操作会删除文件夹下的所有子文件夹和文件！", tvCodes.SelectedNode.Text)) == DialogResult.Yes)
                {
                    Directory.Delete(((DirectoryInfo)tvCodes.SelectedNode.Tag).FullName, true);
                    LoadCodes();
                }
            }
            else if (tvCodes.SelectedNode.Tag is FileInfo)
            {
                if (MsgBox.Confirm(string.Format("您确定删除 {0} 文件吗?", tvCodes.SelectedNode.Text)) == DialogResult.Yes)
                {
                    File.Delete(((FileInfo)tvCodes.SelectedNode.Tag).FullName);
                    LoadCodes();
                }
            }
        }

        private void tvCodes_MouseClick(object sender, MouseEventArgs e)
        {
            TreeNode node = tvCodes.GetNodeAt(e.Location);
            if (node == null) return;
            tvCodes.SelectedNode = node;
        }
    }
}
