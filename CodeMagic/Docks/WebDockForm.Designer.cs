namespace CodeMagic.Docks
{
    partial class WebDockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebDockForm));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsTbxUrl = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnHome = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReturn = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsBtnGo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnGoogle = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBaidu = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGitHub = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEasyIcon = new System.Windows.Forms.ToolStripButton();
            this.tsBtnIconFont = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(784, 234);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("https://www.baidu.com/", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnHome,
            this.tsbtnReturn,
            this.tsBtnRefresh,
            this.tsTbxUrl,
            this.tsBtnGo,
            this.tsBtnGoogle,
            this.tsBtnBaidu,
            this.tsbtnGitHub,
            this.tsBtnEasyIcon,
            this.tsBtnIconFont});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(784, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsTbxUrl
            // 
            this.tsTbxUrl.Name = "tsTbxUrl";
            this.tsTbxUrl.Size = new System.Drawing.Size(500, 23);
            // 
            // tsBtnHome
            // 
            this.tsBtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnHome.Image = global::CodeMagic.Properties.Resources.home;
            this.tsBtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHome.Name = "tsBtnHome";
            this.tsBtnHome.Size = new System.Drawing.Size(23, 20);
            this.tsBtnHome.Text = "首页";
            this.tsBtnHome.Click += new System.EventHandler(this.tsBtnHome_Click);
            // 
            // tsbtnReturn
            // 
            this.tsbtnReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnReturn.Image = global::CodeMagic.Properties.Resources.return_solid;
            this.tsbtnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReturn.Name = "tsbtnReturn";
            this.tsbtnReturn.Size = new System.Drawing.Size(23, 20);
            this.tsbtnReturn.Text = "返回";
            this.tsbtnReturn.Click += new System.EventHandler(this.tsbtnReturn_Click);
            // 
            // tsBtnRefresh
            // 
            this.tsBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRefresh.Image = global::CodeMagic.Properties.Resources.Refresh;
            this.tsBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRefresh.Name = "tsBtnRefresh";
            this.tsBtnRefresh.Size = new System.Drawing.Size(23, 20);
            this.tsBtnRefresh.Text = "刷新";
            this.tsBtnRefresh.Click += new System.EventHandler(this.tsBtnRefresh_Click);
            // 
            // tsBtnGo
            // 
            this.tsBtnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnGo.Image = global::CodeMagic.Properties.Resources.go;
            this.tsBtnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGo.Name = "tsBtnGo";
            this.tsBtnGo.Size = new System.Drawing.Size(23, 20);
            this.tsBtnGo.Text = "Go";
            this.tsBtnGo.Click += new System.EventHandler(this.tsBtnGo_Click);
            // 
            // tsBtnGoogle
            // 
            this.tsBtnGoogle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnGoogle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnGoogle.Image = global::CodeMagic.Properties.Resources.google;
            this.tsBtnGoogle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGoogle.Name = "tsBtnGoogle";
            this.tsBtnGoogle.Size = new System.Drawing.Size(23, 20);
            this.tsBtnGoogle.Text = "Google";
            this.tsBtnGoogle.ToolTipText = "https://www.google.com/";
            this.tsBtnGoogle.Click += new System.EventHandler(this.tsBtnGoogle_Click);
            // 
            // tsBtnBaidu
            // 
            this.tsBtnBaidu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnBaidu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBaidu.Image = global::CodeMagic.Properties.Resources.baidu;
            this.tsBtnBaidu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBaidu.Name = "tsBtnBaidu";
            this.tsBtnBaidu.Size = new System.Drawing.Size(23, 20);
            this.tsBtnBaidu.Text = "https://www.baidu.com/";
            this.tsBtnBaidu.Click += new System.EventHandler(this.tsBtnBaidu_Click);
            // 
            // tsbtnGitHub
            // 
            this.tsbtnGitHub.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnGitHub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnGitHub.Image = global::CodeMagic.Properties.Resources.github;
            this.tsbtnGitHub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGitHub.Name = "tsbtnGitHub";
            this.tsbtnGitHub.Size = new System.Drawing.Size(23, 20);
            this.tsbtnGitHub.Text = "GitHub";
            this.tsbtnGitHub.ToolTipText = "https://github.com/";
            this.tsbtnGitHub.Click += new System.EventHandler(this.tsbtnGitHub_Click);
            // 
            // tsBtnEasyIcon
            // 
            this.tsBtnEasyIcon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnEasyIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnEasyIcon.Image = global::CodeMagic.Properties.Resources.panda;
            this.tsBtnEasyIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEasyIcon.Name = "tsBtnEasyIcon";
            this.tsBtnEasyIcon.Size = new System.Drawing.Size(23, 20);
            this.tsBtnEasyIcon.Text = "https://www.easyicon.net/";
            this.tsBtnEasyIcon.Click += new System.EventHandler(this.tsBtnEasyIcon_Click);
            // 
            // tsBtnIconFont
            // 
            this.tsBtnIconFont.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnIconFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnIconFont.Image = global::CodeMagic.Properties.Resources.iconfont;
            this.tsBtnIconFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnIconFont.Name = "tsBtnIconFont";
            this.tsBtnIconFont.Size = new System.Drawing.Size(23, 20);
            this.tsBtnIconFont.Text = "https://www.iconfont.cn";
            this.tsBtnIconFont.Click += new System.EventHandler(this.tsBtnIconFont_Click);
            // 
            // WebDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebDockForm";
            this.Text = "浏览器";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnHome;
        private System.Windows.Forms.ToolStripButton tsbtnReturn;
        private System.Windows.Forms.ToolStripButton tsBtnRefresh;
        private System.Windows.Forms.ToolStripTextBox tsTbxUrl;
        private System.Windows.Forms.ToolStripButton tsBtnGo;
        private System.Windows.Forms.ToolStripButton tsBtnGoogle;
        private System.Windows.Forms.ToolStripButton tsBtnBaidu;
        private System.Windows.Forms.ToolStripButton tsbtnGitHub;
        private System.Windows.Forms.ToolStripButton tsBtnEasyIcon;
        private System.Windows.Forms.ToolStripButton tsBtnIconFont;
    }
}