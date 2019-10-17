namespace CodeMagic.Dialogs
{
    partial class DefaultCodeCreateDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultCodeCreateDialogForm));
            this.lbxLeft = new System.Windows.Forms.ListBox();
            this.lbxRight = new System.Windows.Forms.ListBox();
            this.btnALLIn = new System.Windows.Forms.Button();
            this.btnOneIn = new System.Windows.Forms.Button();
            this.btnOneOut = new System.Windows.Forms.Button();
            this.btnALLOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnSelModel = new System.Windows.Forms.Button();
            this.btnSelDAL = new System.Windows.Forms.Button();
            this.btnSelBLL = new System.Windows.Forms.Button();
            this.btnSelUI = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxLeft
            // 
            this.lbxLeft.FormattingEnabled = true;
            this.lbxLeft.Location = new System.Drawing.Point(17, 17);
            this.lbxLeft.Name = "lbxLeft";
            this.lbxLeft.Size = new System.Drawing.Size(234, 199);
            this.lbxLeft.TabIndex = 0;
            // 
            // lbxRight
            // 
            this.lbxRight.FormattingEnabled = true;
            this.lbxRight.Location = new System.Drawing.Point(373, 17);
            this.lbxRight.Name = "lbxRight";
            this.lbxRight.Size = new System.Drawing.Size(234, 199);
            this.lbxRight.TabIndex = 1;
            // 
            // btnALLIn
            // 
            this.btnALLIn.Location = new System.Drawing.Point(275, 33);
            this.btnALLIn.Name = "btnALLIn";
            this.btnALLIn.Size = new System.Drawing.Size(75, 26);
            this.btnALLIn.TabIndex = 2;
            this.btnALLIn.Text = ">>";
            this.btnALLIn.UseVisualStyleBackColor = true;
            this.btnALLIn.Click += new System.EventHandler(this.btnALLIn_Click);
            // 
            // btnOneIn
            // 
            this.btnOneIn.Location = new System.Drawing.Point(275, 65);
            this.btnOneIn.Name = "btnOneIn";
            this.btnOneIn.Size = new System.Drawing.Size(75, 26);
            this.btnOneIn.TabIndex = 3;
            this.btnOneIn.Text = ">";
            this.btnOneIn.UseVisualStyleBackColor = true;
            this.btnOneIn.Click += new System.EventHandler(this.btnOneIn_Click);
            // 
            // btnOneOut
            // 
            this.btnOneOut.Location = new System.Drawing.Point(275, 97);
            this.btnOneOut.Name = "btnOneOut";
            this.btnOneOut.Size = new System.Drawing.Size(75, 26);
            this.btnOneOut.TabIndex = 4;
            this.btnOneOut.Text = "<";
            this.btnOneOut.UseVisualStyleBackColor = true;
            this.btnOneOut.Click += new System.EventHandler(this.btnOneOut_Click);
            // 
            // btnALLOut
            // 
            this.btnALLOut.Location = new System.Drawing.Point(275, 129);
            this.btnALLOut.Name = "btnALLOut";
            this.btnALLOut.Size = new System.Drawing.Size(75, 26);
            this.btnALLOut.TabIndex = 5;
            this.btnALLOut.Text = "<<";
            this.btnALLOut.UseVisualStyleBackColor = true;
            this.btnALLOut.Click += new System.EventHandler(this.btnALLOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.btnSelUI);
            this.groupBox1.Controls.Add(this.btnSelBLL);
            this.groupBox1.Controls.Add(this.btnSelDAL);
            this.groupBox1.Controls.Add(this.btnSelModel);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(532, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 395);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(408, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Image = global::CodeMagic.Properties.Resources.ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(451, 393);
            this.btnOk.Name = "btnOk";
            this.btnOk.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnOk.Size = new System.Drawing.Size(75, 26);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "生成(&B)";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(422, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DAL";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(422, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BLL";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(65, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(422, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "UI";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(65, 127);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "AdminLTE2";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(151, 127);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "SB-Admin2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnSelModel
            // 
            this.btnSelModel.Location = new System.Drawing.Point(493, 20);
            this.btnSelModel.Name = "btnSelModel";
            this.btnSelModel.Size = new System.Drawing.Size(75, 23);
            this.btnSelModel.TabIndex = 10;
            this.btnSelModel.Text = "选择...";
            this.btnSelModel.UseVisualStyleBackColor = true;
            // 
            // btnSelDAL
            // 
            this.btnSelDAL.Location = new System.Drawing.Point(493, 46);
            this.btnSelDAL.Name = "btnSelDAL";
            this.btnSelDAL.Size = new System.Drawing.Size(75, 23);
            this.btnSelDAL.TabIndex = 11;
            this.btnSelDAL.Text = "选择...";
            this.btnSelDAL.UseVisualStyleBackColor = true;
            // 
            // btnSelBLL
            // 
            this.btnSelBLL.Location = new System.Drawing.Point(493, 72);
            this.btnSelBLL.Name = "btnSelBLL";
            this.btnSelBLL.Size = new System.Drawing.Size(75, 23);
            this.btnSelBLL.TabIndex = 12;
            this.btnSelBLL.Text = "选择...";
            this.btnSelBLL.UseVisualStyleBackColor = true;
            // 
            // btnSelUI
            // 
            this.btnSelUI.Location = new System.Drawing.Point(493, 98);
            this.btnSelUI.Name = "btnSelUI";
            this.btnSelUI.Size = new System.Drawing.Size(75, 23);
            this.btnSelUI.TabIndex = 13;
            this.btnSelUI.Text = "选择...";
            this.btnSelUI.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(234, 127);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "不生成UI";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // DefaultCodeCreateDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnALLOut);
            this.Controls.Add(this.btnOneOut);
            this.Controls.Add(this.btnOneIn);
            this.Controls.Add(this.btnALLIn);
            this.Controls.Add(this.lbxRight);
            this.Controls.Add(this.lbxLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DefaultCodeCreateDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "默认代码生成器";
            this.Load += new System.EventHandler(this.DefaultCodeCreateDialogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxLeft;
        private System.Windows.Forms.ListBox lbxRight;
        private System.Windows.Forms.Button btnALLIn;
        private System.Windows.Forms.Button btnOneIn;
        private System.Windows.Forms.Button btnOneOut;
        private System.Windows.Forms.Button btnALLOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelUI;
        private System.Windows.Forms.Button btnSelBLL;
        private System.Windows.Forms.Button btnSelDAL;
        private System.Windows.Forms.Button btnSelModel;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}