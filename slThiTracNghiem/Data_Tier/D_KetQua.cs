using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

using System.Data;
using System.Data.SqlClient;

namespace Data_Tier
{
    public class D_KetQua : General_Data
    {

        //-------------Lưu Kết quả thí sinh thi xuống csdl-------------
        public int LuuKetQua(KetQua KQ)
        {

            ketnoi();//123,hvk,mt,10,10/03/1999 10:00:00 PM
            CMD = new SqlCommand("insert  into TB_KETQUA values('" + KQ.MaThiSinh + "',N'" + KQ.TenThiSinh + "' ,'" + KQ.MaMon + "'," + KQ.Diem + ",'" + KQ.NgayThi + "')", con);
            //DA = new SqlDataAdapter(CMD);
            int n = CMD.ExecuteNonQuery();
            con.Close();
            return n;

        }

        //public void LuuKetQua2D(string mssv, string ten, string mamonthi, string diem, string dateThi)
        //{
        //    string query = "insert  into TB_KETQUA values('" + mssv + "','" + ten + "' ,'" + mamonthi + "'," + Convert.ToDouble(diem) + ",'" + dateThi + "')";
        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
        //    {
        //        connection.Open();
        //        //SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //        SqlCommand sc = new SqlCommand(query, connection);
        //        sc.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //}

        //public int D_ResultSave(string mssv, string ten, string mamonthi, double diem, string dateThi)
        //{
        //    //string query = "insert  into TB_KETQUA values('" + mssv + "','" + ten + "' ,'" + mamonthi + "'," + Convert.ToDouble(diem) + ",'" + dateThi + "')";
        //    //con.Open();
        //    //CMD = new SqlCommand(query, con);
        //    //int n = CMD.ExecuteNonQuery();
        //    //con.Close(); 
        //    //return n;
        //    try
        //    {
        //        ketnoi();
        //        string sql = "insert into TB_KETQUA (MATHISINH,TENTHISINH,MAMON,DIEM,NGAYTHI) values (@mssv,@ten,@mamon,@diem,@ngaythi)";
        //        SqlCommand cmd = con.CreateCommand();
        //        cmd.CommandText = sql;
        //        cmd.Parameters.Add("@mssv", SqlDbType.NChar).Value = mssv;
        //        cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
        //        cmd.Parameters.Add("@mamon", SqlDbType.NChar).Value = mamonthi;
        //        cmd.Parameters.Add("@diem", SqlDbType.Real).Value = diem;
        //        cmd.Parameters.Add("@ngaythi", SqlDbType.NVarChar).Value = dateThi;
        //        int n = cmd.ExecuteNonQuery();
        //        con.Close();
        //        return n;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return -1;
        //    }

        //}

        public DataSet XemDiem_D(string mathisinh)
        {
            CMD = new SqlCommand("select * from TB_KETQUA where mathisinh='" + mathisinh + "' ", con);
            DA = new SqlDataAdapter(CMD);
            ds = new DataSet();
            DA.Fill(ds, "TB_KETQUA");
            return ds;
        }

        public DataSet XemDiem_AllD()
        {
            CMD = new SqlCommand("select * from TB_KETQUA ", con);
            DA = new SqlDataAdapter(CMD);
            ds = new DataSet();
            DA.Fill(ds, "TB_KETQUA");
            return ds;
        }

        public DataSet Search_D(string s)
        {
            CMD = new SqlCommand("SELECT * FROM TB_KETQUA WHERE TENTHISINH like N'%" + s + "%'",con);
            ds = new DataSet();
            DA = new SqlDataAdapter(CMD);
            DA.Fill(ds);
            return ds;
        }
    }
}
