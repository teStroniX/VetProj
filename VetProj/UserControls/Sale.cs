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
using VetProj.Forms;

namespace VetProj.UserControls
{
	public partial class Sale : UserControl
	{
		DataTable dt = new DataTable();
		int? ID;
		public Sale()
		{
			InitializeComponent();
			LoadForm();
			EditMode(false);
			btn_delete.Enabled = false;
			btn_edit.Enabled = false;
		}
		public Sale(int ID)
		{
			InitializeComponent();

			this.ID = ID;

			LoadForm();
			EditMode(false);
			InitializeSale(ID);
		}
		private void EditMode(bool edit)
		{
			dgv_movements.Enabled = edit;
			tableLayoutPanel3.Enabled = edit;

			btn_cancel.Enabled = edit;
			btn_delete.Enabled = !edit;
			btn_edit.Enabled = !edit;
			btn_new.Enabled = !edit;
			btn_save.Enabled = edit;

			dgv_movements.AllowUserToAddRows = edit;
		}
		private void LoadForm()
		{
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("ITEMID", typeof(int));
			dt.Columns.Add("CUSTID", typeof(int));
			dt.Columns.Add("NAME", typeof(string));
			dt.Columns.Add("PRICE", typeof(float));
			dt.Columns.Add("QUANTITY", typeof(float));
			dt.Columns.Add("TOTAL", typeof(float));

			dgv_movements.DataSource = dt;

			dgv_movements.Columns["NAME"].HeaderText = "Stok Adı";
			dgv_movements.Columns["PRICE"].HeaderText = "Fiyat";
			dgv_movements.Columns["QUANTITY"].HeaderText = "Miktar";
			dgv_movements.Columns["TOTAL"].HeaderText = "Toplam Tutar";

			dgv_movements.Columns["NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgv_movements.Columns["PRICE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_movements.Columns["QUANTITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_movements.Columns["TOTAL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

			dgv_movements.Columns["ID"].Visible = false;
			dgv_movements.Columns["ITEMID"].Visible = false;
			dgv_movements.Columns["CUSTID"].Visible = false;
			dgv_movements.Columns["PRICE"].DefaultCellStyle.Format = "C2";
			dgv_movements.Columns["QUANTITY"].DefaultCellStyle.Format = "N2";
			dgv_movements.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

			dgv_movements.Columns["TOTAL"].ReadOnly = true;
		}
		private void Sale_Load(object sender, EventArgs e)
		{
		}

		private void dgv_movements_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{

		}
		string val = "";
		private void dgv_movements_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv_movements.Columns[e.ColumnIndex].Name == "NAME" && val != dgv_movements[e.ColumnIndex, e.RowIndex].Value + "")
			{
				SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM ITEMS WHERE NAME LIKE '%' + @NAME + '%'", Program.con);
				adp.SelectCommand.Parameters.AddWithValue("@NAME", dgv_movements[e.ColumnIndex, e.RowIndex].Value);

				DataTable dt = new DataTable();

				adp.Fill(dt);

				if (dt.Rows.Count == 1)
				{
					dgv_movements["ITEMID", e.RowIndex].Value = dt.Rows[0]["ID"];
					dgv_movements["NAME", e.RowIndex].Value = dt.Rows[0]["NAME"];
					dgv_movements["PRICE", e.RowIndex].Value = dt.Rows[0]["PRICE"];
					dgv_movements["QUANTITY", e.RowIndex].Value = 0;
				}
				else if (dt.Rows.Count > 1)
				{
					ItemSelector form = new ItemSelector(dgv_movements[e.ColumnIndex, e.RowIndex].Value + "");
					if (form.ShowDialog() == DialogResult.OK)
					{
						dgv_movements["ITEMID", e.RowIndex].Value = form.dr["ID"];
						dgv_movements["NAME", e.RowIndex].Value = form.dr["NAME"];
						dgv_movements["PRICE", e.RowIndex].Value = form.dr["PRICE"];
						dgv_movements["QUANTITY", e.RowIndex].Value = 0;
					}
					else
					{
						MessageBox.Show("Bir Stok Seçmediniz!", "VetSis V.1.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
						dgv_movements["NAME", e.RowIndex].Value = "";
						dgv_movements["PRICE", e.RowIndex].Value = 0;
						dgv_movements["QUANTITY", e.RowIndex].Value = 0;
					}
				}
				else
				{
					MessageBox.Show("Uygun Bir Stok Bulunamadı!", "VetSis V.1.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
					dgv_movements["NAME", e.RowIndex].Value = "";
					dgv_movements["PRICE", e.RowIndex].Value = 0;
					dgv_movements["QUANTITY", e.RowIndex].Value = 0;
				}
			}
			else if ((new string[]{"QUANTITY","PRICE" }).Contains(dgv_movements.Columns[e.ColumnIndex].Name))
			{
				double dbl = 0;
				double dbl2 = 0;
				Double.TryParse(dgv_movements["QUANTITY", e.RowIndex].Value + "", out dbl);
				Double.TryParse(dgv_movements["PRICE", e.RowIndex].Value + "", out dbl2);
				dgv_movements["TOTAL", e.RowIndex].Value = dbl * dbl2;
			}
		}

		private void dgv_movements_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv_movements.Columns[e.ColumnIndex].Name == "NAME")
			{
				val = dgv_movements[e.ColumnIndex, e.RowIndex].Value+"";
			}
		}

		private void InitializeSale(int ID)
		{
			reset = false;
			DataTable dtHeader = new DataTable();
			DataTable dtMovements = new DataTable();

			SqlDataAdapter adpHeader = new SqlDataAdapter("SELECT C.ID CUSTID, CS.ID, CS.NAME + ' ' + CS.SURNAME AS NAME, C.TRANO, CS.PHONE, CS.EMAIL, T.DATE FROM TRA_CUSTOMERS C JOIN CUSTOMERS CS ON C.CUSTOMERID = CS.ID JOIN TRANSACTIONS T ON T.ID = C.TRANO WHERE TRANO = @TRANO", Program.con);
			adpHeader.SelectCommand.Parameters.AddWithValue("@TRANO", ID);

			adpHeader.Fill(dtHeader);

			SqlDataAdapter adpMovements = new SqlDataAdapter("SELECT I.ID, IT.ID ITEMID, IT.NAME, I.PRICE, I.QUANTITY, I.TOTAL FROM TRA_ITEMS I JOIN ITEMS IT ON I.ITEMID = IT.ID WHERE TRANO = @TRANO",Program.con);
			adpMovements.SelectCommand.Parameters.AddWithValue("@TRANO", ID);

			adpMovements.Fill(dtMovements);
			
			dt.Rows.Clear();

			if (dtHeader.Rows.Count > 0)
			{
				txb_customerid.Text = dtHeader.Rows[0]["ID"].ToString();
				txb_customername.Text = dtHeader.Rows[0]["NAME"].ToString();
				txb_trano.Text = dtHeader.Rows[0]["TRANO"].ToString();
				dtp_date.Value = Convert.ToDateTime(dtHeader.Rows[0]["DATE"]);
				txb_phone.Text = dtHeader.Rows[0]["PHONE"].ToString();
				txb_email.Text = dtHeader.Rows[0]["EMAIL"].ToString();

				foreach (DataRow dr in dtMovements.Rows)
				{
					dt.Rows.Add(dr["ID"], dr["ITEMID"], dtHeader.Rows[0]["CUSTID"], dr["NAME"], dr["PRICE"], dr["QUANTITY"], dr["TOTAL"]);
				}
			}
			else
			{
				txb_customerid.Text = "";
				txb_customername.Text = "";
				txb_trano.Text = "";
				txb_phone.Text = "";
				txb_email.Text = "";
			}

			dgv_movements.Columns["ID"].Visible = false;
			reset = true;
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (Program.con.State != ConnectionState.Open)
				Program.con.Open();

			SqlTransaction tran = Program.con.BeginTransaction();
			try
			{
				EditMode(false);
				dgv_movements.Refresh();

				if (ID != null)
				{
					SqlCommand cmd = new SqlCommand("DELETE FROM TRA_ITEMS WHERE TRANO = @TRANO; DELETE FROM TRA_CUSTOMERS WHERE TRANO = @TRANO", Program.con);
					cmd.Parameters.AddWithValue("@TRANO", ID);

					cmd.Transaction = tran;

					cmd.ExecuteNonQuery();
				}
				else
				{

					int trano = 0;
					SqlDataAdapter adp = new SqlDataAdapter("INSERT INTO TRANSACTIONS([TRANSACTION]) OUTPUT inserted.ID VALUES('CUSTOMER,ITEM')", Program.con);
					adp.SelectCommand.Transaction = tran;

					DataTable dt = new DataTable();
					adp.Fill(dt);

					trano = Convert.ToInt32(dt.Rows[0][0]);
					this.ID = trano;
				}

				for (int i = 0; i < this.dt.Rows.Count; i++)
				{
					DataRow dr = this.dt.Rows[i];

					SqlCommand cmd = new SqlCommand(@"INSERT INTO TRA_CUSTOMERS(CUSTOMERID,INOUT,PRICE,QUANTITY,TOTAL,TRANO) VALUES(@CUSTOMERID,0,@PRICE,@QUANTITY,@TOTAL,@TRANO)
														INSERT INTO TRA_ITEMS(ITEMID,INOUT,PRICE,QUANTITY,TOTAL,TRANO) VALUES(@ITEMID,0,@PRICE,@QUANTITY,@TOTAL,@TRANO)", Program.con);
					cmd.Transaction = tran;

					cmd.Parameters.AddWithValue("@CUSTOMERID", txb_customerid.Text);
					cmd.Parameters.AddWithValue("@ITEMID", dr["ITEMID"]);
					cmd.Parameters.AddWithValue("@PRICE", dr["PRICE"]);
					cmd.Parameters.AddWithValue("@QUANTITY", dr["QUANTITY"]);
					cmd.Parameters.AddWithValue("@TOTAL", dr["TOTAL"]);
					cmd.Parameters.AddWithValue("@TRANO", this.ID);

					if (cmd.ExecuteNonQuery() == 0)
						throw new Exception("Veri Kaydı Yapılamadı!");
				}
				tran.Commit();
				((MainPage)ParentForm).Update(ID ?? 0);
			}
			catch (Exception ex)
			{
				tran.Rollback();
				EditMode(true);
				MessageBox.Show(ex.Message, "VetSis V.1.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btn_new_Click(object sender, EventArgs e)
		{
			this.ID = null;
			InitializeSale(0);
			EditMode(true);
			((MainPage)ParentForm).ClearSelection();
		}

		bool reset = true;
		private void txb_customerid_TextChanged(object sender, EventArgs e)
		{
			if (reset)
			{
				txb_customername.Text = "";
				txb_phone.Text = "";
				txb_email.Text = "";
			}
		}

		private void txb_customername_TextChanged(object sender, EventArgs e)
		{
			if (reset)
			{
				txb_customerid.Text = "";
				txb_phone.Text = "";
				txb_email.Text = "";
			}
		}

		private void txb_customerid_Validated(object sender, EventArgs e)
		{
			SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM CUSTOMERS WHERE ID = @ID", Program.con);
			adp.SelectCommand.Parameters.AddWithValue("@ID", txb_customerid.Text);

			DataTable dt = new DataTable();

			adp.Fill(dt);

			if (dt.Rows.Count == 1)
			{
				reset = false;
				txb_customerid.Text = dt.Rows[0]["ID"].ToString();
				txb_customername.Text = dt.Rows[0]["NAME"].ToString() + " " + dt.Rows[0]["SURNAME"].ToString();
				txb_phone.Text = dt.Rows[0]["PHONE"].ToString();
				txb_email.Text = dt.Rows[0]["EMAIL"].ToString();
				reset = true;
			}
			else
				MessageBox.Show("Müşteri Bulunamadı!", "Vetsis V.1.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void txb_customername_Validated(object sender, EventArgs e)
		{
			SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM CUSTOMERS WHERE (NAME + ' ' + SURNAME) LIKE '%' + @NAME + '%'", Program.con);
			adp.SelectCommand.Parameters.AddWithValue("@NAME", txb_customername.Text);

			DataTable dt = new DataTable();

			adp.Fill(dt);

			if (dt.Rows.Count == 1)
			{
				reset = false;
				txb_customerid.Text = dt.Rows[0]["ID"].ToString();
				txb_customername.Text = dt.Rows[0]["NAME"].ToString() + " " + dt.Rows[0]["SURNAME"].ToString();
				txb_phone.Text = dt.Rows[0]["PHONE"].ToString();
				txb_email.Text = dt.Rows[0]["EMAIL"].ToString();
				reset = true;
			}
			else
				MessageBox.Show("Müşteri Bulunamadı!", "Vetsis V.1.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			EditMode(true);
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			if (ID != null)
				((MainPage)ParentForm).Update(ID ?? 0);
			else
			{
				InitializeSale(0);
				EditMode(false);
				btn_edit.Enabled = false;
				btn_delete.Enabled = false;
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(ID + " No'lu evrağı silmek istediğinize emin misiniz?","VetSis V.1.1",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (Program.con.State != ConnectionState.Open)
					Program.con.Open();
				try
				{
					SqlCommand cmd = new SqlCommand("DELETE FROM TRANSACTIONS WHERE ID = @TRANO; DELETE FROM TRA_ITEMS WHERE TRANO = @TRANO; DELETE FROM TRA_CUSTOMERS WHERE TRANO = @TRANO", Program.con);
					cmd.Parameters.AddWithValue("@TRANO", ID);

					cmd.ExecuteNonQuery();
					InitializeSale(0);
					((MainPage)ParentForm).Update(0);
					EditMode(false);
					btn_edit.Enabled = false;
					btn_delete.Enabled = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "VetSis V.1.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
