namespace AutoWeb
{
    partial class FormMain
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
            this.txttungay = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listbuucuc = new System.Windows.Forms.DataGridView();
            this.btnlaythongtinphat = new System.Windows.Forms.Button();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.txttimernghi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listbuucuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttimernghi)).BeginInit();
            this.SuspendLayout();
            // 
            // txttungay
            // 
            this.txttungay.CustomFormat = "dd/MM/yyyy";
            this.txttungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txttungay.Location = new System.Drawing.Point(51, 27);
            this.txttungay.Name = "txttungay";
            this.txttungay.Size = new System.Drawing.Size(216, 20);
            this.txttungay.TabIndex = 104;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 539);
            this.tabControl1.TabIndex = 105;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtmatkhau);
            this.tabPage1.Controls.Add(this.txttaikhoan);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txttimernghi);
            this.tabPage1.Controls.Add(this.txtlog);
            this.tabPage1.Controls.Add(this.btnlaythongtinphat);
            this.tabPage1.Controls.Add(this.listbuucuc);
            this.tabPage1.Controls.Add(this.txttungay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thongtinphat.vnpost.vn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listbuucuc
            // 
            this.listbuucuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listbuucuc.Location = new System.Drawing.Point(8, 72);
            this.listbuucuc.Name = "listbuucuc";
            this.listbuucuc.Size = new System.Drawing.Size(280, 353);
            this.listbuucuc.TabIndex = 105;
            // 
            // btnlaythongtinphat
            // 
            this.btnlaythongtinphat.Location = new System.Drawing.Point(290, 27);
            this.btnlaythongtinphat.Name = "btnlaythongtinphat";
            this.btnlaythongtinphat.Size = new System.Drawing.Size(100, 23);
            this.btnlaythongtinphat.TabIndex = 106;
            this.btnlaythongtinphat.Text = "Lấy thông tin";
            this.btnlaythongtinphat.UseVisualStyleBackColor = true;
            this.btnlaythongtinphat.Click += new System.EventHandler(this.btnlaythongtinphat_Click);
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(312, 72);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtlog.Size = new System.Drawing.Size(498, 433);
            this.txtlog.TabIndex = 107;
            // 
            // txttimernghi
            // 
            this.txttimernghi.Location = new System.Drawing.Point(570, 30);
            this.txttimernghi.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txttimernghi.Name = "txttimernghi";
            this.txttimernghi.Size = new System.Drawing.Size(120, 20);
            this.txttimernghi.TabIndex = 108;
            this.txttimernghi.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "Thời gian chờ dữ liệu hiển thị :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "(1000=1s)";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(80, 447);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(208, 20);
            this.txttaikhoan.TabIndex = 111;
            this.txttaikhoan.Text = "10";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(80, 474);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(208, 20);
            this.txtmatkhau.TabIndex = 112;
            this.txtmatkhau.Text = "123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "TK :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "MK :";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listbuucuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttimernghi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txttungay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView listbuucuc;
        private System.Windows.Forms.Button btnlaythongtinphat;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txttimernghi;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}