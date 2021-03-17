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
    public partial class frm8_QuanLyTaiKhoan_NhanVien : Form
    {
        public frm8_QuanLyTaiKhoan_NhanVien()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        DataTable dt_ts = new DataTable();
        B_NhanVien B_NV=new B_NhanVien();
        B_ServerStatus status = new B_ServerStatus();
        Server ser = new Server();

        private void frm8_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            //-------laod dữ liệu vào bảng nhân viên----------
            NapNhanVien();
            txtMaNV.Focus();

            //kiểm tra nếu đăng nhập vào là nhâ viên thì không cho xóa 
        }

        private void NapNhanVien()
        {
            B_NV = new B_NhanVien();
            dt = B_NV.GetAll_NhanVien_B();
            dgvLoadThongTin.DataSource = dt; 
        }       

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frm2_GiaoDienChinh f = new frm2_GiaoDienChinh();
            f.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void XoaTrang()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtTenDN.Clear();
            txtMatKhau.Clear();
            cboChucVu.Text = "";
            mktDienThoai.Text = "";
            txtMaNV.Focus();
           
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        //---------------= SỰ KIỆN CELL CLICK---------------
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                B_NV = new B_NhanVien();

                string manhanvien = dgvLoadThongTin.CurrentRow.Cells[0].Value.ToString();//--------lấy mã nhân viên trong bảng nhân viên-

                dt = B_NV.GetAll_NhanVien_TheoMa_B(manhanvien);

                txtMaNV.Text = dt.Rows[0]["manhanvien"].ToString();
                txtHoTen.Text = dt.Rows[0]["hoten"].ToString();
                txtTenDN.Text = dt.Rows[0]["tendn"].ToString();
                txtMatKhau.Text = dt.Rows[0]["matkhau"].ToString();

                cboChucVu.DataSource = dt;
                cboChucVu.ValueMember = "manhanvien";
                cboChucVu.DisplayMember = "chucvu";

                txtDiaChi.Text = dt.Rows[0]["diachi"].ToString();
                mktDienThoai.Text = dt.Rows[0]["sodienthoai"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Trường Này Không Có Dữ Liệu!\n Bạn Vui Lòng Chọn Trường  Khác!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //string n = "434/34A Hiệp Hòa, Quận 12                                                                           ";
                //MessageBox.Show("ssdgs" + n.Length);

                if (txtDiaChi.Text == "" || txtHoTen.Text == "" || txtMaNV.Text == "" || txtMatKhau.Text == "" || txtTenDN.Text == "" || cboChucVu.Text == "" || mktDienThoai.Text == "")
                {
                    MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin!");
                    txtMaNV.SelectAll();
                }
                else
                {
                    B_NV = new B_NhanVien();
                    NhanVien nv = new NhanVien(txtMaNV.Text.ToUpper(), txtHoTen.Text, txtTenDN.Text, txtMatKhau.Text, cboChucVu.Text, txtDiaChi.Text, mktDienThoai.Text);

                    if (B_NV.ThemMoi_NV_B(nv) == 1)
                    {
                        MessageBox.Show("Thêm Nhân Viên Thành Công!");
                        NapNhanVien();
                        XoaTrang();
                    }
                    else
                    {
                        MessageBox.Show("Mã Nhân viên Bị Trùng!\n Bạn Vui lòng nhập lại mã nhân viên khác!");
                        txtMaNV.Clear();
                    }
                }
            }
            catch { return; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiaChi.Text == "" || txtHoTen.Text == "" || txtMaNV.Text == "" || txtMatKhau.Text == "" || txtTenDN.Text == "" || cboChucVu.Text == "" || mktDienThoai.Text == "")
                {
                    MessageBox.Show("Bạn Không Được Để Trống Nội Dung Nào! ", "Thông Báo!");
                }
                else
                {
                    string manv = dgvLoadThongTin.CurrentRow.Cells[0].Value.ToString();

                    NhanVien nv = new NhanVien(manv, txtHoTen.Text, txtTenDN.Text, txtMatKhau.Text, cboChucVu.Text, txtDiaChi.Text, mktDienThoai.Text);
                    if (B_NV.Sua_NhanVien_B(nv) == 1)
                    {
                        MessageBox.Show("Sửa Thông Tin Nhân Viên Thành Công!");
                        NapNhanVien();
                        XoaTrang();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thông Tin Nhân Viên Thất Bại!");

                    }
                }
            }
            catch { return; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Bạn Chọn Nhân Viên Để Xóa!");
                    txtMaNV.Focus();
                }
                else
                {

                    NhanVien NV = new NhanVien(txtMaNV.Text, txtHoTen.Text, txtTenDN.Text, txtMatKhau.Text, cboChucVu.Text, txtDiaChi.Text, mktDienThoai.Text);
                    if (B_NV.Xoa_NhanVien_B(NV) == 1)
                    {
                        MessageBox.Show("Xóa Nhân Viên Thành Công!");
                        NapNhanVien();
                        XoaTrang();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Nhân Viên Thất Bại!");
                        XoaTrang();
                    }
                }
            }
            catch { return; }

        }

        private void btnInDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            frmINDANHSACHCACNHANVIEN f = new frmINDANHSACHCACNHANVIEN();
            f.Show();
        }

        private void frm8_QuanLyTaiKhoan_NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dt = status.B_getStatusOfServer(1);
            string s = dt.Rows[0]["STATUS"].ToString();
            if (s == "The Server is working..." && frm1_DN.chon == "Nhân Viên")
                ser.Close_Server();
        }
    }
}
