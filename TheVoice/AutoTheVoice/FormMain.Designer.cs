namespace AutoTheVoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelBarTitle = new System.Windows.Forms.Panel();
            this.btnmaximi = new System.Windows.Forms.PictureBox();
            this.btnminima = new System.Windows.Forms.PictureBox();
            this.btnres = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnchaylayvoice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelBarTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarTitle
            // 
            this.panelBarTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBarTitle.Controls.Add(this.btnmaximi);
            this.panelBarTitle.Controls.Add(this.btnminima);
            this.panelBarTitle.Controls.Add(this.btnres);
            this.panelBarTitle.Controls.Add(this.btnclose);
            this.panelBarTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarTitle.Location = new System.Drawing.Point(0, 0);
            this.panelBarTitle.Name = "panelBarTitle";
            this.panelBarTitle.Size = new System.Drawing.Size(967, 30);
            this.panelBarTitle.TabIndex = 1;
            this.panelBarTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarTitle_MouseDown);
            // 
            // btnmaximi
            // 
            this.btnmaximi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnmaximi.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximi.Image")));
            this.btnmaximi.Location = new System.Drawing.Point(906, 1);
            this.btnmaximi.Name = "btnmaximi";
            this.btnmaximi.Size = new System.Drawing.Size(25, 25);
            this.btnmaximi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximi.TabIndex = 7;
            this.btnmaximi.TabStop = false;
            this.btnmaximi.Click += new System.EventHandler(this.btnmaximi_Click);
            // 
            // btnminima
            // 
            this.btnminima.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnminima.Image = ((System.Drawing.Image)(resources.GetObject("btnminima.Image")));
            this.btnminima.Location = new System.Drawing.Point(875, 1);
            this.btnminima.Name = "btnminima";
            this.btnminima.Size = new System.Drawing.Size(25, 25);
            this.btnminima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminima.TabIndex = 6;
            this.btnminima.TabStop = false;
            this.btnminima.Click += new System.EventHandler(this.btnminima_Click);
            // 
            // btnres
            // 
            this.btnres.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnres.Image = ((System.Drawing.Image)(resources.GetObject("btnres.Image")));
            this.btnres.Location = new System.Drawing.Point(906, 2);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(25, 25);
            this.btnres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnres.TabIndex = 5;
            this.btnres.TabStop = false;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(937, 1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(25, 25);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 4;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnchaylayvoice);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 442);
            this.panelMenu.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sản phẩm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 32);
            this.panel1.TabIndex = 1;
            // 
            // btnchaylayvoice
            // 
            this.btnchaylayvoice.FlatAppearance.BorderSize = 0;
            this.btnchaylayvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnchaylayvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchaylayvoice.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchaylayvoice.ForeColor = System.Drawing.Color.White;
            this.btnchaylayvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnchaylayvoice.Image")));
            this.btnchaylayvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchaylayvoice.Location = new System.Drawing.Point(10, 101);
            this.btnchaylayvoice.Name = "btnchaylayvoice";
            this.btnchaylayvoice.Size = new System.Drawing.Size(205, 32);
            this.btnchaylayvoice.TabIndex = 0;
            this.btnchaylayvoice.Text = "Chạy lấy voice";
            this.btnchaylayvoice.UseVisualStyleBackColor = true;
            this.btnchaylayvoice.Click += new System.EventHandler(this.btnchaylayvoice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Location = new System.Drawing.Point(219, 28);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(748, 419);
            this.panelContent.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(967, 472);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBarTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelBarTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnchaylayvoice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox btnmaximi;
        private System.Windows.Forms.PictureBox btnminima;
        private System.Windows.Forms.PictureBox btnres;
        private System.Windows.Forms.PictureBox btnclose;
    }
}