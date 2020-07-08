using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StyleTempleProshow
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void hienthicombox()
        {
            daProshowSildeVideoNen ds = new daProshowSildeVideoNen();
            DataTable dt = new DataTable();
            dt = ds.DanhSachStyle(Cl_KetNoi.hamketnoisql());
            cmbstyle.DataSource = dt;
            cmbstyle.DisplayMember = "ID";
            cmbstyle.ValueMember = "ID";
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            hienthicombox();     
        }
        private void btnchonfile_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT",typeof(int));
            dt.Columns.Add("Silde", typeof(string));
            dt.Columns.Add("ThongSoThayDoi", typeof(int));
            dt.Columns.Add("ThongSoSub", typeof(int));
            dt.Columns.Add("ThongSoVideoNen", typeof(int));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;
            dlg.Filter = "Proshow|*.psh|All files (*.*)|*.*";            
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                string[] lines = File.ReadAllLines(dlg.FileName);
                int stt = 1;
                foreach (string s in lines)
                {
                   

                    if (stt >= 466 && s != "modifierCount=0")
                    {
                        dt.Rows.Add(stt, s,0,0,0);
                        
                    }
                    stt = stt + 1;
                }
                ListDuLieu.DataSource = dt;
                this.Invoke(new Action(() =>
                {
                    int i = dt.Rows.Count - 1;
                    foreach (DataRow r in dt.Rows)
                    {
                       
                        string check = ListDuLieu.Rows[i].Cells["Silde"].Value.ToString();
                        if (check.IndexOf("../..") != -1 || check.IndexOf("sound.length") != -1 || check.IndexOf("time=") != -1)
                        {
                            ListDuLieu.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                        }
                        i = i - 1;
                    }
                }));
               
            }
           
        }

        private void btnthaychuoi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Silde", typeof(string));
            dt.Columns.Add("ThongSoThayDoi", typeof(int));
            dt.Columns.Add("ThongSoSub", typeof(int));
            dt.Columns.Add("ThongSoVideoNen", typeof(int));
            DataTable table = (DataTable)ListDuLieu.DataSource;
            if (table.Rows.Count > 0)
            {
                foreach (DataRow r in table.Rows)
                {
                    int _STT = int.Parse(r["STT"].ToString());
                    int _ThongSoThayDoi = int.Parse(r["ThongSoThayDoi"].ToString());
                    int _ThongSoSub = int.Parse(r["ThongSoSub"].ToString());
                    int _ThongSoVideoNen = int.Parse(r["ThongSoVideoNen"].ToString());
                    string _Silde = r["Silde"].ToString().Replace(txtgoc.Text,txtthaydoi.Text);
                    dt.Rows.Add(_STT,_Silde, _ThongSoThayDoi, _ThongSoSub, _ThongSoVideoNen);
                }
                ListDuLieu.DataSource = dt;
                this.Invoke(new Action(() =>
                {
                    int i = dt.Rows.Count - 1;
                    foreach (DataRow r in dt.Rows)
                    {

                        string check = ListDuLieu.Rows[i].Cells["Silde"].Value.ToString();
                        if (check.IndexOf("../..") != -1 || check.IndexOf("sound.length") != -1 || check.IndexOf("time=") != -1)
                        {
                            ListDuLieu.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                        }
                        i = i - 1;
                    }
                }));
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));           
            dt.Columns.Add("Silde", typeof(string));
            dt.Columns.Add("ThongSoThayDoi", typeof(int));
            dt.Columns.Add("ThongSoSub", typeof(int));
            dt.Columns.Add("ThongSoVideoNen", typeof(int));
            dt.Columns.Add("STT", typeof(int));
            DataTable table = (DataTable)ListDuLieu.DataSource;
            if (table.Rows.Count > 0)
            {
                foreach (DataRow r in table.Rows)
                {
                    int _ID = int.Parse(cmbstyle.Text);
                    int _STT = int.Parse(r["STT"].ToString());
                    int _ThongSoThayDoi = int.Parse(r["ThongSoThayDoi"].ToString());
                    int _ThongSoSub = int.Parse(r["ThongSoSub"].ToString());
                    int _ThongSoVideoNen = int.Parse(r["ThongSoVideoNen"].ToString());
                    string _Silde = r["Silde"].ToString().Replace(txtgoc.Text, txtthaydoi.Text);
                    dt.Rows.Add(_ID, _Silde, _ThongSoThayDoi, _ThongSoSub, _ThongSoVideoNen, _STT);
                }
                daProshowSildeVideoNen them = new daProshowSildeVideoNen();
                them.ThemStyle(Cl_KetNoi.hamketnoisql(),dt);
                hienthicombox();
                MessageBox.Show("ok thêm thành công");
            }
        }

        private void cmbstyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            daProshowSildeVideoNen ds = new daProshowSildeVideoNen();
            DataTable dt = new DataTable();
            dt = ds.ThongTinStyle(Cl_KetNoi.hamketnoisql(),int.Parse(cmbstyle.Text));
            if (dt.Rows.Count > 0)
            {
                ListDuLieu.DataSource = dt;
                this.Invoke(new Action(() =>
                {
                    int i = dt.Rows.Count - 1;
                    foreach (DataRow r in dt.Rows)
                    {

                        string check = ListDuLieu.Rows[i].Cells["Silde"].Value.ToString();
                        if (check.IndexOf("../..") != -1 || check.IndexOf("sound.length") != -1 || check.IndexOf("time=") != -1)
                        {
                            ListDuLieu.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                        }
                        i = i - 1;
                    }
                }));
            }
            }
            catch { }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Silde", typeof(string));
            dt.Columns.Add("ThongSoThayDoi", typeof(int));
            dt.Columns.Add("ThongSoSub", typeof(int));
            dt.Columns.Add("ThongSoVideoNen", typeof(int));
            dt.Columns.Add("STT", typeof(int));
            DataTable table = (DataTable)ListDuLieu.DataSource;
            if (table.Rows.Count > 0)
            {
                int _ID = int.Parse(cmbstyle.Text);
                foreach (DataRow r in table.Rows)
                {
                    
                    int _STT = int.Parse(r["STT"].ToString());
                    int _ThongSoThayDoi = int.Parse(r["ThongSoThayDoi"].ToString());
                    int _ThongSoSub = int.Parse(r["ThongSoSub"].ToString());
                    int _ThongSoVideoNen = int.Parse(r["ThongSoVideoNen"].ToString());
                    string _Silde = r["Silde"].ToString().Replace(txtgoc.Text, txtthaydoi.Text);
                    dt.Rows.Add(_ID, _Silde, _ThongSoThayDoi, _ThongSoSub, _ThongSoVideoNen, _STT);
                }
                daProshowSildeVideoNen xoa = new daProshowSildeVideoNen();
                xoa.XoaStyle(Cl_KetNoi.hamketnoisql(),_ID);
                daProshowSildeVideoNen them = new daProshowSildeVideoNen();
                them.ThemStyle(Cl_KetNoi.hamketnoisql(), dt);
                hienthicombox();
                MessageBox.Show("ok sưa thành công");
            }
        }

        private void btntaopsh_Click(object sender, EventArgs e)
        {
            DataTable slidepsproshow = new DataTable();
            slidepsproshow.Columns.Add("PathMC", typeof(string));
            slidepsproshow.Columns.Add("PathSub", typeof(string));
            slidepsproshow.Columns.Add("PathImage", typeof(string));
            slidepsproshow.Columns.Add("TimeSlide", typeof(string));
            slidepsproshow.Columns.Add("PathVoice", typeof(string));
            slidepsproshow.Columns.Add("TimeVoice", typeof(string));
          
                string _PathMC = "";
                string _PathSub =txtsub.Text;
                string _PathImage = txtanh.Text;
                string _TimeSlide ="5000";
                string _PathVoice = txtvoice.Text;
                string _TimeVoice = "5000";               
                slidepsproshow.Rows.Add(_PathMC, _PathSub, _PathImage, _TimeSlide, _PathVoice, _TimeVoice);
                slidepsproshow.Rows.Add(_PathMC, _PathSub, _PathImage, _TimeSlide, _PathVoice, _TimeVoice);

                proshowserver creatvideo = new proshowserver();
                string filePsh;
                filePsh = creatvideo._CreatePSH(int.Parse(cmbstyle.Text),"1",
                                                   txtintro.Text,"8000",
                                                   txtouttro.Text, "5000",
                                                   @"D:\", txtmusicbg.Text, slidepsproshow, txtvideobg.Text);
        }

    }
}
