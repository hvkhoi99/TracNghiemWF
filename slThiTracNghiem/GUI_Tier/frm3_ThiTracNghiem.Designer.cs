namespace GUI_Tier
{
    partial class frm3_ThiTracNghiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3_ThiTracNghiem));
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMonThi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GRP_THI = new System.Windows.Forms.GroupBox();
            this.radD = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radA = new System.Windows.Forms.RadioButton();
            this.lblDapAnD = new System.Windows.Forms.Label();
            this.lblDapAnC = new System.Windows.Forms.Label();
            this.lblDapAnB = new System.Windows.Forms.Label();
            this.lblDapAnA = new System.Windows.Forms.Label();
            this.lbl_noidungcauhoi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSoCauHoi = new System.Windows.Forms.ComboBox();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.dtpic = new System.Windows.Forms.DateTimePicker();
            this.tmThoiGianThi = new System.Windows.Forms.Timer(this.components);
            this.lblMaCauHoi = new System.Windows.Forms.Label();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.CHUCHAY = new System.Windows.Forms.Timer(this.components);
            this.lbldapan = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_BatDauThi = new System.Windows.Forms.PictureBox();
            this.pic_NopBaiThi = new System.Windows.Forms.PictureBox();
            this.pic_TroVe = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_CountDown = new System.Windows.Forms.Label();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.GRP_THI.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BatDauThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NopBaiThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TroVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên :";
            // 
            // lblHoten
            // 
            this.lblHoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(96, 19);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(163, 27);
            this.lblHoten.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Thi :";
            // 
            // cboMonThi
            // 
            this.cboMonThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonThi.FormattingEnabled = true;
            this.cboMonThi.Location = new System.Drawing.Point(443, 17);
            this.cboMonThi.Name = "cboMonThi";
            this.cboMonThi.Size = new System.Drawing.Size(121, 26);
            this.cboMonThi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn Môn Thi :";
            // 
            // GRP_THI
            // 
            this.GRP_THI.BackColor = System.Drawing.Color.Transparent;
            this.GRP_THI.Controls.Add(this.radD);
            this.GRP_THI.Controls.Add(this.lbl_CountDown);
            this.GRP_THI.Controls.Add(this.radC);
            this.GRP_THI.Controls.Add(this.radB);
            this.GRP_THI.Controls.Add(this.radA);
            this.GRP_THI.Controls.Add(this.lblDapAnD);
            this.GRP_THI.Controls.Add(this.label5);
            this.GRP_THI.Controls.Add(this.lblDapAnC);
            this.GRP_THI.Controls.Add(this.lblDapAnB);
            this.GRP_THI.Controls.Add(this.lblDapAnA);
            this.GRP_THI.Controls.Add(this.lbl_noidungcauhoi);
            this.GRP_THI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GRP_THI.Location = new System.Drawing.Point(92, 176);
            this.GRP_THI.Margin = new System.Windows.Forms.Padding(4);
            this.GRP_THI.Name = "GRP_THI";
            this.GRP_THI.Padding = new System.Windows.Forms.Padding(4);
            this.GRP_THI.Size = new System.Drawing.Size(585, 352);
            this.GRP_THI.TabIndex = 3;
            this.GRP_THI.TabStop = false;
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radD.Location = new System.Drawing.Point(22, 311);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(33, 17);
            this.radD.TabIndex = 5;
            this.radD.TabStop = true;
            this.radD.Text = "D";
            this.radD.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radC.Location = new System.Drawing.Point(22, 265);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(32, 17);
            this.radC.TabIndex = 5;
            this.radC.TabStop = true;
            this.radC.Text = "C";
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radB.Location = new System.Drawing.Point(22, 221);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(32, 17);
            this.radB.TabIndex = 5;
            this.radB.TabStop = true;
            this.radB.Text = "B";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radA.Location = new System.Drawing.Point(22, 174);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(32, 17);
            this.radA.TabIndex = 5;
            this.radA.TabStop = true;
            this.radA.Text = "A";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // lblDapAnD
            // 
            this.lblDapAnD.BackColor = System.Drawing.Color.Khaki;
            this.lblDapAnD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDapAnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDapAnD.Location = new System.Drawing.Point(61, 301);
            this.lblDapAnD.Name = "lblDapAnD";
            this.lblDapAnD.Size = new System.Drawing.Size(503, 36);
            this.lblDapAnD.TabIndex = 4;
            this.lblDapAnD.Text = "Đáp Án D";
            this.lblDapAnD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDapAnC
            // 
            this.lblDapAnC.BackColor = System.Drawing.Color.Khaki;
            this.lblDapAnC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDapAnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDapAnC.Location = new System.Drawing.Point(61, 256);
            this.lblDapAnC.Name = "lblDapAnC";
            this.lblDapAnC.Size = new System.Drawing.Size(503, 36);
            this.lblDapAnC.TabIndex = 3;
            this.lblDapAnC.Text = "Đáp Án C";
            this.lblDapAnC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDapAnB
            // 
            this.lblDapAnB.BackColor = System.Drawing.Color.Khaki;
            this.lblDapAnB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDapAnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDapAnB.Location = new System.Drawing.Point(61, 211);
            this.lblDapAnB.Name = "lblDapAnB";
            this.lblDapAnB.Size = new System.Drawing.Size(503, 36);
            this.lblDapAnB.TabIndex = 2;
            this.lblDapAnB.Text = "Đáp Án B";
            this.lblDapAnB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDapAnA
            // 
            this.lblDapAnA.BackColor = System.Drawing.Color.Khaki;
            this.lblDapAnA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDapAnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDapAnA.Location = new System.Drawing.Point(61, 162);
            this.lblDapAnA.Name = "lblDapAnA";
            this.lblDapAnA.Size = new System.Drawing.Size(503, 39);
            this.lblDapAnA.TabIndex = 1;
            this.lblDapAnA.Text = "Đáp Án A";
            this.lblDapAnA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_noidungcauhoi
            // 
            this.lbl_noidungcauhoi.BackColor = System.Drawing.Color.Khaki;
            this.lbl_noidungcauhoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_noidungcauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noidungcauhoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_noidungcauhoi.Location = new System.Drawing.Point(20, 64);
            this.lbl_noidungcauhoi.Name = "lbl_noidungcauhoi";
            this.lbl_noidungcauhoi.Size = new System.Drawing.Size(544, 83);
            this.lbl_noidungcauhoi.TabIndex = 0;
            this.lbl_noidungcauhoi.Text = "Nội Dung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chọn Số Câu Hỏi :";
            // 
            // cboSoCauHoi
            // 
            this.cboSoCauHoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSoCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSoCauHoi.FormattingEnabled = true;
            this.cboSoCauHoi.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.cboSoCauHoi.Location = new System.Drawing.Point(443, 60);
            this.cboSoCauHoi.Name = "cboSoCauHoi";
            this.cboSoCauHoi.Size = new System.Drawing.Size(121, 26);
            this.cboSoCauHoi.TabIndex = 2;
            this.cboSoCauHoi.SelectedIndexChanged += new System.EventHandler(this.cboSoCauHoi_SelectedIndexChanged);
            // 
            // grpThongTin
            // 
            this.grpThongTin.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTin.Controls.Add(this.dtpic);
            this.grpThongTin.Controls.Add(this.cboSoCauHoi);
            this.grpThongTin.Controls.Add(this.cboMonThi);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.lblHoten);
            this.grpThongTin.Controls.Add(this.label4);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Location = new System.Drawing.Point(92, 71);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(585, 98);
            this.grpThongTin.TabIndex = 5;
            this.grpThongTin.TabStop = false;
            // 
            // dtpic
            // 
            this.dtpic.CustomFormat = "dd/mm/yyyy";
            this.dtpic.Enabled = false;
            this.dtpic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpic.Location = new System.Drawing.Point(96, 57);
            this.dtpic.Name = "dtpic";
            this.dtpic.Size = new System.Drawing.Size(163, 24);
            this.dtpic.TabIndex = 3;
            // 
            // tmThoiGianThi
            // 
            this.tmThoiGianThi.Tick += new System.EventHandler(this.tmThoiGianThi_Tick);
            // 
            // lblMaCauHoi
            // 
            this.lblMaCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCauHoi.Location = new System.Drawing.Point(668, 551);
            this.lblMaCauHoi.Name = "lblMaCauHoi";
            this.lblMaCauHoi.Size = new System.Drawing.Size(121, 27);
            this.lblMaCauHoi.TabIndex = 0;
            // 
            // btnDau
            // 
            this.btnDau.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(135, 535);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(101, 43);
            this.btnDau.TabIndex = 7;
            this.btnDau.Text = "|<< Đầu tiên";
            this.toolTip1.SetToolTip(this.btnDau, "Câu Hỏi Đầu Tiên");
            this.btnDau.UseVisualStyleBackColor = false;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTruoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(271, 535);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(85, 43);
            this.btnTruoc.TabIndex = 7;
            this.btnTruoc.Text = "|< Prev";
            this.toolTip1.SetToolTip(this.btnTruoc, "Trở Về Cầu Trước");
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep.Location = new System.Drawing.Point(393, 535);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(85, 43);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Next >|";
            this.toolTip1.SetToolTip(this.btnTiep, "Câu Tiếp Theo");
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCuoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(513, 535);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(110, 43);
            this.btnCuoi.TabIndex = 7;
            this.btnCuoi.Text = "Cuối cùng >>|";
            this.toolTip1.SetToolTip(this.btnCuoi, "Câu Hỏi Cuối Cùng");
            this.btnCuoi.UseVisualStyleBackColor = false;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // CHUCHAY
            // 
            this.CHUCHAY.Enabled = true;
            // 
            // lbldapan
            // 
            this.lbldapan.Location = new System.Drawing.Point(20, 535);
            this.lbldapan.Name = "lbldapan";
            this.lbldapan.Size = new System.Drawing.Size(109, 26);
            this.lbldapan.TabIndex = 8;
            // 
            // pic_BatDauThi
            // 
            this.pic_BatDauThi.Image = ((System.Drawing.Image)(resources.GetObject("pic_BatDauThi.Image")));
            this.pic_BatDauThi.Location = new System.Drawing.Point(715, 193);
            this.pic_BatDauThi.Name = "pic_BatDauThi";
            this.pic_BatDauThi.Size = new System.Drawing.Size(52, 55);
            this.pic_BatDauThi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_BatDauThi.TabIndex = 10;
            this.pic_BatDauThi.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_BatDauThi, "Nhấn Vào Đây Để Bắt Đầu Thi");
            this.pic_BatDauThi.Click += new System.EventHandler(this.pic_BatDauThi_Click);
            // 
            // pic_NopBaiThi
            // 
            this.pic_NopBaiThi.Image = ((System.Drawing.Image)(resources.GetObject("pic_NopBaiThi.Image")));
            this.pic_NopBaiThi.Location = new System.Drawing.Point(715, 312);
            this.pic_NopBaiThi.Name = "pic_NopBaiThi";
            this.pic_NopBaiThi.Size = new System.Drawing.Size(52, 55);
            this.pic_NopBaiThi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_NopBaiThi.TabIndex = 10;
            this.pic_NopBaiThi.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_NopBaiThi, "Nhấn Vào Đây Để Nộp Bài Thi");
            this.pic_NopBaiThi.Click += new System.EventHandler(this.pic_NopBaiThi_Click);
            // 
            // pic_TroVe
            // 
            this.pic_TroVe.Image = ((System.Drawing.Image)(resources.GetObject("pic_TroVe.Image")));
            this.pic_TroVe.Location = new System.Drawing.Point(702, 441);
            this.pic_TroVe.Name = "pic_TroVe";
            this.pic_TroVe.Size = new System.Drawing.Size(87, 87);
            this.pic_TroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_TroVe.TabIndex = 11;
            this.pic_TroVe.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_TroVe, "Trở Về Giao Diện Chính");
            this.pic_TroVe.Click += new System.EventHandler(this.pic_TroVe_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(810, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thời gian";
            // 
            // lbl_CountDown
            // 
            this.lbl_CountDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CountDown.AutoSize = true;
            this.lbl_CountDown.BackColor = System.Drawing.Color.Snow;
            this.lbl_CountDown.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountDown.Location = new System.Drawing.Point(485, 17);
            this.lbl_CountDown.Name = "lbl_CountDown";
            this.lbl_CountDown.Size = new System.Drawing.Size(65, 31);
            this.lbl_CountDown.TabIndex = 13;
            this.lbl_CountDown.Text = "0 : 0";
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStatus.ForeColor = System.Drawing.Color.Red;
            this.lblServerStatus.Location = new System.Drawing.Point(12, 10);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(0, 36);
            this.lblServerStatus.TabIndex = 32;
            // 
            // frm3_ThiTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 608);
            this.ControlBox = false;
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.pic_TroVe);
            this.Controls.Add(this.pic_NopBaiThi);
            this.Controls.Add(this.pic_BatDauThi);
            this.Controls.Add(this.lbldapan);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblMaCauHoi);
            this.Controls.Add(this.GRP_THI);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm3_ThiTracNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THI TRẮC NGHIỆM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm3_ThiTracNghiem_FormClosed);
            this.Load += new System.EventHandler(this.frm3_ThiTracNghiem_Load);
            this.GRP_THI.ResumeLayout(false);
            this.GRP_THI.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BatDauThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NopBaiThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TroVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMonThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GRP_THI;
        private System.Windows.Forms.Label lblDapAnD;
        private System.Windows.Forms.Label lblDapAnC;
        private System.Windows.Forms.Label lblDapAnB;
        private System.Windows.Forms.Label lblDapAnA;
        private System.Windows.Forms.Label lbl_noidungcauhoi;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSoCauHoi;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Timer tmThoiGianThi;
        private System.Windows.Forms.Label lblMaCauHoi;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Timer CHUCHAY;
        private System.Windows.Forms.Label lbldapan;
        private System.Windows.Forms.DateTimePicker dtpic;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pic_BatDauThi;
        private System.Windows.Forms.PictureBox pic_NopBaiThi;
        private System.Windows.Forms.PictureBox pic_TroVe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_CountDown;
        private System.Windows.Forms.Label lblServerStatus;
    }
}