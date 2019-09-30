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
    public partial class WebDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public WebDockForm()
        {
            InitializeComponent();
        }

        private void tsBtnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.baidu.com/");
        }

        private void tsbtnReturn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void tsBtnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tsTbxUrl.Text))
            {
                webBrowser1.Url = new Uri(tsTbxUrl.Text.Trim());
            }
        }

        private void tsbtnGitHub_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://github.com/");
        }

        private void tsBtnBaidu_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.baidu.com/");
        }

        private void tsBtnGoogle_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.google.com/");
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            tsTbxUrl.Text = webBrowser1.Url.ToString();
            toolStrip1.Enabled = true;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            toolStrip1.Enabled = false;
        }

        private void tsBtnEasyIcon_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.easyicon.net/");
        }

        private void tsBtnIconFont_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.iconfont.cn");
        }

        private void tsBtnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
