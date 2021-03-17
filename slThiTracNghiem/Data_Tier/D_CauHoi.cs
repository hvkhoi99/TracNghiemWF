using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Entities;


namespace Data_Tier
{
    public class D_CauHoi :General_Data
    {

        //--------1----------HÀM RANDOM  CÂU HỎI----------
        public DataSet RanDomCauHoi(string cau, string mamon)
        {
            ds = new DataSet();
            DA = new SqlDataAdapter("SELECT TOP " + cau + " * from TB_CAUHOI where MaMon= '" + mamon + "' order by newid()", con);            
            DA.Fill(ds, "TB_CauHoi");
            return ds;
        }


        //-2--------2-------------KIỂM TRA MÔN-----------------------------
        public DataSet KiemTraMon(string mamon)
        {
            ds = new DataSet();            
            DA = new SqlDataAdapter("select count(MaMon) from TB_CAUHOI where MaMon='" + mamon + "'", con);
            DA.Fill(ds, "Table_CauHoi");
            return ds;
        }

        //-3--------Lấy Đáp Án---------------
        public DataSet GetDapAn(string macauhoi)
        {
            ds = new DataSet();
            DA = new SqlDataAdapter("select * from TB_DAPAN  where MaCauHoi='" + macauhoi + "'", con);
            DA.Fill(ds, "TB_DapAn");
            return ds;
        }


        //-4-----4------Lấy hết nội dung trong bảng Câu hỏi--------------
        public DataSet getCauHoi_D()
        {
            ds = new DataSet();            
            DA = new SqlDataAdapter("select * from TB_CAUHOI", con);
            DA.Fill(ds, "TB_CAUHOI");
            return ds;
        }

        //-5-----5------Lấy hết nội dung trong bảng Câu hỏi theo mã câu hỏi--------------
        public DataSet getCauHoi_TheoMaCH_D(string MaCH)
        {
            ds = new DataSet();            
            CMD = new SqlCommand("select * from TB_CAUHOI where MACAUHOI=@macauhoi", con);
            CMD.Parameters.Add("@macauhoi", SqlDbType.Char).Value = MaCH;
            DA = new SqlDataAdapter(CMD);            
            DA.Fill(ds, "TB_CAUHOI");
            return ds;
        }

        //-----------7----------------THÊM CÂU HỎI-------ĐÁP ÁN-------------------        

        public int ThemMoiCauHoi_D(CauHoi CH)
        {
            bool kt = KiemTra_MaCH_Trung(CH.MaCauHoi);//mã câu hỏi này lấy từ bảng cau hoi
            string sql = "";

            if (kt == false)
            {
                sql = "insert into TB_CAUHOI values (@mach, @noidung, @mamon, @manv)";
            }
            else
            {
                return 0;
            }

            con.Open();
            CMD = new SqlCommand(sql, con);
            CMD.Parameters.Add("@mach", SqlDbType.Char).Value = CH.MaCauHoi;
            CMD.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = CH.NoiDung;
            CMD.Parameters.Add("@mamon", SqlDbType.Char).Value = CH.MaMon;
            CMD.Parameters.Add("@manv", SqlDbType.Char).Value = CH.MaNhanVien;
            
            int n = CMD.ExecuteNonQuery();
            con.Close();
            return n;
        }

        //--------------8----------SỬA CÂU HỎI------ĐÁP ÁN---------------

        //------1-----Kiểm tra mã câu hỏi_hay ma đáp án hay không có bị trùng hay ko---------
        public bool KiemTra_MaCH_Trung(string mach)
        {
            con.Open();
            CMD = new SqlCommand("select * from TB_CAUHOI where macauhoi=@mach",con);
            CMD.Parameters.Add("@mach", SqlDbType.Char).Value = mach;
            SqlDataReader read = CMD.ExecuteReader();
            bool n = read.Read();
            con.Close();
            return n;
        }
       
        //-----2--------SỬA CÂU HỎI--------------
        public int SuaCauHoi_D(CauHoi CH)
        {
            bool kt=KiemTra_MaCH_Trung(CH.MaCauHoi);//mã câu hỏi này lấy từ bảng cau hoi
            string sql="";
            if (kt == true)
            {
                sql = "update TB_CAUHOI set noidung='" + CH.NoiDung + "', mamon='" + CH.MaMon + "',manhanvien='" + CH.MaNhanVien + "' where macauhoi='" + CH.MaCauHoi + "'";
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

        //--------------9----------XÓA CÂU HỎI------ĐÁP ÁN---------------
        public int XoaCauHoi_D(CauHoi CH)
        {
            bool kt = KiemTra_MaCH_Trung(CH.MaCauHoi);//mã câu hỏi này lấy từ bảng cau hoi
            string sql = "";
            if (kt == true)
            {
                sql = "delete from TB_CAUHOI where macauhoi='" + CH.MaCauHoi + "'";
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
    }
}
