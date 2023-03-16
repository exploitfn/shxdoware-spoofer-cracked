using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace KeyAuth
{
	// Token: 0x0200000F RID: 15
	public partial class Login : Form
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00002400 File Offset: 0x00000600
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000023C6 File Offset: 0x000005C6
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000056F0 File Offset: 0x000038F0
		public static bool SubExist(string name)
		{
			return Login.KeyAuthApp.user_data.subscriptions.Exists((api.Data x) => x.subscription == name);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00005738 File Offset: 0x00003938
		private void Login_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
			bool flag = Login.KeyAuthApp.response.message == "invalidver";
			if (flag)
			{
				bool flag2 = !string.IsNullOrEmpty(Login.KeyAuthApp.app_data.downloadLink);
				if (flag2)
				{
					DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
					DialogResult dialogResult2 = dialogResult;
					DialogResult dialogResult3 = dialogResult2;
					if (dialogResult3 != DialogResult.Yes)
					{
						if (dialogResult3 != DialogResult.No)
						{
							MessageBox.Show("Invalid option");
							Environment.Exit(0);
						}
						else
						{
							WebClient webClient = new WebClient();
							string text = Application.ExecutablePath;
							string str = Login.random_string();
							text = text.Replace(".exe", "-" + str + ".exe");
							webClient.DownloadFile(Login.KeyAuthApp.app_data.downloadLink, text);
							Process.Start(text);
							Process.Start(new ProcessStartInfo
							{
								Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
								WindowStyle = ProcessWindowStyle.Hidden,
								CreateNoWindow = true,
								FileName = "cmd.exe"
							});
							Environment.Exit(0);
						}
					}
					else
					{
						Process.Start(Login.KeyAuthApp.app_data.downloadLink);
						Environment.Exit(0);
					}
				}
				MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
				Environment.Exit(0);
			}
			bool flag3 = !Login.KeyAuthApp.response.success;
			if (flag3)
			{
				MessageBox.Show(Login.KeyAuthApp.response.message);
				Environment.Exit(0);
			}
			Login.KeyAuthApp.check();
			this.siticoneLabel1.Text = string.Format("Current Session Validation Status: {0}", Login.KeyAuthApp.response.success);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000590C File Offset: 0x00003B0C
		private static string random_string()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005978 File Offset: 0x00003B78
		private void UpgradeBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.upgrade(this.username.Text, this.key.Text);
			this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000059CC File Offset: 0x00003BCC
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.password.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				Main main = new Main();
				main.Show();
				base.Hide();
			}
			else
			{
				this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005A4C File Offset: 0x00003C4C
		private void RgstrBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.key.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				Main main = new Main();
				main.Show();
				base.Hide();
			}
			else
			{
				this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005AD8 File Offset: 0x00003CD8
		private void LicBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.license(this.key.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				Main main = new Main();
				main.Show();
				base.Hide();
			}
			else
			{
				this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
			}
		}

		// Token: 0x0400004F RID: 79
		public static api KeyAuthApp = new api("spoofer", "o1kT5ZX76N", "de2843e3e42e4836820ed317cb5540e3846dc5cc4b2652a43bc0a3b84096bf58", "1.0");
	}
}
