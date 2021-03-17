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
    public partial class frm4_DangKyThongTinThi : Form
    {
        B_ThiSinh B_TS=new B_ThiSinh();
        public static string s = "ĐĂNG KÍ  THI TRẮC NGHIỆM                                      ";
        public static string chuoisaukhimahoa = "";

        public frm4_DangKyThongTinThi()
        {
            InitializeComponent();
        }

        //-----------cập nhật lại thông thi thí sinh sau khi THÊM _ XÓA _ SỦA----------------
        
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            
        }
        private void xoatrang()
        {
            txtTenDN.Clear();
            txtMaTS.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaTS.Focus();
        }
        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            
        }

        private void frm4_DangKyThongTinThi_Load(object sender, EventArgs e)
        {
            CAPNHATTHISINH();
            
        }

        private void MAHOAMATKHAU(string matkhau)
        {
            string chuoigoc = matkhau;            
            for (int i = 0; i < chuoigoc.Length; i++)
            {
                char c = chuoigoc[i];
                chuoisaukhimahoa += "" + KyTuSangSo(c) + "";
            }           
        }

        private void CAPNHATTHISINH()
        {
            lvwThiSinh.Items.Clear();
            //--------lấy ra password trong cơ sở dữ liệu trước khi xuất ra---------
            B_TS = new B_ThiSinh();
            DataTable dt_All_TT = new DataTable();
            dt_All_TT = B_TS.Lay_TatCa_ThiSinhDaDK();

            
            foreach (DataRow r in dt_All_TT.Rows)
            {
                ListViewItem li = lvwThiSinh.Items.Add(r["mathisinh"].ToString());
                li.SubItems.Add(r["hoten"].ToString());
                li.SubItems.Add(r["tendn"].ToString());

                //-----------mã hóa mật khẩu---------
                MAHOAMATKHAU(r["matkhau"].ToString());
                li.SubItems.Add(chuoisaukhimahoa);//mat khau

                li.SubItems.Add(r["diachi"].ToString());
            }
        }

        //--------hàm chuyển kí tự sang số...
        private int KyTuSangSo(char c)
        {
            switch (c)
            {
                case '0': return 3; break;
                case '1': return 8; break;
                case '2': return 5; break;
                case '3': return 9; break;
                case '4': return 0; break;
                case '5': return 2; break;
                case '6': return 7; break;
                case '7': return 5; break;
                case '8': return 2; break;
                case '9': return 7; break;
                case 'a': return 2; break;
                case 'b': return 22; break;
                case 'c': return 222; break;
                case 'd': return 3; break;
                case 'e': return 33; break;
                case 'f': return 333; break;
                case 'g': return 4; break;
                case 'h': return 44; break;
                case 'i': return 444; break;
                case 'j': return 5; break;
                case 'k': return 55; break;
                case 'l': return 555; break;
                case 'm': return 6; break;
                case 'n': return 66; break;
                case 'o': return 666; break;
                case 'p': return 7; break;
                case 'q': return 77; break;
                case 'r': return 777; break;
                case 's': return 7777; break;
                case 't': return 8; break;
                case 'u': return 88; break;
                case 'v': return 888; break;
                case 'w': return 9; break;
                case 'x': return 99; break;
                case 'y': return 999; break;
                case 'z': return 9999; break;
                case '.': return 1; break;
                default: return 0;
            }
        }
        private void txtTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if((e.KeyChar=='-') ||e.KeyChar===' ' || (e.KeyChar=='?'))
            //{
            //    e.Handled=true;
            //    MessageBox.Show("Bạn Không được nhập ký tự [ - , ? ,khoảng trắng ]");
            //}
        }

        //private void chuchaydk_Tick(object sender, EventArgs e)
        //{
        //    lbltt.Text = s;
        //    string tam = s[0].ToString();
        //    s = s.Substring(1, s.Length - 1) + tam;
        //}

        private void pic_DongY_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiaChi.Text == "" || txtHoTen.Text == "" || txtMatKhau.Text == "" || txtMaTS.Text == "" || txtTenDN.Text == "")
                {
                    MessageBox.Show("Bạn Chưa Nhập đầy đủ thông tin đăng kí!");
                    txtMaTS.SelectAll();
                }
                else
                {
                    ThiSinh TS = new ThiSinh(txtMaTS.Text.ToUpper(), txtHoTen.Text, txtTenDN.Text, txtMatKhau.Text, txtDiaChi.Text);
                    if (new B_ThiSinh().dangki(TS) == 1)
                    {
                        MessageBox.Show("Đăng Kí Thành Công!", "Thông Báo!");
                        CAPNHATTHISINH();//----cập nhật lại thông tin----------
                        xoatrang();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Kí Thất Bại!", "Thông Báo!");
                        xoatrang();
                    }
                }
            }
            catch { return; }
        }

        private void pic_TroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1_DN DN = new frm1_DN();
            DN.Show();
        }
    }
}
