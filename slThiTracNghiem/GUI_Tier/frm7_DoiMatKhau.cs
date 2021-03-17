using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Business_Tier;
using Entities;

namespace GUI_Tier
{
    public partial class frm7_DoiMatKhau : Form
    {
        public frm7_DoiMatKhau()
        {
            InitializeComponent();
        }
        
        public string tendangnhap = "";
        public string matkhau = "";

        public bool chon;

        B_ThiSinh B_TS=new B_ThiSinh();
        B_NhanVien B_NV = new B_NhanVien();
        B_ServerStatus status = new B_ServerStatus();
        DataTable dt = new DataTable();
        DataTable dt_NV = new DataTable();
        Server ser = new Server();

        private void frm7_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = tendangnhap;
            txtMatKhau.Text = matkhau;
        }
          
        private void pic_ChapNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (frm1_DN.chon == "Thí Sinh")
                {
                    int n = B_TS.SuaMatKhau_B(txtTenDN.Text, txtMatKhau.Text, txtMatKhauMoi.Text);
                    if (n == 1)
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thành Công!\n Bạn Hãy Bấm Vào Nút Trở Về Để Đăng Nhập Lại!");

                        //-------quay lại trang đăng nhập------------------
                        frm1_DN f = new frm1_DN();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thất Bại !!");
                    }
                }
                else
                {
                    int n = B_NV.SuaMatKhau_B(txtTenDN.Text, txtMatKhau.Text, txtMatKhauMoi.Text);
                    if (n == 1)
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thành Công!\n Bạn Hãy Bấm Vào Nút Trở Về Để Đăng Nhập Lại!");

                        //-------quay lại trang đăng nhập------------------
                        frm1_DN f = new frm1_DN();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thất Bại!");

                    }
                }
            }
            catch { return; }
        }

        private void pic_TroVe_Click(object sender, EventArgs e)
        {
            frm1_DN DN = new frm1_DN();
            DN.Show();
            this.Hide();
        }

        private void frm7_DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dt = status.B_getStatusOfServer(1);
            string s = dt.Rows[0]["STATUS"].ToString();
            if (s == "The Server is working..." && frm1_DN.chon == "Nhân Viên")
                ser.Close_Server();
        }
    }
}
