using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Entities;

namespace Data_Tier
{
    public class D_NhanVien :General_Data //Kế Thừa lớp dùng chung
    {
        /// <summary>
        /// hàm đăng nhập cho nhân viên
        /// </summary>
        /// <param name="tendn">tên đăng nhập</param>
        /// <param name="pass">mật khẩu</param>
        /// <returns></returns>
        public DataSet DangNhapNV(string tendn, string matkhau)
        {
            ds = new DataSet();
            DA = new SqlDataAdapter("select * from TB_NHANVIEN where TENDN='" + tendn + "' and MATKHAU='" + matkhau + "'", con);
            DA.Fill(ds, "TB_NHANVIEN");
            return ds;
        }

        //--------------lấy toàn bộ thông tin nhân viên--theo ma nhaan vieen------------
        public DataSet GetAll_NhanVien_TheoMa_D(string manv)
        {
            ds = new DataSet();
            DA = new SqlDataAdapter("select * from TB_NHANVIEN where manhanvien='" + manv + "'", con);
            DA.Fill(ds, "TB_NHANVIEN");
            return ds;
        }

        ////--------------lấy toàn bộ thông tin nhân viên--------------
        public DataSet GetAll_NhanVien_D()
        {
            ds = new DataSet();
            DA = new SqlDataAdapter("select * from TB_NHANVIEN", con);
            DA.Fill(ds, "TB_NHANVIEN");
            return ds;
        }


        //------------------ĐỔI MẬT KHẨU-----------------------------
        public int SuaMatKhau_D(string tendn, string mkcu, string mkmoi)
        {
            ketnoi();
            string sql = "update TB_NHANVIEN set  MatKhau='" + mkmoi + "' where TENDN='" + tendn + "' and MatKhau='" + mkcu + "' ";
            CMD = new SqlCommand(sql, con);
            int n = CMD.ExecuteNonQuery();
            DongKetNoi();

            return n;
        }




        //---------------kiểm tra trùng mã nhân viên --------------
        private bool KiemTra_NV(string manv)
        {
            ketnoi();
            CMD = new SqlCommand("select * from TB_NHANVIEN where manhanvien='" + manv + "'", con);
            SqlDataReader read = CMD.ExecuteReader();
            bool n = read.Read();
            DongKetNoi();
            return n;
        }

        //-----------------thêm mới nhân viên------------
        public int ThemMoiNhanVien_D(NhanVien NV)
        {           
            bool kt = KiemTra_NV(NV.MaNhanVien);
            string sql = "";
            if (kt == false)
            {
                sql = "insert into TB_NHANVIEN values (@manhanvien,@hoten,@tendn,@matkhau,@chucvu,@diachi,@sodienthoai)";
            }
           else
            {
                return 0;                
            }
            ketnoi();
            CMD = new SqlCommand(sql, con);
            CMD.Parameters.Add("@manhanvien", SqlDbType.Char).Value = NV.MaNhanVien;
            CMD.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = NV.HoTen;
            CMD.Parameters.Add("@tendn", SqlDbType.Char).Value =NV.TenDangNhap;
            CMD.Parameters.Add("@matkhau", SqlDbType.Char).Value = NV.MatKhau;
            CMD.Parameters.Add("@chucvu", SqlDbType.Char).Value = NV.ChucVu;
            CMD.Parameters.Add("@diachi", SqlDbType.NVarChar).Value =NV.DiaChi;
            CMD.Parameters.Add("@sodienthoai", SqlDbType.Char).Value =NV.SoDienThoai;

            int n = CMD.ExecuteNonQuery();
            con.Close();
            return n;           
            
        }

        //--------------sửa nhân viên------------
        public int Sua_NhanVien_D(NhanVien NV)
        {            
            string sql = "";
            bool kt = KiemTra_NV(NV.MaNhanVien);
            if (kt == true)
            {
                sql = "update TB_NHANVIEN set hoten=N'" + NV.HoTen + "',TENDN='" + NV.TenDangNhap + "',matkhau='" + NV.MatKhau + "',chucvu=N'" + NV.ChucVu + "',DiaChi=N'" + NV.DiaChi + "',sodienthoai='" + NV.SoDienThoai + "'  where manhanvien='" + NV.MaNhanVien + "'";
            }
            else
            {
                return 0;
            }

            ketnoi();
            CMD = new SqlCommand(sql, con);
                int n = CMD.ExecuteNonQuery();
            con.Close();
            return n;
        }



        //--------------xóa nhân viên------------
        public int xoa_NhanVien_D(NhanVien NV)
        {
            string sql = "";
            bool kt = KiemTra_NV(NV.MaNhanVien);
            if (kt == true)
            {
                sql = "delete from TB_NHANVIEN where MANHANVIEN='" + NV.MaNhanVien + "'";
            }
            else
            {
                return 0;
            }

            ketnoi();
            CMD = new SqlCommand(sql, con);
            int n = CMD.ExecuteNonQuery();
            con.Close();
            return n;
        }
    }
}
