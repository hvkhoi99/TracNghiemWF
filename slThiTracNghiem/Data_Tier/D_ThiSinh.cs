using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Entities;

namespace Data_Tier
{
   public class D_ThiSinh: General_Data //KẾ THỪA
    {

        //------1-----------Lấy Thông Tin Của Thí Sinh ,Để Đăng Nhập làm trắc nghiệm-----------
       public DataSet LayThiSinhDN(string tendn, string matkhau)
       {
           ds = new DataSet();
           DA = new SqlDataAdapter("Select * from TB_THISINH where TENDN='" + tendn + "' and MATKHAU='" + matkhau + "'", con);
           DA.Fill(ds, "TB_THISINH");
           return ds;

       }


       //------2------Lấy hết nội dung trong bảng Câu hỏi theo mã câu hỏi--------------
       //D----SỬ DỤNG CHO CELLCLICK--------
       public DataSet LayThiSinh_TheoMaTS_D(string mats)
       {
           ds = new DataSet();
           CMD = new SqlCommand("select * from TB_THISINH where MATHISINH=@MATHISINH", con);
           CMD.Parameters.Add("@MATHISINH", SqlDbType.Char).Value = mats;
           DA = new SqlDataAdapter(CMD);
           DA.Fill(ds, "TB_THISINH");
           return ds;
       }

       //----------3------LẤY TẤT CẢ THÍ SINH ĐÃ DĂNG KÍ---------------------
       public DataSet Lay_TatCa_ThiSinhDaDK()
       {
           ds = new DataSet();
           DA = new SqlDataAdapter("Select * from TB_THISINH ", con);
           DA.Fill(ds, "TB_THISINH");
           return ds;
       }


       //-----4--------Đăng kí mới 1 thí sinh-------------
       public int dangki(ThiSinh TS)
       {
          string sql = "";
           bool kt = KiemTra_TS(TS.MaThiSinh);
           if (kt == true)
           {
               return 0;
           }
           else
           {
               sql = "insert  into TB_THISINH values('" + TS.MaThiSinh + "', N'" + TS.TenThiSinh + "','" + TS.TenDangNhap + "','" + TS.MatKhau + "',N'" + TS.DiaChi + "')";
           }

           ketnoi();

           SqlCommand cmd = new SqlCommand(sql, con);
           int n = cmd.ExecuteNonQuery();
           con.Close();
           return n;
       }

       //------5------------THÊM KẾT QUẢ-----------------------------
       public int ThemKetQua(string mats, string mamon, string diem, DateTime ngaythi)
       {
           try
           {
               ketnoi();
               string sql = "insert into TB_KETQUA values('" + mats + "','" + mamon + "','" + diem + "','" + ngaythi + "')";
               SqlCommand cmd = new SqlCommand(sql, con);
               int n = cmd.ExecuteNonQuery();
               con.Close();
               return n;
           }
           catch (Exception)
           {
               throw new Exception("Không Thêm Được \n Bạn hãy kiểm tra lại");
           }
       }


       //------------------LẤY THÔNG TIN THÍ SINH----------------------
       public DataSet GetThiSinh(string pass)
       {
           ds = new DataSet();
           CMD = new SqlCommand("Select * from TB_THISINH where MatKhau='" + pass + "'", con);
           DA = new SqlDataAdapter(CMD);
           DA.Fill(ds, "TB_THISINH");
           return ds;

       }

       //------------------LẤY THÔNG TIN THÍ SINH-THEO MÃ THÍ SINH---------------------
       public DataSet GetThiSinh_TenDN_MatKhau_D(string tendn,string matkhau)
       {
           ds = new DataSet();
           CMD = new SqlCommand("Select * from TB_THISINH where matkhau='" + matkhau + "' and tendn='" + tendn + "'", con);
           DA = new SqlDataAdapter(CMD);
           DA.Fill(ds, "TB_THISINH");
           return ds;

       }


       //------------------ĐỔI MẬT KHẨU-----------------------------
       public int SuaMatKhau_D(string tendn, string mkcu, string mkmoi)
       {
           ketnoi();
           string sql = "update TB_THISINH set  MatKhau='" + mkmoi + "' where TenDN='" + tendn + "' and MatKhau='" + mkcu + "' ";
           CMD = new SqlCommand(sql, con);
           int n = CMD.ExecuteNonQuery();
           DongKetNoi();

           return n;
       }

       //---------------kiểm tra trùng mã thí sinh --------------
       private bool KiemTra_TS(string mats)
       {
           ketnoi();
           CMD = new SqlCommand("select * from TB_THISINH where mathisinh='" + mats + "'", con);
           SqlDataReader read = CMD.ExecuteReader();
           bool n = read.Read();
           DongKetNoi();
           return n;
       }


       //--------------sửa thí sinh------------
       public int Sua_ThiSinh_D(ThiSinh TS)
       {
           string sql = "";
           bool kt = KiemTra_TS(TS.MaThiSinh);
           if (kt == true)
           {
               sql = "update TB_THISINH set hoten=N'" + TS.TenThiSinh + "',tendn='" +TS.TenDangNhap + "',matkhau='" +TS.MatKhau + "',DiaChi=N'" +TS.DiaChi + "' where mathisinh='" + TS.MaThiSinh + "'";
           }
           else
           {
               return 0;
           }

           ketnoi();
           CMD = new SqlCommand(sql, con);
           int n = CMD.ExecuteNonQuery();
           con.Close();
           return n;
       }


       //--------------xóa thí sinh------------
       public int xoa_ThiSinh_D(ThiSinh TS)
       {
           string sql = "";
           bool kt = KiemTra_TS(TS.MaThiSinh);
           if (kt == true)
           {
               sql = "delete from TB_THISINH where mathisinh='" + TS.MaThiSinh + "'";
           }
           else
           {
               return 0;
           }

           ketnoi();
           CMD = new SqlCommand(sql, con);
           int n = CMD.ExecuteNonQuery();
           con.Close();
           return n;
       }
    }
}
