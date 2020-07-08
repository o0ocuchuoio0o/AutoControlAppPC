using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AutoFB
{
    public partial class ChayGiaLap : Form
    {
        public ChayGiaLap()
        {
            InitializeComponent();
        }
        #region // các hàm khởi tạo
        private void configinputandoutput()
        {
            try
            {
                if (ConfigurationManager.AppSettings["PathLDPlayer"].ToString() == "")
                {
                    txtpathldplayer.Text = @"C:\ChangZhi\LDPlayer\dnplayer.exe";
                }
                else
                {
                    txtpathldplayer.Text = ConfigurationManager.AppSettings["PathLDPlayer"].ToString();
                }
            }
            catch { }
        }
        private DataTable FileToDatatable(string path)
        {
            DataTable dt = new DataTable();           
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("ID", typeof(int));
            try
            {
                string[] fileList = System.IO.Directory.GetFiles(path);
                //duyệt từng file và copy đè lên file cũ trong thư mục đang chạy chương trình
                foreach (string sourceFile in fileList)
                {
                    //tách tên file ra khỏi đường dẫn (tên file sẽ dùng để tạo đường dẫn đích cần copy đè)
                    string fileName = System.IO.Path.GetFileName(sourceFile);
                    //tạo đường dẫn đích để copy file mới tới
                    if (fileName.IndexOf(".config") != -1 && fileName != "leidians.config")
                    {
                        try
                        {
                            int id = int.Parse(fileName.Replace("leidian", "").Replace(".config", ""));
                            dt.Rows.Add("Phone "+id.ToString(),id);
                        }
                        catch { }

                    }

                }
            }
            catch { }
            return dt;
        }
        private void hienthiemulator()
        {
          
            DataTable dt = new DataTable();
            dt = FileToDatatable(txtpathldplayer.Text.Replace("dnplayer.exe", "") + @"vms\config");
            if (dt.Rows.Count > 0)
            {
                DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
                CheckBox chk = new CheckBox();
                CheckboxColumn.Width = 50;
                chk.FlatStyle = FlatStyle.Flat;
                Listemulator.Columns.Add(CheckboxColumn);
                Listemulator.DataSource = dt;
            }
        }
        private void khoitao()
        {
            configinputandoutput();
            hienthiemulator();
        }
        #endregion

        private void ChayGiaLap_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            khoitao();
        }

        #region // cấu hình tới máy ảo ldplayer
        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (panellistemualtor.Width == 180)
            {
                panellistemualtor.Width = 30;
            }
            else {
                panellistemualtor.Width = 180;
            }
        }
        private void btnpathLDplay_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = false;
            dlg.CheckPathExists = false;
            dlg.Multiselect = false;
            dlg.Filter = "Files(*.exe)|*.exe";
            dlg.Multiselect = true;
            dlg.SupportMultiDottedExtensions = true;
            dlg.Title = "Select LDPlayer";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames[0]);
                txtpathldplayer.Text = dlg.FileName;
                ExeConfigurationFileMap exmap = new ExeConfigurationFileMap();
                exmap.ExeConfigFilename = @"AutoFB.exe.config";
                //Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(exmap, ConfigurationUserLevel.None);
                cf.AppSettings.Settings.Remove("PathLDPlayer");
                cf.AppSettings.Settings.Add("PathLDPlayer", txtpathldplayer.Text);
                cf.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            try
            {
                hienthiemulator();
               
            }
            catch { }
        }
        #endregion

        #region // phần cấu hình tạo máy ảo
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        [DllImport("user32.dll")]
        public static extern long SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);
        private const int GWL_STYLE = (-16);
        private const int WS_VISIBLE = 0x10000000;
        //Gets window attributes 
        [DllImport("USER32.DLL")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        //assorted constants needed 
        public static int WS_CHILD = 0x40000000; //child window 
        public static int WS_BORDER = 0x00800000; //window with border 
        public static int WS_DLGFRAME = 0x00400000; //window with double border but no title 
        public static int WS_CAPTION = WS_BORDER | WS_DLGFRAME; //window with a title bar 
        #endregion

        #region // hàm gọi từ usercontrol
        public void Closeemulator(String pid, string name)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                Process[] process = Process.GetProcesses();

                foreach (Process prs in process)
                {
                    if (prs.Id == int.Parse(pid))
                    {
                        prs.Kill();
                        break;
                    }
                }
            }
            catch { }
            try
            {
                foreach (Control control in flowLayoutPanelContent.Controls)
                {

                    if (control.GetType() == typeof(UC_Emulator))
                    {
                        UC_Emulator movie = (UC_Emulator)control;                       
                        flowLayoutPanelContent.Controls.Remove(control);
                        control.Dispose();                        
                    }
                }
            }
            catch { }
            this.Cursor = Cursors.Default;
        }
        public void Setting(string idphone)
        {
            this.Cursor = Cursors.WaitCursor;
            CauHinhGiaLap fn = new CauHinhGiaLap(idphone);
            fn.Show();
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region // chạy lần lượt theo lựa chọn
        private void btnchaymayao_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Phone", typeof(string));
            foreach (DataGridViewRow row in Listemulator.Rows)
            {
                int i = row.Index;
                bool chk = false;
                try
                {
                    chk = bool.Parse(Listemulator.Rows[i].Cells[0].Value.ToString());
                }
                catch { }
                if (chk == true)
                {
                    int id = int.Parse(Listemulator.Rows[i].Cells["ID"].Value.ToString());
                    string mail = Listemulator.Rows[i].Cells["Phone"].Value.ToString();
                    Listemulator.Rows[i].DefaultCellStyle.BackColor = Color.Beige;
                    table.Rows.Add(id, mail);
                }

            }
            if (table.Rows.Count > 0)
            {

                #region //chay tạo emulator
                foreach (DataRow row in table.Rows)
                {
                    int idmail = int.Parse(row["ID"].ToString());
                    string m_mail = row["Phone"].ToString();

                    try
                    {

                        Process p = new Process();
                        p.StartInfo.FileName = txtpathldplayer.Text;//.Replace(".exe", idmail + ".exe");
                        p.StartInfo.Arguments = "index =" + idmail.ToString();
                        p.Start();
                        p.WaitForInputIdle();
                        UC_Emulator a = new UC_Emulator(p.Id.ToString(), m_mail, idmail.ToString());
                        flowLayoutPanelContent.Controls.Add(a);
                        Thread.Sleep(4000);
                        SetParent(p.MainWindowHandle, a.Handle);
                        int style = GetWindowLong(p.MainWindowHandle, GWL_STYLE);
                        SetWindowLong(p.MainWindowHandle, GWL_STYLE, (style & ~WS_DLGFRAME));
                        MoveWindow(p.MainWindowHandle, -33, -33, 300, 450, true);
                        Thread.Sleep(1000);

                    }
                    catch { }
                }
                #endregion
            }
            else
            {
                MessageBox.Show("Hãy chọn kênh cần open emulator", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion

        #region // chạy theo luồng



        public void CloseemulatorV2(String pid, string name)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                Process[] process = Process.GetProcesses();

                foreach (Process prs in process)
                {
                    if (prs.Id == int.Parse(pid))
                    {
                        prs.Kill();
                        break;
                    }
                }
            }
            catch { }
            this.Cursor = Cursors.Default;
        }
        private void CreateControl(int maxConcurrency)
        {
            int soluong = 0;
            foreach (Control control in flowLayoutPanelContent.Controls)
            {
                if (control.GetType() == typeof(UC_Emulator))
                {
                    soluong = soluong + 1;
                }
            }
            if(soluong< maxConcurrency)
            {
                for (int i = 0; i < maxConcurrency-soluong; i++)
                {
                    UC_Emulator a = new UC_Emulator("0", "Chưa có Phone","0");
                    flowLayoutPanelContent.Controls.Add(a);
                }
            }
        }
        private void btnchaytheoluong_Click(object sender, EventArgs e)
        {
            int maxConcurrency = int.Parse(txtsoluong.Value.ToString());

            #region // tạo sẵn số UC trong panel
            CreateControl(maxConcurrency);
            #endregion

            DataTable dt = (DataTable)Listemulator.DataSource;
            using (SemaphoreSlim concurrencySemaphore = new SemaphoreSlim(maxConcurrency))
            {
                List<Task> tasks = new List<Task>();
                foreach (DataRow r in dt.Rows)
                {
                    concurrencySemaphore.Wait();
                    var t = Task.Factory.StartNew(() =>
                    {
                        try
                        {

                            int idmail = int.Parse(r["ID"].ToString());
                            string m_mail = r["Phone"].ToString();
                           
                            Process p = new Process();
                            p.StartInfo.FileName = txtpathldplayer.Text;//.Replace(".exe", idmail + ".exe");
                            p.StartInfo.Arguments = "index =" + idmail.ToString();
                            p.Start();
                            p.WaitForInputIdle();
                            foreach (Control control in flowLayoutPanelContent.Controls)
                            {

                                if (control.GetType() == typeof(UC_Emulator))
                                {
                                    UC_Emulator movie = (UC_Emulator)control;
                                    if (movie.m_idprosess == "0")
                                    {
                                        movie.m_idprosess = p.Id.ToString();
                                        movie.m_name = m_mail;
                                        movie.m_idphone = idmail.ToString();
                                        movie.loadname();
                                        Thread.Sleep(5000);
                                        SetParent(p.MainWindowHandle, movie.Handle);
                                        int style = GetWindowLong(p.MainWindowHandle, GWL_STYLE);
                                        SetWindowLong(p.MainWindowHandle, GWL_STYLE, (style & ~WS_DLGFRAME));
                                        MoveWindow(p.MainWindowHandle, -33, -33, 300, 450, true);
                                        Thread.Sleep(15000);
                                        CloseemulatorV2(p.Id.ToString(), m_mail);
                                        movie.m_idprosess = "0";
                                        movie.m_name = "Chưa có Phone";
                                        movie.m_idphone = "0";
                                    }
                                }
                            }
                           

                        }
                        finally
                        {
                            concurrencySemaphore.Release();
                        }
                    });

                    tasks.Add(t);
                }
                Task.WaitAll(tasks.ToArray());
            }

        }
        #endregion

    }
}
