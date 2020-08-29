namespace VetProj.UserControls
{
	partial class Customers
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.il_btn = new System.Windows.Forms.ImageList(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.txb_search = new System.Windows.Forms.TextBox();
			this.dgv_stoklar = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bs_CUSTOMERS = new System.Windows.Forms.BindingSource(this.components);
			this.ds_VetSis = new VetProj.ds_VetSis();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.TRA_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TRA_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TRA_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TRA_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tRACUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ds_VetSis1 = new VetProj.ds_VetSis();
			this.ta_CUSTOMERS = new VetProj.ds_VetSisTableAdapters.ta_CUSTOMERS();
			this.ta_TRACUSTOMER = new VetProj.ds_VetSisTableAdapters.ta_TRACUSTOMER();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_stoklar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bs_CUSTOMERS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_VetSis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tRACUSTOMERBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_VetSis1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer2.Size = new System.Drawing.Size(1258, 702);
			this.splitContainer2.SplitterDistance = 209;
			this.splitContainer2.SplitterWidth = 8;
			this.splitContainer2.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.button2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.button3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.button4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.button5, 0, 5);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(209, 702);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(10);
			this.label1.Size = new System.Drawing.Size(203, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Müşteri İşlemleri";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.il_btn;
			this.button1.Location = new System.Drawing.Point(3, 46);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(4);
			this.button1.Size = new System.Drawing.Size(203, 35);
			this.button1.TabIndex = 1;
			this.button1.Text = "Yeni Müşteri";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// il_btn
			// 
			this.il_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_btn.ImageStream")));
			this.il_btn.TransparentColor = System.Drawing.Color.Transparent;
			this.il_btn.Images.SetKeyName(0, "add-1.png");
			this.il_btn.Images.SetKeyName(1, "garbage-2.png");
			this.il_btn.Images.SetKeyName(2, "edit.png");
			this.il_btn.Images.SetKeyName(3, "upload.png");
			this.il_btn.Images.SetKeyName(4, "down-arrow.png");
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.ImageIndex = 1;
			this.button2.ImageList = this.il_btn;
			this.button2.Location = new System.Drawing.Point(3, 87);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(4);
			this.button2.Size = new System.Drawing.Size(203, 35);
			this.button2.TabIndex = 2;
			this.button2.Text = "Müşteri Sil";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.ImageIndex = 2;
			this.button3.ImageList = this.il_btn;
			this.button3.Location = new System.Drawing.Point(3, 128);
			this.button3.Name = "button3";
			this.button3.Padding = new System.Windows.Forms.Padding(4);
			this.button3.Size = new System.Drawing.Size(203, 35);
			this.button3.TabIndex = 3;
			this.button3.Text = "Görüntüle";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.ImageIndex = 3;
			this.button4.ImageList = this.il_btn;
			this.button4.Location = new System.Drawing.Point(3, 169);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(4);
			this.button4.Size = new System.Drawing.Size(203, 35);
			this.button4.TabIndex = 3;
			this.button4.Text = "Borç Ekle";
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button5.ImageIndex = 4;
			this.button5.ImageList = this.il_btn;
			this.button5.Location = new System.Drawing.Point(3, 210);
			this.button5.Name = "button5";
			this.button5.Padding = new System.Windows.Forms.Padding(4);
			this.button5.Size = new System.Drawing.Size(203, 35);
			this.button5.TabIndex = 3;
			this.button5.Text = "Ödeme Ekle";
			this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel2);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.dataGridView1);
			this.splitContainer3.Size = new System.Drawing.Size(1041, 702);
			this.splitContainer3.SplitterDistance = 503;
			this.splitContainer3.SplitterWidth = 8;
			this.splitContainer3.TabIndex = 4;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.dgv_stoklar, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1041, 503);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.txb_search, 1, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1035, 28);
			this.tableLayoutPanel4.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(3, 0);
			this.label7.Name = "label7";
			this.label7.Padding = new System.Windows.Forms.Padding(3);
			this.label7.Size = new System.Drawing.Size(103, 28);
			this.label7.TabIndex = 2;
			this.label7.Text = "Müşteri Arama:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txb_search
			// 
			this.txb_search.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_search.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.txb_search.Location = new System.Drawing.Point(112, 3);
			this.txb_search.Name = "txb_search";
			this.txb_search.Size = new System.Drawing.Size(920, 22);
			this.txb_search.TabIndex = 3;
			this.txb_search.TextChanged += new System.EventHandler(this.txb_search_TextChanged);
			// 
			// dgv_stoklar
			// 
			this.dgv_stoklar.AllowUserToAddRows = false;
			this.dgv_stoklar.AllowUserToDeleteRows = false;
			this.dgv_stoklar.AllowUserToOrderColumns = true;
			this.dgv_stoklar.AllowUserToResizeRows = false;
			this.dgv_stoklar.AutoGenerateColumns = false;
			this.dgv_stoklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_stoklar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_stoklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_stoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_stoklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.PHONE,
            this.EMAIL,
            this.TOTAL});
			this.dgv_stoklar.DataSource = this.bs_CUSTOMERS;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_stoklar.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_stoklar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_stoklar.Location = new System.Drawing.Point(0, 37);
			this.dgv_stoklar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.dgv_stoklar.MultiSelect = false;
			this.dgv_stoklar.Name = "dgv_stoklar";
			this.dgv_stoklar.ReadOnly = true;
			this.dgv_stoklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_stoklar.Size = new System.Drawing.Size(1041, 463);
			this.dgv_stoklar.TabIndex = 0;
			this.dgv_stoklar.SelectionChanged += new System.EventHandler(this.dgv_stoklar_SelectionChanged);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// NAME
			// 
			this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NAME.DataPropertyName = "NAME";
			this.NAME.HeaderText = "Müşteri Adı Soyadı";
			this.NAME.Name = "NAME";
			this.NAME.ReadOnly = true;
			// 
			// PHONE
			// 
			this.PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.PHONE.DataPropertyName = "PHONE";
			this.PHONE.HeaderText = "Telefon Numarası";
			this.PHONE.Name = "PHONE";
			this.PHONE.ReadOnly = true;
			this.PHONE.Width = 142;
			// 
			// EMAIL
			// 
			this.EMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.EMAIL.DataPropertyName = "EMAIL";
			this.EMAIL.HeaderText = "E-Mail";
			this.EMAIL.Name = "EMAIL";
			this.EMAIL.ReadOnly = true;
			this.EMAIL.Width = 84;
			// 
			// TOTAL
			// 
			this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.TOTAL.DataPropertyName = "TOTAL";
			dataGridViewCellStyle2.Format = "C2";
			this.TOTAL.DefaultCellStyle = dataGridViewCellStyle2;
			this.TOTAL.HeaderText = "Toplam Bakiye";
			this.TOTAL.Name = "TOTAL";
			this.TOTAL.ReadOnly = true;
			this.TOTAL.Width = 129;
			// 
			// bs_CUSTOMERS
			// 
			this.bs_CUSTOMERS.DataMember = "CUSTOMERS";
			this.bs_CUSTOMERS.DataSource = this.ds_VetSis;
			// 
			// ds_VetSis
			// 
			this.ds_VetSis.DataSetName = "ds_VetSis";
			this.ds_VetSis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TRA_NAME,
            this.TRA_TYPE,
            this.TRA_DATE,
            this.TRA_TOTAL});
			this.dataGridView1.DataSource = this.tRACUSTOMERBindingSource;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1041, 191);
			this.dataGridView1.TabIndex = 0;
			// 
			// TRA_NAME
			// 
			this.TRA_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TRA_NAME.DataPropertyName = "NAME";
			this.TRA_NAME.HeaderText = "Müşteri Adı Soyadı";
			this.TRA_NAME.Name = "TRA_NAME";
			this.TRA_NAME.ReadOnly = true;
			// 
			// TRA_TYPE
			// 
			this.TRA_TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.TRA_TYPE.DataPropertyName = "TYPE";
			this.TRA_TYPE.HeaderText = "İşlem Tipi";
			this.TRA_TYPE.Name = "TRA_TYPE";
			this.TRA_TYPE.ReadOnly = true;
			this.TRA_TYPE.Width = 97;
			// 
			// TRA_DATE
			// 
			this.TRA_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.TRA_DATE.DataPropertyName = "DATE";
			this.TRA_DATE.HeaderText = "İşlem Tarihi";
			this.TRA_DATE.Name = "TRA_DATE";
			this.TRA_DATE.ReadOnly = true;
			this.TRA_DATE.Width = 108;
			// 
			// TRA_TOTAL
			// 
			this.TRA_TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.TRA_TOTAL.DataPropertyName = "TOTAL";
			this.TRA_TOTAL.HeaderText = "Toplam Tutar";
			this.TRA_TOTAL.Name = "TRA_TOTAL";
			this.TRA_TOTAL.ReadOnly = true;
			this.TRA_TOTAL.Width = 117;
			// 
			// tRACUSTOMERBindingSource
			// 
			this.tRACUSTOMERBindingSource.DataMember = "TRACUSTOMER";
			this.tRACUSTOMERBindingSource.DataSource = this.ds_VetSis1;
			// 
			// ds_VetSis1
			// 
			this.ds_VetSis1.DataSetName = "ds_VetSis";
			this.ds_VetSis1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ta_CUSTOMERS
			// 
			this.ta_CUSTOMERS.ClearBeforeFill = true;
			// 
			// ta_TRACUSTOMER
			// 
			this.ta_TRACUSTOMER.ClearBeforeFill = true;
			// 
			// Customers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer2);
			this.Name = "Customers";
			this.Size = new System.Drawing.Size(1258, 702);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_stoklar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bs_CUSTOMERS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_VetSis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tRACUSTOMERBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_VetSis1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.DataGridView dgv_stoklar;
		private System.Windows.Forms.ImageList il_btn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.BindingSource bs_CUSTOMERS;
		private ds_VetSis ds_VetSis;
		private ds_VetSisTableAdapters.ta_CUSTOMERS ta_CUSTOMERS;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txb_search;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn TRA_NAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn TRA_TYPE;
		private System.Windows.Forms.DataGridViewTextBoxColumn TRA_DATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn TRA_TOTAL;
		private System.Windows.Forms.BindingSource tRACUSTOMERBindingSource;
		private ds_VetSis ds_VetSis1;
		private ds_VetSisTableAdapters.ta_TRACUSTOMER ta_TRACUSTOMER;
	}
}
