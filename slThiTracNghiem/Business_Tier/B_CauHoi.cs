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
    public class B_CauHoi
    {
        public D_CauHoi D_CH=new D_CauHoi();
        public General_Data D_GD;

        //--------1--------HÀM RANDOM CÂU HỎI--------------------
        public DataTable RanDomCauHoi(string cau, string mamon)
        {
            return D_CH.RanDomCauHoi(cau, mamon).Tables[0];
        }

        //------2----------KIỂM TRA MÔN HỌC-----------------
        public DataTable KiemTraMon(string mamon)
        {
            return D_CH.KiemTraMon(mamon).Tables[0];
        }

        //-----3------LẤY ĐÁP ÁN----------------
        public DataTable GetDapAn(string macauhoi)
        {
            return D_CH.GetDapAn(macauhoi).Tables[0];
        }


        //----4-----lấy hết nội dung trong bảng câu hỏi---------------
        public DataTable getCauHoi_B()
        {
            return D_CH.getCauHoi_D().Tables["TB_CAUHOI"];            
        }

        //------5------Lấy hết nội dung trong bảng Câu hỏi theo mã câu hỏi--------------
        public DataTable GetCauHoi_TheoMaCh_D(string mach)
        {
            return D_CH.getCauHoi_TheoMaCH_D(mach).Tables["TB_CAUHOI"];
        }

        //------------6--------Cập nhật dữ liệu cho bảng câu hỏi----------bo di-----------
        public void CapNhat_CauHoi_B(DataTable dtTable)
        {
            D_GD.CapNhatDuLieu_GD(dtTable, "TB_CAUHOI"); 
        }

        //------------7---------Them Mới Câu hỏi----------------------
        public int ThemMoiCauHoi_B(CauHoi CH)
        {
            return D_CH.ThemMoiCauHoi_D(CH);
        }

        //---------8---------Sửa câu hỏi---------------------
        public int SuaCauHoi_B(CauHoi CH)
        {
            return D_CH.SuaCauHoi_D(CH);
        }

        //---------9---------Xóa câu hỏi---------------------
        public int XoaCauHoi_B(CauHoi CH)
        {
            return D_CH.XoaCauHoi_D(CH);
        }
    }

}
