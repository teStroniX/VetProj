using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VetProj.Forms.Definitions;
using VetProj.Forms.Transactions;

namespace VetProj.UserControls
{
	public partial class Customers : UserControl
	{
		public Customers()
		{
			InitializeComponent();

			ta_CUSTOMERS.Fill(ds_VetSis.CUSTOMERS);
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			Customer form = new Customer();
			form.ShowDialog();

			ta_CUSTOMERS.Fill(ds_VetSis.CUSTOMERS);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Customer form = new Customer(Convert.ToInt32(dgv_stoklar.SelectedRows[0].Cells["ID"].Value));
			form.ShowDialog();

			ta_CUSTOMERS.Fill(ds_VetSis.CUSTOMERS);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int ID = Convert.ToInt32(dgv_stoklar.SelectedRows[0].Cells["ID"].Value);
			string NAME = dgv_stoklar.SelectedRows[0].Cells["NAME"].Value + "";

			if (MessageBox.Show(NAME + " Adlı Müşteriyi Silmek İstediğinize Emin Misiniz?", "VetSis Versiyon 1.1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					SqlCommand cmd = new SqlCommand("DELETE FROM CUSTOMERS WHERE ID =  @ID", Program.con);

					cmd.Parameters.AddWithValue("@ID", ID);

					if (Program.con.State != ConnectionState.Open)
						Program.con.Open();

					cmd.ExecuteNonQuery();

					ta_CUSTOMERS.Fill(ds_VetSis.CUSTOMERS);
				}catch(Exception ex)
				{
					MessageBox.Show(ex.Message, "VetSis V.1.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void txb_search_TextChanged(object sender, EventArgs e)
		{
			bs_CUSTOMERS.Filter = "[NAME] LIKE '%' + '" + txb_search.Text + "' + '%'";
		}

		public void RefreshAll()
		{
			ta_CUSTOMERS.Fill(ds_VetSis.CUSTOMERS);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			CustomerTransaction form = new CustomerTransaction("+", Convert.ToInt32(dgv_stoklar.SelectedRows[0].Cells["ID"].Value));
			form.ShowDialog();

			this.ta_CUSTOMERS.Fill(this.ds_VetSis.CUSTOMERS);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			CustomerTransaction form = new CustomerTransaction("-", Convert.ToInt32(dgv_stoklar.SelectedRows[0].Cells["ID"].Value));
			form.ShowDialog();

			this.ta_CUSTOMERS.Fill(this.ds_VetSis.CUSTOMERS);
		}

		private void dgv_stoklar_SelectionChanged(object sender, EventArgs e)
		{
			if(dgv_stoklar.SelectedRows.Count > 0)
			{
				ta_TRACUSTOMER.Fill(ds_VetSis1.TRACUSTOMER, Convert.ToInt32(dgv_stoklar.SelectedRows[0].Cells["ID"].Value));
			}
		}
	}
}
