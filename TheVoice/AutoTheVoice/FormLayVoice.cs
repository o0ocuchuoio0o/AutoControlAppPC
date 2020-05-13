using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Configuration;
namespace AutoTheVoice
{
    public partial class FormLayVoice : Form
    {
        public FormLayVoice()
        {
            InitializeComponent();
        }
        #region // load folder output
        private void configinputandoutput()
        {
            try
            {
                if (ConfigurationManager.AppSettings["OutputFolder"].ToString() == "")
                {
                    if (!Directory.Exists("D:\\_OutputFolder"))
                    {
                        Directory.CreateDirectory("D:\\_OutputFolder");
                    }
                    txtfloderout.Text = @"D:\_OutputFolder";
                }
                else
                {
                    txtfloderout.Text = ConfigurationManager.AppSettings["OutputFolder"].ToString();
                }
            }
            catch { }
           
        }
        private int GetOSArchitecture()
        {
            string pa =
                Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            return ((String.IsNullOrEmpty(pa) ||
                     String.Compare(pa, 0, "x86", 0, 3, true) == 0) ? 32 : 64);
        }
        private void config()
        {
            string duongdan = "";
            try
            {
                int checkio = GetOSArchitecture();

                if (checkio == 64)
                {
                    duongdan = System.IO.Directory.GetCurrentDirectory() + @"\Win64bit\ffmpeg.exe";
                }
                else
                {
                    duongdan = System.IO.Directory.GetCurrentDirectory() + @"\Win32bit\ffmpeg.exe";
                }
            }
            catch
            {
                duongdan = System.IO.Directory.GetCurrentDirectory() + @"\Win32bit\ffmpeg.exe";
            }
            ExeConfigurationFileMap exmap = new ExeConfigurationFileMap();
            exmap.ExeConfigFilename = @"AutoTheVoice.exe.config";
            //Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(exmap, ConfigurationUserLevel.None);
            cf.AppSettings.Settings.Remove("ffmpeg:ExeLocation");
            cf.AppSettings.Settings.Add("ffmpeg:ExeLocation", duongdan);
            cf.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        #endregion
        public static void Concatenate(string[] mp3filenames,string pathout)
        {
            Stream w = File.OpenWrite(pathout);
            foreach (string filename in mp3filenames)
                File.OpenRead(filename).CopyTo(w);
            w.Flush();
            w.Close();
        }
        private void downloadFileV2(string url, string path)
        {
            using (WebClient wc = new WebClient())
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;              
                wc.DownloadFileCompleted += wc_DownloadFileCompletedV2;
                wc.DownloadFileAsync(new Uri(url), path);
            }
        }
        private void wc_DownloadFileCompletedV2(object sender, AsyncCompletedEventArgs e)
        {
           // lblxuly.Text = "Lấy voice done!";
        }
        private void downloadFileV2_Ex(string url, string path)
        {
            xNet.HttpRequest http = new xNet.HttpRequest();
            http.ConnectTimeout = 99999999;
            http.KeepAliveTimeout = 99999999;
            http.ReadWriteTimeout = 99999999;
            var binImg = http.Get(url).ToMemoryStream().ToArray();
            File.WriteAllBytes(path, binImg);
        }
        private void ChomeClose()
        {
            try
            {
                try
                {
                    PropretiesCollection.driver.Close();
                    PropretiesCollection.driver.Quit();
                }
                catch { }
                System.Threading.Thread.Sleep(2000);
                try
                {
                    foreach (Process proc in Process.GetProcessesByName("chromedriver"))
                    {
                        proc.Kill();
                    }
                }
                catch { }
                try
                {
                    foreach (Process proc in Process.GetProcessesByName("chrome"))
                    {
                        proc.Kill();
                    }
                }
                catch { }
                try
                {
                    foreach (Process proc in Process.GetProcessesByName("chrome.exe"))
                    {
                        proc.Kill();
                    }
                }
                catch { }
                try
                {
                    foreach (Process proc in Process.GetProcessesByName("geckodriver"))
                    {
                        proc.Kill();
                    }
                }
                catch { }
                try
                {
                    foreach (Process proc in Process.GetProcessesByName("firefox"))
                    {
                        proc.Kill();
                    }
                }
                catch { }
            }
            catch { }
        }
       
        private void hienthiapi()
        {
            DataTable dt = new DataTable();
            WS_Service.WS_Service ds = new WS_Service.WS_Service();
            dt = ds.DanhSachAPI();
            cmbapi.DataSource = dt;
            cmbapi.ValueMember = "API";
            cmbapi.DisplayMember = "API";
        }
        private void CompressRAR(string rar_file, string path_file)
        {
            try
            {
                foreach (Process procs in Process.GetProcessesByName("WinRAR"))
                {
                    procs.Kill();
                }
            }
            catch { }
            ProcessStartInfo ps = new ProcessStartInfo();
            // - File chương trình nén và giải nén Winar
            ps.FileName = @"WinRAR.exe";
            // - Tham số truyền vào câu lệnh (vd: rar.exe a - trong đó a là tham số)
            // - rar_file: tên file nén | path_file: đường dẫn nguồn nén(file đc nén, thư mục đc nén)
            // - \" Thêm vào một dấu nháy kép ("")
            ps.Arguments = "a -r -ep1 \"" + rar_file + "\" \"" + path_file + "\"";
            ps.WindowStyle = ProcessWindowStyle.Hidden;     // - Ẩn cửa sổ nén
            // - Chạy câu lệnh nén
            Process proc = Process.Start(ps);
            // - Thoát sau khi nén xong
            proc.WaitForExit();
        }
        private void ExtractRAR(string rar_file, string path_file)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            // - File chương trình nén và giải nén Winar
            ps.FileName = @"WinRAR.exe";
            // - Tham số truyền vào câu lệnh (vd: rar.exe x - trong đó x là tham số)
            // - rar_file: tên file nén | path_file: đường dẫn giải nén(file đc giải nén, thư mục đc giải nén)
            // - \" Thêm vào một dấu nháy kép ("")
            ps.Arguments = "x -y \"" + rar_file + "\" \"" + path_file + "\"";
            ps.WindowStyle = ProcessWindowStyle.Hidden;     // - Ẩn cửa sổ giải nén
            // - Chạy câu lệnh giải nén
            Process proc = Process.Start(ps);
            // - Thoát sau khi giải nén xong
            proc.WaitForExit();
        }
      
        private void FormLayVoice_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            configinputandoutput();
            config();
            hienthiapi();
        }

        private void btnfloderout_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fl = new FolderBrowserDialog();
            fl.ShowNewFolderButton = true;
            if (fl.ShowDialog() == DialogResult.OK)
            {
                txtfloderout.Text = fl.SelectedPath;
                ExeConfigurationFileMap exmap = new ExeConfigurationFileMap();
                exmap.ExeConfigFilename = @"AutoTheVoice.exe.config";
                //Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(exmap, ConfigurationUserLevel.None);
                cf.AppSettings.Settings.Remove("OutputFolder");
                cf.AppSettings.Settings.Add("OutputFolder", txtfloderout.Text);
                cf.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void XoaFilemp3(string pathoutput)
        {

            string[] fileList = System.IO.Directory.GetFiles(pathoutput);
            //duyệt từng file và copy đè lên file cũ trong thư mục đang chạy chương trình
            foreach (string sourceFile in fileList)
            {
                //tách tên file ra khỏi đường dẫn (tên file sẽ dùng để tạo đường dẫn đích cần copy đè)
                string fileName = System.IO.Path.GetFileName(sourceFile);
                //tạo đường dẫn đích để copy file mới tới
                if (fileName.IndexOf(".mp4") != -1 || fileName.IndexOf(".mp3") != -1 || fileName.IndexOf(".avi") != -1 || fileName.IndexOf(".webm") != -1)
                {
                    string destinationFile = pathoutput + @"\" + fileName;
                    System.IO.File.Delete(destinationFile);

                }

            }

        }
        private void btnlayvoice_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(txtfloderout.Text + @"\Out"))
            {
                Directory.CreateDirectory(txtfloderout.Text + @"\Out");
            }
            try
            {
                if (!bgwlayvoice.IsBusy)
                {
                    timerlayvoice.Enabled = false;
                    timerlayvoice.Stop();
                    bgwlayvoice.RunWorkerAsync();

                }
            }
            catch
            {
                txtthongbao.Text = string.Empty;
                timerlayvoice.Enabled = true;
                timerlayvoice.Interval = 8000;
                timerlayvoice.Start();
            }
        }
        public static String chuanHoa(String _string)
        {
            return System.Text.RegularExpressions.Regex.Replace(_string, "\\s+", " ");
        }
        private void bgwlayvoice_DoWork(object sender, DoWorkEventArgs e)
        {

            DataTable dt = new DataTable();
            WS_Service.WS_Service ds = new WS_Service.WS_Service();
            dt = ds.DanhSachCanRender();
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                string _ngonngu = r["NgonNgu"].ToString();
                string _gioitinh = r["GioiTinh"].ToString();
                string _noidung = r["NoiDung"].ToString();
                string _id=r["ID"].ToString();
                #region // thực hiện update đang render
                WS_Service.WS_Service render = new WS_Service.WS_Service();
                render.UpdateDangRender(Guid.Parse(r["ID"].ToString()));
                #endregion
                if (!Directory.Exists(txtfloderout.Text + @"\Out\" + r["ID"].ToString()))
                {
                    Directory.CreateDirectory(txtfloderout.Text + @"\Out\" + r["ID"].ToString());
                }
                XoaFilemp3(txtfloderout.Text + @"\Out");
                #region text cat nho
                string chuoingatcau = @". ";
                if (_ngonngu == "Japanese")
                {
                    chuoingatcau = @"。";
                }
                else if (_ngonngu == "Chinese")
                {
                    chuoingatcau = @"。";
                }
                else
                {
                    chuoingatcau = @". ";
                }

                string temp =chuanHoa(_noidung).Replace(chuoingatcau, "|");
                string[] listtext = temp.Split('|');

                #region // xử lý bật site lấy voice
                ChromeOptions options = new ChromeOptions();
                // options.AddArgument("headless");
                // PropretiesCollection.driver = new ChromeDriver(service,options);
                PropretiesCollection.driver = new ChromeDriver(options);

                cl_ReadVoice read = new cl_ReadVoice();
                if (radvoiceware.Checked == true)
                {
                    PropretiesCollection.driver.Navigate().GoToUrl("http://www.voiceware.co.kr/eng/product/product1.php?fbclid=IwAR3uoWfvMJ6g53aNRf6o3WSm8A4fbq3hg7OVjXRD4K43ktPh9SsyP_zDnQ0");
                    read.selectV2(_ngonngu, "");
                }
                else if (radTTScool.Checked == true)
                {
                    PropretiesCollection.driver.Navigate().GoToUrl("https://tts.cool/");
                    read.select_Service(cmbapi.Text);
                    read.select_Sex(_gioitinh);
                    read.selectV2_TTSCool(_ngonngu);
                }

                #endregion

                DataTable _DuLieu = new DataTable();
                _DuLieu.Columns.Add("FileVoice",typeof(string));
                int k = 1;

                string _urlvoicecu = "";
                string listvoice = "";
                for (int row = 0; row < listtext.Length; row++)
                {
                  
                    #region //DUYET LAY VOICE

                    string url = "";
                    string text = listtext[row].ToString();
                    if (text != "")
                    {
                        txtthongbao.Text = "Đang lấy voice id:"+_id+" thứ " + k.ToString() + ":" + text.ToString();
                        string voicefile = txtfloderout.Text + @"\Out\"+r["ID"].ToString()+ @"\" + row.ToString() + ".wav";
                        string _voice = txtfloderout.Text + @"\Out\" + r["ID"].ToString()  +@"\" + row.ToString() + ".mp3";
                        if (radvoiceware.Checked == true)
                        {
                            if (text.Length >= 200)
                            {
                                url = read.getURLMp3_V2(_urlvoicecu, text.Trim().Substring(0, 199));
                                _urlvoicecu = url;
                            }
                            else
                            {
                                url = read.getURLMp3_V2(_urlvoicecu, text.Trim());
                                _urlvoicecu = url;
                            }
                            if (url != "")
                            {
                                downloadFileV2(url, voicefile);
                            }
                            Thread.Sleep(2000);
                            RunFFMPEG fftangmam = new RunFFMPEG();
                            string voicexulytamam = txtfloderout.Text + @"\Out\" + r["ID"].ToString() + @"\voicexuly" + row.ToString() + ".wav";
                            string tangam = string.Format(@"-i {0} -filter:a loudnorm {1}", voicefile, voicexulytamam);
                            fftangmam.RunCommand(tangam, true);
                            voicefile = voicexulytamam;
                        }
                        else if (radTTScool.Checked == true)
                        {
                            if (text.Length >= 200)
                            {
                                url = read.getURL_TTSCool(_urlvoicecu, text.Trim().Substring(0, 199));
                                _urlvoicecu = url;
                            }
                            else
                            {
                                url = read.getURL_TTSCool(_urlvoicecu, text.Trim());
                                _urlvoicecu = url;
                            }
                            if (url != "")
                            {
                                downloadFileV2_Ex(url, _voice);
                                Thread.Sleep(2000);
                            }
                            voicefile = _voice;
                        }
                        if (File.Exists(voicefile))
                        {
                            _DuLieu.Rows.Add(voicefile);
                            //if (listvoice == "")
                            //{
                            //    listvoice = voicefile;
                            //}
                            //else {
                            //    listvoice = listvoice + "|" + voicefile;
                            //}
                            
                        }
                    }
                    #endregion

                    k = k + 1;
                }
                #endregion

                #region // ghép voice vào 1 file mp3
                string[] mangvoice = new string[_DuLieu.Rows.Count];
                //int indexvoice = 0;
                //foreach (DataRow row in _DuLieu.Rows)
                //{
                //    mangvoice[indexvoice] = row["FileVoice"].ToString();
                //    indexvoice = indexvoice + 1;
                //}
                //string pathvoice = txtfloderout.Text + @"\Out" + @"\" + _id.ToString() + ".mp3";               
                //string kq = mashup.CreateMashup(mangvoice, pathvoice);
                //RunFFMPEG ffghepvoice = new RunFFMPEG();
                //string pathvoice= txtfloderout.Text + @"\Out" + @"\" + _id.ToString() + ".mp3";
                //string ghepvoice = string.Format(@"-i ""concat:"+listvoice+@"""-acodec copy {0}", pathvoice);
                //ffghepvoice.RunCommand(ghepvoice, true);
                           
                #endregion
                ChomeClose();
                #region // nén và upload file lên server
                if (Directory.Exists(txtfloderout.Text + @"\Out\" + r["ID"].ToString()))
                {                  
                    #region // upload file len server
                    try
                    {
                        foreach (Process proc in Process.GetProcessesByName("WinRAR"))
                        {
                            proc.Kill();
                        }
                    }
                    catch { }                   
                    string urlupload = "http://buudienhanoi.com.vn/ThangBDHN_Luu/UpLoadVoice.aspx";
                    WebClient myWebClient = new WebClient();
                    string rar_file = txtfloderout.Text + @"\Out" + @"\" + _id.ToString() + ".zip";
                    CompressRAR(rar_file, txtfloderout.Text + @"\Out\" + r["ID"].ToString());
                    Thread.Sleep(1000);
                    byte[] responseArray = myWebClient.UploadFile(urlupload, rar_file);
                    myWebClient.Dispose();
                    Thread.Sleep(1000);
                            
                    string m_PathVoice = "/FileVoice/" + _id.ToString() + ".zip";                 
                    WS_Service.WS_Service voice=new WS_Service.WS_Service();
                    voice.UpdateDaRender(Guid.Parse(_id),m_PathVoice);
                    XoaFilemp3(txtfloderout.Text + @"\Out\" + r["ID"].ToString());
                    try
                    {
                        foreach (Process proc in Process.GetProcessesByName("WinRAR"))
                        {
                            proc.Kill();
                        }
                    }
                    catch { }
                    #endregion
                }
                #endregion
            }

          
         
         
        }

        private void bgwlayvoice_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
            }
            else
            {
                if (!bgwlayvoice.IsBusy)
                {                   
                    txtthongbao.Text = "Complete!";                   
                    Thread.Sleep(8000);
                    timerlayvoice.Enabled = true;
                    timerlayvoice.Start();
                }
            }
        }

        private void timerlayvoice_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!bgwlayvoice.IsBusy)
                {
                    bgwlayvoice.RunWorkerAsync();
                    timerlayvoice.Enabled = false;
                    timerlayvoice.Stop();
                }

            }
            catch
            {
                txtthongbao.Text = string.Empty;
                timerlayvoice.Enabled = true;
                timerlayvoice.Interval = 8000;
                timerlayvoice.Start();
            }
        }

      
    }
}
