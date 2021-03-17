using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Entities;
using Data_Tier;

namespace Business_Tier
{
    public class B_MonThi
    {
        private D_MonThi D_MT=new D_MonThi();


        public DataTable GetMonThi()
        {
            return D_MT.GetMonThi().Tables[0];
        }

        //------------------Lấy ra tên môn thi theo MA Môn--------mã môn lấy từ gridview-------
        public DataTable GetMonThi_Theo_MaMon_B(string mamon)
        {
            return D_MT.GetMonThi_Theo_MaMon_D(mamon).Tables["TB_MONTHI"];
        }
    }
}
