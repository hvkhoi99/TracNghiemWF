using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entities;
using System.Data;
using System.Data.SqlClient;


namespace Data_Tier
{
    public class D_DapAn:General_Data
    {
        public DataSet GetDapAn(string macauhoi)
        {
            ds = new DataSet();           
            DA = new SqlDataAdapter("select NoiDungDapAn,KieuDapAn,MaDapAn from TB_DAPAN  where MaCauHoi='" + macauhoi + "'", con);
            DA.Fill(ds, "TB_DapAn");
            return ds;
        }


        //-------------lấy thông tin toàn bộ bảng đáp án-----------------
        public DataSet GetAll_DapAn_D()
        {
            ds = new DataSet();
            DA = new SqlDataAdapter("select * from TB_DAPAN ", con);
            DA.Fill(ds, "TB_DAPAN");
            return ds;
        }

        //------------------lấy đáp án theo mã câu hỏi--------------
        public DataSet GetDapAn_Theo_MaCH_D(string mach)
        {
            ds = new DataSet();
            CMD = new SqlCommand("select * from TB_DAPAN where MACAUHOI=@mach",con);
            CMD.Parameters.Add("@mach", SqlDbType.Char).Value = mach;
            DA = new SqlDataAdapter(CMD);
            DA.Fill(ds, "TB_DAPAN");
            return ds;
        }

               

        //------------------------SỬA-ĐÁP ÁN---------------

        //------1-----Kiểm tra mã đáp án có bị trùng hay ko---------
        public bool KiemTra_MaDA_Trung(string madapan)
        {
            con.Open();
            CMD = new SqlCommand("select * from TB_DAPAN where madapan='"+madapan+"'", con);            
            SqlDataReader read = CMD.ExecuteReader();
            bool n = read.Read();
            con.Close();
            return n;
        }

        //---------------------------THÊM ĐÁP ÁN MỚI--------------------------
        public int ThemMoiDapAn_D(DapAn DAn)
        {

            bool kt = KiemTra_MaDA_Trung(DAn.MaDapAn);//mã đáp án này lấy từ bảng đáp án
            string sql = "";

            if (kt == true)
            {
                return 0;
            }

            else
            {
                sql = "insert into TB_DAPAN values (@macauhoi, @madapan, @noidungdapan,@kieudapan)";
            }

            con.Open();
            CMD = new SqlCommand(sql, con);
            CMD.Parameters.Add("@macauhoi", SqlDbType.Char).Value = DAn.MaCauHoi;
            CMD.Parameters.Add("@madapan", SqlDbType.Char).Value = DAn.MaDapAn;
            CMD.Parameters.Add("@noidungdapan", SqlDbType.NVarChar).Value = DAn.NoiDung;
            CMD.Parameters.Add("@kieudapan", SqlDbType.Char).Value = DAn.KieuDapAn;

            int n = CMD.ExecuteNonQuery();
            con.Close();
            return n;
        }

        //-------------sửa đáp án--------------
        public int SuaDapAN_D(DapAn DA)
        {
            bool kt = KiemTra_MaDA_Trung(DA.MaDapAn);//mã đáp án này lấy từ bảng đáp án
            string sql = "";

            

            if (kt == true)
            {
                sql = "update TB_DAPAN set macauhoi='" + DA.MaCauHoi + "',noidungdapan=N'" + DA.NoiDung + "', kieudapan='" + DA.KieuDapAn + "' where madapan='" + DA.MaDapAn + "'";
            }
            else
            {
                return 0;
            }
            con.Open();
            CMD = new SqlCommand(sql, con);
            int n = CMD.ExecuteNonQuery();
            con.Close();

            return n;
        }

        

        //------------------------XÓA-ĐÁP ÁN---------------
        public int XoaDapAN_D(DapAn DA)
        {
            bool kt = KiemTra_MaDA_Trung(DA.MaDapAn);//mã đáp án này lấy từ bảng đáp án
            string sql = "";

            if (kt == true)
            {
                sql = "delete from TB_DAPAN where madapan='" + DA.MaDapAn + "'";
            }
            else
            {
                return 0;
            }
            con.Open();
            CMD = new SqlCommand(sql, con);
            int n = CMD.ExecuteNonQuery();
            con.Close();//-------------

            return n;
        }
    }
}
