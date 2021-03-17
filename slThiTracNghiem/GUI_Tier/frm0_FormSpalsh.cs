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
    public partial class frm0_FormSpalsh : Form
    {
        public frm0_FormSpalsh()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblFlash.Visible = false;
            if (progressBar1.Value < progressBar1.Maximum)
            {
                lblFlash.Visible = true;
                progressBar1.Value += 10;
                lblFlash.Text = progressBar1.Value + " %";
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                timer2.Enabled = true;
            }
        }

        private void frm0_FormSpalsh_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = Application.StartupPath + "\\TEST.swf";
        }

    }
}
