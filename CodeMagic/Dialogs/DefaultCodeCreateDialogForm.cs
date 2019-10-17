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
    public partial class DefaultCodeCreateDialogForm : Form
    {
        private DataTable _tables;

        public DefaultCodeCreateDialogForm(DataTable tables)
        {
            _tables = tables;
            InitializeComponent();
        }

        private void DefaultCodeCreateDialogForm_Load(object sender, EventArgs e)
        {
            lbxLeft.DataSource = _tables;
            lbxLeft.DisplayMember = "name";
            lbxLeft.ValueMember = "name";
        }

        private void btnALLIn_Click(object sender, EventArgs e)
        {
            lbxLeft.DataSource = null;
            lbxRight.DataSource = _tables;
            lbxRight.DisplayMember = "name";
            lbxRight.ValueMember = "name";
        }

        private void btnOneIn_Click(object sender, EventArgs e)
        {
            //if (lbxLeft.Items.Count == 0) return;
            //if (lbxLeft.SelectedItem == null) return;

            //DataRow row = lbxLeft.SelectedItem as DataRow;
            //if (row == null) return;

            //lbxRight.DisplayMember = "name";
            //lbxRight.ValueMember = "name";
            //lbxRight.Items.Add(row);
        }

        private void btnOneOut_Click(object sender, EventArgs e)
        {

        }

        private void btnALLOut_Click(object sender, EventArgs e)
        {
            lbxLeft.DataSource = _tables;
            lbxLeft.DisplayMember = "name";
            lbxLeft.ValueMember = "name";
            lbxRight.DataSource = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
