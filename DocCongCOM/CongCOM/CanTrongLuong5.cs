using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO.Ports;
using System.Threading;

namespace CongCOM
{
    public class CanTrongLuong5
    {
        // Can Ohaus Ranger count 2000
        // TT3
        
        string _TenCong;
        int _BaudRate;
        Parity _Parity;
        StopBits _StopBits;
        int _DataBits;

        public CanTrongLuong5(string TenCong, int baudrate, Parity parity, StopBits stopbits, int databits)
        {
            this._TenCong = TenCong;
            _BaudRate = baudrate;
            _Parity = parity;
            _StopBits = stopbits;
            _DataBits = databits;
        }

        public CanTrongLuong5(string TenCong)
        {
            this._TenCong = TenCong;
            _BaudRate = 2400;
            _Parity = Parity.None;
            _StopBits = StopBits.One;
            _DataBits = 8;
        }

        string DuLieuDong; 
        public double DocTrongLuong()
        {
            return XuLyChuoi(DuLieuGoc());
        }
               

        private double XuLyChuoi(string dulieu)
        {
            double kq = 0;

            // xd là kieu g hay Kg
            int index = dulieu.IndexOf(" kg");
            int index2 = dulieu.IndexOf(" g");

            //lọc chuỗi
            // Chỉ giữ lại số, dấu cộng
            string chuoi = "";
            foreach (char c in dulieu)
            {
                if (c == '\n' || c == '.' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    chuoi += c;
            }

            string[] mang = chuoi.Split('\n');

            List<double> mang2 = new List<double>();
            foreach (string dong in mang)
            {
                double temp = 0;
                try
                {
                    temp = Convert.ToDouble(dong);
                }
                catch { }
                if (temp > 0)
                    mang2.Add(temp);
            }

            double[] mang_dn = mang2.Distinct().ToArray();
            double[] mang_dn_sl = new double[mang_dn.Length];

            for (int i = 0; i < mang_dn.Length; i++)
            {
                var q = (from double row in mang2
                         where row == mang_dn[i]
                         select new { row });
                mang_dn_sl[i] = q.Count();
            }

            double maxValue = mang_dn_sl.Max();
            int maxIndex = mang_dn_sl.ToList().IndexOf(maxValue);

            if (maxIndex >= 0)
                kq = mang_dn[maxIndex];

            if (index > 0)
            {
                //kg
                kq = kq * 1000;
            }
            else if (index2 > 0)
            {
                //g

            }

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
        

        public string DuLieuGoc()
        {
            DuLieuDong = "";
            
            SerialPort mySerialPort = new SerialPort(this._TenCong);

            mySerialPort.BaudRate = 9600;
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
