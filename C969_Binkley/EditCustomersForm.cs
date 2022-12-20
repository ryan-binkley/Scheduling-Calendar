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
            if (!ValidateInput())
            {
                return;
            }


        }

        private void modifyButtonECF_Click(object sender, EventArgs e)
        {

        }

        private void deleteButtonECF_Click(object sender, EventArgs e)
        {

        }

        private void saveButtonECF_Click(object sender, EventArgs e)
        {

        }

        private void cancelButtonECF_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
            this.Visible = false;
            LoginForm.calendar_month.Visible = true;
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
