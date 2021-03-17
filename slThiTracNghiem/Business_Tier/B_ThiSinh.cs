using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Data_Tier;
using Entities;

namespace Business_Tier
{
    public class B_ThiSinh
    {
        private D_ThiSinh D_TS=new D_ThiSinh();
        public General_Data gnr = new General_Data();
        public void DongKetNoi()
        {
            gnr.DongKetNoi();
        }
        //--------------1-------------ĐĂNG NHẬP THÍ SINH----------------------
        public DataTable LayThiSinhDN(string tendn, string matkhau)
        {           
            return D_TS.LayThiSinhDN(tendn, matkhau).Tables[0];
        }

        //----2--------Lấy hết nội dung trong bảng Câu hỏi theo mã câu hỏi--------------
       //D----SỬ DỤNG CHO CELLCLICK--------
        public DataTable LayThiSinh_TheoMaTS_b(string mats)
        {
            return D_TS.LayThiSinh_TheoMaTS_D(mats).Tables[0];
        }


        //------------3--------------LẤY TẤT CẢ THÍ SINH ĐÃ DĂNG KÍ---------------------
        public DataTable Lay_TatCa_ThiSinhDaDK()
        {
            return D_TS.Lay_TatCa_ThiSinhDaDK().Tables[0];
        }

        //-------4-----------ĐĂNG KÍ THÍ SINH MỚI---------------------
        public int dangki(ThiSinh TS)
        {
            return D_TS.dangki(TS);
        }

        //-------5------THÊM KẾT QUẢ VÀO CƠ SỞ DỮ LIỆU-----------------------
        public int ThemKetQua(string mats, string mamon, string diem, DateTime ngaythi)
        {
            D_TS = new D_ThiSinh();
            return D_TS.ThemKetQua(mats, mamon, diem,ngaythi);
        }


        //------------------LẤY THÔNG TIN THÍ SINH----------------------
        public DataTable GetThiSinh(string pass)
        {
            return D_TS.GetThiSinh(pass).Tables[0];
        }

        //------------------LẤY THÔNG TIN THÍ SINH-THEO TÊN ĐĂNG NHẬP VÀ MẬT KHẨU---------------------
        public DataTable GetThiSinh_TenDN_MatKhau_B(string tendn,string matkhau)
        {
            return D_TS.GetThiSinh_TenDN_MatKhau_D(tendn,matkhau).Tables[0];
        }

        //------------------ĐỔI MẬT KHẨU-----------------------------
        public int SuaMatKhau_B(string tendn, string mkcu, string mkmoi)
        {
            return D_TS.SuaMatKhau_D(tendn, mkcu, mkmoi);
        }

         //--------------sửa thí sinh------------
        public int Sua_ThiSinh_B(ThiSinh TS)
        {
            return D_TS.Sua_ThiSinh_D(TS); 
        }

        //--------------xóa thí sinh------------
        public int xoa_ThiSinh_D(ThiSinh TS)
        {
            return D_TS.xoa_ThiSinh_D(TS);
        }
    }
}
