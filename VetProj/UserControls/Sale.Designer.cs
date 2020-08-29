namespace VetProj.UserControls
{
	partial class Sale
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_new = new System.Windows.Forms.ToolStripButton();
			this.btn_edit = new System.Windows.Forms.ToolStripButton();
			this.btn_save = new System.Windows.Forms.ToolStripButton();
			this.btn_delete = new System.Windows.Forms.ToolStripButton();
			this.btn_cancel = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txb_trano = new System.Windows.Forms.TextBox();
			this.dtp_date = new System.Windows.Forms.DateTimePicker();
			this.txb_customerid = new System.Windows.Forms.TextBox();
			this.txb_customername = new System.Windows.Forms.TextBox();
			this.txb_email = new System.Windows.Forms.TextBox();
			this.txb_phone = new System.Windows.Forms.MaskedTextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dgv_movements = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_movements)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_new,
            this.btn_edit,
            this.btn_save,
            this.btn_delete,
            this.btn_cancel});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(4, 0, 1, 0);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(1142, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_new
			// 
			this.btn_new.ForeColor = System.Drawing.Color.White;
			this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
			this.btn_new.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(49, 22);
			this.btn_new.Text = "Yeni";
			this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.ForeColor = System.Drawing.Color.White;
			this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
			this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(69, 22);
			this.btn_edit.Text = "Düzenle";
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// btn_save
			// 
			this.btn_save.ForeColor = System.Drawing.Color.White;
			this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
			this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(63, 22);
			this.btn_save.Text = "Kaydet";
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.ForeColor = System.Drawing.Color.White;
			this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
			this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(39, 22);
			this.btn_delete.Text = "Sil";
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.ForeColor = System.Drawing.Color.White;
			this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
			this.btn_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(50, 22);
			this.btn_cancel.Text = "İptal";
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 207);
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
			this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.label1.Size = new System.Drawing.Size(556, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "Evrak Başlık";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.label6, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.label7, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.label8, 0, 5);
			this.tableLayoutPanel3.Controls.Add(this.txb_trano, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.dtp_date, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.txb_customerid, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.txb_customername, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.txb_email, 1, 5);
			this.tableLayoutPanel3.Controls.Add(this.txb_phone, 1, 4);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 36);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 6;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(556, 168);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 28);
			this.label3.TabIndex = 0;
			this.label3.Text = "Evrak No:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.label4.Location = new System.Drawing.Point(3, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 28);
			this.label4.TabIndex = 0;
			this.label4.Text = "Evrak Tarih:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.label5.Location = new System.Drawing.Point(3, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 28);
			this.label5.TabIndex = 0;
			this.label5.Text = "Müşteri No:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.label6.Location = new System.Drawing.Point(3, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 28);
			this.label6.TabIndex = 0;
			this.label6.Text = "Müşteri Adı:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.label7.Location = new System.Drawing.Point(3, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 28);
			this.label7.TabIndex = 0;
			this.label7.Text = "Telefon No:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.label8.Location = new System.Drawing.Point(3, 140);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 28);
			this.label8.TabIndex = 0;
			this.label8.Text = "E-Mail:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txb_trano
			// 
			this.txb_trano.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_trano.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.txb_trano.Location = new System.Drawing.Point(90, 3);
			this.txb_trano.Name = "txb_trano";
			this.txb_trano.Size = new System.Drawing.Size(463, 22);
			this.txb_trano.TabIndex = 1;
			// 
			// dtp_date
			// 
			this.dtp_date.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F);
			this.dtp_date.CustomFormat = "dd MMMM yyyy dddd HH:mm:ss";
			this.dtp_date.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtp_date.Enabled = false;
			this.dtp_date.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_date.Location = new System.Drawing.Point(90, 31);
			this.dtp_date.Name = "dtp_date";
			this.dtp_date.Size = new System.Drawing.Size(463, 22);
			this.dtp_date.TabIndex = 2;
			// 
			// txb_customerid
			// 
			this.txb_customerid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_customerid.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.txb_customerid.Location = new System.Drawing.Point(90, 59);
			this.txb_customerid.Name = "txb_customerid";
			this.txb_customerid.Size = new System.Drawing.Size(463, 22);
			this.txb_customerid.TabIndex = 1;
			this.txb_customerid.TextChanged += new System.EventHandler(this.txb_customerid_TextChanged);
			this.txb_customerid.Validated += new System.EventHandler(this.txb_customerid_Validated);
			// 
			// txb_customername
			// 
			this.txb_customername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_customername.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.txb_customername.Location = new System.Drawing.Point(90, 87);
			this.txb_customername.Name = "txb_customername";
			this.txb_customername.Size = new System.Drawing.Size(463, 22);
			this.txb_customername.TabIndex = 1;
			this.txb_customername.TextChanged += new System.EventHandler(this.txb_customername_TextChanged);
			this.txb_customername.Validated += new System.EventHandler(this.txb_customername_Validated);
			// 
			// txb_email
			// 
			this.txb_email.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_email.Enabled = false;
			this.txb_email.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.txb_email.Location = new System.Drawing.Point(90, 143);
			this.txb_email.Name = "txb_email";
			this.txb_email.Size = new System.Drawing.Size(463, 22);
			this.txb_email.TabIndex = 1;
			// 
			// txb_phone
			// 
			this.txb_phone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_phone.Enabled = false;
			this.txb_phone.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.txb_phone.Location = new System.Drawing.Point(90, 115);
			this.txb_phone.Name = "txb_phone";
			this.txb_phone.Size = new System.Drawing.Size(463, 22);
			this.txb_phone.TabIndex = 3;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.dgv_movements, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 222);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1136, 366);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// dgv_movements
			// 
			this.dgv_movements.AllowUserToResizeColumns = false;
			this.dgv_movements.AllowUserToResizeRows = false;
			this.dgv_movements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_movements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_movements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_movements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_movements.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_movements.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_movements.Location = new System.Drawing.Point(3, 36);
			this.dgv_movements.MultiSelect = false;
			this.dgv_movements.Name = "dgv_movements";
			this.dgv_movements.Size = new System.Drawing.Size(1130, 327);
			this.dgv_movements.TabIndex = 0;
			this.dgv_movements.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_movements_CellEnter);
			this.dgv_movements.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_movements_CellValidated);
			this.dgv_movements.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_movements_CellValidating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.label2.Size = new System.Drawing.Size(1130, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Stok Hareket";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1142, 591);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.AutoSize = true;
			this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(1136, 213);
			this.tableLayoutPanel5.TabIndex = 0;
			// 
			// Sale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel4);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Sale";
			this.Size = new System.Drawing.Size(1142, 616);
			this.Load += new System.EventHandler(this.Sale_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_movements)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataGridView dgv_movements;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_new;
		private System.Windows.Forms.ToolStripButton btn_edit;
		private System.Windows.Forms.ToolStripButton btn_save;
		private System.Windows.Forms.ToolStripButton btn_delete;
		private System.Windows.Forms.ToolStripButton btn_cancel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txb_trano;
		private System.Windows.Forms.DateTimePicker dtp_date;
		private System.Windows.Forms.TextBox txb_customerid;
		private System.Windows.Forms.TextBox txb_customername;
		private System.Windows.Forms.TextBox txb_email;
		private System.Windows.Forms.MaskedTextBox txb_phone;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
	}
}
