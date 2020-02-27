using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO.Ports;
using System.Threading;

namespace CongCOM
{
    public class CongCOM3
    {
        string _TenCong;
        int _BaudRate;
        Parity _Parity;
        StopBits _StopBits;
        int _DataBits;

        public CongCOM3(string TenCong, int baudrate, Parity parity, StopBits stopbits, int databits)
        {
            this._TenCong = TenCong;
            _BaudRate = baudrate;
            _Parity = parity;
            _StopBits = stopbits;
            _DataBits = databits;
        }

        public CongCOM3(string TenCong)
        {
            this._TenCong = TenCong;
            _BaudRate = 9600;
            _Parity = Parity.None;
            _StopBits = StopBits.One;
            _DataBits = 8;
        }
        
        public string DuLieuDong,DuLieuDong2;
        Thread readThread;        
        SerialPort SerialPort1;

        void Read()
        {
            Thread.Sleep(500);
            string message = SerialPort1.ReadExisting();
            DuLieuDong = message;
            Thread.Sleep(400);
            DuLieuDong += " --- " + SerialPort1.ReadExisting();
        }   

        public double LayTrongLuong()
        {
            // Create a new SerialPort object with default settings.
            SerialPort1 = new SerialPort();

            // Allow the user to set the appropriate properties.
            SerialPort1.PortName = this._TenCong;
            SerialPort1.BaudRate = _BaudRate;
            SerialPort1.Parity = _Parity; //SerialPort1.Parity = Parity.None;
            SerialPort1.DataBits = _DataBits;
            SerialPort1.StopBits = _StopBits;// SerialPort1.StopBits = StopBits.One;
            SerialPort1.Handshake = Handshake.None;

            SerialPort1.ReadTimeout = 50;
            SerialPort1.WriteTimeout = 50;

            return XuLyChuoi(DocChuoi());
        }

        string DocChuoi()
        {
            DuLieuDong = "";
            SerialPort1.Open();

            readThread = new Thread(Read);
            readThread.Start();
            readThread.Join();
            readThread.Abort();
            SerialPort1.Close();

            return DuLieuDong;
        }

        double XuLyChuoi(string DuLieu)
        {
            double kq = 0;

            if (DuLieu.IndexOf("+") != -1)
            {
                int index = DuLieu.IndexOf("+");
                string chuoiso = DuLieu.Substring(index+1, 6);
                try { kq = Convert.ToDouble(chuoiso); }
                catch { }
            }

            return kq;
        }

        public string DocChuoi2()
        {
            SerialPort1 = new SerialPort();

            // Allow the user to set the appropriate properties.
            SerialPort1.PortName = this._TenCong;
            SerialPort1.BaudRate = _BaudRate;
            SerialPort1.Parity = _Parity; //SerialPort1.Parity = Parity.None;
            SerialPort1.DataBits = _DataBits;
            SerialPort1.StopBits = _StopBits;// SerialPort1.StopBits = StopBits.One;
            SerialPort1.Handshake = Handshake.None;

            //SerialPort1.ReadTimeout = 50;
            //SerialPort1.WriteTimeout = 50;

            DuLieuDong = "";
            SerialPort1.Open();

            readThread = new Thread(Read);
            readThread.Start();
            readThread.Join();
            readThread.Abort();
            SerialPort1.Close();

            return DuLieuDong;
        }
    }
}
