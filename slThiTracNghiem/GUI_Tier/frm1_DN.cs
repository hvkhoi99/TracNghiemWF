using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Tier;

namespace GUI_Tier
{
    //192.168.43.171
    public partial class frm1_DN : Form
    {
        private B_ThiSinh B_TS;
        private B_NhanVien B_NV;
        Client cli = new Client();

        public static string chon;
        public static string chucvu;
        public static string manhanvien;
        public static string TenThiSinhDiThi;
        public static string mathisinh;
        public static string chuchay = "đăng nhập                     ";
        int dem = 0;
        public static string ServerIP;

        public frm1_DN()
        {
            InitializeComponent();
            if (radNhanVien.Checked == true)
            {
                lblServerIP.Visible = false;
                txtServerIP.Visible = false;
            }
            CheckForIllegalCrossThreadCalls = false;
        }

        private void frm1_DN_Load(object sender, EventArgs e)
        {
            txtDangNhap.Focus();
        }

        frm7_DoiMatKhau frm_DMK = new frm7_DoiMatKhau();

        private void radThiSinh_CheckedChanged(object sender, EventArgs e)
        {
            //chuyen ve vi tri cu
            this.btnDangNhap.Location = new System.Drawing.Point(510, 178);
            this.btnDangKy.Location = new System.Drawing.Point(510, 230);
            this.btnDoiMatKhau.Location = new System.Drawing.Point(510, 283);
            this.btnThoat.Location = new System.Drawing.Point(510, 333);
            this.lblServerIP.Location = new System.Drawing.Point(19, 41);
            this.txtServerIP.Location = new System.Drawing.Point(175, 36);
            this.lblDangNhap.Location = new System.Drawing.Point(19, 96);
            this.txtDangNhap.Location = new System.Drawing.Point(175, 91);
            this.lblMatKhau.Location = new System.Drawing.Point(19, 145);
            this.txtMatKhau.Location = new System.Drawing.Point(175, 142);
            txtServerIP.Text = "";
            txtDangNhap.Text = "";
            txtMatKhau.Text = "";
            grpThongTin.Text = "Thông Tin Đăng Nhập Của thí sinh";
            //btnDoiMatKhau.Visible = true;
            lblServerIP.Visible = true;
            txtServerIP.Visible = true;
            btnDangKy.Visible = true;
            txtServerIP.Focus();
        }

        private void radNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            //chuyen den vi tri moi
            this.btnDangNhap.Location = new System.Drawing.Point(510, 178);
            this.btnDoiMatKhau.Location = new System.Drawing.Point(510, 230);
            this.btnThoat.Location = new System.Drawing.Point(510, 283);
            this.lblDangNhap.Location = new System.Drawing.Point(19, 69);
            this.txtDangNhap.Location = new System.Drawing.Point(175, 64);
            this.lblMatKhau.Location = new System.Drawing.Point(19, 130);
            this.txtMatKhau.Location = new System.Drawing.Point(175, 127);
            txtDangNhap.Text = "";
            txtMatKhau.Text = "";
            grpThongTin.Text = "Thông Tin Của Nhân Viên";
            //btnDoiMatKhau.Visible = true;
            lblServerIP.Visible = false;
            txtServerIP.Visible = false;
            btnDangKy.Visible = false;
            txtDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                ServerIP = txtServerIP.Text;
                if (radThiSinh.Checked == true)
                {
                    chon = radThiSinh.Text;
                    if (txtServerIP.Text == "" || txtDangNhap.Text == "" || txtMatKhau.Text == "")
                    {
                        MessageBox.Show("Nhập đầy đủ thông tin của thí sinh!");
                        txtDangNhap.SelectAll();
                    }
                    else
                    {
                        try
                        {
                            //cli.Connect(ServerIP);
                            if (cli.Connect(ServerIP) == true)
                            {
                                B_TS = new B_ThiSinh();
                                DataTable dt = new DataTable();
                                dt = B_TS.LayThiSinhDN(txtDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
                                if (dt.Rows.Count > 0)
                                {
                                    //MessageBox.Show("Đăng Nhập Thành Công","Thông Báo !");
                                    timer1.Start();
                                    //----lấy ra tên thí sinh theo mã thi sinh để gán vào form thi trắc nghiệm --------
                                    DataTable dt_thisinh = new B_ThiSinh().LayThiSinh_TheoMaTS_b(dt.Rows[0]["mathisinh"].ToString());
                                    TenThiSinhDiThi = dt_thisinh.Rows[0]["hoten"].ToString();
                                    mathisinh = dt.Rows[0]["mathisinh"].ToString();//-------lay ra ma thi sinh---------
                                    //MessageBox.Show("dddđ :" + TenThiSinhDiThi);                       
                                }
                                else
                                {
                                    txtDangNhap.SelectAll();
                                    MessageBox.Show("Bạn đã nhập sai thông tin!", "Thông Báo!"); dem++;
                                    if (dem == 3)
                                    {
                                        MessageBox.Show("Bạn đã đăng nhập sai 3 lần! \n Bạn vui lòng đăng ký tài khoản! \n Chương Trình Sẽ Tự Động Thoát!", "Thông Báo!");
                                        this.Close();
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex);
                        }
                    }
                }
                else
                {
                    chon = radNhanVien.Text;
                    if (txtDangNhap.Text == "" || txtMatKhau.Text == "")
                    {
                        MessageBox.Show("Hãy Nhập đầy đủ thông tin của nhân viên!");
                        txtDangNhap.SelectAll();
                    }
                    else
                    {
                        txtDangNhap.Focus();
                        B_NV = new B_NhanVien();
                        DataTable dt = new DataTable();
                        dt = B_NV.DangNhapNV(txtDangNhap.Text, txtMatKhau.Text);

                        if (dt.Rows.Count > 0)
                        {
                            DataRow dr;
                            dr = dt.Rows[0];
                            frm2_GiaoDienChinh GDC = new frm2_GiaoDienChinh();
                            GDC.LayMaNV_GDC = dt.Rows[0]["MANHANVIEN"].ToString();//--------lay ma nhan vien
                            chucvu = dt.Rows[0]["CHUCVU"].ToString();//-------lấy ra chức vụ của nhân viên đăng nhập vào------------
                            manhanvien = dt.Rows[0]["MANHANVIEN"].ToString();
                            timer1.Start();
                            //MessageBox.Show("Đăng Nhập Thành Công");
                            //---------lấy ra tên của nhân viên---------
                            TenThiSinhDiThi = dt.Rows[0]["hoten"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã nhập sai thông tin!", "Thông Báo!"); dem++;


                            if (dem == 3)
                            {
                                MessageBox.Show("Bạn đã đăng nhập sai 3 lần! \n Bạn vui lòng đăng ký tài khoản! \n Chương Trình Sẽ Tự Động Thoát!", "Thông Báo!");
                                this.Close();
                            }
                            txtDangNhap.SelectAll();
                        }
                    }

                }
            }
            catch { return; }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (btnDangKy.Text == "Đăng ký")
            {
                this.Hide();
                frm4_DangKyThongTinThi DK = new frm4_DangKyThongTinThi();
                DK.Show();
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (radThiSinh.Checked == true)
            {
                //-----------------lấy text của thí sinh đã được check-------------
                chon = radThiSinh.Text;

                if (txtDangNhap.Text == "" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin của thí sinh!");
                    txtDangNhap.Focus();
                }
                else
                {
                    B_TS = new B_ThiSinh();
                    DataTable dt = new DataTable();
                    dt = B_TS.LayThiSinhDN(txtDangNhap.Text, txtMatKhau.Text);

                    if (dt.Rows.Count > 0)
                    {
                        frm7_DoiMatKhau frm_DMK = new frm7_DoiMatKhau();
                        foreach (DataRow dr in dt.Rows)
                        {
                            frm_DMK.tendangnhap = txtDangNhap.Text;
                            frm_DMK.matkhau = txtMatKhau.Text;
                            mathisinh = dt.Rows[0]["mathisinh"].ToString();
                            TenThiSinhDiThi = dt.Rows[0]["hoten"].ToString();
                        }
                        frm_DMK.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không tồn tại!");
                        txtDangNhap.SelectAll();
                    }
                }
            }
            else
            {
                //-------------lấy text của nhân viên--------------
                chon = radNhanVien.Text;
                if (txtDangNhap.Text == "" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Vui Lòng Nhập đầy đủ thông tin!");
                    txtDangNhap.Focus();
                }
                else
                {
                    B_NV = new B_NhanVien();
                    DataTable dt = new DataTable();
                    dt = B_NV.DangNhapNV(txtDangNhap.Text, txtMatKhau.Text);

                    if (dt.Rows.Count > 0)
                    {
                        frm7_DoiMatKhau frm_DMK = new frm7_DoiMatKhau();
                        foreach (DataRow dr in dt.Rows)
                        {
                            frm_DMK.tendangnhap = txtDangNhap.Text;
                            frm_DMK.matkhau = txtMatKhau.Text;
                            manhanvien = dt.Rows[0]["manhanvien"].ToString();
                            TenThiSinhDiThi = dt.Rows[0]["hoten"].ToString();
                        }
                        frm_DMK.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không tồn tại!");
                        txtDangNhap.SelectAll();
                    }


                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Đã Chắc Chắn Muốn Thoát? ", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1000;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                if (radThiSinh.Checked == true)
                {
                    cli.Close_Client();
                }
                frm2_GiaoDienChinh GDC = new frm2_GiaoDienChinh();
                GDC.Show();
                this.Hide();
            }

        }

        private void txtDangNhap_Click(object sender, EventArgs e)
        {
            if (txtDangNhap.ForeColor == Color.Black)
                return;
            txtDangNhap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            txtDangNhap.ForeColor = Color.Black;
            txtDangNhap.Clear();
        }

        private void txtDangNhap_Leave(object sender, EventArgs e)
        {
            if (!txtDangNhap.Text.Trim().Equals(""))
                return;
            txtDangNhap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic);
            txtDangNhap.ForeColor = Color.Black;
        }
    }
}


