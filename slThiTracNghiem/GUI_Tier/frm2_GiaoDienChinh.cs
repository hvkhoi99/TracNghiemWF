using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Tier;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Entities;


namespace GUI_Tier
{
    public partial class frm2_GiaoDienChinh : Form
    {

        B_ThiSinh B_TS = new B_ThiSinh();
        B_KetQua B_KQ = new B_KetQua();
        frm1_DN frm1 = new frm1_DN();
        Client cli = new Client();
        Server ser = new Server();

        public string LayMaNV_GDC = "";
        public static string s = "                                                    ";
        public static string manhanvien;

        public frm2_GiaoDienChinh()
        {
            InitializeComponent();
            this.ChucNang_Show(); //hiện tại đóng mục này lại để làm phương án 1
        }

        private void AdminConnect()
        {
            if (frm1_DN.chon == "Nhân Viên")
            {
                //1. hiện tại: 
                //sau khi Nhân viên đăng nhập thì hàm Connect() dc gọi ngay lúc đầu
                //nếu Nhân Viên ấn "Đăng nhập lại" hoặc "Đăng Xuất" thì gọi server.Close();
                //formClose() gọi server.Close(); phòng khi thoát đột ngột
                //nếu nhấn vào các button khác thì sẽ đặt server.Close() vảo trong các form (formClose()) mà các button đó dẫn đến
                //
                //2. cách khác: 
                //tạo thêm một buttonStopServer nữa, một biến ServerStatus = flase, một lable_Server_Status hiển thị trạng thái hiện tại của Server
                //nếu ấn vào button StartServer thì ServerStatus = true và lable_Server_Status sẽ hiển thị text "The Server is opening..."
                //lúc này, sau khi start server thì buttonStopServer sẽ được hiển thị, buttonStartServer sẽ bị ẩn đi.
                //+ nếu ấn vào các button dẫn đến các form khác thì ở các form khác, sẽ set server.Close() trong formClose của các form đó
                //+ nếu quay lại trang chủ (form2-Giao diện chính), khi ấn buttonStopServer thì sẽ gọi server.Close, lúc này server đã được ngắt kết nối
                //sau khi ấn stopserver, lable_Server_Status sẽ hiển thị "The Server is off", và biến ServerStatus = false;

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTT.Text = s;
            string tam = s[0].ToString();
            s = s.Substring(1, s.Length - 1) + tam;
        }

        private void ChucNang_Show()
        {
            if (frm1_DN.chon == "Thí Sinh")
            {
                this.pic_DangNhapLai.Location = new System.Drawing.Point(155, 398);
                this.pic_Thoat.Location = new System.Drawing.Point(491, 398);
                this.lblDangNhapLai.Location = new System.Drawing.Point(154, 524);
                this.lblDangXuat.Location = new System.Drawing.Point(502, 524);
                this.pic_StartServer.Visible = false;
                this.lblStartServer.Visible = false;
                this.pic_StopServer.Visible = false;
                this.lblStopServer.Visible = false;
                this.lblServerStatus.Text = "IP: " + frm1_DN.ServerIP;
            }
            else
            {
                this.pic_StartServer.Location = new System.Drawing.Point(88, 398);
                this.lblStartServer.Location = new System.Drawing.Point(106, 524);
                this.pic_DangNhapLai.Location = new System.Drawing.Point(447, 398);
                this.lblDangNhapLai.Location = new System.Drawing.Point(446, 524);
                this.pic_Thoat.Location = new System.Drawing.Point(631, 398);
                this.lblDangXuat.Location = new System.Drawing.Point(642, 524);
                this.pic_StartServer.Visible = true;
                this.lblStartServer.Visible = true;
                this.pic_StopServer.Visible = false;
                this.lblStopServer.Visible = false;
                lblServerStatus.Text = cli.Status(1);
                if (cli.Status(1) == "The Server is off...")
                {
                    this.pic_StartServer.Location = new System.Drawing.Point(88, 398);
                    this.lblStartServer.Location = new System.Drawing.Point(106, 524);
                    this.pic_StartServer.Visible = true;
                    this.lblStartServer.Visible = true;
                    this.pic_StopServer.Visible = false;
                    this.lblStopServer.Visible = false;
                }
                else if (cli.Status(1) == "The Server is working...")
                {
                    this.pic_StopServer.Location = new System.Drawing.Point(88, 398);
                    this.lblStopServer.Location = new System.Drawing.Point(106, 524);
                    this.pic_StartServer.Visible = false;
                    this.lblStartServer.Visible = false;
                    this.pic_StopServer.Visible = true;
                    this.lblStopServer.Visible = true;
                }
            }
        }

        private void pic_Thoat_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Đã Chắc Chắn Muốn Thoát?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cli.Status(1) == "The Server is working..." && frm1_DN.chon == "Nhân Viên") ser.Close_Server();
                    Application.Exit();
                }
            }
            catch { return; }
        }

        private void pic_DangNhapLai_Click(object sender, EventArgs e)
        {
            try
            {
                if (cli.Status(1) == "The Server is working..." && frm1_DN.chon == "Nhân Viên") ser.Close_Server();

                frm1.Show();
                this.Hide();
            }
            catch { return; }
        }

        private void frm2_GiaoDienChinh_Load(object sender, EventArgs e)
        {
            manhanvien = frm1_DN.manhanvien;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (cli.Status(1) == "The Server is working..." && frm1_DN.chon == "Nhân Viên") ser.Close_Server();
            frm3_ThiTracNghiem frm = new frm3_ThiTracNghiem();
            frm.Show();
            this.Hide();
        }

        private void btnQuanLyTK_Click(object sender, EventArgs e)
        {
            if (frm1_DN.chon == "Thí Sinh" || frm1_DN.chucvu.Trim() == "Nhân Viên")
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập!");
            }
            else
            {
                if (radNhanVien.Checked == false && radThiSinh.Checked == false)
                {
                    MessageBox.Show("Bạn Chưa Chọn Loại Tài Khoản Nào!\n \n Vui Lòng Chọn 1 Trong 2 Tài Khoản Ở Trên! \n\n Xin Cảm Ơn!");
                }
                else
                {
                    if (radNhanVien.Checked == true)
                    {
                        frm8_QuanLyTaiKhoan_NhanVien nv = new frm8_QuanLyTaiKhoan_NhanVien();
                        nv.Show();
                        this.Hide();
                    }
                    else
                    {
                        frm9_QuanLyThiSinh ts = new frm9_QuanLyThiSinh();
                        ts.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void btnQuanlyCH_Click(object sender, EventArgs e)
        {
            if (frm1_DN.chon == "Thí Sinh" || frm1_DN.chucvu.Trim() == "Nhân Viên")
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập!");
            }
            else
            {
                frm6_QuanLyCauHoi frmcauhoi = new frm6_QuanLyCauHoi();
                frmcauhoi.laymanhanvien_QLCH = LayMaNV_GDC;
                frmcauhoi.Show();
                this.Hide();
            }
        }

        private void btnXemdiem_Click(object sender, EventArgs e)
        {
            frm5_KetQuaThi frm = new frm5_KetQuaThi();
            frm.Show();
            this.Hide();
        }

        private void pic_StopServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (cli.Status(1) == "The Server is working..." && frm1_DN.chon == "Nhân Viên")
                {
                    ser.Close_Server();
                    lblServerStatus.Text = cli.Status(1);
                    this.pic_StartServer.Location = new System.Drawing.Point(88, 398);
                    this.lblStartServer.Location = new System.Drawing.Point(106, 524);
                    this.pic_StartServer.Visible = true;
                    this.lblStartServer.Visible = true;
                    this.pic_StopServer.Visible = false;
                    this.lblStopServer.Visible = false;
                    MessageBox.Show("Server đã bị tắt!");

                }
            }
            catch
            {
                return;
            }
        }

        private void pic_StartServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (cli.Status(1) == "The Server is off...")
                {
                    if (cli.ServerStatusIs("The Server is working...", 1) == 1)
                    {
                        ser.Connect();
                        CheckForIllegalCrossThreadCalls = false;
                        //TS004,Bùi Tiến Dũng,MT001,10,12/18/2020 4:35:09 PM
                        lblServerStatus.Text = cli.Status(1);
                        this.pic_StopServer.Location = new System.Drawing.Point(88, 398);
                        this.lblStopServer.Location = new System.Drawing.Point(106, 524);
                        this.pic_StartServer.Visible = false;
                        this.lblStartServer.Visible = false;
                        this.pic_StopServer.Visible = true;
                        this.lblStopServer.Visible = true;
                        MessageBox.Show("Server đã được bật!");
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void frm2_GiaoDienChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cli.Status(1) == "The Server is working..." && frm1_DN.chon == "Nhân Viên")
            {
                ser.Close_Server();
            }
        }
    }
}
