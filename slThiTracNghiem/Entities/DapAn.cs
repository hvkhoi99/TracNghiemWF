using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class DapAn
    {

        public string MaDapAn { get; set; }
        public string NoiDung { get; set; }
        public string MaCauHoi { get; set; }
        public string KieuDapAn { get; set; }

        public DapAn() { }

        public DapAn(string mada, string nd, string mach, string kieuda)
        {
            MaDapAn = mada;
            NoiDung = nd;
            MaCauHoi = mach;
            KieuDapAn = kieuda;
        }
    }
}
