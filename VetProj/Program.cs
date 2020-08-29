using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetProj
{
	static class Program
	{
		public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VetProj.Properties.Settings.VetSisConnectionString"].ConnectionString);
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginPage());
		}
	}
}
