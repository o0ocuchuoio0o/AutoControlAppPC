using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFB
{
    public partial class CauHinhGiaLap : Form
    {
        public CauHinhGiaLap(string idphone)
        {
            InitializeComponent();
            lbltitle.Text = "Cấu hình tài khoản trong phone " + idphone.ToString();
            m_IDPhone = idphone;
           
        }
        private string m_IDPhone;
        public string IDPhone { get => m_IDPhone; set => m_IDPhone = value; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void dstaikhoanchuaganphone()
        {
            daSqllite dl = new daSqllite();
            DataSet ds = new DataSet();
            ds = dl.DataChuaGanPhone();
            if (ds.Tables.Count > 0)
            {
                ListTaiKhoanFB.DataSource = ds.Tables[0];
            }
        }
        private void dstaikhoantheophone()
        {
            daSqllite dl = new daSqllite();
            DataSet ds = new DataSet();
            ds = dl.DataTheoPhone(int.Parse(m_IDPhone));
            if (ds.Tables.Count > 0)
            {
                ListTaiKhoan.DataSource = ds.Tables[0];
            }
        }
        private void configinputandoutput()
        {
            try
            {
                if (ConfigurationManager.AppSettings["PathAPK"].ToString() != "")
                {
                    txtsavedata.Text = ConfigurationManager.AppSettings["PathAPK"].ToString();
                }
                
            }
            catch { }
        }
        private void CauHinhGiaLap_Load(object sender, EventArgs e)
        {
            dstaikhoanchuaganphone();
            dstaikhoantheophone();
            configinputandoutput();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CauHinhGiaLap_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var selectedRows = ListTaiKhoanFB.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(row => !row.IsNewRow)
            .ToArray();
            foreach (var row in selectedRows)
            {              
                string _USERNAME= ListTaiKhoanFB.Rows[row.Index].Cells["USERNAME"].Value.ToString();
                #region // add tài khoản cấu hình theo phone
                daSqllite add = new daSqllite();
                add.UpdatePhone(_USERNAME,int.Parse(m_IDPhone));
                #endregion
            }
            dstaikhoanchuaganphone();
            dstaikhoantheophone();
        }

        private void btnresetapk_Click(object sender, EventArgs e)
        {

        }

        private void btnexportapk_Click(object sender, EventArgs e)
        {

            string pathldplayer = ConfigurationManager.AppSettings["PathLDPlayer"].ToString();
            pathldplayer = pathldplayer.Replace("dnplayer.exe", "");
            AutoADB.LDPlayerHelper.LDP_FOLDER_PATH = pathldplayer;
            string mail = "";
            var selectedRows = ListTaiKhoan.SelectedRows
             .OfType<DataGridViewRow>()
             .Where(row => !row.IsNewRow)
             .ToArray();
            string _USERNAME = "";
            foreach (var row in selectedRows)
            {
                _USERNAME = ListTaiKhoan.Rows[row.Index].Cells["USERNAME"].Value.ToString();
                #region // add tài khoản cấu hình theo phone
                AutoADB.LDPlayerHelper.bachupapp(m_IDPhone, "com.facebook.katana", txtsavedata.Text + @"" + _USERNAME + ".apk");
                #endregion
            }
            MessageBox.Show("Done export APK" + _USERNAME);


        }

        private void btnpathsavedata_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;           
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames[0]);
                txtsavedata.Text = folderDlg.SelectedPath;
                ExeConfigurationFileMap exmap = new ExeConfigurationFileMap();
                exmap.ExeConfigFilename = @"AutoFB.exe.config";
                //Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(exmap, ConfigurationUserLevel.None);
                cf.AppSettings.Settings.Remove("PathAPK");
                cf.AppSettings.Settings.Add("PathAPK", txtsavedata.Text);
                cf.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }
    }
}
