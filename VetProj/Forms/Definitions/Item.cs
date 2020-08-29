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
	public partial class Item : Form
	{
		string ItemName;
		int? ID;
		public Item()
		{
			InitializeComponent();

			ta_ANIMALS.Fill(ds_VetSis.ANIMALS);
			ta_CATEGORIES.Fill(ds_VetSis.CATEGORIES1, Convert.ToInt32(cbx_animal.SelectedValue));
			ta_SUBCATEGORIES.Fill(ds_VetSis.SUBCATEGORIES1, Convert.ToInt32(cbx_categorie.SelectedValue));
			ta_UNITS.Fill(ds_VetSis.UNITS);

			txb_quantity.Text = "0";

			EditMode(true);
		}
		public Item(int ID)
		{
			InitializeComponent();

			this.ID = ID;

			ta_ANIMALS.Fill(ds_VetSis.ANIMALS);
			ta_CATEGORIES.Fill(ds_VetSis.CATEGORIES1,Convert.ToInt32(cbx_animal.SelectedValue));
			ta_SUBCATEGORIES.Fill(ds_VetSis.SUBCATEGORIES1,Convert.ToInt32(cbx_categorie.SelectedValue));
			ta_UNITS.Fill(ds_VetSis.UNITS);

			ta_ITEM.Fill(ds_VetSis.ITEM, ID);

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
			cbx_animal.Enabled = edit;
			cbx_categorie.Enabled = edit;
			cbx_subcategorie.Enabled = edit;
			cbx_unit.Enabled = edit;

			btn_cancel.Enabled = edit;
			btn_save.Enabled = edit;
			btn_edit.Enabled = !edit;

			txb_name.Enabled = edit;
			txb_quantity.Enabled = edit;
			txb_price.Enabled = edit;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			ItemName = txb_name.Text;

			Text = ItemName;
			label2.Text = ItemName;
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			EditMode(true);

			ds_VetSis.ITEM.Rows[0].SetModified();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			SqlCommand cmd;

			if (ID != null)
			{
				cmd = new SqlCommand("UPDATE ITEMS SET NAME = @NAME, QUANTITY = @QUANTITY, ANIMAL = @ANIMAL, CATEGORIE = @CATEGORIE, SUBCATEGORIE = @SUBCATEGORIE, UNIT = @UNIT, PRICE = @PRICE WHERE ID = @ID; SELECT @ID ID", Program.con);
				cmd.Parameters.AddWithValue("@ID", ID);
			}
			else
			{
				cmd = new SqlCommand("INSERT INTO ITEMS(NAME,QUANTITY,ANIMAL,CATEGORIE,SUBCATEGORIE,UNIT,PRICE) OUTPUT inserted.ID VALUES(@NAME,@QUANTITY,@ANIMAL,@CATEGORIE,@SUBCATEGORIE,@UNIT,@PRICE)", Program.con);
			}

			cmd.Parameters.AddWithValue("@NAME", txb_name.Text);
			cmd.Parameters.AddWithValue("@QUANTITY", Convert.ToDouble(txb_quantity.Text));
			cmd.Parameters.AddWithValue("@ANIMAL", cbx_animal.SelectedValue ?? 0);
			cmd.Parameters.AddWithValue("@CATEGORIE", cbx_categorie.SelectedValue ?? 0);
			cmd.Parameters.AddWithValue("@SUBCATEGORIE", cbx_subcategorie.SelectedValue ?? 0);
			cmd.Parameters.AddWithValue("@UNIT", cbx_unit.SelectedValue ?? 0);
			cmd.Parameters.AddWithValue("@PRICE", Convert.ToDouble(txb_price.Text));

			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			adp.Fill(dt);

			ID = Convert.ToInt32(dt.Rows[0][0]);

			ta_ITEM.Fill(ds_VetSis.ITEM, ID ?? 0);

			EditMode(false);
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			EditMode(false);

			if (ID != null)
				ta_ITEM.Fill(ds_VetSis.ITEM, ID ?? 0);
			else
				this.Close();
		}

		private void cbx_animal_SelectedIndexChanged(object sender, EventArgs e)
		{
			ta_CATEGORIES.Fill(ds_VetSis.CATEGORIES1, Convert.ToInt32(cbx_animal.SelectedValue));
			ta_SUBCATEGORIES.Fill(ds_VetSis.SUBCATEGORIES1, Convert.ToInt32(cbx_categorie.SelectedValue));
		}

		private void cbx_categorie_SelectedIndexChanged(object sender, EventArgs e)
		{
			ta_SUBCATEGORIES.Fill(ds_VetSis.SUBCATEGORIES1, Convert.ToInt32(cbx_categorie.SelectedValue));
		}

		private void txb_quantity_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (char.IsLetter(ch) && ch != ',')
			{
				e.Handled = true;
			}
		}
	}
}
