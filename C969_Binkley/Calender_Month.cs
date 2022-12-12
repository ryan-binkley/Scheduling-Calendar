using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Binkley
{
    public partial class Calender_Month : Form
    {
        public Calender_Month()
        {
            InitializeComponent();
			StartTimer();

		}



		// Void -> Void
		// This function sets up a timer and adds a one second update interval and the tmr_Tick event handler to it
		private void StartTimer()
		{
			Timer tmr = null;

			tmr = new Timer();
			tmr.Interval = 1000;
			tmr.Tick += new EventHandler(tmr_Tick);
			tmr.Enabled = true;
		}

		// Event Handler
		// Event handler to handle the timer
		void tmr_Tick(object sender, EventArgs e)
		{
			currentTimeTimer.Text = DateTime.Now.ToString();
			UTCTimeTimer.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("UTC")).ToString();
		}
	}
}
