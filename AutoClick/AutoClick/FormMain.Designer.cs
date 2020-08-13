namespace AutoClick
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
            this.btnmoweb = new System.Windows.Forms.Button();
            this.btnclick = new System.Windows.Forms.Button();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.checklaytaikhoanmacdinh = new System.Windows.Forms.CheckBox();
            this.btnclickpixel = new System.Windows.Forms.Button();
            this.txtsolanlap = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlapduyet = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btncheckfinal = new System.Windows.Forms.Button();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtsolanlap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlapduyet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmoweb
            // 
            this.btnmoweb.Location = new System.Drawing.Point(95, 72);
            this.btnmoweb.Name = "btnmoweb";
            this.btnmoweb.Size = new System.Drawing.Size(113, 43);
            this.btnmoweb.TabIndex = 0;
            this.btnmoweb.Text = "Mở web";
            this.btnmoweb.UseVisualStyleBackColor = true;
            this.btnmoweb.Click += new System.EventHandler(this.btnmoweb_Click);
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(231, 72);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(101, 43);
            this.btnclick.TabIndex = 1;
            this.btnclick.Text = "Click";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Location = new System.Drawing.Point(100, 207);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(62, 13);
            this.lblthongbao.TabIndex = 2;
            this.lblthongbao.Text = "lblthongbao";
            // 
            // checklaytaikhoanmacdinh
            // 
            this.checklaytaikhoanmacdinh.AutoSize = true;
            this.checklaytaikhoanmacdinh.Location = new System.Drawing.Point(103, 41);
            this.checklaytaikhoanmacdinh.Name = "checklaytaikhoanmacdinh";
            this.checklaytaikhoanmacdinh.Size = new System.Drawing.Size(150, 17);
            this.checklaytaikhoanmacdinh.TabIndex = 3;
            this.checklaytaikhoanmacdinh.Text = "checklaytaikhoanmacdinh";
            this.checklaytaikhoanmacdinh.UseVisualStyleBackColor = true;
            // 
            // btnclickpixel
            // 
            this.btnclickpixel.Location = new System.Drawing.Point(380, 72);
            this.btnclickpixel.Name = "btnclickpixel";
            this.btnclickpixel.Size = new System.Drawing.Size(101, 43);
            this.btnclickpixel.TabIndex = 4;
            this.btnclickpixel.Text = "Click pixel";
            this.btnclickpixel.UseVisualStyleBackColor = true;
            this.btnclickpixel.Click += new System.EventHandler(this.btnclickpixel_Click);
            // 
            // txtsolanlap
            // 
            this.txtsolanlap.Location = new System.Drawing.Point(380, 43);
            this.txtsolanlap.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtsolanlap.Name = "txtsolanlap";
            this.txtsolanlap.Size = new System.Drawing.Size(101, 20);
            this.txtsolanlap.TabIndex = 5;
            this.txtsolanlap.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "so lan lap";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Click chữ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mở web";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "so lan lap";
            // 
            // txtlapduyet
            // 
            this.txtlapduyet.Location = new System.Drawing.Point(363, 266);
            this.txtlapduyet.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtlapduyet.Name = "txtlapduyet";
            this.txtlapduyet.Size = new System.Drawing.Size(101, 20);
            this.txtlapduyet.TabIndex = 9;
            this.txtlapduyet.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "Click số";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(231, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 43);
            this.button4.TabIndex = 12;
            this.button4.Text = "Click check";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btncheckfinal
            // 
            this.btncheckfinal.Location = new System.Drawing.Point(231, 303);
            this.btncheckfinal.Name = "btncheckfinal";
            this.btncheckfinal.Size = new System.Drawing.Size(101, 43);
            this.btncheckfinal.TabIndex = 13;
            this.btncheckfinal.Text = "Check final";
            this.btncheckfinal.UseVisualStyleBackColor = true;
            this.btncheckfinal.Click += new System.EventHandler(this.btncheckfinal_Click);
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(352, 315);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(100, 20);
            this.txtngaysinh.TabIndex = 14;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 374);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.btncheckfinal);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlapduyet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsolanlap);
            this.Controls.Add(this.btnclickpixel);
            this.Controls.Add(this.checklaytaikhoanmacdinh);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.btnclick);
            this.Controls.Add(this.btnmoweb);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtsolanlap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlapduyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmoweb;
        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.CheckBox checklaytaikhoanmacdinh;
        private System.Windows.Forms.Button btnclickpixel;
        private System.Windows.Forms.NumericUpDown txtsolanlap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtlapduyet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btncheckfinal;
        private System.Windows.Forms.TextBox txtngaysinh;
    }
}