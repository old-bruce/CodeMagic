using CodeMagic.PGSql.DevTool.DbHelper;
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

namespace CodeMagic.PGSql.DevTool
{
    public partial class SelectFormDialog : Form
    {
        public SelectFormDialog()
        {
            InitializeComponent();
        }

        public PgConnectionString ConnectionString { get; private set; }

        private void SelectFormDialog_Load(object sender, EventArgs e)
        {
            string dirPath = Application.StartupPath + "/DB";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            string[] files = Directory.GetFiles(dirPath);
            if (files.Length > 0)
            {
                List<FileInfo> fileInfoList = new List<FileInfo>();
                foreach (string file in files)
                {
                    fileInfoList.Add(new FileInfo(file));
                }
                cbxHost.DataSource = fileInfoList;
                cbxHost.DisplayMember = "Name";
                cbxHost.SelectedIndex = 0;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = cbxHost.SelectedItem as FileInfo;
            string text = File.ReadAllText(fileInfo.FullName, Encoding.UTF8);
            ConnectionString = Newtonsoft.Json.JsonConvert.DeserializeObject<PgConnectionString>(text);
            if (ConnectionString != null)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
