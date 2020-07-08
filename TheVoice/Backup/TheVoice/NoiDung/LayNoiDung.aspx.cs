using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DaoTheVoice;
using TheVoice.KetNoi;
using Ext.Net;
namespace TheVoice.NoiDung
{
    public partial class LayNoiDung : System.Web.UI.Page
    {
        private void hienthicombox()
        {
            DataTable dtngonngu = new DataTable();
            daDanhMucNgonNgu ngonngu = new daDanhMucNgonNgu();
            dtngonngu = ngonngu.DanhSach(Cl_KetNoi.hamketnoisql());
            Storengonngu.DataSource = dtngonngu;
            Storengonngu.DataBind();
            cmbngonngu.SelectedItem.Mode = ParameterMode.Raw;

            DataTable dtgioitinh = new DataTable();
            daDanhMucGioiTinh gioitinh = new daDanhMucGioiTinh();
            dtgioitinh = gioitinh.DanhSach(Cl_KetNoi.hamketnoisql());
            Storegioitinh.DataSource = dtgioitinh;
            Storegioitinh.DataBind();
            cmbgioitinh.SelectedItem.Mode = ParameterMode.Raw;

        }

        private int m_SoLuongUp = 0;
        private void LaySoLuongUp(string idnguoidung)
        {
            daNguoiDung tt = new daNguoiDung();
            DataTable dt = new DataTable();
            dt = tt.ThongTinTheoIDNguoiDung(Cl_KetNoi.hamketnoisql(),Guid.Parse(idnguoidung));
            DataRow r = dt.Rows[0];
            m_SoLuongUp = int.Parse(r["SoLuongUp"].ToString());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                lblNguoiDung.Value = Request.QueryString["ACCS-_-ADD"];
                hienthicombox();
            }
        }

        protected void btnThemBaiViet_Click(object sender, DirectEventArgs e)
        {
            daBaiViet bv = new daBaiViet();
            int soluongdaup = 0;
            DataTable table = new DataTable();
            table = bv.DanhSachTheoNguoiDung(Cl_KetNoi.hamketnoisql(), Guid.Parse(lblNguoiDung.Value.ToString()), DateTime.Now);
            if (table.Rows.Count > 0)
            {
                soluongdaup = table.Rows.Count;
            }
            if (soluongdaup < m_SoLuongUp)
            {
                #region // thêm bài viết
                string ngonngu;
                try
                {
                    ngonngu = cmbngonngu.SelectedItem.Value.ToString();
                    if (ngonngu == "")
                    {
                        X.Msg.Alert("Thông báo lỗi", "Hãy chọn ngôn ngữ!").Show();
                        return;
                    }
                }
                catch
                {
                    X.Msg.Alert("Thông báo lỗi", "Hãy chọn ngôn ngữ!").Show();
                    return;
                }
                string gioitinh = "All";
                try
                {
                    gioitinh = cmbgioitinh.SelectedItem.Value.ToString();
                }
                catch
                {
                    gioitinh = "All";
                }
                string noidung;
                try
                {
                    noidung = txtNoiDung.Text.Trim();
                    if (ngonngu == "")
                    {
                        X.Msg.Alert("Thông báo lỗi", "Hãy nhập nội dung!").Show();
                        return;
                    }
                }
                catch
                {
                    X.Msg.Alert("Thông báo lỗi", "nhập nội dung bài viết!").Show();
                    return;
                }

                daBaiViet them = new daBaiViet();

                try
                {
                    them.Them(Cl_KetNoi.hamketnoisql(), noidung, Guid.Parse(lblNguoiDung.Value.ToString()), ngonngu, gioitinh);
                    X.Msg.Alert("OK", "OK!").Show();
                    txtNoiDung.Text = "";
                }
                catch
                {
                    X.Msg.Alert("Thông báo lỗi", "có lỗi trong quá trình thêm bài viết!").Show();
                    return;
                }
                #endregion
            }
            else {
                X.Msg.Alert("Thông báo lỗi", "Đã quá giới hạn cho phép up trong 1 ngày!").Show();
                return;
            }
        }
    }
}