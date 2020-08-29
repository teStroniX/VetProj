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
	public partial class Items : UserControl
	{
		SqlDataAdapter adpAnimals;
		SqlDataAdapter adpCategories;
		SqlDataAdapter adpSubcategories;
		SqlDataAdapter adpQuantity;

		DataTable dtAnimals = new DataTable();
		DataTable dtCategories = new DataTable();
		DataTable dtSubcategories = new DataTable();
		DataTable dtQuantity = new DataTable();
		public Items()
		{
			InitializeComponent();

			this.ta_ITEMS2.Fill(this.ds_VetSis.ITEMS2);
			dgv_stoklar.Columns["ID"].Visible = false;

			adpAnimals = new SqlDataAdapter("SELECT * FROM ANIMALS ORDER BY NAME", Program.con);
			adpCategories = new SqlDataAdapter("SELECT * FROM CATEGORIES WHERE ANIMAL = @ANIMAL ORDER BY NAME", Program.con);
			adpSubcategories = new SqlDataAdapter("SELECT * FROM SUBCATEGORIES WHERE CATEGORIE = @CATEGORIE ORDER BY NAME", Program.con);
			adpQuantity = new SqlDataAdapter("SELECT '' NAME UNION SELECT CAST(A.QUANTITY AS NVARCHAR(32)) + B.NAME AS NAME FROM ITEMS A LEFT JOIN UNITS B ON A.UNIT = B.ID WHERE A.CATEGORIE = @CATEGORIE AND A.SUBCATEGORIE = @SUBCATEGORIE AND A.ANIMAL = @ANIMAL ORDER BY NAME", Program.con);

			adpCategories.SelectCommand.Parameters.AddWithValue("@ANIMAL", cbx_animals.SelectedValue ?? 0);
			adpSubcategories.SelectCommand.Parameters.AddWithValue("@CATEGORIE", cbx_categories.SelectedValue ?? 0);
			adpQuantity.SelectCommand.Parameters.AddWithValue("@CATEGORIE", cbx_categories.SelectedValue ?? 0);
			adpQuantity.SelectCommand.Parameters.AddWithValue("@SUBCATEGORIE", cbx_subcategories.SelectedValue ?? 0);
			adpQuantity.SelectCommand.Parameters.AddWithValue("@ANIMAL", cbx_animals.SelectedValue ?? 0);

			adpAnimals.Fill(dtAnimals);
			adpCategories.Fill(dtCategories);
			adpSubcategories.Fill(dtSubcategories);
			adpQuantity.Fill(dtQuantity);

			cbx_animals.DataSource = dtAnimals;
			cbx_categories.DataSource = dtCategories;
			cbx_subcategories.DataSource = dtSubcategories;
			cbx_quantity.DataSource = dtQuantity;

			cbx_animals.DisplayMember = "NAME";
			cbx_animals.ValueMember = "ID";
			cbx_categories.DisplayMember = "NAME";
			cbx_categories.ValueMember = "ID";
			cbx_subcategories.DisplayMember = "NAME";
			cbx_subcategories.ValueMember = "ID";
			cbx_quantity.DisplayMember = "NAME";
			cbx_quantity.ValueMember = "NAME";
		}

		private void cbx_animals_SelectedIndexChanged(object sender, EventArgs e)
		{
			adpAnimals.SelectCommand.Parameters.Clear();
			adpCategories.SelectCommand.Parameters.Clear();
			adpSubcategories.SelectCommand.Parameters.Clear();
			adpQuantity.SelectCommand.Parameters.Clear();

			adpCategories.SelectCommand.Parameters.AddWithValue("@ANIMAL", cbx_animals.SelectedValue ?? 0);
			adpSubcategories.SelectCommand.Parameters.AddWithValue("@CATEGORIE", cbx_categories.SelectedValue ?? 0);
			adpQuantity.SelectCommand.Parameters.AddWithValue("@CATEGORIE", cbx_categories.SelectedValue ?? 0);
			adpQuantity.SelectCommand.Parameters.AddWithValue("@SUBCATEGORIE", cbx_subcategories.SelectedValue ?? 0);
			adpQuantity.SelectCommand.Parameters.AddWithValue("@ANIMAL", cbx_animals.SelectedValue ?? 0);

			if (sender == cbx_animals)
			{
				dtCategories.Rows.Clear();
				dtSubcategories.Rows.Clear();
				dtQuantity.Rows.Clear();

				adpCategories.Fill(dtCategories);
				adpSubcategories.Fill(dtSubcategories);
				adpQuantity.Fill(dtQuantity);

				List<string> query = new List<string>();

				if (cbx_animals.Text != "")
					query.Add(String.Format("[ANIMAL] = '{0}'", cbx_animals.Text));

				bs_ITEMS2.Filter = "";

				for (int i = 0; i < query.Count; i++)
					bs_ITEMS2.Filter += (i == 0 ? "" : " AND ") + query[i];
			}
			else if (sender == cbx_categories)
			{
				dtSubcategories.Rows.Clear();
				dtQuantity.Rows.Clear();

				adpSubcategories.Fill(dtSubcategories);
				adpQuantity.Fill(dtQuantity);

				List<string> query = new List<string>();

				if (cbx_animals.Text != "")
					query.Add(String.Format("[ANIMAL] = '{0}'", cbx_animals.Text));
				if (cbx_categories.Text != "")
					query.Add(String.Format("[CATEGORIE] = '{0}'", cbx_categories.Text));

				bs_ITEMS2.Filter = "";

				for (int i = 0; i < query.Count; i++)
					bs_ITEMS2.Filter += (i == 0 ? "" : " AND ") + query[i];
			}
			else if (sender == cbx_subcategories)
			{
				dtQuantity.Rows.Clear();

				adpQuantity.Fill(dtQuantity);

				List<string> query = new List<string>();

				if (cbx_animals.Text != "")
					query.Add(String.Format("[ANIMAL] = '{0}'", cbx_animals.Text));
				if (cbx_categories.Text != "")
					query.Add(String.Format("[CATEGORIE] = '{0}'", cbx_categories.Text));
				if (cbx_subcategories.Text != "")
					query.Add(String.Format("[SUBCATEGORIE] = '{0}'", cbx_subcategories.Text));

				bs_ITEMS2.Filter = "";

				for (int i = 0; i < query.Count; i++)
					bs_ITEMS2.Filter += (i == 0 ? "" : " AND ") + query[i];

			}
			else if (sender == cbx_quantity)
			{
				List<string> query = new List<string>();

				if (cbx_animals.Text != "")
					query.Add(String.Format("[ANIMAL] = '{0}'", cbx_animals.Text));
				if (cbx_categories.Text != "")
					query.Add(String.Format("[CATEGORIE] = '{0}'", cbx_categories.Text));
				if (cbx_subcategories.Text != "")
					query.Add(String.Format("[SUBCATEGORIE] = '{0}'", cbx_subcategories.Text));
				if (cbx_quantity.Text != "")
					query.Add(String.Format("[QUANTITY] = '{0}'", cbx_quantity.Text));

				bs_ITEMS2.Filter = "";

				for (int i = 0; i < query.Count; i++)
					bs_ITEMS2.Filter += (i == 0 ? "" : " AND ") + query[i];
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Item form = new Item();
			form.ShowDialog();

			ta_ITEMS2.Fill(ds_VetSis.ITEMS2);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Item form = new Item(Convert.ToInt32(dgv_stoklar.SelectedRows[0].Cells["ID"].Value));
			form.ShowDialog();

			ta_ITEMS2.Fill(ds_VetSis.ITEMS2);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int ID = Convert.ToInt32(dgv_stoklar.SelectedRows[0].Cells["ID"].Value);
			string NAME = dgv_stoklar.SelectedRows[0].Cells["NAME"].Value + "";

			if (MessageBox.Show(NAME + " Adlı Stoğu Silmek İstediğinize Emin Misiniz?", "VetSis Versiyon 1.1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					SqlCommand cmd = new SqlCommand("DELETE FROM ITEMS WHERE ID =  @ID", Program.con);

					cmd.Parameters.AddWithValue("@ID", ID);

					if (Program.con.State != ConnectionState.Open)
						Program.con.Open();

					cmd.ExecuteNonQuery();

					ta_ITEMS2.Fill(ds_VetSis.ITEMS2);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "VetSis V.1.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
		}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			cbx_animals.SelectedIndex = 0;

			bs_ITEMS2.Filter = "[NAME] LIKE '%' + '" + txb_search.Text + "' + '%'";
		}

		public void RefreshAll()
		{
			this.ta_ITEMS2.Fill(this.ds_VetSis.ITEMS2);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ItemTransaction form = new ItemTransaction("+", Convert.ToInt32(dgv_stoklar.SelectedRows[0].Cells["ID"].Value));
			form.ShowDialog();
			
			this.ta_ITEMS2.Fill(this.ds_VetSis.ITEMS2);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			ItemTransaction form = new ItemTransaction("-", Convert.ToInt32(dgv_stoklar.SelectedRows[0].Cells["ID"].Value));
			form.ShowDialog();

			this.ta_ITEMS2.Fill(this.ds_VetSis.ITEMS2);
		}

		private void dgv_stoklar_SelectionChanged(object sender, EventArgs e)
		{
			if (dgv_stoklar.SelectedRows.Count > 0)
				ta_TRAITEM.Fill(ds_VetSis.TRAITEM, Convert.ToInt32(dgv_stoklar.SelectedRows[0].Cells["ID"].Value));
		}
	}
}
