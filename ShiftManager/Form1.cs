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
    // 給与体系の構造体
    public struct HourlyWage
    {
        public int week, wage;
        public DateTime sTime, eTime;
    }

    // 給与体系のセット
    public struct WageSet
    {
        //public HourlyWage[] hw;
        public string[] wageitem;
    }

    // 稼働表の構造体
    public struct LaborChart
    {
        DateTime sDate, eDate;
    }

    public partial class Main : Form
    {
        public string[] defweek = new string[8];
        public SetHourlyWage shw;
        public Alert al;
        public HourlyWage[] hw = new HourlyWage[999];
        public WageSet ws = new WageSet();
        public LaborChart lc = new LaborChart();
        public int n = 0;
        public void SendNotify(string NOTIFY)
        {
            Notify.Text = NOTIFY;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 999; i++)
            {
                hw[i] = new HourlyWage();
            }
            ws.wageitem = new string[999];
            defweek[0] = "日曜日";
            defweek[1] = "月曜日";
            defweek[2] = "火曜日";
            defweek[3] = "水曜日";
            defweek[4] = "木曜日";
            defweek[5] = "金曜日";
            defweek[6] = "土曜日";
            defweek[7] = "祝日";
            timer1.Start();
            SendNotify("準備完了");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            Time.Text = datetime.ToShortTimeString();
        }

        private void 給与体系の設定RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shw = new SetHourlyWage();
            shw.Pmain = this;
            shw.ShowDialog();
            shw.Dispose();
        }

        private void アラートの設定AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            al = new Alert();
            al.Pmain = this;
            al.ShowDialog();
            al.Dispose();
        }
    }
}
