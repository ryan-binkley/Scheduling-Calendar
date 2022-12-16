using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Binkley
{
    public static class CurrentDate
    {
        // Make global static variables representing what month it currently is
        public static DateTime currentMonthDateTime = new DateTime(2022, 1, 1);
        public static BindingList<Appointment> appointmentsByMonth = new BindingList<Appointment>();

        // Make global static variables representing what week it currently is
        public static DateTime currentWeekStartDateTime = new DateTime(2022, 1, 1);
        public static DateTime currentWeekEndDateTime = new DateTime(2022, 1, 7);
        public static BindingList<Appointment> appointmentsByWeek = new BindingList<Appointment>();

        // Methods to modify the list should be put under here.

        // Void -> BindingList<Appointment>
        // This function should get all the appointments of the current month and put them in the appointmentsByMonth BindingList
        public static void GetAppointmentsByMonth()
        {
            // This lambda expression ...
            appointmentsByMonth = new BindingList<Appointment>(AppointmentList.appointments.Where(appointment => appointment.AppointmentMonth == currentMonthDateTime.Month).ToList());
        }

        // DataGridView -> Void
        // This function sets the input DataGridView to the appointmentsByMonth BindingList
        public static void SetAppointmentsByMonth(DataGridView inpDataGrid)
        {
            inpDataGrid.DataSource = appointmentsByMonth;
        }

        // Void -> BindingList<Appointment>
        // This function should get all the appointments of the current week and put them in the appointmentsByWeek BindingList
        public static void GetAppointmentsByWeek()
        {
            // This lambda expression ...
            appointmentsByWeek = new BindingList<Appointment>(AppointmentList.appointments.Where(appointment => (appointment.Start >= currentWeekStartDateTime) && (appointment.Start <= currentWeekEndDateTime)).ToList());
        }

        // DataGridView -> Void
        // This function sets the input DataGridView to the appointmentsByWeek BindingList
        public static void SetAppointmentsByWeek(DataGridView inpDataGrid)
        {
            inpDataGrid.DataSource = appointmentsByWeek;
        }
    }
}
