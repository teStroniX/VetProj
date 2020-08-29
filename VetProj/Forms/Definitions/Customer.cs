using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetProj.Forms.Definitions
{
	public partial class Customer : Form
	{
		string ItemName;
		int? ID;
		public Customer()
		{
			InitializeComponent();

			EditMode(true);
		}
		public Customer(int ID)
		{
			InitializeComponent();

			this.ID = ID;

			ta_CUSTOMER.Fill(ds_VetSis.CUSTOMER, ID);

			EditMode(false);
		}

		private void Item_Load(object sender, EventArgs e)
		{
			CultureInfo ci = new CultureInfo("tr-TR");
			ci.NumberFormat.NumberDecimalSeparator = ",";
			Thread.CurrentThread.CurrentCulture = ci;
		}

		private void EditMode(bool edit)
		{
			btn_cancel.Enabled = edit;
			btn_save.Enabled = edit;
			btn_edit.Enabled = !edit;

			txb_name.Enabled = edit;
			txb_surname.Enabled = edit;
			txb_phone.Enabled = edit;
			txb_email.Enabled = edit;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			ItemName = txb_name.Text + " " + txb_surname.Text;

			Text = ItemName;
			label2.Text = ItemName;
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			EditMode(true);
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			SqlCommand cmd;

			if (ID != null)
			{
				cmd = new SqlCommand("UPDATE CUSTOMERS SET NAME = @NAME, SURNAME = @SURNAME, PHONE = @PHONE, EMAIL = @EMAIL WHERE ID = @ID; SELECT @ID ID", Program.con);
				cmd.Parameters.AddWithValue("@ID", ID);
			}
			else
			{
				cmd = new SqlCommand("INSERT INTO CUSTOMERS(NAME,SURNAME,PHONE,EMAIL) OUTPUT inserted.ID VALUES(@NAME,@SURNAME,@PHONE,@EMAIL)", Program.con);
			}

			cmd.Parameters.AddWithValue("@NAME", txb_name.Text);
			cmd.Parameters.AddWithValue("@SURNAME", txb_surname.Text);
			cmd.Parameters.AddWithValue("@PHONE", txb_phone.Text);
			cmd.Parameters.AddWithValue("@EMAIL", txb_email.Text);

			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			adp.Fill(dt);

			ID = Convert.ToInt32(dt.Rows[0][0]);

			ta_CUSTOMER.Fill(ds_VetSis.CUSTOMER, ID ?? 0);

			EditMode(false);
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			EditMode(false);

			if (ID != null)
				ta_CUSTOMER.Fill(ds_VetSis.CUSTOMER, ID ?? 0);
			else
				this.Close();
		}
		
	}
}
