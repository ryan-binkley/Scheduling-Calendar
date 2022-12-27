using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969_Binkley.DatabaseObjects;
using C969_Binkley.StaticClasses;
using C969_Binkley.Database;
using MySql.Data.MySqlClient;

namespace C969_Binkley
{
    public partial class ECFAddModify : Form
    {
        public static string addOrMod = "";
        public ECFAddModify()
        {
            InitializeComponent();
        }



        private void saveButtonECF_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            // Create a local reference to the Sql Connection in the DBConnection class
            MySqlConnection sqlConnection = DBConnection.sqlConnection;

            if (addOrMod == "add")
            {
                Customer saveCust = new Customer();

                saveCust.Address = new Address();
                saveCust.Address.City = new City();
                saveCust.Address.City.Country = new Country();

                saveCust.CustomerId = Customer.uniqueID;
                saveCust.CustomerName = this.customerNameTextboxECF.Text;
                saveCust.AddressString = this.addressTextboxECF.Text;
                saveCust.Phone = this.phoneTextboxECF.Text;
                saveCust.CityName = this.cityTextboxECF.Text;
                saveCust.CountryName = this.countryTextboxECF.Text;

                CustomerList.AddCustomer(saveCust);

                try
                {
                    // If the connection is not open, inform user and return null to get out of the function call
                    if (!(sqlConnection.State == ConnectionState.Open))
                    {
                        MessageBox.Show("Connection to Database is closed.", "Connection Error");

                        return;
                    }

                    // Create new instance of MySqlCommand with the SqlCmd and the SqlConnection as parameters
                    string cmd = String.Format("BEGIN; INSERT INTO customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (\"{0}\", \"{1}\", 1, 1, NOW(), \"test\", NOW(), \"test\"); COMMIT;", saveCust.CustomerId.ToString(), saveCust.CustomerName);
                    
                    MySqlCommand mySqlCmd = new MySqlCommand(cmd, sqlConnection);

                    mySqlCmd.ExecuteNonQuery();
                }

                // If an error occurs, show a messagebox informing the user of the error and return null
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.Message, "ECFAddModify Error");

                    return;
                }
            }

            if (addOrMod == "mod")
            {
                int indexOfCustToBeChanged = CustomerList.listOfCustomers.IndexOf((Customer)Calender.custForm.custDGV.CurrentRow.DataBoundItem);

                CustomerList.listOfCustomers[indexOfCustToBeChanged].CustomerName = this.customerNameTextboxECF.Text;
                CustomerList.listOfCustomers[indexOfCustToBeChanged].AddressString = this.addressTextboxECF.Text;
                CustomerList.listOfCustomers[indexOfCustToBeChanged].Phone = this.phoneTextboxECF.Text;
                CustomerList.listOfCustomers[indexOfCustToBeChanged].CityName = this.cityTextboxECF.Text;
                CustomerList.listOfCustomers[indexOfCustToBeChanged].CountryName = this.countryTextboxECF.Text;
            }

            ClearTextboxes();
            this.Visible = false;
            Calender.custForm.Visible = true;
        }

        private void cancelButtonECF_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
            this.Visible = false;
            Calender.custForm.Visible = true;
        }


        // Void -> Void
        // This method clears the forms textboxes
        public void ClearTextboxes()
        {
            foreach (Control txtBox in this.Controls)
            {
                if (txtBox is TextBox)
                {
                    txtBox.Text = "";
                }
            }
        }

        // void -> Boolean
        // This function ensures that no textboxes are left empty
        public bool ValidateInput()
        {
            foreach (Control txtBox in this.Controls)
            {
                if ((txtBox is TextBox) && (txtBox.Text == ""))
                {
                    MessageBox.Show("There cannot be any empt inputs!", "Customer Edit Error", MessageBoxButtons.OK);
                    return false;
                }
            }

            return true;
        }


    }
}
