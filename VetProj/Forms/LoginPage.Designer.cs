namespace VetProj
{
	partial class LoginPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
			this.tlp_background = new System.Windows.Forms.TableLayoutPanel();
			this.pbx_logo = new System.Windows.Forms.PictureBox();
			this.tlp_background2 = new System.Windows.Forms.TableLayoutPanel();
			this.lbl_header1 = new System.Windows.Forms.Label();
			this.lbl_header2 = new System.Windows.Forms.Label();
			this.tlp_background3 = new System.Windows.Forms.TableLayoutPanel();
			this.lbl_username = new System.Windows.Forms.Label();
			this.lbl_password = new System.Windows.Forms.Label();
			this.txb_username = new System.Windows.Forms.TextBox();
			this.txb_password = new System.Windows.Forms.TextBox();
			this.tlp_background4 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_login = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.tlp_background.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
			this.tlp_background2.SuspendLayout();
			this.tlp_background3.SuspendLayout();
			this.tlp_background4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlp_background
			// 
			this.tlp_background.ColumnCount = 2;
			this.tlp_background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.25F));
			this.tlp_background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.75F));
			this.tlp_background.Controls.Add(this.pbx_logo, 0, 0);
			this.tlp_background.Controls.Add(this.tlp_background2, 1, 0);
			this.tlp_background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_background.Location = new System.Drawing.Point(0, 0);
			this.tlp_background.Name = "tlp_background";
			this.tlp_background.RowCount = 1;
			this.tlp_background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
			this.tlp_background.Size = new System.Drawing.Size(539, 223);
			this.tlp_background.TabIndex = 0;
			// 
			// pbx_logo
			// 
			this.pbx_logo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbx_logo.Image = global::VetProj.Properties.Resources.VetLogo;
			this.pbx_logo.Location = new System.Drawing.Point(18, 18);
			this.pbx_logo.Margin = new System.Windows.Forms.Padding(18);
			this.pbx_logo.Name = "pbx_logo";
			this.pbx_logo.Size = new System.Drawing.Size(153, 187);
			this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbx_logo.TabIndex = 0;
			this.pbx_logo.TabStop = false;
			// 
			// tlp_background2
			// 
			this.tlp_background2.ColumnCount = 1;
			this.tlp_background2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_background2.Controls.Add(this.lbl_header1, 0, 0);
			this.tlp_background2.Controls.Add(this.lbl_header2, 0, 1);
			this.tlp_background2.Controls.Add(this.tlp_background3, 0, 2);
			this.tlp_background2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_background2.Location = new System.Drawing.Point(192, 3);
			this.tlp_background2.Name = "tlp_background2";
			this.tlp_background2.RowCount = 3;
			this.tlp_background2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlp_background2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlp_background2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_background2.Size = new System.Drawing.Size(344, 217);
			this.tlp_background2.TabIndex = 1;
			// 
			// lbl_header1
			// 
			this.lbl_header1.AutoSize = true;
			this.lbl_header1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_header1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_header1.ForeColor = System.Drawing.Color.White;
			this.lbl_header1.Location = new System.Drawing.Point(3, 20);
			this.lbl_header1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
			this.lbl_header1.Name = "lbl_header1";
			this.lbl_header1.Size = new System.Drawing.Size(338, 23);
			this.lbl_header1.TabIndex = 0;
			this.lbl_header1.Text = "XXX Veteriner Hekimliği";
			this.lbl_header1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lbl_header2
			// 
			this.lbl_header2.AutoSize = true;
			this.lbl_header2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_header2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_header2.ForeColor = System.Drawing.Color.White;
			this.lbl_header2.Location = new System.Drawing.Point(3, 43);
			this.lbl_header2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
			this.lbl_header2.Name = "lbl_header2";
			this.lbl_header2.Size = new System.Drawing.Size(338, 22);
			this.lbl_header2.TabIndex = 0;
			this.lbl_header2.Text = "Cari Takip Sistemi";
			this.lbl_header2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tlp_background3
			// 
			this.tlp_background3.ColumnCount = 2;
			this.tlp_background3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlp_background3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_background3.Controls.Add(this.lbl_username, 0, 0);
			this.tlp_background3.Controls.Add(this.lbl_password, 0, 1);
			this.tlp_background3.Controls.Add(this.txb_username, 1, 0);
			this.tlp_background3.Controls.Add(this.txb_password, 1, 1);
			this.tlp_background3.Controls.Add(this.tlp_background4, 1, 2);
			this.tlp_background3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_background3.Location = new System.Drawing.Point(3, 105);
			this.tlp_background3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
			this.tlp_background3.Name = "tlp_background3";
			this.tlp_background3.RowCount = 3;
			this.tlp_background3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlp_background3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlp_background3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_background3.Size = new System.Drawing.Size(338, 109);
			this.tlp_background3.TabIndex = 1;
			// 
			// lbl_username
			// 
			this.lbl_username.AutoSize = true;
			this.lbl_username.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_username.ForeColor = System.Drawing.Color.White;
			this.lbl_username.Location = new System.Drawing.Point(3, 0);
			this.lbl_username.Name = "lbl_username";
			this.lbl_username.Size = new System.Drawing.Size(90, 26);
			this.lbl_username.TabIndex = 0;
			this.lbl_username.Text = "Kullanıcı Adı:";
			this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_password
			// 
			this.lbl_password.AutoSize = true;
			this.lbl_password.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_password.ForeColor = System.Drawing.Color.White;
			this.lbl_password.Location = new System.Drawing.Point(3, 26);
			this.lbl_password.Name = "lbl_password";
			this.lbl_password.Size = new System.Drawing.Size(90, 26);
			this.lbl_password.TabIndex = 1;
			this.lbl_password.Text = "Şifre:";
			this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txb_username
			// 
			this.txb_username.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_username.Location = new System.Drawing.Point(99, 3);
			this.txb_username.Name = "txb_username";
			this.txb_username.Size = new System.Drawing.Size(236, 20);
			this.txb_username.TabIndex = 2;
			this.txb_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_username_KeyDown);
			// 
			// txb_password
			// 
			this.txb_password.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_password.Location = new System.Drawing.Point(99, 29);
			this.txb_password.Name = "txb_password";
			this.txb_password.Size = new System.Drawing.Size(236, 20);
			this.txb_password.TabIndex = 3;
			this.txb_password.UseSystemPasswordChar = true;
			this.txb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_password_KeyDown);
			// 
			// tlp_background4
			// 
			this.tlp_background4.ColumnCount = 2;
			this.tlp_background4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_background4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_background4.Controls.Add(this.btn_login, 0, 0);
			this.tlp_background4.Controls.Add(this.btn_cancel, 1, 0);
			this.tlp_background4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_background4.Location = new System.Drawing.Point(96, 52);
			this.tlp_background4.Margin = new System.Windows.Forms.Padding(0);
			this.tlp_background4.Name = "tlp_background4";
			this.tlp_background4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.tlp_background4.RowCount = 1;
			this.tlp_background4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_background4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
			this.tlp_background4.Size = new System.Drawing.Size(242, 57);
			this.tlp_background4.TabIndex = 4;
			// 
			// btn_login
			// 
			this.btn_login.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_login.ForeColor = System.Drawing.Color.White;
			this.btn_login.Location = new System.Drawing.Point(18, 3);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(107, 31);
			this.btn_login.TabIndex = 0;
			this.btn_login.Text = "Giriş";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_cancel.ForeColor = System.Drawing.Color.White;
			this.btn_cancel.Location = new System.Drawing.Point(131, 3);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(108, 31);
			this.btn_cancel.TabIndex = 1;
			this.btn_cancel.Text = "İptal";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// LoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(19)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(539, 223);
			this.ControlBox = false;
			this.Controls.Add(this.tlp_background);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.tlp_background.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
			this.tlp_background2.ResumeLayout(false);
			this.tlp_background2.PerformLayout();
			this.tlp_background3.ResumeLayout(false);
			this.tlp_background3.PerformLayout();
			this.tlp_background4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlp_background;
		private System.Windows.Forms.PictureBox pbx_logo;
		private System.Windows.Forms.TableLayoutPanel tlp_background2;
		private System.Windows.Forms.Label lbl_header1;
		private System.Windows.Forms.Label lbl_header2;
		private System.Windows.Forms.TableLayoutPanel tlp_background3;
		private System.Windows.Forms.Label lbl_username;
		private System.Windows.Forms.Label lbl_password;
		private System.Windows.Forms.TextBox txb_username;
		private System.Windows.Forms.TextBox txb_password;
		private System.Windows.Forms.TableLayoutPanel tlp_background4;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.Button btn_cancel;
	}
}

