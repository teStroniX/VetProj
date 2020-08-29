using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetProj.Forms;

namespace VetProj
{
	public partial class LoginPage : Form
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD",Program.con);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();

			cmd.Parameters.AddWithValue("@USERNAME", txb_username.Text);
			cmd.Parameters.AddWithValue("@PASSWORD", txb_password.Text);

			adp.Fill(dt);

			if(dt.Rows.Count == 1)
			{
				MainPage form = new MainPage(dt.Rows[0]["NAME"] + " " + dt.Rows[0]["SURNAME"]);
				this.Hide();
				form.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!","VetSis Pro v2", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void txb_username_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				txb_password.Focus();
		}

		private void txb_password_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btn_login_Click(new object(), new EventArgs());
		}
	}
}
