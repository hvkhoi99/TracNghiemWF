using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class KetQua
    {

        public string MaThiSinh { get; set; }
        public string TenThiSinh { get; set; }
        public string MaMon { get; set; }
        public double Diem { get; set; }
        public string NgayThi { get; set; }

        public KetQua() { }

        public KetQua(string mats,string tents, string mamon, double diem, string ngaythi)
        {
            MaThiSinh = mats;
            TenThiSinh = tents;
            MaMon = mamon;
            Diem = diem;
            NgayThi = ngaythi;
        }


    }
}
