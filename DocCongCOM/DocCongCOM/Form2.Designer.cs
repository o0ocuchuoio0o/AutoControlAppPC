namespace DocCongCOM
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.txtSoLieuDaXuLy = new System.Windows.Forms.TextBox();
            this.cbbPort = new System.Windows.Forms.ComboBox();
            this.btn_ghi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbTrongLuong = new System.Windows.Forms.RichTextBox();
            this.btn_dung = new System.Windows.Forms.Button();
            this.btn_chay = new System.Windows.Forms.Button();
            this.txt_so = new System.Windows.Forms.TextBox();
            this.txtSoLieuDong2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoLieuDaXuLy
            // 
            this.txtSoLieuDaXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLieuDaXuLy.Location = new System.Drawing.Point(330, 175);
            this.txtSoLieuDaXuLy.Name = "txtSoLieuDaXuLy";
            this.txtSoLieuDaXuLy.Size = new System.Drawing.Size(546, 26);
            this.txtSoLieuDaXuLy.TabIndex = 27;
            // 
            // cbbPort
            // 
            this.cbbPort.FormattingEnabled = true;
            this.cbbPort.Location = new System.Drawing.Point(409, 12);
            this.cbbPort.Name = "cbbPort";
            this.cbbPort.Size = new System.Drawing.Size(110, 21);
            this.cbbPort.TabIndex = 26;
            // 
            // btn_ghi
            // 
            this.btn_ghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghi.Location = new System.Drawing.Point(479, 57);
            this.btn_ghi.Name = "btn_ghi";
            this.btn_ghi.Size = new System.Drawing.Size(110, 49);
            this.btn_ghi.TabIndex = 24;
            this.btn_ghi.Text = "Đọc dữ liệu";
            this.btn_ghi.UseVisualStyleBackColor = true;
            this.btn_ghi.Click += new System.EventHandler(this.btn_ghi_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 2400;
            this.serialPort1.PortName = "COM3";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(435, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(342, 119);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(330, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Trọng lượng";
            // 
            // rtbTrongLuong
            // 
            this.rtbTrongLuong.Location = new System.Drawing.Point(12, 12);
            this.rtbTrongLuong.Name = "rtbTrongLuong";
            this.rtbTrongLuong.Size = new System.Drawing.Size(312, 339);
            this.rtbTrongLuong.TabIndex = 28;
            this.rtbTrongLuong.Text = "";
            // 
            // btn_dung
            // 
            this.btn_dung.Location = new System.Drawing.Point(610, 122);
            this.btn_dung.Name = "btn_dung";
            this.btn_dung.Size = new System.Drawing.Size(75, 23);
            this.btn_dung.TabIndex = 29;
            this.btn_dung.Text = "Dừng";
            this.btn_dung.UseVisualStyleBackColor = true;
            this.btn_dung.Click += new System.EventHandler(this.btn_dung_Click);
            // 
            // btn_chay
            // 
            this.btn_chay.Location = new System.Drawing.Point(610, 83);
            this.btn_chay.Name = "btn_chay";
            this.btn_chay.Size = new System.Drawing.Size(75, 23);
            this.btn_chay.TabIndex = 30;
            this.btn_chay.Text = "Chạy";
            this.btn_chay.UseVisualStyleBackColor = true;
            this.btn_chay.Click += new System.EventHandler(this.btn_chay_Click);
            // 
            // txt_so
            // 
            this.txt_so.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_so.Location = new System.Drawing.Point(330, 253);
            this.txt_so.Name = "txt_so";
            this.txt_so.Size = new System.Drawing.Size(274, 26);
            this.txt_so.TabIndex = 31;
            // 
            // txtSoLieuDong2
            // 
            this.txtSoLieuDong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLieuDong2.Location = new System.Drawing.Point(330, 207);
            this.txtSoLieuDong2.Name = "txtSoLieuDong2";
            this.txtSoLieuDong2.Size = new System.Drawing.Size(546, 26);
            this.txtSoLieuDong2.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSoLieuDong2);
            this.Controls.Add(this.txt_so);
            this.Controls.Add(this.btn_chay);
            this.Controls.Add(this.btn_dung);
            this.Controls.Add(this.rtbTrongLuong);
            this.Controls.Add(this.txtSoLieuDaXuLy);
            this.Controls.Add(this.cbbPort);
            this.Controls.Add(this.btn_ghi);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoLieuDaXuLy;
        private System.Windows.Forms.ComboBox cbbPort;
        private System.Windows.Forms.Button btn_ghi;
        private System.Windows.Forms.Timer timer1;
        internal System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbTrongLuong;
        private System.Windows.Forms.Button btn_dung;
        private System.Windows.Forms.Button btn_chay;
        private System.Windows.Forms.TextBox txt_so;
        private System.Windows.Forms.TextBox txtSoLieuDong2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}