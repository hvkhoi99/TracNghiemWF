using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Data_Tier;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace Business_Tier
{
    public class B_DapAn
    {
        private D_DapAn D_DA=new D_DapAn();
        General_Data GD=new General_Data();
        public DataSet GetDapAn(string macauhoi)
        {
            return D_DA.GetDapAn(macauhoi);
        }

        //-------------lấy thông tin toàn bộ bảng đáp án-----------------
        public DataTable GetAll_DapAn_B()
        {
            return D_DA.GetAll_DapAn_D().Tables["TB_DAPAN"];
        }

        //------------------lấy đáp án theo mã câu hỏi--------------
        public DataTable GetDapAn_Theo_MaCH_B(string mach)
        {
            return D_DA.GetDapAn_Theo_MaCH_D(mach).Tables["TB_DAPAN"];
        }

        //-----------------------Cập nhật lại dữ liệu cho bảng đáp án---------------
        public void CapNhat_DapAn(DataTable dtTable)
        {
            GD.CapNhatDuLieu_GD(dtTable, "TB_DAPAN"); 
        }

        //---------------------Thêm mới đáp án---------------------------
        public int ThemMoiDapAn(DapAn DA)
        {
            return D_DA.ThemMoiDapAn_D(DA);
        }


        //---------------------Sửa đáp án---------------------------
        public int SuaDapAN_B(DapAn DA)
        {
            return D_DA.SuaDapAN_D(DA);
        }

        //---------------------Xóa đáp án---------------------------
        public int XoaDapAN_B(DapAn DA)
        {
            return D_DA.XoaDapAN_D(DA);
        }
    }
}
