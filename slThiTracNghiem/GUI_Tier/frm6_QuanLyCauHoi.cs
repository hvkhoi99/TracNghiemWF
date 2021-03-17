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
    public partial class frm6_QuanLyCauHoi : Form
    {
        public frm6_QuanLyCauHoi()
        {
            InitializeComponent();
            
        }
        B_CauHoi B_CH = new B_CauHoi();
        B_DapAn B_DA = new B_DapAn();
        B_MonThi B_MT = new B_MonThi();
        DataTable tbch = new DataTable();
        DataTable tbda = new DataTable();
        B_ServerStatus status = new B_ServerStatus();
        Server ser = new Server();

        public string laymanhanvien_QLCH = "";
        public static string chuchay = "                                                  ";

        public string MaCH = "";


        private void frm6_QuanLyCauHoi_Load(object sender, EventArgs e)
        {
            try
            {
                txt_MaNV.Text = frm2_GiaoDienChinh.manhanvien;
                txt_MaNV.ReadOnly = true;
                if (frm1_DN.chon == "Thí Sinh")
                {
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                }
                tbch = B_CH.getCauHoi_B();
                dgv_CauHoi.DataSource = tbch;
                dgv_CauHoi.Columns[0].HeaderText = "MÃ CÂU HỎI";
                dgv_CauHoi.Columns[1].HeaderText = "NỘI DUNG";
                dgv_CauHoi.Columns[2].HeaderText = "MÃ MÔN";
                dgv_CauHoi.Columns[3].HeaderText = "MÃ NHÂN VIÊN";

                tbda = B_DA.GetAll_DapAn_B();
                dgv_DapAn.DataSource = tbda;
                dgv_DapAn.Columns[0].HeaderText = "MÃ CÂU HỎI";
                dgv_DapAn.Columns[1].HeaderText = "MÃ ĐÁP ÁN";
                dgv_DapAn.Columns[2].HeaderText = "NỘI DUNG";
                dgv_DapAn.Columns[3].HeaderText = "KIỂU ĐÁP ÁN";


                //txt_MaNV.Text = laymanhanvien_QLCH;

                //mã môn mặc định cho người dùng
                string MaMon = "MT001";
                DataTable dt_MonThi = B_MT.GetMonThi_Theo_MaMon_B(MaMon);
                cbo_MonHoc.DataSource = dt_MonThi;
                cbo_MonHoc.DisplayMember = "TENMON";
                cbo_MonHoc.ValueMember = "MAMON";
            }
            catch
            {
                return;
            }

            //this.reportViewer1.RefreshReport();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            frm2_GiaoDienChinh gdc = new frm2_GiaoDienChinh();
            gdc.Show();
            this.Hide();
        }
        
        private void AnHet(bool cc)
        {
            btn_Them.Enabled = cc;
            btn_Luu.Enabled = cc;
            btn_Sua.Enabled = cc;
            btn_Xoa.Enabled = cc;
           
        }

        private void XoaHet()
        {
            txt_MaCH.Clear();
            txt_NoiDungCH.Clear();
            txt_MaDA1.Clear();
            txt_MaDA2.Clear();
            txt_MaDA3.Clear();
            txt_MaDA4.Clear();
            txt_DA1.Clear();
            txt_DA2.Clear();
            txt_DA3.Clear();
            txt_DA4.Clear();
            txt_MaCH.Focus();
        }

        //-----------XÓA TRẮNG NỘI DUNG CÁC TEXTBOX TRƯỚC KHI XEM--------------
        private void btn_Them_Click(object sender, EventArgs e)
        {
            XoaHet();
        }        

        //-------------SỰ KIỆN CELLCLICK VÀO BẢNG GRIDVIEW---------------
        private void dgv_CauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //------lay ma cau hoi trong DataGridview ------------
                MaCH = dgv_CauHoi.CurrentRow.Cells[0].Value.ToString();

                string MaMon = dgv_CauHoi.CurrentRow.Cells[2].Value.ToString();
                // MessageBox.Show("Ma mon Chon La :" + MaMon);

                DataTable dt_theomach = B_CH.GetCauHoi_TheoMaCh_D(MaCH);//----1
                DataTable dt_DA_theomach = B_DA.GetDapAn_Theo_MaCH_B(MaCH);
                DataTable dt_MonThi = B_MT.GetMonThi_Theo_MaMon_B(MaMon);

                txt_MaCH.Text = dt_theomach.Rows[0]["macauhoi"].ToString();
                txt_NoiDungCH.Text = dt_theomach.Rows[0]["noidung"].ToString();


                cbo_MonHoc.DataSource = dt_MonThi;
                cbo_MonHoc.DisplayMember = "TENMON";
                cbo_MonHoc.ValueMember = "MAMON";


                txt_MaDA1.Text = dt_DA_theomach.Rows[0]["madapan"].ToString();
                txt_MaDA2.Text = dt_DA_theomach.Rows[1]["madapan"].ToString();
                txt_MaDA3.Text = dt_DA_theomach.Rows[2]["madapan"].ToString();
                txt_MaDA4.Text = dt_DA_theomach.Rows[3]["madapan"].ToString();

                txt_DA1.Text = dt_DA_theomach.Rows[0]["noidungdapan"].ToString();
                txt_DA2.Text = dt_DA_theomach.Rows[1]["noidungdapan"].ToString();
                txt_DA3.Text = dt_DA_theomach.Rows[2]["noidungdapan"].ToString();
                txt_DA4.Text = dt_DA_theomach.Rows[3]["noidungdapan"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Dòng Này Không Có Dữ Liệu! \n Bạn Vui Lòng Chọn Dòng Khác! ","Thông Báo!");
            }

        }

        //-------------LẤY KIỂU CHO ĐÁP ÁN-----------------
        private void rad_A_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_A.Checked == true)
            {
                rad_A.Text = "1";
                rad_B.Text = "0";
                rad_C.Text = "0";
                rad_D.Text = "0";
            }
            if (rad_B.Checked == true)
           {
                rad_A.Text = "0";
                rad_B.Text = "1";
                rad_C.Text = "0";
                rad_D.Text = "0";
            }
            if (rad_C.Checked == true)
               {
                rad_A.Text = "0";
                rad_B.Text = "0";
                rad_C.Text = "1";
                rad_D.Text = "0";
            }
            if (rad_D.Checked == true)
            {
                rad_A.Text = "0";
                rad_B.Text = "0";
                rad_C.Text = "0";
                rad_D.Text = "1";
            }
               
        }

        //---------XEM LẠI CÁC THÔNG TIN TRONG BẢNG CÂU HỎI VỚI BẢNG ĐÁP ÁN ĐÃ CẬP NHẬT--THÊM------------------
        private void btn_XemHet_Click(object sender, EventArgs e)
        {
            try
            {
                tbch = B_CH.getCauHoi_B();
                dgv_CauHoi.DataSource = tbch;

                tbda = B_DA.GetAll_DapAn_B();
                dgv_DapAn.DataSource = tbda;
            }
            catch { return; }
        }

        //-----------LƯU CÂU HỎI ------ĐÁP ÁN MỚI------------------------------
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {               
                CauHoi CH = new CauHoi(txt_MaCH.Text.ToUpper(), txt_NoiDungCH.Text, cbo_MonHoc.SelectedValue.ToString(), txt_MaNV.Text.ToUpper());

                if (B_CH.ThemMoiCauHoi_B(CH) == 1)
                {
                    MessageBox.Show("Thêm Câu Hỏi Thành Công!");
                    dgv_CauHoi.DataSource = B_CH.GetCauHoi_TheoMaCh_D(txt_MaCH.Text);//hiển thị lại bảng câu hỏi theo mã câu hỏi
                }
                else
                {
                    MessageBox.Show("Thêm Câu Hỏi Thất Bại!");
                }



                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        DapAn DA1 = new DapAn(txt_MaDA1.Text.ToUpper(), txt_DA1.Text, txt_MaCH.Text.ToUpper(), rad_A.Text);

                        if (B_DA.ThemMoiDapAn(DA1) == 1)
                        {
                            //MessageBox.Show("Thêm Đáp Án A Thành Công");
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);
                        }
                        else
                        {
                            MessageBox.Show("Mã Đáp Án A Bị Trùng!");
                        }
                        i++;
                    }
                    if (i == 1)
                    {
                        DapAn DA2 = new DapAn(txt_MaDA2.Text.ToUpper(), txt_DA2.Text, txt_MaCH.Text.ToUpper(), rad_B.Text);

                        if (B_DA.ThemMoiDapAn(DA2) == 1)
                        {
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);
                        }
                        else
                        {
                            MessageBox.Show("Mã Đáp Án B Bị Trùng ");
                        }
                        i++;
                    }
                    if (i == 2)
                    {
                        DapAn DA3 = new DapAn(txt_MaDA3.Text.ToUpper(), txt_DA3.Text, txt_MaCH.Text.ToUpper(), rad_C.Text);

                        if (B_DA.ThemMoiDapAn(DA3) == 1)
                        {
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);

                        }
                        else
                        {
                            MessageBox.Show("Mã Đáp Án C Bị Trùng!");
                        }
                        i++;
                    }
                    if (i == 3)
                    {
                        DapAn DA4 = new DapAn(txt_MaDA4.Text.ToUpper(), txt_DA4.Text, txt_MaCH.Text.ToUpper(), rad_D.Text);

                        if (B_DA.ThemMoiDapAn(DA4) == 1)
                        {
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);

                        }
                        else
                        {
                            MessageBox.Show("Mã Đáp Án D Bị Trùng!");
                        }
                        i++;
                    }
                }
                ////-------end for---------//
                XoaHet();//--sau khi them xong thì xóa hết các textbox để người dùng nhạp tiếp
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin!");
            }



        }
        

        //-------------SỬA CÂU HỎI--------ĐÁP ÁN---------------------
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                CauHoi CH = new CauHoi(txt_MaCH.Text, txt_NoiDungCH.Text, cbo_MonHoc.SelectedValue.ToString(), txt_MaNV.Text);
                if (B_CH.SuaCauHoi_B(CH) == 1)
                {
                    MessageBox.Show("Sửa Câu Hỏi Thành Công!");
                    dgv_CauHoi.DataSource = B_CH.GetCauHoi_TheoMaCh_D(txt_MaCH.Text);//hiển thị lại bảng câu hỏi theo mã câu hỏi
                }
                else
                {
                    MessageBox.Show("Sửa Câu Hỏi Thất Bại!\n Bạn Vui Lòng Sửa Lại!");
                    XoaHet();
                }

                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        DapAn DA1 = new DapAn(txt_MaDA1.Text, txt_DA1.Text, txt_MaCH.Text, rad_A.Text);

                        if (B_DA.SuaDapAN_B(DA1) == 1)
                        {
                            //MessageBox.Show("Sửa Đáp Án A Thành Công");
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);
                        }
                        i++;
                    }
                    if (i == 1)
                    {
                        DapAn DA2 = new DapAn(txt_MaDA2.Text, txt_DA2.Text, txt_MaCH.Text, rad_B.Text);

                        if (B_DA.SuaDapAN_B(DA2) == 1)
                        {
                            //MessageBox.Show("Sửa Đáp Án B Thành Công");
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);
                        }
                        i++;
                    }
                    if (i == 2)
                    {
                        DapAn DA3 = new DapAn(txt_MaDA3.Text, txt_DA3.Text, txt_MaCH.Text, rad_C.Text);

                        if (B_DA.SuaDapAN_B(DA3) == 1)
                        {
                            //MessageBox.Show("Sửa Đáp Án C Thành Công");
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);
                        }
                        i++;
                    }
                    if (i == 3)
                    {
                        DapAn DA4 = new DapAn(txt_MaDA4.Text, txt_DA4.Text, txt_MaCH.Text, rad_D.Text);

                        if (B_DA.SuaDapAN_B(DA4) == 1)
                        {
                            //MessageBox.Show("Sửa Đáp Án D Thành Công");
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);
                        }
                        i++;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn Chưa Chọn nội Dung Để Sửa!", "Thông Báo!");
            }

        }

        
        //---------XÓA CÂU HỎI VÀ ĐÁP ÁN-----------------
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        DapAn DA1 = new DapAn(txt_MaDA1.Text, txt_DA1.Text, txt_MaCH.Text, rad_A.Text);

                        if (B_DA.XoaDapAN_B(DA1) == 1)
                        {
                            //MessageBox.Show("XÓA Đáp Án A Thành Công");
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);
                        }
                        i++;
                    }
                    if (i == 1)
                    {
                        DapAn DA2 = new DapAn(txt_MaDA2.Text, txt_DA2.Text, txt_MaCH.Text, rad_B.Text);

                        if (B_DA.XoaDapAN_B(DA2) == 1)
                        {
                            //MessageBox.Show("XÓA Đáp Án B Thành Công");
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);
                        }
                        i++;
                    }
                    if (i == 2)
                    {
                        DapAn DA3 = new DapAn(txt_MaDA3.Text, txt_DA3.Text, txt_MaCH.Text, rad_C.Text);

                        if (B_DA.XoaDapAN_B(DA3) == 1)
                        {
                            //MessageBox.Show("XÓA Đáp Án C Thành Công");
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);
                        }
                        i++;
                    }
                    if (i == 3)
                    {
                        DapAn DA4 = new DapAn(txt_MaDA4.Text, txt_DA4.Text, txt_MaCH.Text, rad_D.Text);

                        if (B_DA.XoaDapAN_B(DA4) == 1)
                        {
                            //MessageBox.Show("XÓA Đáp Án D Thành Công");
                            dgv_DapAn.DataSource = B_DA.GetDapAn_Theo_MaCH_B(txt_MaCH.Text);
                        }
                        i++;
                    }
                }//----------END FOR-----------

                CauHoi CH = new CauHoi(txt_MaCH.Text, txt_NoiDungCH.Text, cbo_MonHoc.SelectedValue.ToString(), txt_MaNV.Text);
                if (B_CH.XoaCauHoi_B(CH) == 1)
                {
                    MessageBox.Show("Xóa Câu Hỏi Thành Công !");
                    dgv_CauHoi.DataSource = B_CH.GetCauHoi_TheoMaCh_D(txt_MaCH.Text);//hiển thị lại bảng câu hỏi theo mã câu hỏi

                    //------------CẬP NHẬT THÔNG TIN SAU KHI XÓA------------------
                    tbch = B_CH.getCauHoi_B();
                    dgv_CauHoi.DataSource = tbch;

                    tbda = B_DA.GetAll_DapAn_B();
                    dgv_DapAn.DataSource = tbda;

                    //--------XÓA HẾT CÁC TEXTBOX---------
                    XoaHet();
                    
                }
                else
                {
                    MessageBox.Show("Xóa Câu Hỏi Thất Bại!\n Bạn Vui Lòng Xóa Lại!");
                    XoaHet();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn Chưa Chọn nội Dung Để Xóa!", "Thông Báo!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Title.Text = chuchay;
            string tam = chuchay[0].ToString();
            chuchay = chuchay.Substring(1, chuchay.Length - 1) + tam;
        }

        private void txt_MaCH_TextChanged(object sender, EventArgs e)
        {
            //lb2.Text = txt_MaCH.Text;
            txt_MaDA1.Text = txt_MaCH.Text+"A";
            txt_MaDA2.Text = txt_MaCH.Text+"B";
            txt_MaDA3.Text = txt_MaCH.Text+"C";
            txt_MaDA4.Text = txt_MaCH.Text+"D";

        }

        private void frm6_QuanLyCauHoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dt = status.B_getStatusOfServer(1);
            string s = dt.Rows[0]["STATUS"].ToString();
            if (s == "The Server is working..." && frm1_DN.chon == "Nhân Viên")
                ser.Close_Server();
        }
    }
}
