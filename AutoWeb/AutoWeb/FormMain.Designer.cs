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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimernghi = new System.Windows.Forms.NumericUpDown();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.btnlaythongtinphat = new System.Windows.Forms.Button();
            this.listbuucuc = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpasschatluong = new System.Windows.Forms.TextBox();
            this.txttaikhoanchatluong = new System.Windows.Forms.TextBox();
            this.btnlaythongtinchatluong = new System.Windows.Forms.Button();
            this.txtngaychatluong = new System.Windows.Forms.DateTimePicker();
            this.btnchaylaithongtinphat = new System.Windows.Forms.Button();
            this.lblbuucuckhongsolieu = new System.Windows.Forms.Label();
            this.lblxuly = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttimernghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listbuucuc)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttungay
            // 
            this.txttungay.CustomFormat = "dd/MM/yyyy";
            this.txttungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txttungay.Location = new System.Drawing.Point(12, 30);
            this.txttungay.Name = "txttungay";
            this.txttungay.Size = new System.Drawing.Size(167, 20);
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
            this.tabPage1.Controls.Add(this.lblxuly);
            this.tabPage1.Controls.Add(this.lblbuucuckhongsolieu);
            this.tabPage1.Controls.Add(this.btnchaylaithongtinphat);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "MK :";
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
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(80, 474);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(208, 20);
            this.txtmatkhau.TabIndex = 112;
            this.txtmatkhau.Text = "123456";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(80, 447);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(208, 20);
            this.txttaikhoan.TabIndex = 111;
            this.txttaikhoan.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "(1000=1s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "Thời gian chờ dữ liệu hiển thị :";
            // 
            // txttimernghi
            // 
            this.txttimernghi.Location = new System.Drawing.Point(464, 28);
            this.txttimernghi.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txttimernghi.Name = "txttimernghi";
            this.txttimernghi.Size = new System.Drawing.Size(53, 20);
            this.txttimernghi.TabIndex = 108;
            this.txttimernghi.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
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
            // btnlaythongtinphat
            // 
            this.btnlaythongtinphat.Location = new System.Drawing.Point(188, 27);
            this.btnlaythongtinphat.Name = "btnlaythongtinphat";
            this.btnlaythongtinphat.Size = new System.Drawing.Size(100, 23);
            this.btnlaythongtinphat.TabIndex = 106;
            this.btnlaythongtinphat.Text = "Lấy thông tin";
            this.btnlaythongtinphat.UseVisualStyleBackColor = true;
            this.btnlaythongtinphat.Click += new System.EventHandler(this.btnlaythongtinphat_Click);
            // 
            // listbuucuc
            // 
            this.listbuucuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listbuucuc.Location = new System.Drawing.Point(8, 72);
            this.listbuucuc.Name = "listbuucuc";
            this.listbuucuc.Size = new System.Drawing.Size(280, 353);
            this.listbuucuc.TabIndex = 105;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtpasschatluong);
            this.tabPage2.Controls.Add(this.txttaikhoanchatluong);
            this.tabPage2.Controls.Add(this.btnlaythongtinchatluong);
            this.tabPage2.Controls.Add(this.txtngaychatluong);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "chatluong.vnpost.vn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "MK :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "TK :";
            // 
            // txtpasschatluong
            // 
            this.txtpasschatluong.Location = new System.Drawing.Point(83, 88);
            this.txtpasschatluong.Name = "txtpasschatluong";
            this.txtpasschatluong.Size = new System.Drawing.Size(216, 20);
            this.txtpasschatluong.TabIndex = 116;
            this.txtpasschatluong.Text = "123";
            // 
            // txttaikhoanchatluong
            // 
            this.txttaikhoanchatluong.Location = new System.Drawing.Point(83, 61);
            this.txttaikhoanchatluong.Name = "txttaikhoanchatluong";
            this.txttaikhoanchatluong.Size = new System.Drawing.Size(216, 20);
            this.txttaikhoanchatluong.TabIndex = 115;
            this.txttaikhoanchatluong.Text = "bccp1";
            // 
            // btnlaythongtinchatluong
            // 
            this.btnlaythongtinchatluong.Location = new System.Drawing.Point(345, 33);
            this.btnlaythongtinchatluong.Name = "btnlaythongtinchatluong";
            this.btnlaythongtinchatluong.Size = new System.Drawing.Size(100, 23);
            this.btnlaythongtinchatluong.TabIndex = 108;
            this.btnlaythongtinchatluong.Text = "Lấy thông tin";
            this.btnlaythongtinchatluong.UseVisualStyleBackColor = true;
            this.btnlaythongtinchatluong.Click += new System.EventHandler(this.btnlaythongtinchatluong_Click);
            // 
            // txtngaychatluong
            // 
            this.txtngaychatluong.CustomFormat = "dd/MM/yyyy";
            this.txtngaychatluong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngaychatluong.Location = new System.Drawing.Point(83, 32);
            this.txtngaychatluong.Name = "txtngaychatluong";
            this.txtngaychatluong.Size = new System.Drawing.Size(216, 20);
            this.txtngaychatluong.TabIndex = 107;
            // 
            // btnchaylaithongtinphat
            // 
            this.btnchaylaithongtinphat.Location = new System.Drawing.Point(583, 27);
            this.btnchaylaithongtinphat.Name = "btnchaylaithongtinphat";
            this.btnchaylaithongtinphat.Size = new System.Drawing.Size(197, 23);
            this.btnchaylaithongtinphat.TabIndex = 115;
            this.btnchaylaithongtinphat.Text = "Chạy lại bưu cục không có dữ liệu";
            this.btnchaylaithongtinphat.UseVisualStyleBackColor = true;
            this.btnchaylaithongtinphat.Click += new System.EventHandler(this.btnchaylaithongtinphat_Click);
            // 
            // lblbuucuckhongsolieu
            // 
            this.lblbuucuckhongsolieu.AutoSize = true;
            this.lblbuucuckhongsolieu.ForeColor = System.Drawing.Color.Red;
            this.lblbuucuckhongsolieu.Location = new System.Drawing.Point(312, 53);
            this.lblbuucuckhongsolieu.Name = "lblbuucuckhongsolieu";
            this.lblbuucuckhongsolieu.Size = new System.Drawing.Size(0, 13);
            this.lblbuucuckhongsolieu.TabIndex = 116;
            // 
            // lblxuly
            // 
            this.lblxuly.AutoSize = true;
            this.lblxuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxuly.ForeColor = System.Drawing.Color.Lime;
            this.lblxuly.Location = new System.Drawing.Point(644, 53);
            this.lblxuly.Name = "lblxuly";
            this.lblxuly.Size = new System.Drawing.Size(0, 13);
            this.lblxuly.TabIndex = 117;
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
            ((System.ComponentModel.ISupportInitialize)(this.txttimernghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listbuucuc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Button btnlaythongtinchatluong;
        private System.Windows.Forms.DateTimePicker txtngaychatluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpasschatluong;
        private System.Windows.Forms.TextBox txttaikhoanchatluong;
        private System.Windows.Forms.Button btnchaylaithongtinphat;
        private System.Windows.Forms.Label lblbuucuckhongsolieu;
        private System.Windows.Forms.Label lblxuly;
    }
}