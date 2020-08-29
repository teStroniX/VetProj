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

namespace VetProj.Forms.Transactions
{
	public partial class ItemTransaction : Form
	{
		string type = "";
		int ID;
		public ItemTransaction(string type, int ID)
		{
			InitializeComponent();

			this.type = type;
			this.ID = ID;

			if (type == "+")
				Text = "Stok Ekle";
			else if (type == "-")
				Text = "Stok Çıkar";

			SqlDataAdapter adp = new SqlDataAdapter("SELECT SUM(CASE WHEN INOUT = 1 THEN QUANTITY ELSE -1 * QUANTITY END) AS QUANTITY, (SELECT NAME FROM ITEMS WHERE ID = @ID) AS NAME FROM TRA_ITEMS WHERE ITEMID = @ID",Program.con);
			DataTable dt = new DataTable();

			adp.SelectCommand.Parameters.AddWithValue("@ID", ID);

			adp.Fill(dt);

			if (dt.Rows.Count == 1)
			{
				txb_prequantity.Text = Convert.ToDouble(dt.Rows[0]["QUANTITY"]).ToString("0.00");
				txb_endquantity.Text = Convert.ToDouble(dt.Rows[0]["QUANTITY"]).ToString("0.00");
				label2.Text = dt.Rows[0]["NAME"].ToString();
			}
			else
				Close();
		}
		private void txb_quantity_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (char.IsLetter(ch) && ch != ',')
			{
				e.Handled = true;
			}
		}

		private void txb_quantity_TextChanged(object sender, EventArgs e)
		{
			double val;
			double val2;
			Double.TryParse(txb_quantity.Text, out val);
			Double.TryParse(txb_prequantity.Text, out val2);

			if (type == "+")
				txb_endquantity.Text = (val + val2).ToString("0.00");
			else if(type == "-")
				txb_endquantity.Text = (val2 - val).ToString("0.00");
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			try
			{
				double val;
				Double.TryParse(txb_quantity.Text, out val);

				SqlCommand cmd = new SqlCommand(@"DECLARE @ID TABLE(ID INT); 
												INSERT INTO TRANSACTIONS([TRANSACTION]) OUTPUT INSERTED.ID INTO @ID VALUES('ITEM')
												INSERT INTO TRA_ITEMS(ITEMID, QUANTITY, PRICE, TOTAL, INOUT, TRANO) SELECT @ITEMID,@QUANTITY,0,0,@INOUT,ID FROM @ID", Program.con);

				cmd.Parameters.AddWithValue("@ITEMID", ID);
				cmd.Parameters.AddWithValue("@QUANTITY", val);
				cmd.Parameters.AddWithValue("@INOUT", type == "+" ? 1 : 0);

				if (Program.con.State != ConnectionState.Open)
					Program.con.Open();

				cmd.ExecuteNonQuery();
				this.Close();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"VetSis V.1.1",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}
