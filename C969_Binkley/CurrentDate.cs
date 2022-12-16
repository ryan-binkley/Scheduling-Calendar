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
        // Make a global static class representing what month it currently is
        public static DateTime currentMonthDateTime = new DateTime(2022, 1, 1);
        public static BindingList<Appointment> appointmentsByMonth = new BindingList<Appointment>();

        // Methods to modify the list should be put under here.

        // Void -> BindingList<Appointment>
        // This function should get all the appointments of the current month and put them in the appointmentsByMonth BindingList
        public static void GetAppointmentsByMonth()
        {
            appointmentsByMonth = new BindingList<Appointment>(AppointmentList.appointments.Where(appointment => appointment.AppointmentMonth == currentMonthDateTime.Month).ToList());
        }

        // DataGridView -> Void
        // This function sets the input DataGridView to the appointmentsByMonth BindingList
        public static void SetAppointmentsByMonth(DataGridView inpDataGrid)
        {
            inpDataGrid.DataSource = appointmentsByMonth;
        }
    }
}
