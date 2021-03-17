namespace GUI_Tier
{
    partial class frm2_GiaoDienChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2_GiaoDienChinh));
            this.lblTT = new System.Windows.Forms.Label();
            this.chuchayChinh = new System.Windows.Forms.Timer(this.components);
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radThiSinh = new System.Windows.Forms.RadioButton();
            this.radNhanVien = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_DangNhapLai = new System.Windows.Forms.PictureBox();
            this.pic_Thoat = new System.Windows.Forms.PictureBox();
            this.btnThiTN = new System.Windows.Forms.Button();
            this.btnQuanLyTK = new System.Windows.Forms.Button();
            this.btnQuanlyCH = new System.Windows.Forms.Button();
            this.btnXemdiem = new System.Windows.Forms.Button();
            this.pic_StartServer = new System.Windows.Forms.PictureBox();
            this.pic_StopServer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDangXuat = new System.Windows.Forms.Label();
            this.lblDangNhapLai = new System.Windows.Forms.Label();
            this.lblStartServer = new System.Windows.Forms.Label();
            this.lblStopServer = new System.Windows.Forms.Label();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DangNhapLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StartServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StopServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTT
            // 
            this.lblTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTT.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT.ForeColor = System.Drawing.Color.Brown;
            this.lblTT.Location = new System.Drawing.Point(0, 0);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(806, 53);
            this.lblTT.TabIndex = 3;
            this.lblTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chuchayChinh
            // 
            this.chuchayChinh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::GUI_Tier.Properties.Resources.Windows_Close_Program2;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // radThiSinh
            // 
            this.radThiSinh.AutoSize = true;
            this.radThiSinh.ForeColor = System.Drawing.Color.Blue;
            this.radThiSinh.Location = new System.Drawing.Point(113, 22);
            this.radThiSinh.Name = "radThiSinh";
            this.radThiSinh.Size = new System.Drawing.Size(82, 20);
            this.radThiSinh.TabIndex = 14;
            this.radThiSinh.Text = "Thí Sinh";
            this.radThiSinh.UseVisualStyleBackColor = true;
            // 
            // radNhanVien
            // 
            this.radNhanVien.AutoSize = true;
            this.radNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.radNhanVien.Location = new System.Drawing.Point(10, 22);
            this.radNhanVien.Name = "radNhanVien";
            this.radNhanVien.Size = new System.Drawing.Size(97, 20);
            this.radNhanVien.TabIndex = 13;
            this.radNhanVien.Text = "Nhân Viên";
            this.radNhanVien.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radThiSinh);
            this.groupBox1.Controls.Add(this.radNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(296, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 59);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, "BẠN PHẢI CHỌN 1 TRONG 2 LOẠI TÀI KHOẢN ĐỂ QUẢN LÝ");
            // 
            // pic_DangNhapLai
            // 
            this.pic_DangNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("pic_DangNhapLai.Image")));
            this.pic_DangNhapLai.Location = new System.Drawing.Point(428, 396);
            this.pic_DangNhapLai.Name = "pic_DangNhapLai";
            this.pic_DangNhapLai.Size = new System.Drawing.Size(134, 123);
            this.pic_DangNhapLai.TabIndex = 21;
            this.pic_DangNhapLai.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_DangNhapLai, "Nhấn Vào Đây Để Đăng Nhập Lại");
            this.pic_DangNhapLai.Click += new System.EventHandler(this.pic_DangNhapLai_Click);
            // 
            // pic_Thoat
            // 
            this.pic_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("pic_Thoat.Image")));
            this.pic_Thoat.Location = new System.Drawing.Point(604, 396);
            this.pic_Thoat.Name = "pic_Thoat";
            this.pic_Thoat.Size = new System.Drawing.Size(125, 123);
            this.pic_Thoat.TabIndex = 21;
            this.pic_Thoat.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_Thoat, "Nhấn Vào Đây Để Thoát");
            this.pic_Thoat.Click += new System.EventHandler(this.pic_Thoat_Click);
            // 
            // btnThiTN
            // 
            this.btnThiTN.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThiTN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThiTN.ForeColor = System.Drawing.Color.Gold;
            this.btnThiTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThiTN.Location = new System.Drawing.Point(43, 282);
            this.btnThiTN.Margin = new System.Windows.Forms.Padding(4);
            this.btnThiTN.Name = "btnThiTN";
            this.btnThiTN.Size = new System.Drawing.Size(166, 38);
            this.btnThiTN.TabIndex = 23;
            this.btnThiTN.Text = "Thi trắc nghiệm";
            this.toolTip1.SetToolTip(this.btnThiTN, "Nhấn vào đây để thi");
            this.btnThiTN.UseVisualStyleBackColor = false;
            this.btnThiTN.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnQuanLyTK
            // 
            this.btnQuanLyTK.BackColor = System.Drawing.Color.DarkGreen;
            this.btnQuanLyTK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTK.ForeColor = System.Drawing.Color.Gold;
            this.btnQuanLyTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyTK.Location = new System.Drawing.Point(217, 282);
            this.btnQuanLyTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyTK.Name = "btnQuanLyTK";
            this.btnQuanLyTK.Size = new System.Drawing.Size(166, 38);
            this.btnQuanLyTK.TabIndex = 24;
            this.btnQuanLyTK.Text = "Quản lý tài khoản";
            this.toolTip1.SetToolTip(this.btnQuanLyTK, "Nhấn vào đây để quản lý tài khoản");
            this.btnQuanLyTK.UseVisualStyleBackColor = false;
            this.btnQuanLyTK.Click += new System.EventHandler(this.btnQuanLyTK_Click);
            // 
            // btnQuanlyCH
            // 
            this.btnQuanlyCH.BackColor = System.Drawing.Color.DarkGreen;
            this.btnQuanlyCH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanlyCH.ForeColor = System.Drawing.Color.Gold;
            this.btnQuanlyCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanlyCH.Location = new System.Drawing.Point(406, 282);
            this.btnQuanlyCH.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanlyCH.Name = "btnQuanlyCH";
            this.btnQuanlyCH.Size = new System.Drawing.Size(166, 38);
            this.btnQuanlyCH.TabIndex = 25;
            this.btnQuanlyCH.Text = "Quản lý Câu Hỏi";
            this.toolTip1.SetToolTip(this.btnQuanlyCH, "Nhấn vào đây để quản lý câu hỏi");
            this.btnQuanlyCH.UseVisualStyleBackColor = false;
            this.btnQuanlyCH.Click += new System.EventHandler(this.btnQuanlyCH_Click);
            // 
            // btnXemdiem
            // 
            this.btnXemdiem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXemdiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemdiem.ForeColor = System.Drawing.Color.Gold;
            this.btnXemdiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemdiem.Location = new System.Drawing.Point(580, 282);
            this.btnXemdiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemdiem.Name = "btnXemdiem";
            this.btnXemdiem.Size = new System.Drawing.Size(166, 38);
            this.btnXemdiem.TabIndex = 26;
            this.btnXemdiem.Text = "Xem điểm";
            this.toolTip1.SetToolTip(this.btnXemdiem, "Nhấn vào đây để xem điểm");
            this.btnXemdiem.UseVisualStyleBackColor = false;
            this.btnXemdiem.Click += new System.EventHandler(this.btnXemdiem_Click);
            // 
            // pic_StartServer
            // 
            this.pic_StartServer.Image = global::GUI_Tier.Properties.Resources.Junior_Icon_146_2;
            this.pic_StartServer.Location = new System.Drawing.Point(64, 396);
            this.pic_StartServer.Name = "pic_StartServer";
            this.pic_StartServer.Size = new System.Drawing.Size(134, 123);
            this.pic_StartServer.TabIndex = 27;
            this.pic_StartServer.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_StartServer, "Mở server để cho thí sinh đăng nhập vào thi");
            this.pic_StartServer.Click += new System.EventHandler(this.pic_StartServer_Click);
            // 
            // pic_StopServer
            // 
            this.pic_StopServer.Image = global::GUI_Tier.Properties.Resources.Windows_Close_Program;
            this.pic_StopServer.Location = new System.Drawing.Point(241, 396);
            this.pic_StopServer.Name = "pic_StopServer";
            this.pic_StopServer.Size = new System.Drawing.Size(125, 123);
            this.pic_StopServer.TabIndex = 29;
            this.pic_StopServer.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_StopServer, "Nhấn vào đây để tắt Server");
            this.pic_StopServer.Click += new System.EventHandler(this.pic_StopServer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(168, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(474, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.AutoSize = true;
            this.lblDangXuat.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangXuat.Location = new System.Drawing.Point(615, 522);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(99, 25);
            this.lblDangXuat.TabIndex = 22;
            this.lblDangXuat.Text = "Đăng Xuất";
            // 
            // lblDangNhapLai
            // 
            this.lblDangNhapLai.AutoSize = true;
            this.lblDangNhapLai.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhapLai.Location = new System.Drawing.Point(427, 522);
            this.lblDangNhapLai.Name = "lblDangNhapLai";
            this.lblDangNhapLai.Size = new System.Drawing.Size(136, 25);
            this.lblDangNhapLai.TabIndex = 22;
            this.lblDangNhapLai.Text = "Đăng Nhập Lại";
            // 
            // lblStartServer
            // 
            this.lblStartServer.AutoSize = true;
            this.lblStartServer.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartServer.Location = new System.Drawing.Point(82, 522);
            this.lblStartServer.Name = "lblStartServer";
            this.lblStartServer.Size = new System.Drawing.Size(95, 25);
            this.lblStartServer.TabIndex = 28;
            this.lblStartServer.Text = "Mở Server";
            // 
            // lblStopServer
            // 
            this.lblStopServer.AutoSize = true;
            this.lblStopServer.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopServer.Location = new System.Drawing.Point(252, 522);
            this.lblStopServer.Name = "lblStopServer";
            this.lblStopServer.Size = new System.Drawing.Size(98, 25);
            this.lblStopServer.TabIndex = 30;
            this.lblStopServer.Text = "Tắt Server";
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStatus.ForeColor = System.Drawing.Color.Red;
            this.lblServerStatus.Location = new System.Drawing.Point(12, 9);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(42, 36);
            this.lblServerStatus.TabIndex = 31;
            this.lblServerStatus.Text = "...";
            // 
            // frm2_GiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 604);
            this.ControlBox = false;
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.lblStopServer);
            this.Controls.Add(this.pic_StopServer);
            this.Controls.Add(this.lblStartServer);
            this.Controls.Add(this.pic_StartServer);
            this.Controls.Add(this.btnXemdiem);
            this.Controls.Add(this.btnQuanlyCH);
            this.Controls.Add(this.btnQuanLyTK);
            this.Controls.Add(this.btnThiTN);
            this.Controls.Add(this.lblDangNhapLai);
            this.Controls.Add(this.lblDangXuat);
            this.Controls.Add(this.pic_Thoat);
            this.Controls.Add(this.pic_DangNhapLai);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTT);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm2_GiaoDienChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIAO DIỆN CHÍNH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm2_GiaoDienChinh_FormClosed);
            this.Load += new System.EventHandler(this.frm2_GiaoDienChinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DangNhapLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StartServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StopServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Timer chuchayChinh;
        private System.Windows.Forms.RadioButton radThiSinh;
        private System.Windows.Forms.RadioButton radNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_DangNhapLai;
        private System.Windows.Forms.PictureBox pic_Thoat;
        private System.Windows.Forms.Label lblDangXuat;
        private System.Windows.Forms.Label lblDangNhapLai;
        private System.Windows.Forms.Button btnThiTN;
        private System.Windows.Forms.Button btnQuanLyTK;
        private System.Windows.Forms.Button btnQuanlyCH;
        private System.Windows.Forms.Button btnXemdiem;
        private System.Windows.Forms.PictureBox pic_StartServer;
        private System.Windows.Forms.Label lblStartServer;
        private System.Windows.Forms.Label lblStopServer;
        private System.Windows.Forms.PictureBox pic_StopServer;
        private System.Windows.Forms.Label lblServerStatus;
    }
}