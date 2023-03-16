namespace KeyAuth
{
	// Token: 0x0200000F RID: 15
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00005B4C File Offset: 0x00003D4C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005B88 File Offset: 0x00003D88
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.LoginBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.key = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.username = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.password = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.RgstrBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.UpgradeBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.LicBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.status = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel1 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(283, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = 0;
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(237, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new global::System.Drawing.Point(10, 11);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(90, 19);
			this.label2.TabIndex = 27;
			this.label2.Text = "ShxdowWare Login";
			this.LoginBtn.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.LoginBtn.BorderThickness = 1;
			this.LoginBtn.CheckedState.Parent = this.LoginBtn;
			this.LoginBtn.CustomImages.Parent = this.LoginBtn;
			this.LoginBtn.FillColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.LoginBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LoginBtn.ForeColor = global::System.Drawing.Color.White;
			this.LoginBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.LoginBtn.HoveredState.Parent = this.LoginBtn;
			this.LoginBtn.Location = new global::System.Drawing.Point(12, 167);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
			this.LoginBtn.Size = new global::System.Drawing.Size(151, 27);
			this.LoginBtn.TabIndex = 26;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.Click += new global::System.EventHandler(this.LoginBtn_Click);
			this.key.AllowDrop = true;
			this.key.BorderColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.key.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.key.DefaultText = "Key";
			this.key.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.key.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.key.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.DisabledState.Parent = this.key;
			this.key.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.key.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.FocusedState.Parent = this.key;
			this.key.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.HoveredState.Parent = this.key;
			this.key.Location = new global::System.Drawing.Point(48, 130);
			this.key.Margin = new global::System.Windows.Forms.Padding(4);
			this.key.Name = "key";
			this.key.PasswordChar = '\0';
			this.key.PlaceholderText = "";
			this.key.SelectedText = "";
			this.key.ShadowDecoration.Parent = this.key;
			this.key.Size = new global::System.Drawing.Size(236, 30);
			this.key.TabIndex = 32;
			this.key.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.username.AllowDrop = true;
			this.username.BorderColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.username.DefaultText = "Username";
			this.username.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.username.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.username.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.DisabledState.Parent = this.username;
			this.username.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.username.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.username.FocusedState.Parent = this.username;
			this.username.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.username.HoveredState.Parent = this.username;
			this.username.Location = new global::System.Drawing.Point(48, 54);
			this.username.Margin = new global::System.Windows.Forms.Padding(4);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderText = "";
			this.username.SelectedText = "";
			this.username.ShadowDecoration.Parent = this.username;
			this.username.Size = new global::System.Drawing.Size(236, 30);
			this.username.TabIndex = 33;
			this.username.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.password.AllowDrop = true;
			this.password.BorderColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.password.DefaultText = "Password";
			this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.Parent = this.password;
			this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.password.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.FocusedState.Parent = this.password;
			this.password.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.HoveredState.Parent = this.password;
			this.password.Location = new global::System.Drawing.Point(48, 92);
			this.password.Margin = new global::System.Windows.Forms.Padding(4);
			this.password.Name = "password";
			this.password.PasswordChar = '\0';
			this.password.PlaceholderText = "";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(236, 30);
			this.password.TabIndex = 34;
			this.password.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.RgstrBtn.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.RgstrBtn.BorderThickness = 1;
			this.RgstrBtn.CheckedState.Parent = this.RgstrBtn;
			this.RgstrBtn.CustomImages.Parent = this.RgstrBtn;
			this.RgstrBtn.FillColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.RgstrBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RgstrBtn.ForeColor = global::System.Drawing.Color.White;
			this.RgstrBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.RgstrBtn.HoveredState.Parent = this.RgstrBtn;
			this.RgstrBtn.Location = new global::System.Drawing.Point(169, 167);
			this.RgstrBtn.Name = "RgstrBtn";
			this.RgstrBtn.ShadowDecoration.Parent = this.RgstrBtn;
			this.RgstrBtn.Size = new global::System.Drawing.Size(153, 27);
			this.RgstrBtn.TabIndex = 35;
			this.RgstrBtn.Text = "Register";
			this.RgstrBtn.Click += new global::System.EventHandler(this.RgstrBtn_Click);
			this.UpgradeBtn.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.UpgradeBtn.BorderThickness = 1;
			this.UpgradeBtn.CheckedState.Parent = this.UpgradeBtn;
			this.UpgradeBtn.CustomImages.Parent = this.UpgradeBtn;
			this.UpgradeBtn.FillColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.UpgradeBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.UpgradeBtn.ForeColor = global::System.Drawing.Color.White;
			this.UpgradeBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.UpgradeBtn.HoveredState.Parent = this.UpgradeBtn;
			this.UpgradeBtn.Location = new global::System.Drawing.Point(12, 200);
			this.UpgradeBtn.Name = "UpgradeBtn";
			this.UpgradeBtn.ShadowDecoration.Parent = this.UpgradeBtn;
			this.UpgradeBtn.Size = new global::System.Drawing.Size(151, 27);
			this.UpgradeBtn.TabIndex = 36;
			this.UpgradeBtn.Text = "Upgrade";
			this.UpgradeBtn.Click += new global::System.EventHandler(this.UpgradeBtn_Click);
			this.LicBtn.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.LicBtn.BorderThickness = 1;
			this.LicBtn.CheckedState.Parent = this.LicBtn;
			this.LicBtn.CustomImages.Parent = this.LicBtn;
			this.LicBtn.FillColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.LicBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LicBtn.ForeColor = global::System.Drawing.Color.White;
			this.LicBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.LicBtn.HoveredState.Parent = this.LicBtn;
			this.LicBtn.Location = new global::System.Drawing.Point(169, 200);
			this.LicBtn.Name = "LicBtn";
			this.LicBtn.ShadowDecoration.Parent = this.LicBtn;
			this.LicBtn.Size = new global::System.Drawing.Size(153, 27);
			this.LicBtn.TabIndex = 37;
			this.LicBtn.Text = "License";
			this.LicBtn.Click += new global::System.EventHandler(this.LicBtn_Click);
			this.status.AutoSize = false;
			this.status.BackColor = global::System.Drawing.Color.Transparent;
			this.status.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.status.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.status.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.status.Location = new global::System.Drawing.Point(0, 302);
			this.status.Margin = new global::System.Windows.Forms.Padding(2);
			this.status.Name = "status";
			this.status.Size = new global::System.Drawing.Size(332, 42);
			this.status.TabIndex = 38;
			this.status.Text = "Status: Awaiting login";
			this.status.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.siticoneLabel1.AutoSize = false;
			this.siticoneLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneLabel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneLabel1.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Bold);
			this.siticoneLabel1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.siticoneLabel1.Location = new global::System.Drawing.Point(0, 260);
			this.siticoneLabel1.Margin = new global::System.Windows.Forms.Padding(2);
			this.siticoneLabel1.Name = "siticoneLabel1";
			this.siticoneLabel1.Size = new global::System.Drawing.Size(332, 42);
			this.siticoneLabel1.TabIndex = 39;
			this.siticoneLabel1.Text = "Current Session Validation Status: \r\n";
			this.siticoneLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			base.ClientSize = new global::System.Drawing.Size(332, 344);
			base.Controls.Add(this.siticoneLabel1);
			base.Controls.Add(this.status);
			base.Controls.Add(this.LicBtn);
			base.Controls.Add(this.UpgradeBtn);
			base.Controls.Add(this.RgstrBtn);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.key);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.LoginBtn);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Login_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000050 RID: 80
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000051 RID: 81
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000052 RID: 82
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000053 RID: 83
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000056 RID: 86
		private global::Siticone.UI.WinForms.SiticoneRoundedButton LoginBtn;

		// Token: 0x04000057 RID: 87
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000058 RID: 88
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox key;

		// Token: 0x04000059 RID: 89
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox password;

		// Token: 0x0400005A RID: 90
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox username;

		// Token: 0x0400005B RID: 91
		private global::Siticone.UI.WinForms.SiticoneRoundedButton LicBtn;

		// Token: 0x0400005C RID: 92
		private global::Siticone.UI.WinForms.SiticoneRoundedButton UpgradeBtn;

		// Token: 0x0400005D RID: 93
		private global::Siticone.UI.WinForms.SiticoneRoundedButton RgstrBtn;

		// Token: 0x0400005E RID: 94
		private global::Siticone.UI.WinForms.SiticoneLabel status;

		// Token: 0x0400005F RID: 95
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
	}
}
