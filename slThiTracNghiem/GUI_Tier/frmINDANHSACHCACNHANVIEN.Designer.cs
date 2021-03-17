namespace GUI_Tier
{
    partial class frmINDANHSACHCACNHANVIEN
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
            this.crv_DanhSachNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_DanhSachNhanVien
            // 
            this.crv_DanhSachNhanVien.ActiveViewIndex = -1;
            this.crv_DanhSachNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_DanhSachNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_DanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_DanhSachNhanVien.Location = new System.Drawing.Point(0, 0);
            this.crv_DanhSachNhanVien.Name = "crv_DanhSachNhanVien";
            this.crv_DanhSachNhanVien.Size = new System.Drawing.Size(1004, 486);
            this.crv_DanhSachNhanVien.TabIndex = 0;
            // 
            // frmINDANHSACHCACNHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 486);
            this.Controls.Add(this.crv_DanhSachNhanVien);
            this.Name = "frmINDANHSACHCACNHANVIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmINDANHSACHCACNHANVIEN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmINDANHSACHCACNHANVIEN_FormClosed);
            this.Load += new System.EventHandler(this.frmINDANHSACHCACNHANVIEN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_DanhSachNhanVien;

    }
}