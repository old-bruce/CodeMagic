using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lblStatus.Visible = true;
            try
            {
                Program.LoadConfig();
                Program.CreateMainForm();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MsgBox.Error(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "https://github.com/old-bruce/CodeMagic");
        }
    }
}
