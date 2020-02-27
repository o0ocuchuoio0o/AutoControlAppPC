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
//using CanTrongLuong;
using System.Threading;

namespace DocCongCOM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(getData);
        }
                
        private void Form2_Load(object sender, EventArgs e)
        {
            ListPortCOM();
            this.myDelegate = new AddDataDelegate(AddDataMethod);
        }

        public void ListPortCOM()
        {
            foreach (string cong in SerialPort.GetPortNames())
            {
                cbbPort.Items.Add(cong);
            }
            cbbPort.SelectedIndex = 0;
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {
            CanTrongLuong.CanTrongLuong db = new CanTrongLuong.CanTrongLuong(cbbPort.Text);
            double so = db.DocTrongLuong();
            txt_so.Text = so.ToString();
            rtbTrongLuong.AppendText(so.ToString() + Environment.NewLine);
            rtbTrongLuong.ScrollToCaret();

            //string tem = db.DuLieuGoc();
            //txt_so.Text = tem;
            //rtbTrongLuong.AppendText(tem + Environment.NewLine);
            //rtbTrongLuong.ScrollToCaret();

            MessageBox.Show("Đã đọc xong", "Thông báo");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CanTrongLuong.CanTrongLuong db = new CanTrongLuong.CanTrongLuong(cbbPort.Text);
            string temp = db.DocTrongLuong().ToString();
            //string temp = db.DuLieuGoc();
            txtSoLieuDaXuLy.Text = temp;
            rtbTrongLuong.AppendText(temp + Environment.NewLine);
            rtbTrongLuong.ScrollToCaret();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSoLieuDaXuLy.Text = "";
            rtbTrongLuong.Text = "";
        }

        private void btn_dung_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btn_chay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SerialPort mySerialPort = new SerialPort("COM3");

            mySerialPort.BaudRate = 2400;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            mySerialPort.Open();

            MessageBox.Show("Press any key to continue...");

            mySerialPort.Close();

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            txtSoLieuDong2.Invoke(this.myDelegate, new Object[] { indata });
        }

        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;

        public void AddDataMethod(String myString)
        {
            txtSoLieuDong2.AppendText(myString);
        }
    }
}
