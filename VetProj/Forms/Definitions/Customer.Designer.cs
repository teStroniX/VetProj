namespace VetProj.Forms.Definitions
{
	partial class Customer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_save = new System.Windows.Forms.ToolStripButton();
			this.btn_edit = new System.Windows.Forms.ToolStripButton();
			this.btn_cancel = new System.Windows.Forms.ToolStripButton();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txb_name = new System.Windows.Forms.TextBox();
			this.ds_VetSis = new VetProj.ds_VetSis();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txb_surname = new System.Windows.Forms.TextBox();
			this.txb_phone = new System.Windows.Forms.MaskedTextBox();
			this.txb_email = new System.Windows.Forms.TextBox();
			this.ta_CUSTOMER = new VetProj.ds_VetSisTableAdapters.ta_CUSTOMER();
			this.tableLayoutPanel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
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
			this.label2.Text = "Yeni Müşteri";
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
			this.tableLayoutPanel2.Controls.Add(this.txb_surname, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.txb_phone, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.txb_email, 1, 3);
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
			this.label1.Size = new System.Drawing.Size(57, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Adı:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txb_name
			// 
			this.txb_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_VetSis, "CUSTOMER.NAME", true));
			this.txb_name.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txb_name.Location = new System.Drawing.Point(66, 3);
			this.txb_name.Name = "txb_name";
			this.txb_name.Size = new System.Drawing.Size(329, 22);
			this.txb_name.TabIndex = 1;
			this.txb_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
			this.label3.Size = new System.Drawing.Size(57, 28);
			this.label3.TabIndex = 0;
			this.label3.Text = "Soyadı:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label4.Location = new System.Drawing.Point(3, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 28);
			this.label4.TabIndex = 0;
			this.label4.Text = "Telefon:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label5.Location = new System.Drawing.Point(3, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 28);
			this.label5.TabIndex = 0;
			this.label5.Text = "E-Mail:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txb_surname
			// 
			this.txb_surname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_VetSis, "CUSTOMER.SURNAME", true));
			this.txb_surname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_surname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txb_surname.Location = new System.Drawing.Point(66, 31);
			this.txb_surname.Name = "txb_surname";
			this.txb_surname.Size = new System.Drawing.Size(329, 22);
			this.txb_surname.TabIndex = 1;
			this.txb_surname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txb_phone
			// 
			this.txb_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_VetSis, "CUSTOMER.PHONE", true));
			this.txb_phone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_phone.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.txb_phone.Location = new System.Drawing.Point(66, 59);
			this.txb_phone.Mask = "(999) 000-0000";
			this.txb_phone.Name = "txb_phone";
			this.txb_phone.Size = new System.Drawing.Size(329, 22);
			this.txb_phone.TabIndex = 2;
			// 
			// txb_email
			// 
			this.txb_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_VetSis, "CUSTOMER.EMAIL", true));
			this.txb_email.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txb_email.Location = new System.Drawing.Point(66, 87);
			this.txb_email.Name = "txb_email";
			this.txb_email.Size = new System.Drawing.Size(329, 22);
			this.txb_email.TabIndex = 1;
			// 
			// ta_CUSTOMER
			// 
			this.ta_CUSTOMER.ClearBeforeFill = true;
			// 
			// Customer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(404, 547);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Customer";
			this.Text = "Yeni Müşteri";
			this.Load += new System.EventHandler(this.Item_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
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
		private System.Windows.Forms.TextBox txb_surname;
		private System.Windows.Forms.MaskedTextBox txb_phone;
		private System.Windows.Forms.TextBox txb_email;
		private ds_VetSis ds_VetSis;
		private ds_VetSisTableAdapters.ta_CUSTOMER ta_CUSTOMER;
	}
}