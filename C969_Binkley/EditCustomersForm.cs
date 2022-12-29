using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969_Binkley.Database;
using C969_Binkley.DatabaseObjects;
using C969_Binkley.StaticClasses;
using MySql.Data.MySqlClient;

namespace C969_Binkley
{
    public partial class EditCustomersForm : Form
    {
        public static ECFAddModify ecfForm = new ECFAddModify();
        public EditCustomersForm()
        {
            InitializeComponent();
            CustomerList.listOfCustomers = CustomerList.GetAllCustomers();
            custDGV.AutoGenerateColumns = false;
            custDGV.DataSource = CustomerList.listOfCustomers;
        }

        // This is a simple accessor for the DataGridView
        public DataGridView custDGV
        {
            get { return this.editCustomerDataGridView; }
            set { this.editCustomerDataGridView = value; }
        }

        // Eventhandlers for all the buttons on the EditCustomersForm
        private void addButtonECF_Click(object sender, EventArgs e)
        {
            ECFAddModify.addOrMod = "add";
            this.Visible = false;
            ecfForm.Visible = true;

            AppointmentList.appointments = AppointmentList.GetAllAppointments();
            LoginForm.calendar_month.apptDGV.DataSource = AppointmentList.appointments;
        }

        private void modifyButtonECF_Click(object sender, EventArgs e)
        {
            ECFAddModify.addOrMod = "mod";
            this.Visible = false;
            ecfForm.Visible = true;

            int indexOfCustToBeChanged = CustomerList.listOfCustomers.IndexOf((Customer)Calender.custForm.custDGV.CurrentRow.DataBoundItem);

            ecfForm.customerNameTextboxECF.Text = CustomerList.listOfCustomers[indexOfCustToBeChanged].CustomerName;
            ecfForm.addressTextboxECF.Text = CustomerList.listOfCustomers[indexOfCustToBeChanged].AddressString;
            ecfForm.phoneTextboxECF.Text = CustomerList.listOfCustomers[indexOfCustToBeChanged].Phone;
            ecfForm.cityTextboxECF.Text = CustomerList.listOfCustomers[indexOfCustToBeChanged].CityName;
            ecfForm.countryTextboxECF.Text = CustomerList.listOfCustomers[indexOfCustToBeChanged].CountryName;

            AppointmentList.appointments = AppointmentList.GetAllAppointments();
            LoginForm.calendar_month.apptDGV.DataSource = AppointmentList.appointments;
        }

        private void deleteButtonECF_Click(object sender, EventArgs e)
        {
            Customer custSelected = (Customer)custDGV.CurrentRow.DataBoundItem;

            // Create a local reference to the Sql Connection in the DBConnection class
            MySqlConnection sqlConnection = DBConnection.sqlConnection;

            try
            {
                // If the connection is not open, inform user and return null to get out of the function call
                if (!(sqlConnection.State == ConnectionState.Open))
                {
                    MessageBox.Show("Connection to Database is closed.", "Connection Error");

                    return;
                }

                // Create new instance of MySqlCommand with the SqlCmd and the SqlConnection as parameters
                string cmd = String.Format("BEGIN; " +
                    "DELETE FROM appointment WHERE customerId={0};" +
                    "DELETE FROM customer WHERE addressId={1}; " +
                    "DELETE FROM address WHERE cityId={2};" +
                    "DELETE FROM city WHERE countryId={3};" +
                    "DELETE FROM country WHERE countryId={3};" +
                    "COMMIT;", custSelected.CustomerId.ToString(), custSelected.Address.AddressId.ToString(), custSelected.Address.City.CityId.ToString(), custSelected.Address.City.Country.CountryId.ToString());

                MySqlCommand mySqlCmd = new MySqlCommand(cmd, sqlConnection);

                mySqlCmd.ExecuteNonQuery();
            }

            // If an error occurs, show a messagebox informing the user of the error and return null
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message, "ECFDelete Error");

                return;
            }

            CustomerList.DeleteCustomer(custSelected);

            AppointmentList.appointments = AppointmentList.GetAllAppointments();
            LoginForm.calendar_month.apptDGV.DataSource = AppointmentList.appointments;
        }


        private void backButtonECF_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm.calendar_month.Visible = true;
        }
    }
}
