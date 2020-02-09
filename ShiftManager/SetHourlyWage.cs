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
    public partial class SetHourlyWage : Form
    {
        public Main Pmain;
        public SetHourlyWage()
        {
            InitializeComponent();
        }

        private void SetHourlyWage_Load(object sender, EventArgs e)
        {
            weekcombo.SelectedIndex = 0;
            AppliedList.Items.AddRange(Pmain.ws.wageitem);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime sTime = new DateTime(2015, 1, 1, (int)sHour.Value, (int)sMin.Value, 0);
                DateTime eTime = new DateTime(2015, 1, 1, (int)eHour.Value, (int)eMin.Value, 0);
                if (sTime > eTime)
                {
                    MessageBox.Show(this, "開始時間が終了時間よりも大きいです", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Pmain.hw[Pmain.n].week = weekcombo.SelectedIndex;
                    Pmain.hw[Pmain.n].sTime = sTime;
                    Pmain.hw[Pmain.n].eTime = eTime;
                    Pmain.hw[Pmain.n].wage = (int)numericUpDown1.Value;
                    Pmain.ws.wageitem[Pmain.n] = Pmain.defweek[Pmain.hw[Pmain.n].week] + ", " + Pmain.hw[Pmain.n].sTime.ToShortTimeString() + ", " + Pmain.hw[Pmain.n].eTime.ToShortTimeString() + ", " + Pmain.hw[Pmain.n].wage.ToString();
                    AppliedList.Items.Add(Pmain.ws.wageitem[Pmain.n]);
                    Pmain.n += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int IDX = AppliedList.SelectedIndex;
            if(IDX != -1)
                AppliedList.Items.RemoveAt(IDX);
            
        }
    }
}
