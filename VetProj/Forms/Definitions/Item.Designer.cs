namespace VetProj.Forms.Definitions
{
	partial class Item
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_save = new System.Windows.Forms.ToolStripButton();
			this.btn_edit = new System.Windows.Forms.ToolStripButton();
			this.btn_cancel = new System.Windows.Forms.ToolStripButton();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txb_name = new System.Windows.Forms.TextBox();
			this.bs_ITEM = new System.Windows.Forms.BindingSource(this.components);
			this.ds_VetSis = new VetProj.ds_VetSis();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbx_animal = new System.Windows.Forms.ComboBox();
			this.cbx_categorie = new System.Windows.Forms.ComboBox();
			this.cbx_subcategorie = new System.Windows.Forms.ComboBox();
			this.cbx_unit = new System.Windows.Forms.ComboBox();
			this.txb_quantity = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txb_price = new System.Windows.Forms.TextBox();
			this.ta_ITEM = new VetProj.ds_VetSisTableAdapters.ta_ITEM();
			this.ta_ANIMALS = new VetProj.ds_VetSisTableAdapters.ta_ANIMALS();
			this.ta_CATEGORIES = new VetProj.ds_VetSisTableAdapters.ta_CATEGORIES1();
			this.ta_SUBCATEGORIES = new VetProj.ds_VetSisTableAdapters.ta_SUBCATEGORIES1();
			this.ta_UNITS = new VetProj.ds_VetSisTableAdapters.ta_UNITS();
			this.tableLayoutPanel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bs_ITEM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_VetSis)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 547);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_save,
            this.btn_edit,
            this.btn_cancel});
			this.toolStrip1.Location = new System.Drawing.Point(0, 35);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(404, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_save
			// 
			this.btn_save.ForeColor = System.Drawing.Color.White;
			this.btn_save.Image = global::VetProj.Properties.Resources.save;
			this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(63, 22);
			this.btn_save.Text = "Kaydet";
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.ForeColor = System.Drawing.Color.White;
			this.btn_edit.Image = global::VetProj.Properties.Resources.edit;
			this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(69, 22);
			this.btn_edit.Text = "Düzenle";
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.ForeColor = System.Drawing.Color.White;
			this.btn_cancel.Image = global::VetProj.Properties.Resources.rewind_1;
			this.btn_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(50, 22);
			this.btn_cancel.Text = "İptal";
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 2);
			this.label2.Size = new System.Drawing.Size(404, 35);
			this.label2.TabIndex = 2;
			this.label2.Text = "Yeni Stok";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.txb_name, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.cbx_animal, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.cbx_categorie, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.cbx_subcategorie, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.cbx_unit, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.txb_quantity, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.txb_price, 1, 6);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 63);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 8;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 481);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Stok Adı:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txb_name
			// 
			this.txb_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_ITEM, "NAME", true));
			this.txb_name.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txb_name.Location = new System.Drawing.Point(104, 3);
			this.txb_name.Name = "txb_name";
			this.txb_name.Size = new System.Drawing.Size(291, 22);
			this.txb_name.TabIndex = 1;
			this.txb_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// bs_ITEM
			// 
			this.bs_ITEM.DataMember = "ITEM";
			this.bs_ITEM.DataSource = this.ds_VetSis;
			// 
			// ds_VetSis
			// 
			this.ds_VetSis.DataSetName = "ds_VetSis";
			this.ds_VetSis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label3.Location = new System.Drawing.Point(3, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 31);
			this.label3.TabIndex = 0;
			this.label3.Text = "Hayvan Cinsi:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label4.Location = new System.Drawing.Point(3, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 31);
			this.label4.TabIndex = 0;
			this.label4.Text = "Kategori:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label5.Location = new System.Drawing.Point(3, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 31);
			this.label5.TabIndex = 0;
			this.label5.Text = "Alt Kategori:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label6.Location = new System.Drawing.Point(3, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 28);
			this.label6.TabIndex = 0;
			this.label6.Text = "Miktar:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label7.Location = new System.Drawing.Point(3, 149);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 31);
			this.label7.TabIndex = 0;
			this.label7.Text = "Miktar Birim:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbx_animal
			// 
			this.cbx_animal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_ITEM, "ANIMAL", true));
			this.cbx_animal.DataSource = this.ds_VetSis;
			this.cbx_animal.DisplayMember = "ANIMALS.NAME";
			this.cbx_animal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbx_animal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_animal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbx_animal.FormattingEnabled = true;
			this.cbx_animal.Location = new System.Drawing.Point(104, 31);
			this.cbx_animal.Name = "cbx_animal";
			this.cbx_animal.Size = new System.Drawing.Size(291, 25);
			this.cbx_animal.TabIndex = 2;
			this.cbx_animal.ValueMember = "ANIMALS.ID";
			this.cbx_animal.SelectedIndexChanged += new System.EventHandler(this.cbx_animal_SelectedIndexChanged);
			// 
			// cbx_categorie
			// 
			this.cbx_categorie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_ITEM, "CATEGORIE", true));
			this.cbx_categorie.DataSource = this.ds_VetSis;
			this.cbx_categorie.DisplayMember = "CATEGORIES1.NAME";
			this.cbx_categorie.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbx_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_categorie.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbx_categorie.FormattingEnabled = true;
			this.cbx_categorie.Location = new System.Drawing.Point(104, 62);
			this.cbx_categorie.Name = "cbx_categorie";
			this.cbx_categorie.Size = new System.Drawing.Size(291, 25);
			this.cbx_categorie.TabIndex = 2;
			this.cbx_categorie.ValueMember = "CATEGORIES1.ID";
			this.cbx_categorie.SelectedIndexChanged += new System.EventHandler(this.cbx_categorie_SelectedIndexChanged);
			// 
			// cbx_subcategorie
			// 
			this.cbx_subcategorie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_ITEM, "SUBCATEGORIE", true));
			this.cbx_subcategorie.DataSource = this.ds_VetSis;
			this.cbx_subcategorie.DisplayMember = "SUBCATEGORIES1.NAME";
			this.cbx_subcategorie.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbx_subcategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_subcategorie.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbx_subcategorie.FormattingEnabled = true;
			this.cbx_subcategorie.Location = new System.Drawing.Point(104, 93);
			this.cbx_subcategorie.Name = "cbx_subcategorie";
			this.cbx_subcategorie.Size = new System.Drawing.Size(291, 25);
			this.cbx_subcategorie.TabIndex = 2;
			this.cbx_subcategorie.ValueMember = "SUBCATEGORIES1.ID";
			// 
			// cbx_unit
			// 
			this.cbx_unit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_ITEM, "UNIT", true));
			this.cbx_unit.DataSource = this.ds_VetSis;
			this.cbx_unit.DisplayMember = "UNITS.NAME";
			this.cbx_unit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbx_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_unit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbx_unit.FormattingEnabled = true;
			this.cbx_unit.Location = new System.Drawing.Point(104, 152);
			this.cbx_unit.Name = "cbx_unit";
			this.cbx_unit.Size = new System.Drawing.Size(291, 25);
			this.cbx_unit.TabIndex = 2;
			this.cbx_unit.ValueMember = "UNITS.ID";
			// 
			// txb_quantity
			// 
			this.txb_quantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_ITEM, "QUANTITY", true));
			this.txb_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_quantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txb_quantity.Location = new System.Drawing.Point(104, 124);
			this.txb_quantity.Name = "txb_quantity";
			this.txb_quantity.Size = new System.Drawing.Size(291, 22);
			this.txb_quantity.TabIndex = 1;
			this.txb_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_quantity_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label8.Location = new System.Drawing.Point(3, 180);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 28);
			this.label8.TabIndex = 0;
			this.label8.Text = "Fiyat:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txb_price
			// 
			this.txb_price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_ITEM, "PRICE", true));
			this.txb_price.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_price.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txb_price.Location = new System.Drawing.Point(104, 183);
			this.txb_price.Name = "txb_price";
			this.txb_price.Size = new System.Drawing.Size(291, 22);
			this.txb_price.TabIndex = 1;
			this.txb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_quantity_KeyPress);
			// 
			// ta_ITEM
			// 
			this.ta_ITEM.ClearBeforeFill = true;
			// 
			// ta_ANIMALS
			// 
			this.ta_ANIMALS.ClearBeforeFill = true;
			// 
			// ta_CATEGORIES
			// 
			this.ta_CATEGORIES.ClearBeforeFill = true;
			// 
			// ta_SUBCATEGORIES
			// 
			this.ta_SUBCATEGORIES.ClearBeforeFill = true;
			// 
			// ta_UNITS
			// 
			this.ta_UNITS.ClearBeforeFill = true;
			// 
			// Item
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(404, 547);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Item";
			this.Text = "Yeni Stok";
			this.Load += new System.EventHandler(this.Item_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bs_ITEM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_VetSis)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_save;
		private System.Windows.Forms.ToolStripButton btn_edit;
		private System.Windows.Forms.ToolStripButton btn_cancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txb_name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbx_animal;
		private System.Windows.Forms.ComboBox cbx_categorie;
		private System.Windows.Forms.ComboBox cbx_subcategorie;
		private System.Windows.Forms.ComboBox cbx_unit;
		private System.Windows.Forms.BindingSource bs_ITEM;
		private ds_VetSis ds_VetSis;
		private ds_VetSisTableAdapters.ta_ITEM ta_ITEM;
		private ds_VetSisTableAdapters.ta_ANIMALS ta_ANIMALS;
		private ds_VetSisTableAdapters.ta_CATEGORIES1 ta_CATEGORIES;
		private ds_VetSisTableAdapters.ta_SUBCATEGORIES1 ta_SUBCATEGORIES;
		private ds_VetSisTableAdapters.ta_UNITS ta_UNITS;
		private System.Windows.Forms.TextBox txb_quantity;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txb_price;
	}
}