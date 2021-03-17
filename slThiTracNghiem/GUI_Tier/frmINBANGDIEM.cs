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
    public partial class frmINBANGDIEM : Form
    {
        public frmINBANGDIEM()
        {
            InitializeComponent();
        }
        B_KetQua B_KQ = new B_KetQua();
        DataTable dt_ketuqa = new DataTable();
        B_ServerStatus status = new B_ServerStatus();
        Server ser = new Server();

        private void frmINBANGDIEM_Load(object sender, EventArgs e)
        {
           // this.reportViewer1.RefreshReport();
            crBangDiem r = new crBangDiem();
            dt_ketuqa=B_KQ.XemDiem_All_B();
            r.SetDataSource(dt_ketuqa);
            crystalReportViewer1.ReportSource = r;
        }

        private void frmINBANGDIEM_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dt = status.B_getStatusOfServer(1);
            string s = dt.Rows[0]["STATUS"].ToString();
            frm2_GiaoDienChinh frm2 = new frm2_GiaoDienChinh();
            if (s == "The Server is working..." && frm1_DN.chon == "Nhân Viên")
                ser.Close_Server();
        }
    }
}
