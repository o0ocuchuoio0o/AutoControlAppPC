using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DaoTheVoice;
using Ext.Net;
using TheVoice.KetNoi;
using System.Data;
namespace TheVoice.QuanLy
{
    public partial class DanhSachNguoiDung : System.Web.UI.Page
    {
        #region // hiên thị grid
        private void danhsachnguoidung()
        {
            daNguoiDung ds = new daNguoiDung();
            DataTable dt = new DataTable();
            dt = ds.DanhSach(Cl_KetNoi.hamketnoisql());
            if (dt.Rows.Count > 0)
            {
                stodanhsachnguoidung.DataSource = dt;
                stodanhsachnguoidung.DataBind();
            }
        }
        protected void DanhSachNguoiDungPhanTrang(object sender, StoreReadDataEventArgs e)
        {
            danhsachnguoidung();
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                danhsachnguoidung();               
            }
        }

        protected void btnthemnguoidung_Click(object sender, DirectEventArgs e)
        {
            btnsuathongtinnguoidung.Hidden = true;
            btnthemmoi.Hidden = false;
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtNgayBatDau.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtNgayKetThuc.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtSoLuongUp.Value = 50;
            this.wThemSuaNguoiDung.Title = "Thêm mới người dùng";
            this.wThemSuaNguoiDung.Show();

        }
        protected void Cmd_SuaChiTiet(object sender, DirectEventArgs e)
        {
            string idnguoidung = e.ExtraParams["IDNguoiDung"].ToString();
            daNguoiDung thongtin = new daNguoiDung();
            DataTable dt = new DataTable();
            dt = thongtin.ThongTinTheoIDNguoiDung(Cl_KetNoi.hamketnoisql(),Guid.Parse(idnguoidung));
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                lblBienID.Text = r["IDNguoiDung"].ToString();
                txtTaiKhoan.Text = r["TaiKhoan"].ToString();
                txtTaiKhoan.Enabled = true;
                txtMatKhau.Text = r["MatKhau"].ToString();
                txtNgayBatDau.Text =DateTime.Parse(r["NgayBatDau"].ToString()).ToString("dd/MM/yyyy");
                txtNgayKetThuc.Text = DateTime.Parse(r["NgayKetThuc"].ToString()).ToString("dd/MM/yyyy");
                txtSoLuongUp.Value = int.Parse(r["SoLuongUp"].ToString());
                btnthemmoi.Hidden = true;
                btnsuathongtinnguoidung.Hidden = false;
                this.wThemSuaNguoiDung.Title = "Sửa thông tin người dùng";
                this.wThemSuaNguoiDung.Show();
            }
        }
        protected void Cmd_XoaNguoidung(object sender, DirectEventArgs e)
        {
            string idkenh = e.ExtraParams["IDNguoiDung"].ToString();
            daNguoiDung xoa = new daNguoiDung();           
            xoa.Xoa(Cl_KetNoi.hamketnoisql(),Guid.Parse(idkenh));
            this.grdDanhSachNguoiDung.GetStore().Reload();
        }


        protected void btnthemmoi_Click(object sender, DirectEventArgs e)
        {


            daNguoiDung them = new daNguoiDung();
            string taikhoan = txtTaiKhoan.Text;
            if (taikhoan == "")
            {
                X.Msg.Alert("Thông báo lỗi", "Hãy nhập vào tài khoản").Show();
                return;
            }
            string matkhau = txtMatKhau.Text;
            if (matkhau == "")
            {
                X.Msg.Alert("Thông báo lỗi", "Hãy nhập vào mật khẩu").Show();
                return;
            }
            DateTime ngaybatdau = Convert.ToDateTime(txtNgayBatDau.Text);
            DateTime ngayketthuc = Convert.ToDateTime(txtNgayKetThuc.Text);
            int soluongup =int.Parse(txtSoLuongUp.Value.ToString());
            them.Them(Cl_KetNoi.hamketnoisql(),taikhoan,matkhau,ngaybatdau,ngayketthuc,0,soluongup);
                this.wThemSuaNguoiDung.Hide();
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";                
                this.grdDanhSachNguoiDung.GetStore().Reload();
            

        }
        protected void btnsuathongtinnguoidung_Click(object sender, DirectEventArgs e)
        {
            daNguoiDung sua=new daNguoiDung();
            Guid IDNguoiDung = Guid.Parse(lblBienID.Text);
            string matkhau = txtMatKhau.Text;
            DateTime ngaybatdau=DateTime.Parse(txtNgayBatDau.Text);
            DateTime ngayketthuc=DateTime.Parse(txtNgayKetThuc.Text);
            int soluongup =int.Parse(txtSoLuongUp.Value.ToString());
            sua.Sua(Cl_KetNoi.hamketnoisql(),IDNguoiDung,matkhau,ngayketthuc,ngaybatdau,soluongup);
            this.wThemSuaNguoiDung.Hide();
            this.grdDanhSachNguoiDung.GetStore().Reload();

        }
        protected void btndong_Click(object sender, DirectEventArgs e)
        {
            this.wThemSuaNguoiDung.Hide();
            this.grdDanhSachNguoiDung.GetStore().Reload();
        }
    }
}