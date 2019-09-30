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
    public partial class TemplateEditDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private bool _textChanged = false;
        private FileInfo _fileInfo;

        public TemplateEditDockForm(FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
            InitializeComponent();
            this.Text = fileInfo.Name;
            tslFilePath.Text = fileInfo.FullName;
            tecCode.SetHighlighting("C#");
        }

        private void TemplateEditDockForm_Load(object sender, EventArgs e)
        {
            tecCode.Text = File.ReadAllText(_fileInfo.FullName, Encoding.UTF8);
            tecCode.TextChanged += tecCode_TextChanged;
        }

        private void TemplateEditDockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_textChanged) return;

            if (MsgBox.Confirm("文件已被修改，但是未保存！\n\n您确定关闭吗？") == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            tsBtnSave.Enabled = false;
            try
            {
                File.WriteAllText(_fileInfo.FullName, tecCode.Text, Encoding.UTF8);
                this.Text = _fileInfo.Name;
                _textChanged = false;
            }
            catch(Exception ex)
            {
                MsgBox.Error(ex.Message);
            }
            tsBtnSave.Enabled = true;
        }

        private void tecCode_TextChanged(object sender, EventArgs e)
        {
            this.Text = _fileInfo.Name + "*";
            _textChanged = true;
        }
    }
}
