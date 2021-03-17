using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ThiSinh
    {
        public string MaThiSinh{get;set;}
        public string TenThiSinh{get;set;}
        public string TenDangNhap{get;set;}
        public string MatKhau{get;set;}
        public string DiaChi { get; set; }

        public ThiSinh(){}


        public ThiSinh(string mathisinh,string ten,string tendn,string matkhau,string diachi)
        {
            MaThiSinh=mathisinh;
            TenThiSinh=ten;
            TenDangNhap=tendn;
            MatKhau=matkhau;
            DiaChi=diachi;
        }
        public ThiSinh(string mathisinh)
        {
            this.MaThiSinh = mathisinh;
        }
    }
}
