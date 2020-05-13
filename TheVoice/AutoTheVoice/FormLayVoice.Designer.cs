namespace AutoTheVoice
{
    partial class FormLayVoice
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
            this.btnlayvoice = new System.Windows.Forms.Button();
            this.cmbapi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfloderout = new System.Windows.Forms.Button();
            this.txtfloderout = new System.Windows.Forms.TextBox();
            this.radTTScool = new System.Windows.Forms.RadioButton();
            this.radvoiceware = new System.Windows.Forms.RadioButton();
            this.bgwlayvoice = new System.ComponentModel.BackgroundWorker();
            this.timerlayvoice = new System.Windows.Forms.Timer(this.components);
            this.txtthongbao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnlayvoice
            // 
            this.btnlayvoice.BackColor = System.Drawing.Color.Green;
            this.btnlayvoice.FlatAppearance.BorderSize = 0;
            this.btnlayvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlayvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlayvoice.ForeColor = System.Drawing.Color.White;
            this.btnlayvoice.Location = new System.Drawing.Point(122, 150);
            this.btnlayvoice.Name = "btnlayvoice";
            this.btnlayvoice.Size = new System.Drawing.Size(131, 48);
            this.btnlayvoice.TabIndex = 1;
            this.btnlayvoice.Text = "Lấy voice";
            this.btnlayvoice.UseVisualStyleBackColor = false;
            this.btnlayvoice.Click += new System.EventHandler(this.btnlayvoice_Click);
            // 
            // cmbapi
            // 
            this.cmbapi.BackColor = System.Drawing.Color.Green;
            this.cmbapi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbapi.ForeColor = System.Drawing.Color.White;
            this.cmbapi.FormattingEnabled = true;
            this.cmbapi.Location = new System.Drawing.Point(122, 93);
            this.cmbapi.Name = "cmbapi";
            this.cmbapi.Size = new System.Drawing.Size(201, 28);
            this.cmbapi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn API :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Floder output :";
            // 
            // btnfloderout
            // 
            this.btnfloderout.BackColor = System.Drawing.Color.Green;
            this.btnfloderout.FlatAppearance.BorderSize = 0;
            this.btnfloderout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfloderout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfloderout.ForeColor = System.Drawing.Color.White;
            this.btnfloderout.Location = new System.Drawing.Point(332, 41);
            this.btnfloderout.Name = "btnfloderout";
            this.btnfloderout.Size = new System.Drawing.Size(32, 23);
            this.btnfloderout.TabIndex = 5;
            this.btnfloderout.Text = "...";
            this.btnfloderout.UseVisualStyleBackColor = false;
            this.btnfloderout.Click += new System.EventHandler(this.btnfloderout_Click);
            // 
            // txtfloderout
            // 
            this.txtfloderout.BackColor = System.Drawing.Color.Green;
            this.txtfloderout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfloderout.Enabled = false;
            this.txtfloderout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfloderout.ForeColor = System.Drawing.Color.White;
            this.txtfloderout.Location = new System.Drawing.Point(122, 41);
            this.txtfloderout.Name = "txtfloderout";
            this.txtfloderout.Size = new System.Drawing.Size(201, 22);
            this.txtfloderout.TabIndex = 6;
            // 
            // radTTScool
            // 
            this.radTTScool.AutoSize = true;
            this.radTTScool.Checked = true;
            this.radTTScool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTTScool.ForeColor = System.Drawing.Color.White;
            this.radTTScool.Location = new System.Drawing.Point(363, 98);
            this.radTTScool.Name = "radTTScool";
            this.radTTScool.Size = new System.Drawing.Size(72, 17);
            this.radTTScool.TabIndex = 7;
            this.radTTScool.TabStop = true;
            this.radTTScool.Text = "TTS_Cool";
            this.radTTScool.UseVisualStyleBackColor = true;
            // 
            // radvoiceware
            // 
            this.radvoiceware.AutoSize = true;
            this.radvoiceware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radvoiceware.ForeColor = System.Drawing.Color.White;
            this.radvoiceware.Location = new System.Drawing.Point(441, 97);
            this.radvoiceware.Name = "radvoiceware";
            this.radvoiceware.Size = new System.Drawing.Size(100, 17);
            this.radvoiceware.TabIndex = 8;
            this.radvoiceware.Text = "voiceware.co.kr";
            this.radvoiceware.UseVisualStyleBackColor = true;
            // 
            // bgwlayvoice
            // 
            this.bgwlayvoice.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwlayvoice_DoWork);
            this.bgwlayvoice.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwlayvoice_RunWorkerCompleted);
            // 
            // timerlayvoice
            // 
            this.timerlayvoice.Tick += new System.EventHandler(this.timerlayvoice_Tick);
            // 
            // txtthongbao
            // 
            this.txtthongbao.BackColor = System.Drawing.Color.Green;
            this.txtthongbao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtthongbao.ForeColor = System.Drawing.Color.White;
            this.txtthongbao.Location = new System.Drawing.Point(12, 236);
            this.txtthongbao.Multiline = true;
            this.txtthongbao.Name = "txtthongbao";
            this.txtthongbao.Size = new System.Drawing.Size(634, 209);
            this.txtthongbao.TabIndex = 9;
            // 
            // FormLayVoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(658, 457);
            this.Controls.Add(this.txtthongbao);
            this.Controls.Add(this.radvoiceware);
            this.Controls.Add(this.radTTScool);
            this.Controls.Add(this.txtfloderout);
            this.Controls.Add(this.btnfloderout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbapi);
            this.Controls.Add(this.btnlayvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLayVoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLayVoice";
            this.Load += new System.EventHandler(this.FormLayVoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlayvoice;
        private System.Windows.Forms.ComboBox cmbapi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnfloderout;
        private System.Windows.Forms.TextBox txtfloderout;
        private System.Windows.Forms.RadioButton radTTScool;
        private System.Windows.Forms.RadioButton radvoiceware;
        private System.ComponentModel.BackgroundWorker bgwlayvoice;
        private System.Windows.Forms.Timer timerlayvoice;
        private System.Windows.Forms.TextBox txtthongbao;
    }
}