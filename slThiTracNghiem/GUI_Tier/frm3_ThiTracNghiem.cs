using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Tier;
using Entities;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Net;

namespace GUI_Tier
{
    public partial class frm3_ThiTracNghiem : Form
    {
        Client cli = new Client();
        Server ser = new Server();
        public frm3_ThiTracNghiem()
        {
            InitializeComponent();
            if (frm1_DN.chon == "Thí Sinh")
            {
                CheckForIllegalCrossThreadCalls = false;
                cli.Connect(frm1_DN.ServerIP);
            }
            
        }

        public static string s = "THI TRẮC NGHIỆM TIẾNG ANH";

        private bool flagA = false;
        private bool flagB = false;
        private bool flagC = false;
        private bool flagD = false;

        public int place = 0;
        public int socauhoi = 0;
        public static double Diem = 0;
        public static string mamonthi;
        B_MonThi B_MT = new B_MonThi();
        B_KetQua B_KQ = new B_KetQua();
        DataTable dt_MONTHI = new DataTable();
        DataTable dt_CAUHOI = new DataTable();
        DataTable dt_DAPAN = new DataTable();
        B_ServerStatus status = new B_ServerStatus();

        //Khởi tạo mảng lưu các câu hỏi
        ArrayList Array_Cauhoi = new ArrayList();
        ArrayList Array_Mach = new ArrayList();
        //Khởi tạo mảng lưu các đáp án
        ArrayList Array_Dapan = new ArrayList();
        ArrayList Array_Kieudapan = new ArrayList();
        ArrayList madapandung = new ArrayList();

        //Mãng các đáp án thí sinh đánh
        ArrayList DapAn_ThiSinh = new ArrayList();

        private int _currentMinute = 0;
        private int _currentSecond = 0;
        private Timer _timer;        

        string ketquathi;

        private void frm3_ThiTracNghiem_Load(object sender, EventArgs e)
        {
            ancacbutton(false);
            //---------LOAD CÁC THÔNG TIN CƠ BẢN--------

            lblHoten.Text = frm1_DN.TenThiSinhDiThi;
            GRP_THI.Enabled = false;

            //lblNgayThi.Text = System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Year.ToString();
            pic_NopBaiThi.Enabled = false;
            //-----lấy môn thi đưa vào comboboxmonthi-----------
            dt_MONTHI = new B_MonThi().GetMonThi();
            cboMonThi.DataSource = dt_MONTHI;
            cboMonThi.DisplayMember = "TENMON";
            cboMonThi.ValueMember = "MAMON";

            //--------số câu hỏi----------------------
            cboSoCauHoi.Text = "10";
            lblMaCauHoi.Visible = true;
        }

        private void GanCauHoiVaoMang()
        {
            //Lấy giá trị câu hỏi
            if (cboSoCauHoi.Text == "10")
            {
                socauhoi = 10;
                _currentMinute = 0;
                _currentSecond = 30;
            }
            else if (cboSoCauHoi.Text == "15")
            {
                socauhoi = 15;
                //proThoiGian.Maximum = 10000;
                _currentMinute = 1;
                _currentSecond = 0;
            }
            else if (cboSoCauHoi.Text == "20")
            {
                socauhoi = 20;
                _currentMinute = 1;
                _currentSecond = 30;
            }

            //Lấy câu hỏi và lưu vào mảng--------------------------------------------

            dt_CAUHOI = new B_CauHoi().RanDomCauHoi(cboSoCauHoi.Text, cboMonThi.SelectedValue.ToString());
            for (int i = 0; i < socauhoi; i++)
            {
                Array_Mach.Add(dt_CAUHOI.Rows[i][0].ToString());//-----mã câu hỏi ở vị trí 0 trong bảng câu hỏi
                Array_Cauhoi.Add(dt_CAUHOI.Rows[i][1].ToString());//------nội dung câu hỏi trong bảng-----
                //Tạo đáp án ảo cho Thí Sinh
                DapAn_ThiSinh.Add("5");

                dt_DAPAN = new B_DapAn().GetDapAn(Array_Mach[i].ToString()).Tables[0];

                for (int j = 0; j < 4; j++)
                {
                    Array_Dapan.Add(dt_DAPAN.Rows[j][0].ToString());//--nôi dung các đáp án--------  
                    Array_Kieudapan.Add(dt_DAPAN.Rows[j][1].ToString());//---------kiểu đáp án                   

                    if (dt_DAPAN.Rows[j][1].ToString().Trim().Equals("1"))//----nếu kiểu đáp án =1
                    {
                        //Đáp án lưu theo số thứ tự (Ví dụ A lưu thành 1 và B lưu thành 2)
                        madapandung.Add(Convert.ToString(j + 1));//------add đáp án đúng và lưu vào mảng
                    }
                }
            }

        }

        //------------HÀM HIỂN THỊ CÂU HỎI------------------
        public void Hienthicauhoi(int cau)
        {
            lbl_noidungcauhoi.Text = "Câu " + (cau + 1) + " : " + Array_Cauhoi[cau].ToString();
            //lblMaCauHoi.Text = Array_Mach[cau].ToString();
            Hienthidapan(cau);
        }

        //--------------------HÀM HIỂN THỊ CÁC ĐÁP ÁN---------------------------
        public void Hienthidapan(int b)
        {
            lblDapAnA.Text = Array_Dapan[0 + (b * 4)].ToString();
            lblDapAnB.Text = Array_Dapan[1 + (b * 4)].ToString();
            lblDapAnC.Text = Array_Dapan[2 + (b * 4)].ToString();
            lblDapAnD.Text = Array_Dapan[3 + (b * 4)].ToString();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            LuuDapAn();
            place = 0;
            Hienthicauhoi(place);
            Danh_Dap_An_ThiSinh();

        }
        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (place == 0)
            {
                Hienthicauhoi(0);
                Danh_Dap_An_ThiSinh();
            }
            else
            {
                LuuDapAn();
                place--;
                Danh_Dap_An_ThiSinh();
                Hienthicauhoi(place);
                if (_timer.Enabled==false) { _ChangeColorCorrectQues(place); }             

            }
        }
        private void btnTiep_Click(object sender, EventArgs e)
        {
            if (place == socauhoi - 1)
            {
                
                LuuDapAn();
                Hienthicauhoi(socauhoi - 1);
                Danh_Dap_An_ThiSinh();
            }
            else
            {
                LuuDapAn();
                place++;
                Danh_Dap_An_ThiSinh();
                Hienthicauhoi(place);
                if (_timer.Enabled == false) { _ChangeColorCorrectQues(place); }

            }

        }
        private void btnCuoi_Click(object sender, EventArgs e)
        {
            LuuDapAn();
            place = socauhoi - 1;
            Hienthicauhoi(socauhoi - 1);
            Danh_Dap_An_ThiSinh();
        }

        private void LuuDapAn()
        {
            String answer = "";
            if (radA.Checked == true)
            {
                answer = "1";
            }
            if (radB.Checked == true)
            {
                answer = "2";
            }
            if (radC.Checked == true)
            {
                answer = "3";
            }
            if (radD.Checked == true)
            {
                answer = "4";
            }
            DapAn_ThiSinh[place] = answer;

        }
        //Đánh đáp án của thí sinh đã đánh vào trắc nghiệm
        private void Danh_Dap_An_ThiSinh()
        {
            if (DapAn_ThiSinh[place].ToString() == "1")
            {
                radA.Checked = true;
            }
            else if (DapAn_ThiSinh[place].ToString() == "2")
            {
                radB.Checked = true;
            }
            else if (DapAn_ThiSinh[place].ToString() == "3")
            {
                radC.Checked = true;
            }
            else if (DapAn_ThiSinh[place].ToString() == "4")
            {
                radD.Checked = true;
            }
            else
            {
                radA.Checked = false;
                radB.Checked = false;
                radC.Checked = false;
                radD.Checked = false;
            }
        }


        private void Tgian()
        {
            string sPhut = "";
            string sGiay = "";
            if (_currentMinute < 10)
            {
                sPhut = "0" + _currentMinute.ToString();
            }
            else
            {
                sPhut = _currentMinute.ToString();
            }

            if (_currentSecond < 10)
            {
                sGiay = "0" + _currentSecond.ToString();
            }
            else
            {
                sGiay = _currentSecond.ToString();
            }

            //this.lbl_CountDown.Text = sPhut + " : " + sGiay;
        }


        private void tmThoiGianThi_Tick(object sender, EventArgs e)
        {
            Tgian();

            if (_currentMinute > 0)
            {
                if (_currentSecond > 0)
                {
                    Tgian();
                    _currentSecond--;
                }
                else
                {
                    _currentSecond = 59;
                    _currentMinute--;
                }
            }
            else
            {
                _currentSecond--;
            }
            //_currentSecond--;
            //if (_currentSecond < 0)
            //{
            //    _currentMinute--;
            //    _currentSecond = 59;
            //    lbl_CountDown.Text = _currentMinute + " : " + _currentSecond;
            //}
            if (_currentMinute == 0 && _currentSecond == -1)
            {
                _timer.Stop();
                tmThoiGianThi.Stop();
                nopbaithi_ketqua();
                if (MessageBox.Show("Bạn Có Muốn Trở Về Giao Diện Chính Không?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frm2_GiaoDienChinh frm = new frm2_GiaoDienChinh();
                    frm.Show();
                    this.Hide();
                }
            }
            if (_currentSecond == -1) _currentSecond = 0;
            lbl_CountDown.Text = _currentMinute + " : " + _currentSecond;
        }

        private void cboSoCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            mamonthi = cboMonThi.SelectedValue.ToString();
        }
        private void ancacbutton(bool an)
        {
            btnCuoi.Enabled = an;
            btnDau.Enabled = an;
            btnTiep.Enabled = an;
            btnTruoc.Enabled = an;
        }

        private void pic_BatDauThi_Click(object sender, EventArgs e)
        {
            try
            {
                ancacbutton(true);
                lbldapan.Visible = true;
                // lblMaCauHoi.te;
                GRP_THI.Enabled = true;
                // lblMaCauHoi.Visible = false;
                lblHoten.Text = frm1_DN.TenThiSinhDiThi;
                //----enable button nopbai
                pic_NopBaiThi.Enabled = true;
                //--------gán câu hỏi vào mảng----
                GanCauHoiVaoMang();
                //Hiển thị câu hỏi đầu tiên
                Hienthicauhoi(0);
                //--------bắt đầu tính thời gian-------------
                //tmThoiGianThi.Start();
                _timer = new Timer();
                _timer.Interval = 1000;
                _timer.Tick += new EventHandler(tmThoiGianThi_Tick);
                _timer.Start();
               
                pic_BatDauThi.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Load Câu Hỏi Thất Bại!\n Bạn Vui Lòng Load Lại Trang Thi Trắc Nghiệm!", "Thông Báo!");
                frm2_GiaoDienChinh frm = new frm2_GiaoDienChinh();
                frm.Show();
                this.Hide();
            }
        }
            
        private void nopbaithi_ketqua()
        {
            try
            {
                //-----------dừng thời gian thi lại-------
                LuuDapAn();
                _timer.Stop();
                tmThoiGianThi.Stop();
                double diem = 0;
                int socaudung = 0;
                for (int i = 0; i < socauhoi; i++)
                {
                    // MessageBox.Show(DapAn_ThiSinh[i].ToString() + "@" + madapandung[i].ToString());
                    if (DapAn_ThiSinh[i].ToString() == madapandung[i].ToString())
                    {
                        socaudung++;
                    }
                }

                diem = Math.Pow((10 / (double)socauhoi * socaudung), 1);

                if (frm1_DN.chon == "Thí Sinh")
                {
                    //-----------lưu điểm lại cho người thi rồi load điểm lại cho họ xem---------
                    KetQua kqt = new KetQua(frm1_DN.mathisinh, frm1_DN.TenThiSinhDiThi, mamonthi, Math.Round(diem,2), dtpic.Value.ToString());
                    if (B_KQ.LuuKetQua_B(kqt) > 0)
                    {
                        MessageBox.Show("Thí sinh " + lblHoten.Text + " Thi Được : " + Math.Round(diem,2) + " Điểm!", "Kết Quả Thi!");
                        ketquathi = frm1_DN.mathisinh.Trim() + "," + frm1_DN.TenThiSinhDiThi.Trim() + "," + mamonthi.Trim() + "," + Math.Round(diem, 2) + "," + dtpic.Value.ToString().Trim();
                        cli.Send(ketquathi);
                        pic_BatDauThi.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi Lưu Kết Quả!", "Thông Báo!");
                    }
                }
                else
                {
                    MessageBox.Show("Thí sinh " + lblHoten.Text + " Thi Được : " + Math.Round(diem,2) + " Điểm.", "Kết Quả Thi");
                    pic_BatDauThi.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Lưu Kết Quả!", "Thông Báo!");
            }
        }
        private void pic_NopBaiThi_Click(object sender, EventArgs e)
        {
            try
            {
                _timer.Stop();
                tmThoiGianThi.Stop();
                nopbaithi_ketqua();
                if (MessageBox.Show("Bạn Có Muốn Trở Về Giao Diện Chính Không?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frm2_GiaoDienChinh frm = new frm2_GiaoDienChinh();
                    frm.Show();
                    this.Hide();
                }
            }
            catch { return; }
        }

        private void pic_TroVe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Muốn Trở Về Giao Diện Chính Không?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (frm1_DN.chon == "Thí Sinh")
                    cli.Close_Client();
                
                frm2_GiaoDienChinh frm = new frm2_GiaoDienChinh();
                frm.Show();
                this.Hide();
            }
        }

        //To mau nhung cau tra loi dung
        private void _ChangeColorCorrectQues(int place)
        {
            string tempAnswer = madapandung[place].ToString();
            if (tempAnswer == "1")
            {
                flagA = true;
                flagB = false;
                flagC = false;
                flagD = false;
            }
            else if (tempAnswer == "2")
            {
                flagA = false;
                flagB = true;
                flagC = false;
                flagD = false;
            }
            else if (tempAnswer == "3")
            {
                flagA = false;
                flagB = false;
                flagC = true;
                flagD = false;
            }
            else if (tempAnswer == "4")
            {
                flagA = false;
                flagB = false;
                flagC = false;
                flagD = true;
            }
            lblDapAnA.ForeColor = flagA ? Color.Orange : Color.Teal;
            lblDapAnB.ForeColor = flagB ? Color.Orange : Color.Teal;
            lblDapAnC.ForeColor = flagC ? Color.Orange : Color.Teal;
            lblDapAnD.ForeColor = flagD ? Color.Orange : Color.Teal;
        }

        private void frm3_ThiTracNghiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frm1_DN.chon == "Thí Sinh")
                cli.Close_Client();
            else if ( cli.Status(1) == "The Server is working..." && frm1_DN.chon == "Nhân Viên")
                ser.Close_Server();
        }
    }
}
