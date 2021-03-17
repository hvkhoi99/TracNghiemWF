namespace GUI_Tier
{
    partial class frm7_DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm7_DoiMatKhau));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lbl_Title_DoiMatKhau = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_ChapNhan = new System.Windows.Forms.PictureBox();
            this.pic_TroVe = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ChapNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TroVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Đăng Nhập :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật Khẩu Cũ :";
            // 
            // txtTenDN
            // 
            this.txtTenDN.BackColor = System.Drawing.Color.Gold;
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(189, 18);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.ReadOnly = true;
            this.txtTenDN.Size = new System.Drawing.Size(224, 26);
            this.txtTenDN.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.Gold;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(189, 58);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(224, 26);
            this.txtMatKhau.TabIndex = 1;
            // 
            // lbl_Title_DoiMatKhau
            // 
            this.lbl_Title_DoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title_DoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title_DoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_DoiMatKhau.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Title_DoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title_DoiMatKhau.Name = "lbl_Title_DoiMatKhau";
            this.lbl_Title_DoiMatKhau.Size = new System.Drawing.Size(801, 43);
            this.lbl_Title_DoiMatKhau.TabIndex = 3;
            this.lbl_Title_DoiMatKhau.Text = "Đổi mật khẩu thí sinh";
            this.lbl_Title_DoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(16, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mật Khẩu Mới :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.Gold;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(189, 95);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(224, 26);
            this.txtMatKhauMoi.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtMatKhauMoi);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTenDN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(87, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pic_ChapNhan
            // 
            this.pic_ChapNhan.Image = ((System.Drawing.Image)(resources.GetObject("pic_ChapNhan.Image")));
            this.pic_ChapNhan.Location = new System.Drawing.Point(625, 66);
            this.pic_ChapNhan.Name = "pic_ChapNhan";
            this.pic_ChapNhan.Size = new System.Drawing.Size(57, 62);
            this.pic_ChapNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ChapNhan.TabIndex = 6;
            this.pic_ChapNhan.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_ChapNhan, "Nhấn Vào Đây Để Chấp Nhân");
            this.pic_ChapNhan.Click += new System.EventHandler(this.pic_ChapNhan_Click);
            // 
            // pic_TroVe
            // 
            this.pic_TroVe.Image = ((System.Drawing.Image)(resources.GetObject("pic_TroVe.Image")));
            this.pic_TroVe.Location = new System.Drawing.Point(625, 149);
            this.pic_TroVe.Name = "pic_TroVe";
            this.pic_TroVe.Size = new System.Drawing.Size(57, 56);
            this.pic_TroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_TroVe.TabIndex = 6;
            this.pic_TroVe.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_TroVe, "Nhấn Vào Đây Để Đăng Nhập Lại");
            this.pic_TroVe.Click += new System.EventHandler(this.pic_TroVe_Click);
            // 
            // frm7_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 249);
            this.ControlBox = false;
            this.Controls.Add(this.pic_TroVe);
            this.Controls.Add(this.pic_ChapNhan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Title_DoiMatKhau);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm7_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm7_DoiMatKhau_FormClosed);
            this.Load += new System.EventHandler(this.frm7_DoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ChapNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TroVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lbl_Title_DoiMatKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_ChapNhan;
        private System.Windows.Forms.PictureBox pic_TroVe;
    }
}