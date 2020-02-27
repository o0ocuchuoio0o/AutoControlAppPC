using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO.Ports;

namespace CongCOM
{
    public class CongCOM2
    {
        public string _TenCong;
        public int _BaudRate;
        public Parity _Parity;
        public StopBits _StopBits;
        public int _DataBits;
        
        public DataTable DanhSachCongCOM()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenCong", typeof(string));

            foreach (string cong in SerialPort.GetPortNames())
            {
                DataRow r = dt.NewRow();
                r["TenCong"] = cong;
                dt.Rows.Add(r);
            }

            return dt;
        }

        public string LayDuLieu()
        {
            SerialPort mySerialPort = new SerialPort(this._TenCong);

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            //mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            mySerialPort.Open();

            string temp = mySerialPort.ReadExisting();
            mySerialPort.Close();
            return XyLyChuoi2(temp);
        }

        string LayDuLieu2(string TenCong)
        {
            //SerialPort mySerialPort = new SerialPort("COM3");
            SerialPort mySerialPort = new SerialPort(TenCong);

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            //mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            mySerialPort.Open();

            string temp = mySerialPort.ReadExisting();
            mySerialPort.Close();
            return XyLyChuoi2(temp);
        }

        private string XyLyChuoi2(string SoLieuBanDau)
        {
            SoLieuBanDau = LocChuoi(SoLieuBanDau);

            string[] mang = SoLieuBanDau.Split('+');

            // duyet mảng loại ra những hàng không đủ 7 ký tự
            List<string> mang2 = new List<string>();
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i].Length == 7)
                    mang2.Add(mang[i]);
            }

            if (mang2.Count >= 3)
            {
                string kq;
                if (mang2[mang2.Count - 1] == mang2[mang2.Count - 2] && mang2[mang2.Count - 2] == mang2[mang2.Count - 3])
                {
                    kq = mang2[mang2.Count - 1];
                }

                else
                    kq = "";

                return kq;
            }
            else return "";

        }

        private string LocChuoi(string ChuoiBanDau)
        {
            // Chỉ giữ lại số, dấu cộng và dấu chấm
            string kq = "";
            foreach (char c in ChuoiBanDau)
            {
                if (c == '+' || c == '.' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    kq += c;
            }

            return kq;
        }

        public CongCOM2(string TenCong)
        {
            _TenCong = TenCong;
            _BaudRate = 9600;
            _Parity = Parity.None;
            _StopBits = StopBits.One;
            _DataBits = 8;
        }

        public CongCOM2(string TenCong, int baudrate, Parity parity, StopBits stopbits, int databits)
        {
            this._TenCong = TenCong;
            _BaudRate = baudrate;
            _Parity = parity;
            _StopBits = stopbits;
            _DataBits = databits;
        }
    }
}
