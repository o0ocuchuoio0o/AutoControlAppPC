using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StyleTempleProshow
{
    public class daWS_FakeAuto
    {
        public DataTable DangNhap(string taikhoan, string matkhau)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto dn = new WS_FakeAuto.WS_FakeAuto();
            dt = dn.DangNhap(taikhoan, matkhau);
            return dt;
        }


        public DataTable DanhSachKenh(int idtaikhoan)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachKenh(idtaikhoan);
            return dt;
        }

        public DataTable ThongTinKenh(int idtaikhoan, int idkenh)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.ThongTinKenh(idtaikhoan, idkenh);
            return dt;
        }

        public DataTable DanhSachBaiViet(int idkenh)
        {

            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            try { dt = ds.DanhSachBaiViet(idkenh); }
            catch { }
            return dt;

        }
        public DataTable DanhSachBaiVietProshow()
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachBaiVietProshowCanRender();
            return dt;
        }
        public DataTable DanhSachBaiVietProshowTheoKenh(int idkenh)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachBaiVietProshowCanRenderTheoKenh(idkenh);
            return dt;
        }

        public DataTable DanhSachBaiVietProshowTheoKenhVoiceSelenium(int idkenh)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachBaiVietProshowCanRenderTheoKenh_VoiceSelenium(idkenh);
            return dt;
        }

        public DataTable DanhSachBaiVietDaRenderProshow(int idkenh)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachBaiVietProshowDaRender(idkenh);
            return dt;
        }
        public DataTable CauHinhMCKenh(int idkenh)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.ThongTinMCTheoKenh(idkenh);
            return dt;
        }
        public DataTable ChiTietBaiViet(int idbaiviet)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.ChiTietBaiViet(idbaiviet);
            return dt;
        }
        public DataTable DanhSachVoiceAMZ()
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachVoiceAMZ();
            return dt;
        }

        public int BaiVietDaUpTrongNgay(int idkenh)
        {
            int kq = 0;
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            kq = ds.DanhSachBaiVietDaUp(idkenh);
            return kq;
        }
        public int Vession()
        {
            WS_FakeAuto.WS_FakeAuto vs = new WS_FakeAuto.WS_FakeAuto();
            return vs.Vession();
        }
        public DataTable DanhSachFileUpdate()
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachFileCapNhat();
            return dt;
        }
        public void InsertBaiVietDaUp(int idkenh, int idbaiviet)
        {
            WS_FakeAuto.WS_FakeAuto baivietdaup = new WS_FakeAuto.WS_FakeAuto();
            baivietdaup.InsertBaiVietDaUp(idkenh, idbaiviet);
        }

        public void UpdateVoiceKenh(int idkenh, string mota, string idvoicamz, string idvoicegoogle)
        {
            WS_FakeAuto.WS_FakeAuto upvoice = new WS_FakeAuto.WS_FakeAuto();
            upvoice.UpdateVoiceKenh(idkenh, mota, idvoicamz, idvoicegoogle);
        }
        public void UpdateBaiVietDangRender(int idbaiviet)
        {
            WS_FakeAuto.WS_FakeAuto baivietdangrender = new WS_FakeAuto.WS_FakeAuto();
            baivietdangrender.UpdateBaiVietDangRender(idbaiviet);
        }
        public void UpdateBaiVietDaRender(int idbaiviet)
        {
            WS_FakeAuto.WS_FakeAuto baivietdarender = new WS_FakeAuto.WS_FakeAuto();
            baivietdarender.UpdateBaiVietDaRender(idbaiviet);
        }

        public DataTable DanhSachNgonNgu()
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachNgonNgu();
            return dt;
        }
        public DataTable DanhSachVoiceNgonNgu(string ngonngu)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachVoiceNgonNgu(ngonngu);
            return dt;
        }
        public DataTable DanhSachEffect()
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachEffect();
            return dt;
        }
        public DataTable DanhSachEffectLevel(string effect)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachEffectLevel(effect);
            return dt;
        }
        public void ThemSuaCauHinhVoiceKenh(int idkenh, string ngonngu, string voice, string effect, string effectlevel)
        {
            WS_FakeAuto.WS_FakeAuto ch = new WS_FakeAuto.WS_FakeAuto();
            ch.InsertCauHinhVoiceKenh(idkenh, ngonngu, voice, effect, effectlevel);
        }
        public DataTable ThongTinCauHinhVoiceKenh(int idkenh)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.ThongTinCauHinhVoiceKenh(idkenh);
            return dt;
        }
        // du lieu lay voice
        public DataTable DanhSachVoiceCanLay(int idkenh)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachTinCanLayVoiceTheoKenh(idkenh);
            return dt;
        }
        public DataTable DanhSachVoiceCanLayTop1(int idkenh)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachTinCanLayVoiceTheoKenhTop(idkenh);
            return dt;
        }
        public void SuaPathVoice(int idchitiet, string pathvoice)
        {
            WS_FakeAuto.WS_FakeAuto ch = new WS_FakeAuto.WS_FakeAuto();
            ch.UpdateDaLayVoice(idchitiet, pathvoice);
        }
        public void UpdateDaRenderVoice(int idbaiviet)
        {
            WS_FakeAuto.WS_FakeAuto ch = new WS_FakeAuto.WS_FakeAuto();
            ch.UpdateBaiVietDaLayVoice(idbaiviet);
        }

        #region // tao psh tren server
        public static string _InTro(string i, string pathintro, string timeintro)
        {
            string ex = "";
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            ex = ds._InTro(i, pathintro, timeintro);
            return ex;
        }
        public static string _Head(string cell, string localFoder, string musicbg)
        {
            string ex = "";
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            ex = ds._Head(cell, localFoder, musicbg);
            return ex;
        }
        public static string _Slide(string i, string pathsub, string pathimage, string timeslide, string pathvoice, string timevoice)
        {
            string ex = "";
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            ex = ds._Silde(i, pathsub, pathimage, timeslide, pathvoice, timevoice);
            return ex;
        }
        public static string _SlideVideoBG(string i, string pathsub, string pathimage, string timeslide, string pathvoice, string timevoice, string pathvideobg)
        {
            string ex = "";
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            ex = ds._SildeVideoBG(i, pathsub, pathimage, timeslide, pathvoice, timevoice, pathvideobg);
            return ex;
        }
        public static string _SlideVideoBG_ID(int id,string i, string pathsub, string pathimage, string timeslide, string pathvoice, string timevoice, string pathvideobg)
        {
            string ex = "";
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            ex = ds._SildeVideoBG_ID(id,i, pathsub, pathimage, timeslide, pathvoice, timevoice, pathvideobg);
            return ex;
        }
        public static string _Slidemc(string i, string pathmc, string pathsub, string pathimage, string timeslide, string pathvoice, string timevoice)
        {
            string ex = "";
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            ex = ds._SildeMC(i, pathmc, pathsub, pathimage, timeslide, pathvoice, timevoice);
            return ex;
        }
        public static string _TranSlide(string i)
        {
            string ex = "";
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            ex = ds._TranSlide(i);
            return ex;
        }
        public static string _OutTro(string i, string pathouttro, string timeouttro)
        {
            string ex = "";
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            ex = ds._OutTro(i, pathouttro, timeouttro);
            return ex;
        }
        public static string _Footer()
        {
            string ex = "";
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            ex = ds._Footer();
            return ex;
        }
        #endregion


        #region // các hàm hệ thống quản lý mail và reup

        public void XuLyMail(string mail, string pass, string mailkhoiphuc, int idtaikhoan)
        {
            WS_FakeAuto.WS_FakeAuto xuly = new WS_FakeAuto.WS_FakeAuto();
            xuly.XuLyMail(mail, pass, mailkhoiphuc, idtaikhoan);

        }
        public void UpdateMailKhoiPhuc(string mail, string pass, string mailkhoiphuc, int idtaikhoan)
        {
            WS_FakeAuto.WS_FakeAuto xuly = new WS_FakeAuto.WS_FakeAuto();
            xuly.UpdateMailKhoiPhuc(mail, pass, mailkhoiphuc, idtaikhoan);
        }
        public void XuLyMailLoi(string mail, string pass, string mailkhoiphuc, int idtaikhoan)
        {
            WS_FakeAuto.WS_FakeAuto xuly = new WS_FakeAuto.WS_FakeAuto();
            xuly.XuLyMailLoi(mail, pass, mailkhoiphuc, idtaikhoan);
        }
        public DataTable DanhSachMailChuaXuLy(int idtaikhoan)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachMailChuaXuLy(idtaikhoan);
            return dt;
        }
        public DataTable DanhSachMailDaXuLy(int idtaikhoan)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachMailDaXuLy(idtaikhoan);
            return dt;
        }
        public void CauHinhMail(int m_ID, string m_LinkKenh, string m_LinkKenhReUp,
              int m_SoLuongVideoUp, string m_NgonNguGoc, string m_NgonNguThay, string m_BotTieuDe,
              string m_ThemTieuDe, string m_ThemMoTa, string m_ThemTag)
        {
            WS_FakeAuto.WS_FakeAuto xuly = new WS_FakeAuto.WS_FakeAuto();
            xuly.CauHinhMail(m_ID, m_LinkKenh, m_LinkKenhReUp,
               m_SoLuongVideoUp, m_NgonNguGoc, m_NgonNguThay, m_BotTieuDe,
               m_ThemTieuDe, m_ThemMoTa, m_ThemTag);
        }
        public void UpdateView(int m_ID, string view, string sub, string ngaytao, bool trangthai)
        {
            WS_FakeAuto.WS_FakeAuto xuly = new WS_FakeAuto.WS_FakeAuto();
            xuly.UpdateView(m_ID, view, sub, ngaytao, trangthai);
        }
        public void XoaMail(int m_ID)
        {
            WS_FakeAuto.WS_FakeAuto xuly = new WS_FakeAuto.WS_FakeAuto();
            xuly.XoaMail(m_ID);
        }

        public DataTable ChiTietMail(int m_ID)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.ChiTietMail(m_ID);
            return dt;
        }

        public void ThemChiTietReup(string Link, string TieuDe, int IDMailDaXuLy)
        {
            WS_FakeAuto.WS_FakeAuto xuly = new WS_FakeAuto.WS_FakeAuto();
            xuly.ThemChiTietReup(Link, TieuDe, IDMailDaXuLy);
        }
        public string Linkvideomoinhat(int IDMailDaXuLy)
        {
            string kq = "";
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            try
            {
                kq = ds.LinkVideoMoiNhat(IDMailDaXuLy);
            }
            catch { }
            return kq;
        }
        public void UpdateDaReup(int ID)
        {
            WS_FakeAuto.WS_FakeAuto xuly = new WS_FakeAuto.WS_FakeAuto();
            xuly.UpdateDaReup(ID);
        }

        public DataTable DanhSachVideoChuaReup(int IDMailDaXuLy)
        {
            DataTable dt = new DataTable();
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            dt = ds.DanhSachVideoChuaReup(IDMailDaXuLy);
            return dt;
        }

        public int SoLuongDaUpTheoNgay(int IDMailDaXuLy)
        {
            int kq = 0;
            WS_FakeAuto.WS_FakeAuto ds = new WS_FakeAuto.WS_FakeAuto();
            kq = ds.SoLuongDaUpTheoNgay(IDMailDaXuLy);
            return kq;
        }

        #endregion


    }
}
