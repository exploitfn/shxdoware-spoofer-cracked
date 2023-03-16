namespace KeyAuth
{
	// Token: 0x0200000E RID: 14
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000094 RID: 148 RVA: 0x000048CC File Offset: 0x00002ACC
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

		// Token: 0x06000095 RID: 149 RVA: 0x00004908 File Offset: 0x00002B08
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.key = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.expiry = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.subscription = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.ip = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.hwid = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.createDate = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.lastLogin = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.subscriptionDaysLabel = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel1 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.siticoneRoundedButton1 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(531, 1);
			this.siticoneControlBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(60, 36);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = 0;
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(482, 0);
			this.siticoneControlBox2.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(53, 36);
			this.siticoneControlBox2.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 167);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 23);
			this.label1.TabIndex = 22;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new global::System.Drawing.Point(23, 14);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(117, 20);
			this.label2.TabIndex = 27;
			this.label2.Text = "ShxdowWare";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.key.BackColor = global::System.Drawing.Color.Transparent;
			this.key.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.key.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.key.Location = new global::System.Drawing.Point(27, 74);
			this.key.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.key.Name = "key";
			this.key.Size = new global::System.Drawing.Size(96, 19);
			this.key.TabIndex = 37;
			this.key.Text = "usernameLabel";
			this.expiry.BackColor = global::System.Drawing.Color.Transparent;
			this.expiry.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.expiry.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.expiry.Location = new global::System.Drawing.Point(27, 97);
			this.expiry.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(74, 19);
			this.expiry.TabIndex = 38;
			this.expiry.Text = "expiryLabel";
			this.subscription.BackColor = global::System.Drawing.Color.Transparent;
			this.subscription.Location = new global::System.Drawing.Point(0, 0);
			this.subscription.Margin = new global::System.Windows.Forms.Padding(4);
			this.subscription.Name = "subscription";
			this.subscription.Size = new global::System.Drawing.Size(3, 2);
			this.subscription.TabIndex = 65;
			this.subscription.Text = null;
			this.createDate.BackColor = global::System.Drawing.Color.Transparent;
			this.createDate.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.createDate.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.createDate.Location = new global::System.Drawing.Point(27, 120);
			this.createDate.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.createDate.Name = "createDate";
			this.createDate.Size = new global::System.Drawing.Size(102, 19);
			this.createDate.TabIndex = 46;
			this.createDate.Text = "createDateLabel";
			this.lastLogin.BackColor = global::System.Drawing.Color.Transparent;
			this.lastLogin.Location = new global::System.Drawing.Point(0, 0);
			this.lastLogin.Margin = new global::System.Windows.Forms.Padding(4);
			this.lastLogin.Name = "lastLogin";
			this.lastLogin.Size = new global::System.Drawing.Size(3, 2);
			this.lastLogin.TabIndex = 62;
			this.lastLogin.Text = null;
			this.subscriptionDaysLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.subscriptionDaysLabel.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.subscriptionDaysLabel.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.subscriptionDaysLabel.Location = new global::System.Drawing.Point(27, 143);
			this.subscriptionDaysLabel.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.subscriptionDaysLabel.Name = "subscriptionDaysLabel";
			this.subscriptionDaysLabel.Size = new global::System.Drawing.Size(142, 19);
			this.subscriptionDaysLabel.TabIndex = 53;
			this.subscriptionDaysLabel.Text = "subscriptionDaysLabel";
			this.siticoneLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.siticoneLabel1.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneLabel1.Name = "siticoneLabel1";
			this.siticoneLabel1.Size = new global::System.Drawing.Size(3, 2);
			this.siticoneLabel1.TabIndex = 61;
			this.siticoneLabel1.Text = null;
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.siticoneRoundedButton1.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.siticoneRoundedButton1.BorderThickness = 1;
			this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.FillColor = global::System.Drawing.Color.LimeGreen;
			this.siticoneRoundedButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(296, 55);
			this.siticoneRoundedButton1.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(212, 38);
			this.siticoneRoundedButton1.TabIndex = 54;
			this.siticoneRoundedButton1.Text = "Spoof";
			this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.label4.Location = new global::System.Drawing.Point(24, 181);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(215, 17);
			this.label4.TabIndex = 57;
			this.label4.Text = "Undetected = Green Buttons";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.Red;
			this.label5.Location = new global::System.Drawing.Point(24, 246);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(181, 17);
			this.label5.TabIndex = 58;
			this.label5.Text = "Detected = Red Buttons";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.Yellow;
			this.label6.Location = new global::System.Drawing.Point(24, 217);
			this.label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(187, 17);
			this.label6.TabIndex = 59;
			this.label6.Text = "Testing = Yellow Buttons";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			base.ClientSize = new global::System.Drawing.Size(593, 289);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.siticoneRoundedButton1);
			base.Controls.Add(this.subscriptionDaysLabel);
			base.Controls.Add(this.siticoneLabel1);
			base.Controls.Add(this.lastLogin);
			base.Controls.Add(this.createDate);
			base.Controls.Add(this.subscription);
			base.Controls.Add(this.expiry);
			base.Controls.Add(this.key);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "uuuu";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Main_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003A RID: 58
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003B RID: 59
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400003C RID: 60
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400003D RID: 61
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000040 RID: 64
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000041 RID: 65
		private global::Siticone.UI.WinForms.SiticoneLabel subscription;

		// Token: 0x04000042 RID: 66
		private global::Siticone.UI.WinForms.SiticoneLabel expiry;

		// Token: 0x04000043 RID: 67
		private global::Siticone.UI.WinForms.SiticoneLabel key;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000045 RID: 69
		private global::Siticone.UI.WinForms.SiticoneLabel ip;

		// Token: 0x04000046 RID: 70
		private global::Siticone.UI.WinForms.SiticoneLabel hwid;

		// Token: 0x04000047 RID: 71
		private global::Siticone.UI.WinForms.SiticoneLabel createDate;

		// Token: 0x04000048 RID: 72
		private global::Siticone.UI.WinForms.SiticoneLabel lastLogin;

		// Token: 0x04000049 RID: 73
		private global::Siticone.UI.WinForms.SiticoneLabel subscriptionDaysLabel;

		// Token: 0x0400004A RID: 74
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;

		// Token: 0x0400004B RID: 75
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label4;
	}
}
