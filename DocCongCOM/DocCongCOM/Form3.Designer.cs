namespace DocCongCOM
{
    partial class Form3
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.stb = new System.Windows.Forms.ComboBox();
            this.dtbits = new System.Windows.Forms.ComboBox();
            this.txtParity = new System.Windows.Forms.ComboBox();
            this.baudrt = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbbPorts = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnDis = new System.Windows.Forms.Button();
            this.txtRec = new System.Windows.Forms.RichTextBox();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtSoLieuDaXuLy = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_chay = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.stb);
            this.GroupBox2.Controls.Add(this.dtbits);
            this.GroupBox2.Controls.Add(this.txtParity);
            this.GroupBox2.Controls.Add(this.baudrt);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.cbbPorts);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.btnCon);
            this.GroupBox2.Controls.Add(this.btnDis);
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(171, 181);
            this.GroupBox2.TabIndex = 12;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Options";
            // 
            // stb
            // 
            this.stb.FormattingEnabled = true;
            this.stb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stb.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stb.Location = new System.Drawing.Point(80, 123);
            this.stb.Name = "stb";
            this.stb.Size = new System.Drawing.Size(78, 21);
            this.stb.TabIndex = 11;
            this.stb.Text = "1";
            // 
            // dtbits
            // 
            this.dtbits.FormattingEnabled = true;
            this.dtbits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dtbits.Location = new System.Drawing.Point(80, 96);
            this.dtbits.Name = "dtbits";
            this.dtbits.Size = new System.Drawing.Size(78, 21);
            this.dtbits.TabIndex = 10;
            this.dtbits.Text = "8";
            // 
            // txtParity
            // 
            this.txtParity.FormattingEnabled = true;
            this.txtParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.txtParity.Location = new System.Drawing.Point(80, 69);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(78, 21);
            this.txtParity.TabIndex = 9;
            this.txtParity.Text = "None";
            // 
            // baudrt
            // 
            this.baudrt.FormattingEnabled = true;
            this.baudrt.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "460800",
            "912600"});
            this.baudrt.Location = new System.Drawing.Point(80, 42);
            this.baudrt.Name = "baudrt";
            this.baudrt.Size = new System.Drawing.Size(78, 21);
            this.baudrt.TabIndex = 8;
            this.baudrt.Text = "9600";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 126);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 13);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Stop bits";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 99);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(49, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Data bits";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(33, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Parity";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Baud rate";
            // 
            // cbbPorts
            // 
            this.cbbPorts.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cbbPorts.FormattingEnabled = true;
            this.cbbPorts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbPorts.Location = new System.Drawing.Point(80, 15);
            this.cbbPorts.Name = "cbbPorts";
            this.cbbPorts.Size = new System.Drawing.Size(78, 21);
            this.cbbPorts.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(6, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "COM Port:";
            // 
            // btnCon
            // 
            this.btnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon.ForeColor = System.Drawing.Color.Red;
            this.btnCon.Location = new System.Drawing.Point(6, 150);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(71, 23);
            this.btnCon.TabIndex = 2;
            this.btnCon.Text = "Connect";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnDis
            // 
            this.btnDis.ForeColor = System.Drawing.Color.Blue;
            this.btnDis.Location = new System.Drawing.Point(83, 150);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(75, 23);
            this.btnDis.TabIndex = 3;
            this.btnDis.Text = "Disconnect";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // txtRec
            // 
            this.txtRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRec.Location = new System.Drawing.Point(189, 12);
            this.txtRec.Name = "txtRec";
            this.txtRec.ReadOnly = true;
            this.txtRec.Size = new System.Drawing.Size(309, 173);
            this.txtRec.TabIndex = 11;
            this.txtRec.Text = "";
            // 
            // txtSoLieuDaXuLy
            // 
            this.txtSoLieuDaXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLieuDaXuLy.Location = new System.Drawing.Point(21, 212);
            this.txtSoLieuDaXuLy.Name = "txtSoLieuDaXuLy";
            this.txtSoLieuDaXuLy.Size = new System.Drawing.Size(292, 44);
            this.txtSoLieuDaXuLy.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.Location = new System.Drawing.Point(333, 225);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(93, 44);
            this.btn_read.TabIndex = 22;
            this.btn_read.Text = "Đọc";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_chay
            // 
            this.btn_chay.Location = new System.Drawing.Point(333, 191);
            this.btn_chay.Name = "btn_chay";
            this.btn_chay.Size = new System.Drawing.Size(75, 23);
            this.btn_chay.TabIndex = 23;
            this.btn_chay.Text = "chạy";
            this.btn_chay.UseVisualStyleBackColor = true;
            this.btn_chay.Click += new System.EventHandler(this.btn_chay_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 281);
            this.Controls.Add(this.btn_chay);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.txtSoLieuDaXuLy);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtRec);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox stb;
        internal System.Windows.Forms.ComboBox dtbits;
        internal System.Windows.Forms.ComboBox txtParity;
        internal System.Windows.Forms.ComboBox baudrt;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cbbPorts;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnCon;
        internal System.Windows.Forms.Button btnDis;
        internal System.Windows.Forms.RichTextBox txtRec;
        internal System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.TextBox txtSoLieuDaXuLy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_chay;
    }
}