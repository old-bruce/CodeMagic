using CodeMagic.Docks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic
{
    public partial class MainForm : Form
    {
        private SidebarDockForm _sidebarDockForm;
        private TemplateSibebarDockForm _templateSidebarDockForm;
        private HomeDockForm _homeDockForm;
        private WebDockForm _webDockForm;
        private SqlQueryDockForm _sqlQueryDockForm;

        private Dictionary<string, WeifenLuo.WinFormsUI.Docking.DockContent> _openTableForms = new Dictionary<string, WeifenLuo.WinFormsUI.Docking.DockContent>();
        private Dictionary<string, WeifenLuo.WinFormsUI.Docking.DockContent> _openTemplateForms = new Dictionary<string, WeifenLuo.WinFormsUI.Docking.DockContent>();

        public MainForm()
        {
            InitializeComponent();
            InitDockForms();
        }

        private void InitDockForms()
        {
            _sidebarDockForm = new SidebarDockForm();
            _templateSidebarDockForm = new TemplateSibebarDockForm();
            _homeDockForm = new HomeDockForm();
        }

        private void OpenDockForms()
        {
            ShowSidebar();
            ShowTemplate();
            ShowHome();
        }

        public void ShowSidebar()
        {
            if (_sidebarDockForm == null)
            {
                _sidebarDockForm = new SidebarDockForm();
            }
            _sidebarDockForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
        }

        public void ShowTemplate()
        {
            if (_templateSidebarDockForm == null)
            {
                _templateSidebarDockForm = new TemplateSibebarDockForm();
            }
            _templateSidebarDockForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockRight);
        }

        public void ShowHome()
        {
            if (_homeDockForm == null)
            {
                _homeDockForm = new HomeDockForm();
            }
            _homeDockForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        public void OpenWeb()
        {
            if (_webDockForm == null)
            {
                _webDockForm = new WebDockForm();
                _webDockForm.FormClosed += (s, e) =>
                {
                    _webDockForm = null;
                };
            }
            _webDockForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        public void OpenSQLQuery()
        {
            if (_sqlQueryDockForm == null)
            {
                _sqlQueryDockForm = new SqlQueryDockForm();
                _sqlQueryDockForm.FormClosed += (s, e) =>
                {
                    _sqlQueryDockForm = null;
                };
            }
            _sqlQueryDockForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        public bool ExistTableForm(string tableName)
        {
            return _openTableForms.ContainsKey(tableName);
        }

        public void OpenOrCreateTableForm(string tableName, WeifenLuo.WinFormsUI.Docking.DockContent dockForm)
        {
            if (!_openTableForms.ContainsKey(tableName) && dockForm != null)
            {
                dockForm.FormClosed += (s, e) =>
                {
                    _openTableForms.Remove(tableName);
                };
                _openTableForms[tableName] = dockForm;
            }
            _openTableForms[tableName].Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        public void OpenTemplateEditForm(FileInfo fileInfo)
        {
            if (!_openTemplateForms.ContainsKey(fileInfo.Name))
            {
                TemplateEditDockForm templateForm = new TemplateEditDockForm(fileInfo);
                templateForm.FormClosed += (s, e) =>
                {
                    _openTemplateForms.Remove(fileInfo.Name);
                };
                _openTemplateForms[fileInfo.Name] = templateForm;
            }
            _openTemplateForms[fileInfo.Name].Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenDockForms();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void 浏览器BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWeb();
        }

        private void iEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "https://www.baidu.com/");
        }

        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.baidu.com/");
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }
    }
}
