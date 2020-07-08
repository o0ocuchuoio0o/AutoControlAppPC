namespace AutoFB
{
    partial class UC_Emulator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Emulator));
            this.btnsetting = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnsetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsetting
            // 
            this.btnsetting.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsetting.Image = ((System.Drawing.Image)(resources.GetObject("btnsetting.Image")));
            this.btnsetting.Location = new System.Drawing.Point(6, 417);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(24, 25);
            this.btnsetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsetting.TabIndex = 2;
            this.btnsetting.TabStop = false;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(207, 418);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(24, 25);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 1;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(36, 421);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 20);
            this.lblname.TabIndex = 3;
            // 
            // UC_Emulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(140)))));
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnsetting);
            this.Controls.Add(this.btnclose);
            this.Name = "UC_Emulator";
            this.Size = new System.Drawing.Size(235, 450);
            this.Load += new System.EventHandler(this.UC_Emulator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnsetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.PictureBox btnsetting;
        private System.Windows.Forms.Label lblname;
    }
}
