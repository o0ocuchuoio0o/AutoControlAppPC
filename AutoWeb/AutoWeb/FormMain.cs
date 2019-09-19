using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using DaoAutoWeb;
using System.Threading;

namespace AutoWeb
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void dmbuucuc()
        {
            da_dmbclay bc = new da_dmbclay();
            DataTable dt = new DataTable();
            dt = bc.DanhSachBuuCuc(Cl_KetNoi.hamketnoisql());
            listbuucuc.DataSource = dt;
        }

        private void khoitao()
        {
            txttungay.Text = DateTime.Now.ToString("MM/dd/yyyy");
            dmbuucuc();
            //DateTime temp = DateTime.ParseExact(txttungay.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //DateTime tungay;
            //try { tungay = temp; }
            //catch { tungay = DateTime.Now; }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            khoitao();                
        }

        private void btnlaythongtinphat_Click(object sender, EventArgs e)
        {
            Thread chay = new Thread(() =>
            {
                txtlog.Text = "";
                DataTable tablebuucuc = (DataTable)listbuucuc.DataSource;
                if (tablebuucuc.Rows.Count > 0)
                {
                    #region // lay thông tin phát
                    ChromePerformanceLoggingPreferences perfLogPrefs = new ChromePerformanceLoggingPreferences();
                    perfLogPrefs.AddTracingCategories(new string[] { "devtools.timeline" });
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--disable-notifications");
                    options.PerformanceLoggingPreferences = perfLogPrefs;
                    options.SetLoggingPreference(LogType.Driver, LogLevel.All);
                    options.SetLoggingPreference("performance", LogLevel.All);
                    options.AddAdditionalCapability(CapabilityType.EnableProfiling, true, true);
                    PropretiesCollection.driver = new ChromeDriver(options);
                    PropretiesCollection.driver.Navigate().GoToUrl("http://thongtinphat.vnpost.vn/Security/SignIn");
                    ThongTinPhat t = new ThongTinPhat();
                    t.login(txttaikhoan.Text, txtmatkhau.Text, txttungay.Text.Trim(), txttungay.Text.Trim());
                    txtlog.Text = txtlog.Text + "\r\n" + "Login thành công bắt đầu quét dữ liệu"+"-->"+DateTime.Now.ToString();
                    foreach (DataRow r in tablebuucuc.Rows)
                    {
                        string mabuucuc = r["mabuucuc"].ToString();
                        string tenbuucuc = r["buucuc"].ToString();
                        txtlog.Text = txtlog.Text + "\r\n" + "Bắt đầu đọc dữ liệu bưu cục " + mabuucuc + "-" + tenbuucuc + "-->" + DateTime.Now.ToString(); ;
                        DataTable dt = new DataTable();
                        dt = t.ThongTin(mabuucuc,int.Parse(txttimernghi.Value.ToString()));
                        txtlog.Text = txtlog.Text + "\r\n" + "Bưu cục " + tenbuucuc + " Có số lượng bản ghi là:" + dt.Rows.Count.ToString() + "-->" + DateTime.Now.ToString();
                        if (dt.Rows.Count > 0)
                        {
                            #region // ghi dữ liệu vào csdl SMP
                            da_smp_mau ghi = new da_smp_mau();
                            ghi.CapNhat(Cl_KetNoi.hamketnoisql(), dt, txttungay.Text, mabuucuc);
                            txtlog.Text = txtlog.Text + "\r\n" + "Ghi thành công dữ liệu cho bưu cục :" + tenbuucuc + "-->" + DateTime.Now.ToString(); 
                            #endregion
                        }

                    }
                    txtlog.Text = txtlog.Text + "\r\n" + "Đã Xong!" + "-->" + DateTime.Now.ToString();
                    //chạy xong tắt chome
                    PropretiesCollection.driver.Close();
                    #endregion
                }
                else
                {
                    MessageBox.Show("Lỗi không có danh sách bưu cục cần lấy dữ liệu");
                    return;
                }
            }
            );
            chay.Start();
        }
    }
}
