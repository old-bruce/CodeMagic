using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic.Dialogs
{
    public partial class VueDefaultDialogForm : Form
    {
        public VueDefaultDialogForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxName.Text))
            {
                errorProvider1.SetError(tbxName, "不能为空");
                return;
            }

            List<string> props = new List<string>();
            if (tbxProps.Text.Trim().Length > 0)
            {
                string[] temps = tbxProps.Text.Trim().Split(',');
                props.AddRange(temps);
            }
            string file = Application.StartupPath + "\\Templates\\VUE\\Default.vue.tpl";
            BLL.VueDefaultCreateBLL bll = new BLL.VueDefaultCreateBLL();
            string codeText = bll.GetCode(file, tbxName.Text, props);

            var dialog = new Dialogs.CodeDialogForm("HTML", codeText);
            dialog.Text = "VUE Default";
            dialog.ShowDialog();
        }
    }
}
