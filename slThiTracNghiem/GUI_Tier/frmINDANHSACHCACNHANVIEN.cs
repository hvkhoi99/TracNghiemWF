using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Business_Tier;

namespace GUI_Tier
{
    public partial class frmINDANHSACHCACNHANVIEN : Form
    {
        public frmINDANHSACHCACNHANVIEN()
        {
            InitializeComponent();
        }
        DataTable dt_nhanvie = new DataTable();
        B_NhanVien nv = new B_NhanVien();
        B_ServerStatus status = new B_ServerStatus();
        Server ser = new Server();

        private void frmINDANHSACHCACNHANVIEN_Load(object sender, EventArgs e)
        {
            dt_nhanvie=nv.GetAll_NhanVien_B();
            crDSNhanVien ds = new crDSNhanVien();
            ds.SetDataSource(dt_nhanvie);
            crv_DanhSachNhanVien.ReportSource=ds;
        }

        private void frmINDANHSACHCACNHANVIEN_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dt = status.B_getStatusOfServer(1);
            string s = dt.Rows[0]["STATUS"].ToString();
            frm2_GiaoDienChinh frm2 = new frm2_GiaoDienChinh();
            if (s == "The Server is working..." && frm1_DN.chon == "Nhân Viên")
                ser.Close_Server();
        }
    }
}
