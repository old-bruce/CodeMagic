namespace CodeMagic.Dialogs
{
    partial class BatchCodeDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchCodeDialogForm));
            this.lblModel = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.btnModel = new System.Windows.Forms.Button();
            this.btnDAL = new System.Windows.Forms.Button();
            this.tbxDAL = new System.Windows.Forms.TextBox();
            this.lblDAL = new System.Windows.Forms.Label();
            this.btnBLL = new System.Windows.Forms.Button();
            this.tbxBLL = new System.Windows.Forms.TextBox();
            this.lblBLL = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnController = new System.Windows.Forms.Button();
            this.tbxController = new System.Windows.Forms.TextBox();
            this.lblController = new System.Windows.Forms.Label();
            this.cbxModel = new System.Windows.Forms.CheckBox();
            this.cbxDAL = new System.Windows.Forms.CheckBox();
            this.cbxBLL = new System.Windows.Forms.CheckBox();
            this.cbxController = new System.Windows.Forms.CheckBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.btnExit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbxView = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(35, 33);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(106, 17);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model 保存路径";
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(35, 53);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(588, 22);
            this.tbxModel.TabIndex = 1;
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(634, 52);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(75, 26);
            this.btnModel.TabIndex = 2;
            this.btnModel.Text = "选择...";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // btnDAL
            // 
            this.btnDAL.Location = new System.Drawing.Point(634, 149);
            this.btnDAL.Name = "btnDAL";
            this.btnDAL.Size = new System.Drawing.Size(75, 26);
            this.btnDAL.TabIndex = 5;
            this.btnDAL.Text = "选择...";
            this.btnDAL.UseVisualStyleBackColor = true;
            this.btnDAL.Click += new System.EventHandler(this.btnDAL_Click);
            // 
            // tbxDAL
            // 
            this.tbxDAL.Location = new System.Drawing.Point(35, 150);
            this.tbxDAL.Name = "tbxDAL";
            this.tbxDAL.Size = new System.Drawing.Size(588, 22);
            this.tbxDAL.TabIndex = 4;
            // 
            // lblDAL
            // 
            this.lblDAL.AutoSize = true;
            this.lblDAL.Location = new System.Drawing.Point(32, 130);
            this.lblDAL.Name = "lblDAL";
            this.lblDAL.Size = new System.Drawing.Size(95, 17);
            this.lblDAL.TabIndex = 3;
            this.lblDAL.Text = "DAL 保存路径";
            // 
            // btnBLL
            // 
            this.btnBLL.Location = new System.Drawing.Point(637, 251);
            this.btnBLL.Name = "btnBLL";
            this.btnBLL.Size = new System.Drawing.Size(75, 26);
            this.btnBLL.TabIndex = 8;
            this.btnBLL.Text = "选择...";
            this.btnBLL.UseVisualStyleBackColor = true;
            this.btnBLL.Click += new System.EventHandler(this.btnBLL_Click);
            // 
            // tbxBLL
            // 
            this.tbxBLL.Location = new System.Drawing.Point(38, 252);
            this.tbxBLL.Name = "tbxBLL";
            this.tbxBLL.Size = new System.Drawing.Size(588, 22);
            this.tbxBLL.TabIndex = 7;
            // 
            // lblBLL
            // 
            this.lblBLL.AutoSize = true;
            this.lblBLL.Location = new System.Drawing.Point(35, 232);
            this.lblBLL.Name = "lblBLL";
            this.lblBLL.Size = new System.Drawing.Size(93, 17);
            this.lblBLL.TabIndex = 6;
            this.lblBLL.Text = "BLL 保存路径";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(475, 424);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 26);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "生成(&B)";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(556, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnController
            // 
            this.btnController.Location = new System.Drawing.Point(637, 343);
            this.btnController.Name = "btnController";
            this.btnController.Size = new System.Drawing.Size(75, 26);
            this.btnController.TabIndex = 14;
            this.btnController.Text = "选择...";
            this.btnController.UseVisualStyleBackColor = true;
            this.btnController.Click += new System.EventHandler(this.btnController_Click);
            // 
            // tbxController
            // 
            this.tbxController.Location = new System.Drawing.Point(38, 344);
            this.tbxController.Name = "tbxController";
            this.tbxController.Size = new System.Drawing.Size(588, 22);
            this.tbxController.TabIndex = 13;
            // 
            // lblController
            // 
            this.lblController.AutoSize = true;
            this.lblController.Location = new System.Drawing.Point(35, 324);
            this.lblController.Name = "lblController";
            this.lblController.Size = new System.Drawing.Size(129, 17);
            this.lblController.TabIndex = 12;
            this.lblController.Text = "Controller 保存路径";
            // 
            // cbxModel
            // 
            this.cbxModel.AutoSize = true;
            this.cbxModel.Location = new System.Drawing.Point(35, 81);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(58, 21);
            this.cbxModel.TabIndex = 15;
            this.cbxModel.Text = "生成";
            this.cbxModel.UseVisualStyleBackColor = true;
            // 
            // cbxDAL
            // 
            this.cbxDAL.AutoSize = true;
            this.cbxDAL.Location = new System.Drawing.Point(35, 178);
            this.cbxDAL.Name = "cbxDAL";
            this.cbxDAL.Size = new System.Drawing.Size(58, 21);
            this.cbxDAL.TabIndex = 16;
            this.cbxDAL.Text = "生成";
            this.cbxDAL.UseVisualStyleBackColor = true;
            // 
            // cbxBLL
            // 
            this.cbxBLL.AutoSize = true;
            this.cbxBLL.Location = new System.Drawing.Point(38, 280);
            this.cbxBLL.Name = "cbxBLL";
            this.cbxBLL.Size = new System.Drawing.Size(58, 21);
            this.cbxBLL.TabIndex = 17;
            this.cbxBLL.Text = "生成";
            this.cbxBLL.UseVisualStyleBackColor = true;
            // 
            // cbxController
            // 
            this.cbxController.AutoSize = true;
            this.cbxController.Location = new System.Drawing.Point(38, 372);
            this.cbxController.Name = "cbxController";
            this.cbxController.Size = new System.Drawing.Size(58, 21);
            this.cbxController.TabIndex = 18;
            this.cbxController.Text = "生成";
            this.cbxController.UseVisualStyleBackColor = true;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(637, 424);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "退出(&X)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 426);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(406, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // cbxView
            // 
            this.cbxView.AutoSize = true;
            this.cbxView.Location = new System.Drawing.Point(106, 372);
            this.cbxView.Name = "cbxView";
            this.cbxView.Size = new System.Drawing.Size(144, 21);
            this.cbxView.TabIndex = 21;
            this.cbxView.Text = "生成 View (CRUD)";
            this.cbxView.UseVisualStyleBackColor = true;
            // 
            // BatchCodeDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 497);
            this.Controls.Add(this.cbxView);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbxController);
            this.Controls.Add(this.cbxBLL);
            this.Controls.Add(this.cbxDAL);
            this.Controls.Add(this.cbxModel);
            this.Controls.Add(this.btnController);
            this.Controls.Add(this.tbxController);
            this.Controls.Add(this.lblController);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBLL);
            this.Controls.Add(this.tbxBLL);
            this.Controls.Add(this.lblBLL);
            this.Controls.Add(this.btnDAL);
            this.Controls.Add(this.tbxDAL);
            this.Controls.Add(this.lblDAL);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.lblModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BatchCodeDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码批量生成";
            this.Load += new System.EventHandler(this.BatchCodeDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnDAL;
        private System.Windows.Forms.TextBox tbxDAL;
        private System.Windows.Forms.Label lblDAL;
        private System.Windows.Forms.Button btnBLL;
        private System.Windows.Forms.TextBox tbxBLL;
        private System.Windows.Forms.Label lblBLL;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnController;
        private System.Windows.Forms.TextBox tbxController;
        private System.Windows.Forms.Label lblController;
        private System.Windows.Forms.CheckBox cbxModel;
        private System.Windows.Forms.CheckBox cbxDAL;
        private System.Windows.Forms.CheckBox cbxBLL;
        private System.Windows.Forms.CheckBox cbxController;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox cbxView;
    }
}