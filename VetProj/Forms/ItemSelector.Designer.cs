namespace VetProj.Forms
{
	partial class ItemSelector
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSelector));
			this.ds_VetSis = new VetProj.ds_VetSis();
			this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CATEGORIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ANIMAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUBCATEGORIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ıTEMSEARCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ta_ITEMSEARCH = new VetProj.ds_VetSisTableAdapters.ta_ITEMSEARCH();
			((System.ComponentModel.ISupportInitialize)(this.ds_VetSis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ıTEMSEARCHBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// ds_VetSis
			// 
			this.ds_VetSis.DataSetName = "ds_VetSis";
			this.ds_VetSis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// advancedDataGridView1
			// 
			this.advancedDataGridView1.AllowUserToAddRows = false;
			this.advancedDataGridView1.AllowUserToDeleteRows = false;
			this.advancedDataGridView1.AllowUserToResizeColumns = false;
			this.advancedDataGridView1.AllowUserToResizeRows = false;
			this.advancedDataGridView1.AutoGenerateColumns = false;
			this.advancedDataGridView1.AutoGenerateContextFilters = true;
			this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.advancedDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.CATEGORIE,
            this.ANIMAL,
            this.SUBCATEGORIE,
            this.QUANTITY,
            this.PRICE});
			this.advancedDataGridView1.DataSource = this.ıTEMSEARCHBindingSource;
			this.advancedDataGridView1.DateWithTime = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.advancedDataGridView1.Location = new System.Drawing.Point(0, 0);
			this.advancedDataGridView1.MultiSelect = false;
			this.advancedDataGridView1.Name = "advancedDataGridView1";
			this.advancedDataGridView1.ReadOnly = true;
			this.advancedDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.advancedDataGridView1.Size = new System.Drawing.Size(885, 723);
			this.advancedDataGridView1.TabIndex = 2;
			this.advancedDataGridView1.TimeFilter = false;
			this.advancedDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.advancedDataGridView1_KeyDown);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 22;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.ID.Visible = false;
			// 
			// NAME
			// 
			this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NAME.DataPropertyName = "NAME";
			this.NAME.HeaderText = "Stok Adı";
			this.NAME.MinimumWidth = 22;
			this.NAME.Name = "NAME";
			this.NAME.ReadOnly = true;
			this.NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// CATEGORIE
			// 
			this.CATEGORIE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.CATEGORIE.DataPropertyName = "CATEGORIE";
			this.CATEGORIE.HeaderText = "Kategori";
			this.CATEGORIE.MinimumWidth = 22;
			this.CATEGORIE.Name = "CATEGORIE";
			this.CATEGORIE.ReadOnly = true;
			this.CATEGORIE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.CATEGORIE.Width = 98;
			// 
			// ANIMAL
			// 
			this.ANIMAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ANIMAL.DataPropertyName = "ANIMAL";
			this.ANIMAL.HeaderText = "Hayvan Cinsi";
			this.ANIMAL.MinimumWidth = 22;
			this.ANIMAL.Name = "ANIMAL";
			this.ANIMAL.ReadOnly = true;
			this.ANIMAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.ANIMAL.Width = 119;
			// 
			// SUBCATEGORIE
			// 
			this.SUBCATEGORIE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.SUBCATEGORIE.DataPropertyName = "SUBCATEGORIE";
			this.SUBCATEGORIE.HeaderText = "Alt Kategori";
			this.SUBCATEGORIE.MinimumWidth = 22;
			this.SUBCATEGORIE.Name = "SUBCATEGORIE";
			this.SUBCATEGORIE.ReadOnly = true;
			this.SUBCATEGORIE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.SUBCATEGORIE.Width = 111;
			// 
			// QUANTITY
			// 
			this.QUANTITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.QUANTITY.DataPropertyName = "QUANTITY";
			this.QUANTITY.HeaderText = "Miktar";
			this.QUANTITY.MinimumWidth = 22;
			this.QUANTITY.Name = "QUANTITY";
			this.QUANTITY.ReadOnly = true;
			this.QUANTITY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.QUANTITY.Width = 85;
			// 
			// PRICE
			// 
			this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.PRICE.DataPropertyName = "PRICE";
			dataGridViewCellStyle2.Format = "C2";
			this.PRICE.DefaultCellStyle = dataGridViewCellStyle2;
			this.PRICE.HeaderText = "Fiyat";
			this.PRICE.MinimumWidth = 22;
			this.PRICE.Name = "PRICE";
			this.PRICE.ReadOnly = true;
			this.PRICE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.PRICE.Width = 74;
			// 
			// ıTEMSEARCHBindingSource
			// 
			this.ıTEMSEARCHBindingSource.DataMember = "ITEMSEARCH";
			this.ıTEMSEARCHBindingSource.DataSource = this.ds_VetSis;
			// 
			// ta_ITEMSEARCH
			// 
			this.ta_ITEMSEARCH.ClearBeforeFill = true;
			// 
			// ItemSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 723);
			this.Controls.Add(this.advancedDataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ItemSelector";
			this.Text = "ItemSelector";
			((System.ComponentModel.ISupportInitialize)(this.ds_VetSis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ıTEMSEARCHBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ds_VetSis ds_VetSis;
		private System.Windows.Forms.BindingSource ıTEMSEARCHBindingSource;
		private ds_VetSisTableAdapters.ta_ITEMSEARCH ta_ITEMSEARCH;
		private ADGV.AdvancedDataGridView advancedDataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ANIMAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn SUBCATEGORIE;
		private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
	}
}