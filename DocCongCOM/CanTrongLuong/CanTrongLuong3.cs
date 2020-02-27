using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace CanTrongLuong
{
    public class CanTrongLuong3
    {
        string _TenCong;
        int _BaudRate;
        Parity _Parity;
        StopBits _StopBits;
        int _DataBits;

        public CanTrongLuong3(string TenCong, int baudrate, Parity parity, StopBits stopbits, int databits)
        {
            this._TenCong = TenCong;
            _BaudRate = baudrate;
            _Parity = parity;
            _StopBits = stopbits;
            _DataBits = databits;
        }

        public CanTrongLuong3(string TenCong)
        {
            this._TenCong = TenCong;
            _BaudRate = 9600;
            _Parity = Parity.None;
            _StopBits = StopBits.One;
            _DataBits = 8;
        }
        
        public string DuLieuDong;
        Thread readThread;        
        SerialPort SerialPort1;

        public void Read()
        {
            Thread.Sleep(500);
            string message = SerialPort1.ReadExisting();
            DuLieuDong = message;
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

            //Thread.Sleep(500);
            //string message = SerialPort1.ReadExisting();
            //DuLieuDong += message;
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

        public string Laydulieu(string TenCong)
        {
            readThread = new Thread(Read);

            SerialPort1 = new SerialPort();
            SerialPort1.PortName = TenCong;
            SerialPort1.BaudRate = 9600;
            SerialPort1.Parity = Parity.None;
            SerialPort1.DataBits = 8;
            SerialPort1.StopBits = StopBits.One;
            SerialPort1.Handshake = Handshake.None;

            // Set the read/write timeouts
            SerialPort1.ReadTimeout = 50;
            SerialPort1.WriteTimeout = 50;

            DuLieuDong = "";
            SerialPort1.Open();

            readThread.Start();
            readThread.Join();
            readThread.Abort();

            //Thread.Sleep(500);
            //string message = SerialPort1.ReadExisting();
            //DuLieuDong += message;
            SerialPort1.Close();

            return DuLieuDong;
        }
    }
}
