using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tier
{
    public partial class frmResultBefore : Form
    {
        public frmResultBefore()
        {
            InitializeComponent();
        }

        int phut, giay;

        private void btnClick_Click(object sender, EventArgs e)
        {
            phut = int.Parse(this.txtPhut.Text);
            giay = int.Parse(this.txtGiay.Text);

            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtPhut.Text = phut.ToString();
            txtGiay.Text = giay.ToString();
            if (phut > 0)
            {
                if (giay > 0)
                {
                    giay--;
                }
                else
                {
                    giay = 59;
                    phut--;
                }
            }
            else
            {
                giay--;
            }

            if (phut == 0 && giay < 0)
            {
                timer1.Stop();
                MessageBox.Show("Đã đếm xong!", "Thông Báo!");

            }
        }
    }
}
