namespace VetProj.Forms
{
	partial class MainPage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dgv_stoklar = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tRANSACTIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ds_VetSis = new VetProj.ds_VetSis();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.ta_TRANSACTIONS = new VetProj.ds_VetSisTableAdapters.ta_TRANSACTIONS();
			this.sale1 = new VetProj.UserControls.Sale();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lbl_username = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_stoklar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_VetSis)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1350, 707);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1342, 681);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Ana Sayfa";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dgv_stoklar);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.sale1);
			this.splitContainer1.Size = new System.Drawing.Size(1336, 675);
			this.splitContainer1.SplitterDistance = 463;
			this.splitContainer1.SplitterWidth = 8;
			this.splitContainer1.TabIndex = 0;
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
            this.TYPE,
            this.DATE,
            this.TOTAL});
			this.dgv_stoklar.DataSource = this.tRANSACTIONSBindingSource;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_stoklar.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_stoklar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_stoklar.Location = new System.Drawing.Point(0, 0);
			this.dgv_stoklar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.dgv_stoklar.MultiSelect = false;
			this.dgv_stoklar.Name = "dgv_stoklar";
			this.dgv_stoklar.ReadOnly = true;
			this.dgv_stoklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_stoklar.Size = new System.Drawing.Size(463, 675);
			this.dgv_stoklar.TabIndex = 1;
			this.dgv_stoklar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stoklar_CellDoubleClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// TYPE
			// 
			this.TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TYPE.DataPropertyName = "TYPE";
			this.TYPE.HeaderText = "İşlem Tipi";
			this.TYPE.Name = "TYPE";
			this.TYPE.ReadOnly = true;
			// 
			// DATE
			// 
			this.DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.DATE.DataPropertyName = "DATE";
			dataGridViewCellStyle2.Format = "F";
			dataGridViewCellStyle2.NullValue = null;
			this.DATE.DefaultCellStyle = dataGridViewCellStyle2;
			this.DATE.HeaderText = "İşlem Tarihi";
			this.DATE.Name = "DATE";
			this.DATE.ReadOnly = true;
			this.DATE.Width = 117;
			// 
			// TOTAL
			// 
			this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.TOTAL.DataPropertyName = "TOTAL";
			dataGridViewCellStyle3.Format = "C2";
			this.TOTAL.DefaultCellStyle = dataGridViewCellStyle3;
			this.TOTAL.HeaderText = "Toplam Tutar";
			this.TOTAL.Name = "TOTAL";
			this.TOTAL.ReadOnly = true;
			this.TOTAL.Width = 127;
			// 
			// tRANSACTIONSBindingSource
			// 
			this.tRANSACTIONSBindingSource.DataMember = "TRANSACTIONS";
			this.tRANSACTIONSBindingSource.DataSource = this.ds_VetSis;
			// 
			// ds_VetSis
			// 
			this.ds_VetSis.DataSetName = "ds_VetSis";
			this.ds_VetSis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1342, 703);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Stoklar";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1342, 703);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Müşteriler";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// ta_TRANSACTIONS
			// 
			this.ta_TRANSACTIONS.ClearBeforeFill = true;
			// 
			// sale1
			// 
			this.sale1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sale1.Location = new System.Drawing.Point(0, 0);
			this.sale1.Name = "sale1";
			this.sale1.Size = new System.Drawing.Size(865, 675);
			this.sale1.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_username,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 707);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbl_username
			// 
			this.lbl_username.Name = "lbl_username";
			this.lbl_username.Size = new System.Drawing.Size(99, 17);
			this.lbl_username.Text = "Abdurrahim Ayaz";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(72, 17);
			this.toolStripStatusLabel2.Text = "Versiyon: 1.1";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(482, 17);
			this.toolStripStatusLabel3.Spring = true;
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(199, 17);
			this.toolStripStatusLabel4.Text = "Tüm Hakları Saklıdır - UgiTek © 2020";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(482, 17);
			this.toolStripStatusLabel5.Spring = true;
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1350, 729);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainPage";
			this.Text = "VetSis © V.1.1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainPage_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_stoklar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tRANSACTIONSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_VetSis)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView dgv_stoklar;
		private ds_VetSis ds_VetSis;
		private System.Windows.Forms.BindingSource tRANSACTIONSBindingSource;
		private ds_VetSisTableAdapters.ta_TRANSACTIONS ta_TRANSACTIONS;
		private UserControls.Sale sale1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_username;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
	}
}