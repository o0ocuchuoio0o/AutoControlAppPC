using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace DocCongCOM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (string cong in SerialPort.GetPortNames())
            {
                cbbPorts.Items.Add(cong);
            }
            cbbPorts.SelectedIndex = 0;
        }

        Thread readThread;
        bool _continue;

        private void btnCon_Click(object sender, EventArgs e)
        {
            readThread = new Thread(Read);

            // Create a new SerialPort object with default settings.
            SerialPort1 = new SerialPort();

            // Allow the user to set the appropriate properties.
            SerialPort1.PortName = cbbPorts.Text;// "COM3";
            SerialPort1.BaudRate = 9600;
            SerialPort1.Parity = Parity.None;
            SerialPort1.DataBits = 8;
            SerialPort1.StopBits = StopBits.One;
            SerialPort1.Handshake = Handshake.None;

            // Set the read/write timeouts
            //_serialPort.ReadTimeout = 500;
            //_serialPort.WriteTimeout = 500;

            //if (!SerialPort1.IsOpen)
                SerialPort1.Open(); //SerialPort1.Close();
            
            _continue = true;
            readThread.Start();
                        
        }

        public void Read()
        {
            
            while (_continue)
            {
                try
                {
                    string message = SerialPort1.ReadExisting();
                    if (txtRec.InvokeRequired)
                    {
                        txtRec.Invoke(new MethodInvoker(delegate { txtRec.AppendText(message); }));
                    }

                 }
                catch (TimeoutException) { }
            }
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            // Dừng luồng            
            readThread.Abort();
            SerialPort1.Close();
            txtRec.AppendText("Dừng luồng");            
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            //CanTrongLuong.CanTrongLuong3 db = new CanTrongLuong.CanTrongLuong3("");
            //string temp = db.Laydulieu(cbbPorts.Text);

            //txtSoLieuDaXuLy.Text = temp;
            //txtRec.AppendText(temp);

            ////CanTrongLuong.CanTrongLuong db = new CanTrongLuong.CanTrongLuong("COM1");
            ////MessageBox.Show(db.KiemKetNoi().ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //CongCOM.CanTrongLuong db = new CongCOM.CanTrongLuong(cbbPorts.Text);
            //string temp = db.LayTrongLuong().ToString();
            
            //txtRec.AppendText(temp+Environment.NewLine);
        }

        private void btn_chay_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;
        }
    }
}
