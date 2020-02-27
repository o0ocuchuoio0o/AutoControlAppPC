using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Data;

namespace CongCOM
{
    public class CongCOM
    {
        SerialPort comport = new SerialPort();

        private List<string> DanhSachCongCOM()
        {
            List<string> ds = null;

            foreach (string cong in SerialPort.GetPortNames())
            {
                ds.Add(cong);
            }

            return ds;
        }

        public DataTable DanhSachCongCOM2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenCong",typeof(string));

            foreach (string cong in SerialPort.GetPortNames())
            {
                DataRow r = dt.NewRow();
                r["TenCong"] = cong;
                dt.Rows.Add(r);
            }

            return dt;
        }

        private bool MoCong(string TenCong)
        {
            SerialPort comport = new SerialPort(TenCong,9600,Parity.None,8,StopBits.One);
            
            if (TenCong == "")
            {
                return false;
            }
            else
            {
                try
                {
                    if (comport.IsOpen == false)
                    {
                        comport.PortName = TenCong;

                        comport.Open();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        private bool DongCong(string TenCong)
        {
            SerialPort comport = new SerialPort(TenCong);
            
            if (TenCong == "")
            {
                return false;
            }
            else
            {
                try
                {
                    if (comport.IsOpen == true)
                    {
                        //comport.PortName = TenCong;
                        comport.Close();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public string LayDuLieuGoc(string TenCong)
        {
            //if (MoCong(TenCong) == true)
            //{
            //    string data;
            //    data = comport.ReadExisting();
            //    DongCong(TenCong);
            //    return data;
            //}
            //else
            //{
            //    return "Lỗi khi mở cổng";
            //}

            SerialPort comport1 = new SerialPort(TenCong,9600,Parity.None,8);

            if (comport1.IsOpen)
            {
                string data = comport1.ReadExisting();
                comport1.Close();
                return data;
            }
            else
            {
                comport1.Open();
                string data = comport1.ReadExisting();
                comport1.Close();
                return data;
            }
        }

        

        public string LayDuLieuDaXuLy2(string TenCong)
        {
            if (TenCong == "")
            {
                return "";
            }
            else
            {
                comport = new SerialPort(TenCong, 9600, Parity.None, 8, StopBits.One); 
                
                if (comport.IsOpen == false)
                    {
                        comport.ReadTimeout = 500;
                        comport.WriteTimeout = 500;
                        comport.Open();
                    }

                    string data;
                    data = comport.ReadExisting();

                    //DongCong(TenCong);
                    if (comport.IsOpen)
                        comport.Close();
                    return XyLyChuoi2(data);
            }
            
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
                if (mang2[mang2.Count - 1] == mang2[mang2.Count - 2] && mang2[mang2.Count - 2] == mang2[mang2.Count-3])
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
                    kq +=c;
            }

            return kq;
        }
    }
}