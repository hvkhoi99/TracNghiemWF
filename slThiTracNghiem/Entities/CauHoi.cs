using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
   public class CauHoi
    {
       public string MaCauHoi { get; set; }
       public string NoiDung { get; set; }
       public string MaMon { get; set; }
       public string MaNhanVien { get; set; }

       public CauHoi() {}

       public CauHoi(string mach,string noidung,string mamon,string mannv)
       {
           MaCauHoi = mach;
           NoiDung = noidung;
           MaMon = mamon;
           MaNhanVien = mannv;
       }


    }
}
