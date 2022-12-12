using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969_Binkley.Database;

namespace C969_Binkley
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			DBConnection.startConnection();
			Application.Run(new LoginForm());
			DBConnection.closeConnection();
		}
	}
}
