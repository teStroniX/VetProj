using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetProj.Forms
{
	public partial class ItemSelector : Form
	{
		public DataRow dr;
		public ItemSelector(string Name)
		{
			InitializeComponent();
			DialogResult = DialogResult.Cancel;
			ta_ITEMSEARCH.Fill(ds_VetSis.ITEMSEARCH, Name);
		}

		private void advancedDataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter)
			{
				dr = ds_VetSis.ITEMSEARCH[advancedDataGridView1.SelectedRows[0].Index];
				DialogResult = DialogResult.OK;
				Close();
			}
		}
	}
}
