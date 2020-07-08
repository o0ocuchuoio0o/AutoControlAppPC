namespace AutoFB
{
    partial class CauHinhGiaLap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauHinhGiaLap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titlebar = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListTaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexportapk = new System.Windows.Forms.Button();
            this.btnresetapk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpathsavedata = new System.Windows.Forms.PictureBox();
            this.txtsavedata = new System.Windows.Forms.TextBox();
            this.ListTaiKhoanFB = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListTaiKhoan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnpathsavedata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListTaiKhoanFB)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.titlebar.Controls.Add(this.lbltitle);
            this.titlebar.Controls.Add(this.btnclose);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(873, 50);
            this.titlebar.TabIndex = 9;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseDown);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(13, 13);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(0, 22);
            this.lbltitle.TabIndex = 10;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(849, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(16, 18);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 9;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListTaiKhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 475);
            this.panel1.TabIndex = 10;
            // 
            // ListTaiKhoan
            // 
            this.ListTaiKhoan.AllowUserToAddRows = false;
            this.ListTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(140)))));
            this.ListTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListTaiKhoan.DefaultCellStyle = dataGridViewCellStyle7;
            this.ListTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListTaiKhoan.GridColor = System.Drawing.Color.DodgerBlue;
            this.ListTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.ListTaiKhoan.MultiSelect = false;
            this.ListTaiKhoan.Name = "ListTaiKhoan";
            this.ListTaiKhoan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.ListTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.ListTaiKhoan.Size = new System.Drawing.Size(539, 475);
            this.ListTaiKhoan.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.btnexportapk);
            this.panel2.Controls.Add(this.btnresetapk);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnpathsavedata);
            this.panel2.Controls.Add(this.txtsavedata);
            this.panel2.Controls.Add(this.ListTaiKhoanFB);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(539, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 475);
            this.panel2.TabIndex = 11;
            // 
            // btnexportapk
            // 
            this.btnexportapk.BackColor = System.Drawing.Color.Green;
            this.btnexportapk.FlatAppearance.BorderSize = 0;
            this.btnexportapk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportapk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportapk.ForeColor = System.Drawing.Color.White;
            this.btnexportapk.Image = ((System.Drawing.Image)(resources.GetObject("btnexportapk.Image")));
            this.btnexportapk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexportapk.Location = new System.Drawing.Point(216, 422);
            this.btnexportapk.Name = "btnexportapk";
            this.btnexportapk.Size = new System.Drawing.Size(106, 23);
            this.btnexportapk.TabIndex = 20;
            this.btnexportapk.Text = "Export apk";
            this.btnexportapk.UseVisualStyleBackColor = false;
            this.btnexportapk.Click += new System.EventHandler(this.btnexportapk_Click);
            // 
            // btnresetapk
            // 
            this.btnresetapk.BackColor = System.Drawing.Color.Green;
            this.btnresetapk.FlatAppearance.BorderSize = 0;
            this.btnresetapk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresetapk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetapk.ForeColor = System.Drawing.Color.White;
            this.btnresetapk.Image = ((System.Drawing.Image)(resources.GetObject("btnresetapk.Image")));
            this.btnresetapk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresetapk.Location = new System.Drawing.Point(102, 422);
            this.btnresetapk.Name = "btnresetapk";
            this.btnresetapk.Size = new System.Drawing.Size(108, 23);
            this.btnresetapk.TabIndex = 19;
            this.btnresetapk.Text = "Reset apk";
            this.btnresetapk.UseVisualStyleBackColor = false;
            this.btnresetapk.Click += new System.EventHandler(this.btnresetapk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Floder APK";
            // 
            // btnpathsavedata
            // 
            this.btnpathsavedata.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnpathsavedata.Image = ((System.Drawing.Image)(resources.GetObject("btnpathsavedata.Image")));
            this.btnpathsavedata.Location = new System.Drawing.Point(298, 447);
            this.btnpathsavedata.Name = "btnpathsavedata";
            this.btnpathsavedata.Size = new System.Drawing.Size(24, 25);
            this.btnpathsavedata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnpathsavedata.TabIndex = 17;
            this.btnpathsavedata.TabStop = false;
            this.btnpathsavedata.Click += new System.EventHandler(this.btnpathsavedata_Click);
            // 
            // txtsavedata
            // 
            this.txtsavedata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtsavedata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsavedata.Enabled = false;
            this.txtsavedata.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsavedata.ForeColor = System.Drawing.Color.White;
            this.txtsavedata.Location = new System.Drawing.Point(102, 449);
            this.txtsavedata.Name = "txtsavedata";
            this.txtsavedata.Size = new System.Drawing.Size(194, 20);
            this.txtsavedata.TabIndex = 16;
            // 
            // ListTaiKhoanFB
            // 
            this.ListTaiKhoanFB.AllowUserToAddRows = false;
            this.ListTaiKhoanFB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ListTaiKhoanFB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTaiKhoanFB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListTaiKhoanFB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListTaiKhoanFB.DefaultCellStyle = dataGridViewCellStyle10;
            this.ListTaiKhoanFB.GridColor = System.Drawing.Color.DodgerBlue;
            this.ListTaiKhoanFB.Location = new System.Drawing.Point(6, 3);
            this.ListTaiKhoanFB.Name = "ListTaiKhoanFB";
            this.ListTaiKhoanFB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListTaiKhoanFB.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.ListTaiKhoanFB.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.ListTaiKhoanFB.Size = new System.Drawing.Size(320, 337);
            this.ListTaiKhoanFB.TabIndex = 15;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(6, 362);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(134, 28);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Go to phone";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // CauHinhGiaLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(873, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CauHinhGiaLap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CauHinhGiaLap";
            this.Load += new System.EventHandler(this.CauHinhGiaLap_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CauHinhGiaLap_MouseDown);
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListTaiKhoan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnpathsavedata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListTaiKhoanFB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListTaiKhoan;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView ListTaiKhoanFB;
        private System.Windows.Forms.PictureBox btnpathsavedata;
        private System.Windows.Forms.TextBox txtsavedata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexportapk;
        private System.Windows.Forms.Button btnresetapk;
    }
}