using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace KeyAuth
{
	// Token: 0x0200000E RID: 14
	public partial class Main : Form
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000023A3 File Offset: 0x000005A3
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000023C6 File Offset: 0x000005C6
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000047CC File Offset: 0x000029CC
		private void Main_Load(object sender, EventArgs e)
		{
			this.siticoneLabel1.Text = string.Format("Current Session Validation Status: {0}", true);
			this.key.Text = "Username: t.me/vroomleaks";
			this.expiry.Text = "Expiry: Never";
			this.subscription.Text = "Subscription: CRACKED";
			this.ip.Text = "IP Address: 127.0.0.1";
			this.hwid.Text = "HWID: CRACKED";
			this.createDate.Text = "Creation date: 00:00:00";
			this.lastLogin.Text = "Last login: 00:00:00";
			this.subscriptionDaysLabel.Text = "Expiry in Days: NEVER";
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000023D0 File Offset: 0x000005D0
		public static bool SubExist(string name, int len)
		{
			return true;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004874 File Offset: 0x00002A74
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			try
			{
				result = result.AddSeconds((double)unixtime).ToLocalTime();
			}
			catch
			{
				result = DateTime.MaxValue;
			}
			return result;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000023D3 File Offset: 0x000005D3
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.timer1.Interval = 15000;
			bool flag = !string.IsNullOrEmpty(this.chatchannel);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000023F4 File Offset: 0x000005F4
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000023F4 File Offset: 0x000005F4
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000023F4 File Offset: 0x000005F4
		private void chatmsg_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000023F7 File Offset: 0x000005F7
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			Spoofer.Spoof();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000023F4 File Offset: 0x000005F4
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000039 RID: 57
		private string chatchannel = "testing";
	}
}
