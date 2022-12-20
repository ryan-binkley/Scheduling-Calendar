using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
