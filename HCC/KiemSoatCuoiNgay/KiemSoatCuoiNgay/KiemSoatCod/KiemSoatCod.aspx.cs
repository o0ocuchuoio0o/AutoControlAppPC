using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KiemSoatCuoiNgay.KiemSoatCod
{
    public partial class KiemSoatCod : System.Web.UI.Page
    {

        #region // hiên thị grid
        private void hienthidanhsachkenh()
        {
            tblKenh tt = new tblKenh();
            storedskenh.DataSource = tt.DanhSachKenh(Cl_KetNoi.hamketnoisql(), int.Parse(lblflag.Value.ToString()));
            storedskenh.DataBind();
            cmbkenh.SelectedItems.Add(new Ext.Net.ListItem { Index = 0, Mode = Ext.Net.ParameterMode.Raw });
            cmbkenh.UpdateSelectedItems();
        }
        private void danhsachtintucchuaup()
        {
            tblBaiViet ds = new tblBaiViet();
            DataTable dt = new DataTable();
            DateTime ngay = Convert.ToDateTime(txtngay.Text);
            int kenh = 0;
            try { kenh = Convert.ToInt32(cmbkenh.SelectedItem.Value); }
            catch { kenh = 0; }
            dt = ds.DanhSachBaiVietTheoNgay(Cl_KetNoi.hamketnoisql(), int.Parse(lblflag.Value.ToString()), ngay, kenh);
            if (dt.Rows.Count > 0)
            {
                stodanhsachtintuc.DataSource = dt;
                stodanhsachtintuc.DataBind();
            }
        }
        private void danhsachtintucdangrender()
        {
            tblBaiViet ds = new tblBaiViet();
            DataTable dt = new DataTable();
            DateTime ngay = Convert.ToDateTime(txtngay.Text);
            int kenh = 0;
            try { kenh = Convert.ToInt32(cmbkenh.SelectedItem.Value); }
            catch { kenh = 0; }
            dt = ds.DanhSachBaiVietTheoNgayDangRender(Cl_KetNoi.hamketnoisql(), int.Parse(lblflag.Value.ToString()), ngay, kenh);
            if (dt.Rows.Count > 0)
            {
                stodanhsachtintuc.DataSource = dt;
                stodanhsachtintuc.DataBind();
            }
        }
        private void danhsachtintucdarender()
        {
            tblBaiViet ds = new tblBaiViet();
            DataTable dt = new DataTable();
            DateTime ngay = Convert.ToDateTime(txtngay.Text);
            int kenh = 0;
            try { kenh = Convert.ToInt32(cmbkenh.SelectedItem.Value); }
            catch { kenh = 0; }
            dt = ds.DanhSachBaiVietTheoNgayDaRender(Cl_KetNoi.hamketnoisql(), int.Parse(lblflag.Value.ToString()), ngay, kenh);
            if (dt.Rows.Count > 0)
            {
                stodanhsachtintuc.DataSource = dt;
                stodanhsachtintuc.DataBind();
            }
        }
        private void danhsachtintucdaup()
        {
            tblBaiVietDaUp ds = new tblBaiVietDaUp();
            DataTable dt = new DataTable();
            DateTime ngay = Convert.ToDateTime(txtngay.Text);
            int kenh = 0;
            try { kenh = Convert.ToInt32(cmbkenh.SelectedItem.Value); }
            catch { kenh = 0; }
            dt = ds.DanhSachBaiVietDaUpTheoNgay(Cl_KetNoi.hamketnoisql(), int.Parse(lblflag.Value.ToString()), ngay, kenh);
            if (dt.Rows.Count > 0)
            {
                stodanhsachtintuc.DataSource = dt;
                stodanhsachtintuc.DataBind();
            }
        }
        private void hienthidulieu()
        {
            if (Radiodaup.Checked == true)
            {
                danhsachtintucdaup();
                CommandColumnXoa.Visible = false;
            }
            else if (Radiochuarender.Checked == true)
            {
                danhsachtintucchuaup();
            }
            else if (Radiodangrender.Checked == true)
            {
                danhsachtintucdangrender();
            }
            else if (Radiochuaup.Checked == true)
            {
                danhsachtintucdarender();
            }
            else
            {
                //   danhsachtintucchuaup();
            }
        }
        protected void DanhSachTinTucPhanTrang(object sender, StoreReadDataEventArgs e)
        {
            hienthidulieu();
        }
        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                lblflag.Value = Request.QueryString["BDHN"];
                txtngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
                hienthidanhsachkenh();
                hienthidulieu();
            }
        }

        protected void Cmd_XoaTin(object sender, DirectEventArgs e)
        {
            int id = int.Parse(e.ExtraParams["ID"].ToString());
            tblBaiViet xoa = new tblBaiViet();
            xoa.XoaBaiViet(Cl_KetNoi.hamketnoisql(), id);
            this.grdDanhSachTinTuc.GetStore().Reload();
        }

      
        protected void cmbchitiet_Sua(object sender, DirectEventArgs e)
        {
            int id = int.Parse(e.ExtraParams["ID"].ToString());
            Ext.Net.Window _CuaSoInDonHang = new Ext.Net.Window();
            _CuaSoInDonHang = CuaSoChiTiet(cl_ReadURL.LayDiaChiURL("/DanhSachTinTuc/ChiTietTinTuc.aspx?IDBaiViet=" + id));
            this.Form.Controls.Add(_CuaSoInDonHang);
            _CuaSoInDonHang.Render();
            _CuaSoInDonHang.Show();
        }
        protected void cmbrenderlai_Sua(object sender, DirectEventArgs e)
        {
            int id = int.Parse(e.ExtraParams["ID"].ToString());
            tblBaiViet rd = new tblBaiViet();
            rd.RenderLaiBaiViet(Cl_KetNoi.hamketnoisql(), id);
            hienthidulieu();
        }


        protected void Cmd_AddTin(object sender, DirectEventArgs e)
        {
            int id = int.Parse(e.ExtraParams["ID"].ToString());
            string TieuDe = e.ExtraParams["TieuDe"].ToString();
            string m_NoiDung = e.ExtraParams["NoiDung"].ToString();
            string NoiDung = m_NoiDung.Replace("\r\n", "<br/>");
            string HinhAnh = e.ExtraParams["HinhAnh"].ToString();
            string Tag = e.ExtraParams["Tag"].ToString();
            string LinkBaiViet = e.ExtraParams["LinkBaiViet"].ToString();
            tblBaiVietTamWebSite them = new tblBaiVietTamWebSite();
            them.HinhAnh = HinhAnh;
            them.LinkBaiViet = LinkBaiViet;
            them.Tag = Tag;
            them.TieuDe = TieuDe;
            them.NoiDung = NoiDung;
            if (int.Parse(lblflag.Value.ToString()) == 1)
            {
                them.InsertBaiVietTam(Cl_KetNoi.hamketnoisqlwebsite());
            }
            else if (int.Parse(lblflag.Value.ToString()) == 3)
            {
                them.InsertBaiVietTam(Cl_KetNoi.hamketnoisqlwebsite2());
            }
            if (Radiodaup.Checked == true)
            {
                tblBaiViet xoa = new tblBaiViet();
                xoa.XoaBaiViet(Cl_KetNoi.hamketnoisql(), id);
            }
            X.Msg.Alert("Thành công", "OK đã thêm dữ liệu vào website").Show();
            this.grdDanhSachTinTuc.GetStore().Reload();
        }
        protected void btnhienthi_Click(object sender, DirectEventArgs e)
        {
            hienthidulieu();
        }
        protected void btnXoaDuLieuDaUp_Click(object sender, DirectEventArgs e)
        {
            tblBaiVietDaUp ds = new tblBaiVietDaUp();
            DataTable dt = new DataTable();
            DateTime ngay = Convert.ToDateTime(txtngay.Text);
            dt = ds.DanhSachBaiVietDaUpTheoNgay_Xoa(Cl_KetNoi.hamketnoisql(), ngay);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    try
                    {
                        File.Delete(Server.MapPath("~/FileKetQua/" + r["ID"].ToString() + ".rar"));
                        File.Delete(Server.MapPath("~/FileKetQua/" + r["ID"].ToString() + "_Thumnail.rar"));
                    }
                    catch { }
                }
            }
            X.Msg.Alert("Thành công", "OK đã dọn dẹp dữ liệu").Show();
        }
        protected void btnXoaVoiceDaRender_Click(object sender, DirectEventArgs e)
        {
            tblChiTietBaiVietDaRender ds = new tblChiTietBaiVietDaRender();
            DataTable dt = new DataTable();
            dt = ds.ChiTietBaiViet(Cl_KetNoi.hamketnoisql());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    try
                    {
                        File.Delete(Server.MapPath("~/FileVoice/" + r["IDChiTiet"].ToString() + ".rar"));
                    }
                    catch { }
                }
                tblChiTietBaiVietDaRender xoa = new tblChiTietBaiVietDaRender();
                xoa.XoaChiTiet(Cl_KetNoi.hamketnoisql());
            }
            X.Msg.Alert("Thành công", "OK đã dọn dẹp dữ liệu").Show();
        }
    }
}