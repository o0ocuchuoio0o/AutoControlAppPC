using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Threading;

namespace CongCOM
{
    public class CanTrongLuong4
    {
        // 4/7/2015 : Cho TT1
        
        string _TenCong;
        int _BaudRate;
        Parity _Parity;
        StopBits _StopBits;
        int _DataBits;

        public CanTrongLuong4(string TenCong, int baudrate, Parity parity, StopBits stopbits, int databits)
        {
            this._TenCong = TenCong;
            _BaudRate = baudrate;
            _Parity = parity;
            _StopBits = stopbits;
            _DataBits = databits;
        }

        public CanTrongLuong4(string TenCong)
        {
            this._TenCong = TenCong;
            _BaudRate = 2400;
            _Parity = Parity.None;
            _StopBits = StopBits.One;
            _DataBits = 8;
        }
        
        public string DuLieuDong;
                
        public double DocTrongLuong()
        {
            return XuLyChuoi(DuLieuGoc());
        }
               

        private double XuLyChuoi(string dulieu)
        {
            double kq = 0;

            // xd là kieu g hay Kg
            int index = dulieu.IndexOf(" Kg");
            int index2 = dulieu.IndexOf(" g");

            //lọc chuỗi
            // Chỉ giữ lại số, dấu cộng
            string chuoi = "";
            foreach (char c in dulieu)
            {
                if (c == '+' || c == 'g' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    chuoi += c;
            }

            //
            if (index > 0)
            {
                //kg
                if (chuoi.IndexOf("+") != -1)
                {
                    int vt_dau = chuoi.IndexOf("+");
                    chuoi = chuoi.Substring(vt_dau + 1, 6);
                    //try { kq = Convert.ToDouble(chuoiso); }
                    //catch { }
                }
            }
            else if (index2 > 0)
            {
                //g
                // tim vitri dau và cuoi
                int vt_dau = chuoi.IndexOf("+");
                int vt_cuoi = chuoi.IndexOf("g");

                if (vt_dau == -1 || vt_cuoi == -1)
                    return 0;

                if (vt_dau < vt_cuoi)
                {
                    chuoi = chuoi.Substring(vt_dau + 1, vt_cuoi - vt_dau - 6);
                    //try { kq = Convert.ToDouble(chuoiso); }
                    //catch { }
                }
                else
                {
                    chuoi = chuoi.Substring(vt_dau, chuoi.Length - vt_dau);
                    vt_cuoi = chuoi.IndexOf("g");
                    vt_dau = chuoi.IndexOf("+");
                    chuoi = chuoi.Substring(vt_dau + 1, vt_cuoi - vt_dau - 6);
                }
            }

            try { kq = Convert.ToDouble(chuoi); }
            catch { }
            return kq;
        }

        public bool KiemKetNoi()
        {
            SerialPort SerialPort1 = new SerialPort();

            // Allow the user to set the appropriate properties.
            SerialPort1.PortName = this._TenCong;
            SerialPort1.BaudRate = _BaudRate;
            SerialPort1.Parity = _Parity;
            SerialPort1.DataBits = _DataBits;
            SerialPort1.StopBits = _StopBits;// StopBits.One;
            SerialPort1.Handshake = Handshake.None;

            if (SerialPort1.IsOpen)
            {
                return true;
            }
            else
            {
                // chưa mở
                try
                {
                    SerialPort1.Open();
                    SerialPort1.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        

        private string DuLieuGoc()
        {
            DuLieuDong = "";
            
            SerialPort mySerialPort = new SerialPort(this._TenCong);

            mySerialPort.BaudRate = 2400;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            mySerialPort.Close();
            mySerialPort.Open();

            Thread.Sleep(1000);

            mySerialPort.Close();

            return DuLieuDong; // XuLyChuoi2(DuLieuDong);
        }
        
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            try
            {
                DuLieuDong += sp.ReadExisting();
            }
            catch { }
        }
        
    }
}