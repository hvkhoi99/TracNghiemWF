using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Entities;

namespace Data_Tier
{
    public class D_MonThi:General_Data
    {

        public DataSet GetMonThi()
        {
            ds = new DataSet();            
            DA = new SqlDataAdapter(" Select * from TB_MONTHI ", con);
            DA.Fill(ds, "TB_MONTHI");
            return ds;
        }

        //------------------Lấy ra tên môn thi theo MA Môn--------mã môn lấy từ gridview-------
        public DataSet GetMonThi_Theo_MaMon_D(string mamon)
        {
            ds = new DataSet();           
            CMD = new SqlCommand("select * from TB_MONTHI where MAMON=@mamon",con);
            CMD.Parameters.Add("@mamon", SqlDbType.Char).Value = mamon;
            DA = new SqlDataAdapter(CMD);
            DA.Fill(ds, "TB_MONTHI");
            return ds;
        }

    }
}
