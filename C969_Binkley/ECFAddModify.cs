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

                saveCust.CustomerId = saveCust.uniqueID;
                saveCust.CustomerName = this.customerNameTextboxECF.Text;
                saveCust.Address.AddressId = saveCust.Address.uniqueID;
                saveCust.AddressString = this.addressTextboxECF.Text;
                saveCust.Phone = this.phoneTextboxECF.Text;
                saveCust.Address.City.CityId = saveCust.Address.City.uniqueID;
                saveCust.CityName = this.cityTextboxECF.Text;
                saveCust.Address.City.Country.CountryId = saveCust.Address.City.Country.uniqueID;
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
                    string cmd = "";

                    MySqlCommand mySqlCmd = new MySqlCommand(cmd, sqlConnection);

                    cmd = String.Format("INSERT INTO country(countryId, country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES({0}, \"{1}\", NOW(), \"test\", NOW(), \"test\");", saveCust.Address.City.Country.CountryId.ToString(), saveCust.CountryName);

                    mySqlCmd = new MySqlCommand(cmd, sqlConnection);

                    mySqlCmd.ExecuteNonQuery();

                    cmd = String.Format("INSERT INTO city (cityId, city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ({0}, \"{1}\", {2}, NOW(), \"test\", NOW(), \"test\");", saveCust.Address.City.CityId.ToString(), saveCust.CityName, saveCust.Address.City.Country.CountryId.ToString());

                    mySqlCmd = new MySqlCommand(cmd, sqlConnection);

                    mySqlCmd.ExecuteNonQuery();

                    cmd = String.Format("INSERT INTO address (addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ({0}, \"{1}\", \"\", {2}, \"\", \"{3}\",  NOW(), \"test\", NOW(), \"test\");", saveCust.Address.AddressId.ToString(), saveCust.AddressString, saveCust.Address.City.CityId.ToString(), saveCust.Address.Phone);

                    mySqlCmd = new MySqlCommand(cmd, sqlConnection);

                    mySqlCmd.ExecuteNonQuery();

                    cmd = String.Format("INSERT INTO customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (\"{0}\", \"{1}\", {2}, 1, NOW(), \"test\", NOW(), \"test\");", saveCust.CustomerId.ToString(), saveCust.CustomerName, saveCust.Address.AddressId.ToString());

                    mySqlCmd = new MySqlCommand(cmd, sqlConnection);

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
                        "UPDATE customer SET  customerName = \'{0}\' WHERE customerId={1}; " +
                        "UPDATE address SET address = \'{2}\' WHERE addressId={3};" +
                        "UPDATE address SET phone = \'{4}\' WHERE addressId={3};" +
                        "UPDATE city SET city = \'{5}\' WHERE cityId={6};" +
                        "UPDATE country SET country = \'{7}\' WHERE countryId={8};" +
                        "COMMIT;", this.customerNameTextboxECF.Text, CustomerList.listOfCustomers[indexOfCustToBeChanged].CustomerId.ToString(), this.addressTextboxECF.Text, CustomerList.listOfCustomers[indexOfCustToBeChanged].Address.AddressId.ToString(), this.phoneTextboxECF.Text, this.cityTextboxECF.Text, CustomerList.listOfCustomers[indexOfCustToBeChanged].Address.City.CityId.ToString(), this.countryTextboxECF.Text, CustomerList.listOfCustomers[indexOfCustToBeChanged].Address.City.Country.CountryId.ToString());

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
