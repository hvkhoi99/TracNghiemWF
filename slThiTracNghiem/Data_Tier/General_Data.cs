
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


using Entities;

namespace Data_Tier
{
    public class General_Data
    {
        public SqlDataAdapter DA;


        public SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_TRACNGHIEM;User ID=test;Password=123;");
        public SqlCommand CMD;
        public SqlCommandBuilder CB;
        public DataSet ds;

        public SqlConnection ketnoi()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_TRACNGHIEM;User ID=test;Password=123;");
            if (con != null && con.State == ConnectionState.Closed)
            con.Open();
            return con;
        }

        public void DongKetNoi()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
        }

        //----------cập nhật dữ liệu cho hàm THEM_SUA_XOA---------------------
        public void CapNhatDuLieu_GD(DataTable dtTable, string Tablename)
        {
            //SqlConnection con = ketnoi();
            CMD = new SqlCommand("select * from " + Tablename + " where 1=7", con);
            DA = new SqlDataAdapter(CMD);
            ds = new DataSet();
            DA.Fill(ds, Tablename);
            CB = new SqlCommandBuilder(DA);
            DA.Update(dtTable);
        }       
    }
}
