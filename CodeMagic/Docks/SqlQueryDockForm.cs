using CodeMagic.DAL;
using ICSharpCode.TextEditor.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic.Docks
{
    public partial class SqlQueryDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public SqlQueryDockForm()
        {
            InitializeComponent();
            tecSQL.SetHighlighting("SQL");
        }

        private void 执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tecSQL.Text)) return;

            string sql = tecSQL.ActiveTextAreaControl.SelectionManager.SelectedText;
            if (string.IsNullOrEmpty(sql))
            {
                sql = tecSQL.Text;
            }

            执行ToolStripMenuItem.Enabled = false;
            this.Text = "SQL查询...";
            Task.Factory.StartNew(() =>
            {
                try
                {
                    DataTable dt = new CommonDAL().Query(sql);
                    this.Invoke(new Action(() =>
                    {
                        dgvResult.DataSource = null;
                        dgvResult.DataSource = dt;
                        执行ToolStripMenuItem.Enabled = true;
                        this.Text = "SQL查询";
                    }));
                }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() =>
                    {
                        dgvResult.DataSource = null;
                        执行ToolStripMenuItem.Enabled = true;
                        MsgBox.Error(ex.Message);
                        this.Text = "SQL查询";
                    }));
                }
            });
        }

        private void dgvResult_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }
}
