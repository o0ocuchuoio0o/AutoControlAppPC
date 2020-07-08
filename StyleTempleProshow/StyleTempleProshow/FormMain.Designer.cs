namespace StyleTempleProshow
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
            this.btnchonfile = new System.Windows.Forms.Button();
            this.ListDuLieu = new System.Windows.Forms.DataGridView();
            this.btnthaychuoi = new System.Windows.Forms.Button();
            this.txtgoc = new System.Windows.Forms.TextBox();
            this.txtthaydoi = new System.Windows.Forms.TextBox();
            this.cmbstyle = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtintro = new System.Windows.Forms.TextBox();
            this.txtouttro = new System.Windows.Forms.TextBox();
            this.txtanh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvoice = new System.Windows.Forms.TextBox();
            this.txtvideobg = new System.Windows.Forms.TextBox();
            this.btntaopsh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmusicbg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsub = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListDuLieu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnchonfile
            // 
            this.btnchonfile.Location = new System.Drawing.Point(52, 12);
            this.btnchonfile.Name = "btnchonfile";
            this.btnchonfile.Size = new System.Drawing.Size(75, 23);
            this.btnchonfile.TabIndex = 0;
            this.btnchonfile.Text = "Chọn file";
            this.btnchonfile.UseVisualStyleBackColor = true;
            this.btnchonfile.Click += new System.EventHandler(this.btnchonfile_Click);
            // 
            // ListDuLieu
            // 
            this.ListDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDuLieu.Location = new System.Drawing.Point(6, 24);
            this.ListDuLieu.Name = "ListDuLieu";
            this.ListDuLieu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListDuLieu.Size = new System.Drawing.Size(901, 365);
            this.ListDuLieu.TabIndex = 1;
            // 
            // btnthaychuoi
            // 
            this.btnthaychuoi.Location = new System.Drawing.Point(190, 13);
            this.btnthaychuoi.Name = "btnthaychuoi";
            this.btnthaychuoi.Size = new System.Drawing.Size(75, 23);
            this.btnthaychuoi.TabIndex = 2;
            this.btnthaychuoi.Text = "Thay chuỗi";
            this.btnthaychuoi.UseVisualStyleBackColor = true;
            this.btnthaychuoi.Click += new System.EventHandler(this.btnthaychuoi_Click);
            // 
            // txtgoc
            // 
            this.txtgoc.Location = new System.Drawing.Point(136, 15);
            this.txtgoc.Name = "txtgoc";
            this.txtgoc.Size = new System.Drawing.Size(48, 20);
            this.txtgoc.TabIndex = 3;
            this.txtgoc.Text = "cell[0]";
            // 
            // txtthaydoi
            // 
            this.txtthaydoi.Location = new System.Drawing.Point(271, 15);
            this.txtthaydoi.Name = "txtthaydoi";
            this.txtthaydoi.Size = new System.Drawing.Size(48, 20);
            this.txtthaydoi.TabIndex = 4;
            this.txtthaydoi.Text = "cell[i]";
            // 
            // cmbstyle
            // 
            this.cmbstyle.FormattingEnabled = true;
            this.cmbstyle.Location = new System.Drawing.Point(325, 15);
            this.cmbstyle.Name = "cmbstyle";
            this.cmbstyle.Size = new System.Drawing.Size(121, 21);
            this.cmbstyle.TabIndex = 5;
            this.cmbstyle.SelectedIndexChanged += new System.EventHandler(this.cmbstyle_SelectedIndexChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(452, 14);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(551, 15);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 421);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListDuLieu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông số";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtsub);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtmusicbg);
            this.tabPage2.Controls.Add(this.btntaopsh);
            this.tabPage2.Controls.Add(this.txtvideobg);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtvoice);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtanh);
            this.tabPage2.Controls.Add(this.txtouttro);
            this.tabPage2.Controls.Add(this.txtintro);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tạo file psh thử";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtintro
            // 
            this.txtintro.Location = new System.Drawing.Point(174, 63);
            this.txtintro.Name = "txtintro";
            this.txtintro.Size = new System.Drawing.Size(411, 20);
            this.txtintro.TabIndex = 0;
            this.txtintro.Text = "D:\\video\\intro.mp4";
            // 
            // txtouttro
            // 
            this.txtouttro.Location = new System.Drawing.Point(174, 117);
            this.txtouttro.Name = "txtouttro";
            this.txtouttro.Size = new System.Drawing.Size(411, 20);
            this.txtouttro.TabIndex = 1;
            this.txtouttro.Text = "D:\\video\\intro.mp4";
            // 
            // txtanh
            // 
            this.txtanh.Location = new System.Drawing.Point(174, 165);
            this.txtanh.Name = "txtanh";
            this.txtanh.Size = new System.Drawing.Size(411, 20);
            this.txtanh.TabIndex = 2;
            this.txtanh.Text = "D:\\video\\imageload1.jpeg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "intro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "outtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ảnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "video nền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "voice";
            // 
            // txtvoice
            // 
            this.txtvoice.Location = new System.Drawing.Point(174, 256);
            this.txtvoice.Name = "txtvoice";
            this.txtvoice.Size = new System.Drawing.Size(411, 20);
            this.txtvoice.TabIndex = 7;
            this.txtvoice.Text = "D:\\video\\11176998.wav";
            // 
            // txtvideobg
            // 
            this.txtvideobg.Location = new System.Drawing.Point(174, 212);
            this.txtvideobg.Name = "txtvideobg";
            this.txtvideobg.Size = new System.Drawing.Size(411, 20);
            this.txtvideobg.TabIndex = 9;
            this.txtvideobg.Text = "D:\\video\\bg.mp4";
            // 
            // btntaopsh
            // 
            this.btntaopsh.Location = new System.Drawing.Point(643, 117);
            this.btntaopsh.Name = "btntaopsh";
            this.btntaopsh.Size = new System.Drawing.Size(150, 54);
            this.btntaopsh.TabIndex = 10;
            this.btntaopsh.Text = "Tạo PSH";
            this.btntaopsh.UseVisualStyleBackColor = true;
            this.btntaopsh.Click += new System.EventHandler(this.btntaopsh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "nhạc nền";
            // 
            // txtmusicbg
            // 
            this.txtmusicbg.Location = new System.Drawing.Point(174, 295);
            this.txtmusicbg.Name = "txtmusicbg";
            this.txtmusicbg.Size = new System.Drawing.Size(411, 20);
            this.txtmusicbg.TabIndex = 11;
            this.txtmusicbg.Text = "D:\\video\\bg.mp3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ảnh sub";
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(174, 332);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(411, 20);
            this.txtsub.TabIndex = 13;
            this.txtsub.Text = "D:\\video\\1ps.PNG";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 488);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cmbstyle);
            this.Controls.Add(this.txtthaydoi);
            this.Controls.Add(this.txtgoc);
            this.Controls.Add(this.btnthaychuoi);
            this.Controls.Add(this.btnchonfile);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDuLieu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchonfile;
        private System.Windows.Forms.DataGridView ListDuLieu;
        private System.Windows.Forms.Button btnthaychuoi;
        private System.Windows.Forms.TextBox txtgoc;
        private System.Windows.Forms.TextBox txtthaydoi;
        private System.Windows.Forms.ComboBox cmbstyle;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtvideobg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtanh;
        private System.Windows.Forms.TextBox txtouttro;
        private System.Windows.Forms.TextBox txtintro;
        private System.Windows.Forms.Button btntaopsh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmusicbg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsub;
    }
}