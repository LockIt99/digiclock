using System;
using System.Text;
using System.Windows.Forms;

namespace digiClock
{
    public partial class digiClock : Form
    {
        public digiClock()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();
        private void digiClock_Load(object sender, EventArgs e)
        {
            rdb12.Select();
            timer.Interval= 1000;
            timer.Tick +=  new EventHandler(timerTick);
            timer.Start();

        }
        private void timerTick(object sender, EventArgs e) 
        {
            if (rdb12.Checked)
            {
                string dateTime = DateTime.Now.ToString("hh:mm:ss tt");
                string[] hhMm = dateTime.Split(':');
                string[] ssAmPm = hhMm[2].Split();

                int hh = Convert.ToInt32(hhMm[0]), mm = Convert.ToInt32(hhMm[1]), ss = Convert.ToInt32(ssAmPm[0]);
                string time = string.Empty;

                time += (hh < 10) ? "0" + hh + ":" : hh + ":";
                time += (mm < 10) ? "0" + mm + ":" : mm + ":";
                time += (ss < 10) ? "0" + ss : ss + "";
                lblclock.Text = time + " " + ssAmPm[1];
            }
            else
            {
                int hh  = DateTime.Now.Hour, mm = DateTime.Now.Minute, ss = DateTime.Now.Second;
                string time = string.Empty;
                time += (hh < 10) ? "0" + hh + ":" : hh + ":";
                time += (mm < 10) ? "0" + mm + ":" : mm + ":";
                time += (ss < 10) ? "0" + ss : ss + "";
                lblclock.Text = time;
            }
        }
    }
}