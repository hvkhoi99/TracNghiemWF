using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Data_Tier;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace Business_Tier
{
    public class B_NhanVien
    {
        private D_NhanVien D_NV=new D_NhanVien();


        //---------------hàm dăng nhập chon nhân viên
        public DataTable DangNhapNV(string tendn, string matkhau)
        {
            return D_NV.DangNhapNV(tendn, matkhau).Tables[0];
        }

        //------------------ĐỔI MẬT KHẨU-----------------------------
        public int SuaMatKhau_B(string tendn, string mkcu, string mkmoi)
        {
            return D_NV.SuaMatKhau_D(tendn, mkcu, mkmoi);
        }

       //--------------lấy toàn bộ thông tin nhân viên---------theo ma nha vie-----
        public DataTable GetAll_NhanVien_TheoMa_B(string manv)
        {
            return D_NV.GetAll_NhanVien_TheoMa_D(manv).Tables[0];
        }

        //--------------lấy toàn bộ thông tin nhân viên---------
        public DataTable GetAll_NhanVien_B()
        {
            return D_NV.GetAll_NhanVien_D().Tables[0];
        }

        //---------thêm mới nhân viên=--------------------
        public int ThemMoi_NV_B(NhanVien NV)
        {
            return D_NV.ThemMoiNhanVien_D(NV);
        }

        //--------------sửa thông tin nhân  viên-------------
        public int Sua_NhanVien_B(NhanVien NV)
        {
            return D_NV.Sua_NhanVien_D(NV);
        }

        //--------------XÓA thông tin nhân  viên-------------
        public int Xoa_NhanVien_B(NhanVien NV)
        {
            return D_NV.xoa_NhanVien_D(NV); 
        }

    }
}
