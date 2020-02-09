using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftManager
{
    public partial class Alert : Form
    {
        public Main Pmain;
        public Alert()
        {
            InitializeComponent();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            alstate();
        }

        public void alstate()
        {
            if (alchk.Checked == false)
            {
                label1.ForeColor = SystemColors.ButtonShadow;
                label2.ForeColor = SystemColors.ButtonShadow;
                OverWork.Enabled = false;
            }
            else
            {
                label1.ForeColor = SystemColors.ControlText;
                label2.ForeColor = SystemColors.ControlText;
                OverWork.Enabled = true;
            }
        }

        private void alchk_CheckedChanged(object sender, EventArgs e)
        {
            alstate();
        }
    }
}
