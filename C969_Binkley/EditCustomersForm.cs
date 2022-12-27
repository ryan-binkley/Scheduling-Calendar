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
        }

        private void deleteButtonECF_Click(object sender, EventArgs e)
        {
            Customer custSelected = (Customer)custDGV.CurrentRow.DataBoundItem;
            CustomerList.DeleteCustomer(custSelected);
        }


        private void backButtonECF_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm.calendar_month.Visible = true;
        }
    }
}
