using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class MonThi
    {

        public string MaMon { get; set; }
        public string TenMon { get; set; }

        public MonThi() { }

        public MonThi(string mamon, string tenmon)
        {
            MaMon = mamon;
            TenMon = tenmon;
        }
    }
}
