using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entities;
using System.Data;
using System.Data.SqlClient;
using Data_Tier;

namespace Business_Tier
{
    public class B_KetQua
    {

        D_KetQua kq_B = new D_KetQua();

        public int LuuKetQua_B(KetQua kq)
        {
            return kq_B.LuuKetQua(kq);
        }

        public DataTable XemDiem_B(string mathisinh)
        {
            return kq_B.XemDiem_D(mathisinh).Tables[0];
        }

        public DataTable XemDiem_All_B()
        {
            return kq_B.XemDiem_AllD().Tables[0];
        }

        //public int B_ResultSave(string mssv, string ten, string mamonthi, double diem, string dateThi)
        //{
        //    return kq_B.D_ResultSave(mssv, ten, mamonthi, diem, dateThi);
        //}

        //public void LuuKetQua2B(string mssv, string ten, string mamonthi, string diem, string dateThi)
        //{
        //    kq_B.LuuKetQua2D(mssv, ten, mamonthi, diem, dateThi);
        //}

        public DataTable Search_B(string s)
        {
            return kq_B.Search_D(s).Tables[0];
        }

    }
}
