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
using VetProj.Forms.Definitions;
using VetProj.UserControls;
using static System.Windows.Forms.DataFormats;

namespace VetProj.Forms
{
	public partial class MainPage : Form
	{
		public MainPage(string name)
		{
			InitializeComponent();
			lbl_username.Text = name;
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var tp = tabControl1.SelectedTab;
			switch (tp.Text)
			{
				case "Stoklar":
					var itm = ((Items)tp.Controls[0]);
					itm.RefreshAll();
					break;
				case "Müşteriler":
					var cust = ((Customers)tp.Controls[0]);
					cust.RefreshAll();
					break;
			}
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			this.ta_TRANSACTIONS.Fill(this.ds_VetSis.TRANSACTIONS);
			foreach (TabPage tp in tabControl1.TabPages)
			{
				switch(tp.Text)
				{
					case "Stoklar":
						UserControls.Items itm = new UserControls.Items();
						itm.Dock = DockStyle.Fill;
						tp.Controls.Add(itm);
						break;
					case "Müşteriler":
						UserControls.Customers cust = new UserControls.Customers();
						cust.Dock = DockStyle.Fill;
						tp.Controls.Add(cust);
						break;
				}
			}
		}

		private void dgv_stoklar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				Font f = new Font(dgv_stoklar.DefaultCellStyle.Font, FontStyle.Bold);
				Font f2 = new Font(dgv_stoklar.DefaultCellStyle.Font, FontStyle.Regular);

				foreach (DataGridViewRow dr in dgv_stoklar.Rows)
					dr.DefaultCellStyle.Font = f2;

				dgv_stoklar.Rows[e.RowIndex].DefaultCellStyle.Font = f;

				Sale sale = new Sale(Convert.ToInt32(dgv_stoklar["ID", e.RowIndex].Value));
				sale.Dock = DockStyle.Fill;

				splitContainer1.Panel2.Controls.Clear();
				splitContainer1.Panel2.Controls.Add(sale);
			}
		}

		public void Update(int ID)
		{
			this.ta_TRANSACTIONS.Fill(this.ds_VetSis.TRANSACTIONS);
			
			foreach(DataGridViewRow dr in dgv_stoklar.Rows)
			{
				if (Convert.ToInt32(dr.Cells["ID"].Value) == ID)
				{
					dr.Selected = true;
					dgv_stoklar_CellDoubleClick(new object(), new DataGridViewCellEventArgs(dgv_stoklar.Columns["ID"].Index, dr.Index));
				}
			}
		}

		public void ClearSelection()
		{
			foreach(DataGridViewRow dr in dgv_stoklar.SelectedRows)
				dr.Selected = false;

			Font f2 = new Font(dgv_stoklar.DefaultCellStyle.Font, FontStyle.Regular);

			foreach (DataGridViewRow dr in dgv_stoklar.Rows)
				dr.DefaultCellStyle.Font = f2;
		}
	}
}
