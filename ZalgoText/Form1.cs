using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZalgoText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZalgify_Click(object sender, EventArgs e)
        {
            Zalgo z = new Zalgo();
            z.zalgo_opt_down = chkDown.Checked;
            z.zalgo_opt_mid = chkMiddle.Checked;
            z.zalgo_opt_up = chkUp.Checked;
            if (rbMax.Checked)
            {
                z.zalgo_opt_max = true;
                z.zalgo_opt_mini = false;
                z.zalgo_opt_normal = false;
            }
            else if (rbMini.Checked)
            {
                z.zalgo_opt_max = false;
                z.zalgo_opt_mini = true;
                z.zalgo_opt_normal = false;
            }
            else if (rbNormal.Checked)
            {
                z.zalgo_opt_max = false;
                z.zalgo_opt_mini = false;
                z.zalgo_opt_normal = true;
            }
            
            txtZalgo.Text = z.ZalgoText(txtText.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtZalgo.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtZalgo.Text = string.Empty;
            txtText.Text = string.Empty;
        }
    }
}
