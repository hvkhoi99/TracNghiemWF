using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public NhanVien() { }

        public NhanVien(string manv,string hoten,string tendangnhap,string matkhau,string chucvu,string diachi,string sodt) 
        {
            MaNhanVien = manv;
            HoTen = hoten;
            TenDangNhap = tendangnhap;
            MatKhau = matkhau;
            ChucVu = chucvu;
            DiaChi = diachi;
            SoDienThoai = sodt;
        }
    }
}
