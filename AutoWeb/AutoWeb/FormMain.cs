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
using System.IO;
using DocDuLieu;
using System.Data.SqlClient;

namespace AutoWeb
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //Cl_KetNoi.sqlDependency();
           
        }

        public delegate void NewHome();
        public event NewHome OnNewHome;
        public void DanhSachBuuCuc(SqlConnection conn)
        {
            conn.Open();
            string sql = "select mabuucuc,buucuc from dbo.dmbclay ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 72000;
            //SqlDependency de = new SqlDependency(cmd);
            //de.OnChange += new OnChangeEventHandler(de_OnChange);
           // SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                //dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
                da.Fill(ds, "DanhSach");
                listbuucuc.DataSource = ds.Tables["DanhSach"];
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }

        }
        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;
            if (OnNewHome != null)
            {
                OnNewHome();
            }
        }
        public void Form1_OnNewHome()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)
            {
                NewHome dd = new NewHome(Form1_OnNewHome);
                i.BeginInvoke(dd, null);
                return;
            }
            DanhSachBuuCuc(Cl_KetNoi.hamketnoisql());

        }

        private void dmbuucuc()
        {
            da_dmbclay bc = new da_dmbclay();
            DataTable dt = new DataTable();
            dt = bc.DanhSachBuuCucKhongsoLieu(Cl_KetNoi.hamketnoisql(), txttungay.Text);
            listbuucuc.DataSource = dt;
        }

        private void khoitao()
        {
            txttungay.Text = DateTime.Now.ToString("MM/dd/yyyy");
            txtngaychatluong.Text = DateTime.Now.ToString("MM/dd/yyyy");
            //dmbuucuc();

            if (!Directory.Exists(@"C:\TempExcel"))
            {
                Directory.CreateDirectory(@"C:\TempExcel");
            }
           // OnNewHome += new NewHome(Form1_OnNewHome);//tab
            //load data vao datagrid
            DanhSachBuuCuc(Cl_KetNoi.hamketnoisql());
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
                    string profile_add = "Profile";
                    string profile_new = "Profile\\ThongTinPhat"; 
                    ChromePerformanceLoggingPreferences perfLogPrefs = new ChromePerformanceLoggingPreferences();
                    perfLogPrefs.AddTracingCategories(new string[] { "devtools.timeline" });
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--disable-notifications");
                    if (!Directory.Exists(profile_add)) { Directory.CreateDirectory(profile_add); }                   
                    options.AddArgument("user-data-dir=" + Application.StartupPath + "\\" + profile_new);
                    options.AddArgument("--window-size=1500,900");
                    options.AddArgument("--disable-infobars");                  
                    options.PerformanceLoggingPreferences = perfLogPrefs;
                    options.SetLoggingPreference(LogType.Driver, LogLevel.All);
                    options.SetLoggingPreference("performance", LogLevel.All);
                    options.AddAdditionalCapability(CapabilityType.EnableProfiling, true, true);
                    PropretiesCollection.driver = new ChromeDriver(options);
                    PropretiesCollection.driver.Navigate().GoToUrl("http://thongtinphat.vnpost.vn/Security/SignIn");
                   // PropretiesCollection.driver.Manage().Window.Size = new Size(480, 720);
                    ThongTinPhat t = new ThongTinPhat();
                    t.login(txttaikhoan.Text, txtmatkhau.Text, txttungay.Text.Trim(), txttungay.Text.Trim());
                    txtlog.Text = txtlog.Text + "\r\n" + "Login thành công bắt đầu quét dữ liệu"+"-->"+DateTime.Now.ToString();
                    int i = 1;
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
                        lblxuly.Text = "Xử lý :" + i.ToString() + "/" + tablebuucuc.Rows.Count.ToString();
                        i++;
                        ScrollToBottom(txtlog);
                    }
                    txtlog.Text = txtlog.Text + "\r\n" + "Đã Xong!" + "-->" + DateTime.Now.ToString();
                    da_smp_mau dlngay = new da_smp_mau();
                    DataTable tableBC = new DataTable();
                    tableBC = dlngay.DanhSachSoLieu(Cl_KetNoi.hamketnoisql(), txttungay.Text);
                    listbuucuc.DataSource = tableBC;
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
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(System.IntPtr hWnd, int wMsg, System.IntPtr wParam, System.IntPtr lParam);

        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 500;

        /// <summary>
        /// Scrolls the vertical scroll bar of a multi-line text box to the bottom.
        /// </summary>
        /// <param name="tb">The text box to scroll</param>
        public static void ScrollToBottom(System.Windows.Forms.TextBox tb)
        {
            if (System.Environment.OSVersion.Platform != System.PlatformID.Unix)
                SendMessage(tb.Handle, WM_VSCROLL, new System.IntPtr(SB_BOTTOM), System.IntPtr.Zero);
        }
        private void btnchaylaithongtinphat_Click(object sender, EventArgs e)
        {
            Thread chay = new Thread(() =>
            {
                txtlog.Text = "";
                da_dmbclay bc = new da_dmbclay();
                DataTable tablebuucuc = new DataTable();
                tablebuucuc = bc.DanhSachBuuCucKhongsoLieu(Cl_KetNoi.hamketnoisql(), txttungay.Text); 
                DataTable tbc = (DataTable)listbuucuc.DataSource;
                lblbuucuckhongsolieu.Text ="Số lượng bưu cục không số liệu :"+ tablebuucuc.Rows.Count.ToString() + "/" + tbc.Rows.Count.ToString();
            
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
                   // PropretiesCollection.driver.Manage().Window.Size = new Size(480, 720);
                    ThongTinPhat t = new ThongTinPhat();
                    t.login(txttaikhoan.Text, txtmatkhau.Text, txttungay.Text.Trim(), txttungay.Text.Trim());
                    txtlog.Text = txtlog.Text + "\r\n" + "Login thành công bắt đầu quét dữ liệu" + "-->" + DateTime.Now.ToString();
                    lblxuly.Text = "0";
                    int i = 1;
                    foreach (DataRow r in tablebuucuc.Rows)
                    {
                        string mabuucuc = r["mabuucuc"].ToString();
                        string tenbuucuc = r["buucuc"].ToString();
                        txtlog.Text = txtlog.Text + "\r\n" + "Bắt đầu đọc dữ liệu bưu cục " + mabuucuc + "-" + tenbuucuc + "-->" + DateTime.Now.ToString(); ;
                        DataTable dt = new DataTable();
                        dt = t.ThongTin(mabuucuc, int.Parse(txttimernghi.Value.ToString()));
                        txtlog.Text = txtlog.Text + "\r\n" + "Bưu cục " + tenbuucuc + " Có số lượng bản ghi là:" + dt.Rows.Count.ToString() + "-->" + DateTime.Now.ToString();
                        if (dt.Rows.Count > 0)
                        {
                            #region // ghi dữ liệu vào csdl SMP
                            da_smp_mau ghi = new da_smp_mau();
                            ghi.CapNhat(Cl_KetNoi.hamketnoisql(), dt, txttungay.Text, mabuucuc);
                            txtlog.Text = txtlog.Text + "\r\n" + "Ghi thành công dữ liệu cho bưu cục :" + tenbuucuc + "-->" + DateTime.Now.ToString();
                           
                            #endregion
                        }
                        lblxuly.Text="Xử lý :"+i.ToString()+"/"+tablebuucuc.Rows.Count.ToString();
                        i++;
                        ScrollToBottom(txtlog);
                    }
                    txtlog.Text = txtlog.Text + "\r\n" + "Đã Xong!" + "-->" + DateTime.Now.ToString();
                    
                    da_smp_mau dlngay = new da_smp_mau();
                    DataTable tableBC = new DataTable();
                    tableBC = dlngay.DanhSachSoLieu(Cl_KetNoi.hamketnoisql(), txttungay.Text);
                    listbuucuc.DataSource = tableBC;
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


        private void hamxoafile(string path)
        {
            string[] fileList = System.IO.Directory.GetFiles(path);
            //duyệt từng file và copy đè lên file cũ trong thư mục đang chạy chương trình
            foreach (string sourceFile in fileList)
            {
                //tách tên file ra khỏi đường dẫn (tên file sẽ dùng để tạo đường dẫn đích cần copy đè)
                string fileName = System.IO.Path.GetFileName(sourceFile);
                //tạo đường dẫn đích để copy file mới tới
                string destinationFile = path + @"\" + fileName;
                //thực hiện xóa file
                System.IO.File.Delete(destinationFile);
            }
        }
        private void btnlaythongtinchatluong_Click(object sender, EventArgs e)
        {

            Thread chay = new Thread(() =>
            {

                    hamxoafile(@"C:\TempExcel");              
                    #region // lay thông tin phát
                    ChromePerformanceLoggingPreferences perfLogPrefs = new ChromePerformanceLoggingPreferences();
                    perfLogPrefs.AddTracingCategories(new string[] { "devtools.timeline" });
                    ChromeOptions options = new ChromeOptions();
                    var downloadDirectory = @"C:\TempExcel";
                    options.AddUserProfilePreference("download.default_directory", downloadDirectory);
                    options.AddUserProfilePreference("download.prompt_for_download", false);
                    options.AddUserProfilePreference("disable-popup-blocking", "true");

                    options.AddArguments("--disable-notifications");
                    options.PerformanceLoggingPreferences = perfLogPrefs;
                    options.SetLoggingPreference(LogType.Driver, LogLevel.All);
                    options.SetLoggingPreference("performance", LogLevel.All);
                    options.AddAdditionalCapability(CapabilityType.EnableProfiling, true, true);
                    PropretiesCollection.driver = new ChromeDriver(options);
                    PropretiesCollection.driver.Navigate().GoToUrl("https://chatluong.vnpost.vn");
                    ChatLuong cl = new ChatLuong();
                    cl.XuLy(txttaikhoanchatluong.Text, txtpasschatluong.Text,txtngaychatluong.Text, txtngaychatluong.Text,1);
                    //chạy xong tắt chome
                    PropretiesCollection.driver.Close();
                       
                        #region //xử lý luôn file excel down về lưu vào csdl
                        string fileexcel = @"C:\TempExcel\" + "Chat Luong cong doan phat theo buu cuc phat.xlsx";
                        DuLieuExcel dExcel = new DuLieuExcel();
                        DataTable DuLieu = new DataTable();
                        dExcel.TenFile =fileexcel;
                        DuLieu = dExcel.Doc().Tables[0];
                        if (DuLieu.Rows.Count > 0)
                        { 
                        
                        }
                        hamxoafile(@"C:\TempExcel"); 
                        #endregion

                    #endregion

            }
           );
            chay.Start();
        }

      
        
    }
}
