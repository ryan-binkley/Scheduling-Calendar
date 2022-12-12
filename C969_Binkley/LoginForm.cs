using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using C969_Binkley.Database;

namespace C969_Binkley
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

        private void submitCredentialsButton_Click(object sender, EventArgs e)
        {
			MySqlConnection sqlConnection = DBConnection.sqlConnection;

			if (sqlConnection.State == ConnectionState.Open)
            {
				MessageBox.Show("It is open");
            }
        }
    }
}
