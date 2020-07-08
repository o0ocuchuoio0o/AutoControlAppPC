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
            ((System.ComponentModel.ISupportInitialize)(this.txtsolanlap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmoweb
            // 
            this.btnmoweb.Location = new System.Drawing.Point(100, 142);
            this.btnmoweb.Name = "btnmoweb";
            this.btnmoweb.Size = new System.Drawing.Size(113, 43);
            this.btnmoweb.TabIndex = 0;
            this.btnmoweb.Text = "Mở web";
            this.btnmoweb.UseVisualStyleBackColor = true;
            this.btnmoweb.Click += new System.EventHandler(this.btnmoweb_Click);
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(236, 142);
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
            this.btnclickpixel.Location = new System.Drawing.Point(385, 142);
            this.btnclickpixel.Name = "btnclickpixel";
            this.btnclickpixel.Size = new System.Drawing.Size(101, 43);
            this.btnclickpixel.TabIndex = 4;
            this.btnclickpixel.Text = "Click pixel";
            this.btnclickpixel.UseVisualStyleBackColor = true;
            this.btnclickpixel.Click += new System.EventHandler(this.btnclickpixel_Click);
            // 
            // txtsolanlap
            // 
            this.txtsolanlap.Location = new System.Drawing.Point(385, 113);
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
            this.label1.Location = new System.Drawing.Point(382, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "so lan lap";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 344);
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
    }
}