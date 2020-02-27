using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO.Ports;
using System.Threading;

namespace CanTrongLuong
{
    public class CanTrongLuong
    {
        string _TenCong;
        int _BaudRate;
        Parity _Parity;
        StopBits _StopBits;
        int _DataBits;

        public double LayTrongLuong()
        {
            // Create a new SerialPort object with default settings.
            SerialPort SerialPort1 = new SerialPort();

            // Allow the user to set the appropriate properties.
            SerialPort1.PortName = this._TenCong;
            SerialPort1.BaudRate = _BaudRate;
            SerialPort1.Parity = _Parity; //SerialPort1.Parity = Parity.None;
            SerialPort1.DataBits = _DataBits;
            SerialPort1.StopBits = _StopBits;// SerialPort1.StopBits = StopBits.One;
            SerialPort1.Handshake = Handshake.None;

            // Set the read/write timeouts
            SerialPort1.ReadTimeout = 50;
            SerialPort1.WriteTimeout = 500;

            try
            {
                SerialPort1.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            string message = ""; int t = 1;

            while (message.Length < 500)
            {
                string temp = "";
                                
                try
                {
                    temp = SerialPort1.ReadLine();
                    //temp = SerialPort1.ReadExisting();
                }
                catch
                {
                    SerialPort1.Close();
                    return 0;
                }
                

                if (t==20)
                {
                    SerialPort1.Close();
                    string chuoive = XyLyChuoi2(message);
                    double sove = 0;
                    try
                    {
                        sove = Convert.ToDouble(chuoive);
                    }
                    catch
                    {

                    }
                    return sove;
                }
                message += temp;
                t++;
            }

            try
            {
                SerialPort1.Close();
            }
            catch
            {

            }

            string chuoive2 = XyLyChuoi2(message);
            double sove2 = 0;
            try
            {
                sove2 = Convert.ToDouble(chuoive2);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return sove2;
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

        public CanTrongLuong(string TenCong, int baudrate, Parity parity, StopBits stopbits, int databits)
        {
            this._TenCong = TenCong;
            _BaudRate = baudrate;
            _Parity = parity;
            _StopBits = stopbits;
            _DataBits = databits;
        }

        public CanTrongLuong(string TenCong)
        {
            this._TenCong = TenCong;
            _BaudRate = 9600;
            _Parity = Parity.None;
            _StopBits = StopBits.One;
            _DataBits = 8;
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


        public double LayTrongLuong2()
        {
            // Create a new SerialPort object with default settings.
            SerialPort SerialPort1 = new SerialPort();

            // Allow the user to set the appropriate properties.
            SerialPort1.PortName = this._TenCong;
            SerialPort1.BaudRate = _BaudRate;
            SerialPort1.Parity = _Parity; //SerialPort1.Parity = Parity.None;
            SerialPort1.DataBits = _DataBits;
            SerialPort1.StopBits = _StopBits;// SerialPort1.StopBits = StopBits.One;
            SerialPort1.Handshake = Handshake.None;

            // Set the read/write timeouts
            SerialPort1.ReadTimeout = 50;
            SerialPort1.WriteTimeout = 500;

            try
            {
                SerialPort1.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            string message = ""; int t = 1;

            while (message.Length < 500)
            {
                string temp = "";

                try
                {
                    temp = SerialPort1.ReadLine();
                    //temp = SerialPort1.ReadExisting();
                }
                catch
                {
                    SerialPort1.Close();
                    return 0;
                }


                if (t == 20)
                {
                    SerialPort1.Close();
                    string chuoive = XyLyChuoi2(message);
                    double sove = 0;
                    try
                    {
                        sove = Convert.ToDouble(chuoive);
                    }
                    catch
                    {

                    }
                    return sove;
                }
                message += temp;
                t++;
            }

            try
            {
                SerialPort1.Close();
            }
            catch
            {

            }

            string chuoive2 = XyLyChuoi2(message);
            double sove2 = 0;
            try
            {
                sove2 = Convert.ToDouble(chuoive2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sove2;
        }

        public string DuLieuGoc()
        {
            // Create a new SerialPort object with default settings.
            SerialPort SerialPort1 = new SerialPort();

            // Allow the user to set the appropriate properties.
            SerialPort1.PortName = this._TenCong;
            SerialPort1.BaudRate = _BaudRate;
            SerialPort1.Parity = _Parity; //SerialPort1.Parity = Parity.None;
            SerialPort1.DataBits = _DataBits;
            SerialPort1.StopBits = _StopBits;// SerialPort1.StopBits = StopBits.One;
            SerialPort1.Handshake = Handshake.None;

            // Set the read/write timeouts
            //SerialPort1.ReadTimeout = 500;
            //SerialPort1.WriteTimeout = 500;

            string temp = "";
            try
            {
                SerialPort1.Open();
                temp = SerialPort1.ReadLine();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SerialPort1.Close();
            }            
            
            return temp;
        }
    }
}
