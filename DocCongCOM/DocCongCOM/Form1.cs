using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
//using CongCOM;

namespace DocCongCOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Khoi tao dieu khien SerialPort
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(getData);
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //CongCOM.CongCOM db = new CongCOM.CongCOM();
            //cbbPort.DataSource = db.DanhSachCongCOM2();
            //cbbPort.DisplayMember = "TenCong";
            //cbbPort.ValueMember = "TenCong";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTrongLuong.Text = "";
            txtSoLieuDaXuLy.Text = "";
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {
            //CongCOM.CongCOM db = new CongCOM.CongCOM();
            
            //txtTrongLuong.Text = db.LayDuLieuGoc(cbbPort.SelectedValue.ToString());            
            //txtSoLieuDaXuLy.Text = db.LayDuLieuDaXuLy2(cbbPort.SelectedValue.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //CongCOM.CongCOM db = new CongCOM.CongCOM();

            ////txtTrongLuong.Text = db.LayDuLieuGoc(cbbPort.SelectedValue.ToString());            
            //txtSoLieuDaXuLy.Text = db.LayDuLieuDaXuLy2(cbbPort.SelectedValue.ToString());
        }

        
    }
}
