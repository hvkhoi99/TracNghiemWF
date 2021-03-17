namespace GUI_Tier
{
    partial class frm6_QuanLyCauHoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm6_QuanLyCauHoi));
            this.dgv_CauHoi = new System.Windows.Forms.DataGridView();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaCH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NoiDungCH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.dgv_DapAn = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rad_A = new System.Windows.Forms.RadioButton();
            this.rad_B = new System.Windows.Forms.RadioButton();
            this.rad_C = new System.Windows.Forms.RadioButton();
            this.rad_D = new System.Windows.Forms.RadioButton();
            this.txt_DA1 = new System.Windows.Forms.TextBox();
            this.txt_DA2 = new System.Windows.Forms.TextBox();
            this.txt_DA3 = new System.Windows.Forms.TextBox();
            this.txt_DA4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_MonHoc = new System.Windows.Forms.ComboBox();
            this.btn_XemHet = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grp_NoiDung = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDA = new System.Windows.Forms.Label();
            this.lbCH = new System.Windows.Forms.Label();
            this.txt_MaDA4 = new System.Windows.Forms.TextBox();
            this.txt_MaDA3 = new System.Windows.Forms.TextBox();
            this.txt_MaDA2 = new System.Windows.Forms.TextBox();
            this.txt_MaDA1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DapAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_NoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_CauHoi
            // 
            this.dgv_CauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CauHoi.GridColor = System.Drawing.Color.Black;
            this.dgv_CauHoi.Location = new System.Drawing.Point(21, 32);
            this.dgv_CauHoi.Name = "dgv_CauHoi";
            this.dgv_CauHoi.Size = new System.Drawing.Size(449, 183);
            this.dgv_CauHoi.TabIndex = 0;
            this.dgv_CauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CauHoi_CellClick);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.BackColor = System.Drawing.Color.Yellow;
            this.btn_TroVe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TroVe.Location = new System.Drawing.Point(881, 556);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(115, 49);
            this.btn_TroVe.TabIndex = 13;
            this.btn_TroVe.Text = "Trở về";
            this.toolTip1.SetToolTip(this.btn_TroVe, "Trở Về Giao Diện Chính");
            this.btn_TroVe.UseVisualStyleBackColor = false;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Câu Hỏi";
            // 
            // txt_MaCH
            // 
            this.txt_MaCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaCH.Location = new System.Drawing.Point(41, 47);
            this.txt_MaCH.Name = "txt_MaCH";
            this.txt_MaCH.Size = new System.Drawing.Size(93, 26);
            this.txt_MaCH.TabIndex = 0;
            this.txt_MaCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MaCH.TextChanged += new System.EventHandler(this.txt_MaCH_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(168, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội Dung Câu Hỏi ";
            // 
            // txt_NoiDungCH
            // 
            this.txt_NoiDungCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoiDungCH.Location = new System.Drawing.Point(171, 47);
            this.txt_NoiDungCH.Multiline = true;
            this.txt_NoiDungCH.Name = "txt_NoiDungCH";
            this.txt_NoiDungCH.Size = new System.Drawing.Size(393, 61);
            this.txt_NoiDungCH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(624, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã NV :";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(700, 364);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(156, 26);
            this.txt_MaNV.TabIndex = 3;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Yellow;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(616, 556);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(115, 49);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Reset form";
            this.toolTip1.SetToolTip(this.btn_Them, "Xóa Trắng Các  TextBox");
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Yellow;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(751, 490);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(115, 49);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sửa";
            this.toolTip1.SetToolTip(this.btn_Sua, "Lưu Thông Tin Câu Hỏi Vừa Sửa");
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Yellow;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(881, 490);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(115, 49);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btn_Xoa, "Xóa Câu Hỏi Đang Chọn");
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Yellow;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(751, 556);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(115, 49);
            this.btn_Luu.TabIndex = 10;
            this.btn_Luu.Text = "Lưu";
            this.toolTip1.SetToolTip(this.btn_Luu, "Lưu Thông Tin Nhập Mới");
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // dgv_DapAn
            // 
            this.dgv_DapAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DapAn.GridColor = System.Drawing.Color.Black;
            this.dgv_DapAn.Location = new System.Drawing.Point(18, 32);
            this.dgv_DapAn.Name = "dgv_DapAn";
            this.dgv_DapAn.Size = new System.Drawing.Size(449, 183);
            this.dgv_DapAn.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv_CauHoi);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(8, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin câu hỏi";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgv_DapAn);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(513, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 226);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đáp án";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(17, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Đáp Án ";
            // 
            // rad_A
            // 
            this.rad_A.AutoSize = true;
            this.rad_A.Location = new System.Drawing.Point(142, 169);
            this.rad_A.Name = "rad_A";
            this.rad_A.Size = new System.Drawing.Size(14, 13);
            this.rad_A.TabIndex = 7;
            this.rad_A.UseVisualStyleBackColor = true;
            this.rad_A.CheckedChanged += new System.EventHandler(this.rad_A_CheckedChanged);
            // 
            // rad_B
            // 
            this.rad_B.AutoSize = true;
            this.rad_B.Location = new System.Drawing.Point(142, 203);
            this.rad_B.Name = "rad_B";
            this.rad_B.Size = new System.Drawing.Size(14, 13);
            this.rad_B.TabIndex = 7;
            this.rad_B.UseVisualStyleBackColor = true;
            this.rad_B.CheckedChanged += new System.EventHandler(this.rad_A_CheckedChanged);
            // 
            // rad_C
            // 
            this.rad_C.AutoSize = true;
            this.rad_C.Location = new System.Drawing.Point(142, 235);
            this.rad_C.Name = "rad_C";
            this.rad_C.Size = new System.Drawing.Size(14, 13);
            this.rad_C.TabIndex = 7;
            this.rad_C.UseVisualStyleBackColor = true;
            this.rad_C.CheckedChanged += new System.EventHandler(this.rad_A_CheckedChanged);
            // 
            // rad_D
            // 
            this.rad_D.AutoSize = true;
            this.rad_D.Location = new System.Drawing.Point(142, 267);
            this.rad_D.Name = "rad_D";
            this.rad_D.Size = new System.Drawing.Size(14, 13);
            this.rad_D.TabIndex = 7;
            this.rad_D.UseVisualStyleBackColor = true;
            this.rad_D.CheckedChanged += new System.EventHandler(this.rad_A_CheckedChanged);
            // 
            // txt_DA1
            // 
            this.txt_DA1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA1.Location = new System.Drawing.Point(173, 163);
            this.txt_DA1.Name = "txt_DA1";
            this.txt_DA1.Size = new System.Drawing.Size(391, 26);
            this.txt_DA1.TabIndex = 6;
            // 
            // txt_DA2
            // 
            this.txt_DA2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA2.Location = new System.Drawing.Point(173, 195);
            this.txt_DA2.Name = "txt_DA2";
            this.txt_DA2.Size = new System.Drawing.Size(391, 26);
            this.txt_DA2.TabIndex = 7;
            // 
            // txt_DA3
            // 
            this.txt_DA3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA3.Location = new System.Drawing.Point(173, 227);
            this.txt_DA3.Name = "txt_DA3";
            this.txt_DA3.Size = new System.Drawing.Size(391, 26);
            this.txt_DA3.TabIndex = 8;
            // 
            // txt_DA4
            // 
            this.txt_DA4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA4.Location = new System.Drawing.Point(173, 259);
            this.txt_DA4.Name = "txt_DA4";
            this.txt_DA4.Size = new System.Drawing.Size(391, 26);
            this.txt_DA4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(170, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nội Dung Đáp Án";
            // 
            // cbo_MonHoc
            // 
            this.cbo_MonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MonHoc.FormattingEnabled = true;
            this.cbo_MonHoc.Location = new System.Drawing.Point(700, 419);
            this.cbo_MonHoc.Name = "cbo_MonHoc";
            this.cbo_MonHoc.Size = new System.Drawing.Size(156, 27);
            this.cbo_MonHoc.TabIndex = 8;
            // 
            // btn_XemHet
            // 
            this.btn_XemHet.BackColor = System.Drawing.Color.Yellow;
            this.btn_XemHet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemHet.Location = new System.Drawing.Point(616, 490);
            this.btn_XemHet.Name = "btn_XemHet";
            this.btn_XemHet.Size = new System.Drawing.Size(115, 49);
            this.btn_XemHet.TabIndex = 11;
            this.btn_XemHet.Text = "Xem hết";
            this.toolTip1.SetToolTip(this.btn_XemHet, "Xem Tất Cả Câu Hỏi Và Đáp Án");
            this.btn_XemHet.UseVisualStyleBackColor = false;
            this.btn_XemHet.Click += new System.EventHandler(this.btn_XemHet_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(1006, 53);
            this.lbl_Title.TabIndex = 14;
            this.lbl_Title.Text = "Quản lý câu hỏi ";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grp_NoiDung
            // 
            this.grp_NoiDung.BackColor = System.Drawing.Color.Transparent;
            this.grp_NoiDung.Controls.Add(this.label11);
            this.grp_NoiDung.Controls.Add(this.label10);
            this.grp_NoiDung.Controls.Add(this.label9);
            this.grp_NoiDung.Controls.Add(this.lbDA);
            this.grp_NoiDung.Controls.Add(this.lbCH);
            this.grp_NoiDung.Controls.Add(this.rad_D);
            this.grp_NoiDung.Controls.Add(this.rad_C);
            this.grp_NoiDung.Controls.Add(this.rad_B);
            this.grp_NoiDung.Controls.Add(this.rad_A);
            this.grp_NoiDung.Controls.Add(this.txt_NoiDungCH);
            this.grp_NoiDung.Controls.Add(this.txt_MaDA4);
            this.grp_NoiDung.Controls.Add(this.txt_MaDA3);
            this.grp_NoiDung.Controls.Add(this.txt_MaDA2);
            this.grp_NoiDung.Controls.Add(this.txt_MaDA1);
            this.grp_NoiDung.Controls.Add(this.txt_DA4);
            this.grp_NoiDung.Controls.Add(this.txt_DA3);
            this.grp_NoiDung.Controls.Add(this.txt_DA2);
            this.grp_NoiDung.Controls.Add(this.txt_DA1);
            this.grp_NoiDung.Controls.Add(this.txt_MaCH);
            this.grp_NoiDung.Controls.Add(this.label6);
            this.grp_NoiDung.Controls.Add(this.label2);
            this.grp_NoiDung.Controls.Add(this.label5);
            this.grp_NoiDung.Controls.Add(this.label1);
            this.grp_NoiDung.ForeColor = System.Drawing.Color.Black;
            this.grp_NoiDung.Location = new System.Drawing.Point(8, 333);
            this.grp_NoiDung.Name = "grp_NoiDung";
            this.grp_NoiDung.Size = new System.Drawing.Size(589, 306);
            this.grp_NoiDung.TabIndex = 15;
            this.grp_NoiDung.TabStop = false;
            this.grp_NoiDung.Text = "Nội dung câu hỏi và đáp án";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "DA";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "DA";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "DA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDA
            // 
            this.lbDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDA.ForeColor = System.Drawing.Color.Black;
            this.lbDA.Location = new System.Drawing.Point(4, 165);
            this.lbDA.Name = "lbDA";
            this.lbDA.Size = new System.Drawing.Size(37, 23);
            this.lbDA.TabIndex = 11;
            this.lbDA.Text = "DA";
            this.lbDA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCH
            // 
            this.lbCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCH.ForeColor = System.Drawing.Color.Black;
            this.lbCH.Location = new System.Drawing.Point(4, 49);
            this.lbCH.Name = "lbCH";
            this.lbCH.Size = new System.Drawing.Size(37, 23);
            this.lbCH.TabIndex = 10;
            this.lbCH.Text = "CH";
            this.lbCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MaDA4
            // 
            this.txt_MaDA4.Enabled = false;
            this.txt_MaDA4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDA4.Location = new System.Drawing.Point(42, 259);
            this.txt_MaDA4.Name = "txt_MaDA4";
            this.txt_MaDA4.Size = new System.Drawing.Size(91, 26);
            this.txt_MaDA4.TabIndex = 5;
            this.txt_MaDA4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MaDA3
            // 
            this.txt_MaDA3.Enabled = false;
            this.txt_MaDA3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDA3.Location = new System.Drawing.Point(42, 227);
            this.txt_MaDA3.Name = "txt_MaDA3";
            this.txt_MaDA3.Size = new System.Drawing.Size(91, 26);
            this.txt_MaDA3.TabIndex = 4;
            this.txt_MaDA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MaDA2
            // 
            this.txt_MaDA2.Enabled = false;
            this.txt_MaDA2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDA2.Location = new System.Drawing.Point(42, 195);
            this.txt_MaDA2.Name = "txt_MaDA2";
            this.txt_MaDA2.Size = new System.Drawing.Size(91, 26);
            this.txt_MaDA2.TabIndex = 3;
            this.txt_MaDA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MaDA1
            // 
            this.txt_MaDA1.Enabled = false;
            this.txt_MaDA1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDA1.Location = new System.Drawing.Point(43, 163);
            this.txt_MaDA1.Name = "txt_MaDA1";
            this.txt_MaDA1.Size = new System.Drawing.Size(91, 26);
            this.txt_MaDA1.TabIndex = 2;
            this.txt_MaDA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm6_QuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1006, 644);
            this.ControlBox = false;
            this.Controls.Add(this.grp_NoiDung);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.cbo_MonHoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_XemHet);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_TroVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm6_QuanLyCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quản lý câu hỏi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm6_QuanLyCauHoi_FormClosed);
            this.Load += new System.EventHandler(this.frm6_QuanLyCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DapAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grp_NoiDung.ResumeLayout(false);
            this.grp_NoiDung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CauHoi;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NoiDungCH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.DataGridView dgv_DapAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rad_A;
        private System.Windows.Forms.RadioButton rad_B;
        private System.Windows.Forms.RadioButton rad_C;
        private System.Windows.Forms.RadioButton rad_D;
        private System.Windows.Forms.TextBox txt_DA1;
        private System.Windows.Forms.TextBox txt_DA2;
        private System.Windows.Forms.TextBox txt_DA3;
        private System.Windows.Forms.TextBox txt_DA4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_MonHoc;
        public System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Button btn_XemHet;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grp_NoiDung;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbCH;
        private System.Windows.Forms.TextBox txt_MaDA4;
        private System.Windows.Forms.TextBox txt_MaDA3;
        private System.Windows.Forms.TextBox txt_MaDA2;
        private System.Windows.Forms.TextBox txt_MaDA1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDA;
    }
}