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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void tbmButton_Click(object sender, EventArgs e)
        {
            mainTextbox.Text = "Report for how many types were scheduled in each month:\n\n";
        }

        private void consultantScheduleButton_Click(object sender, EventArgs e)
        {
            mainTextbox.Text = "Report for each consultant's schedule:\n\n";
        }

        private void userScheduleButton_Click(object sender, EventArgs e)
        {
            mainTextbox.Text = "Report for each customer's schedule:\n\n";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm.calendar_month.Visible = true;
            this.Visible = false;
        }

        private void tbmReport()
        {
            string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            foreach (string month in Months)
            {

            }
        }
    }
}
