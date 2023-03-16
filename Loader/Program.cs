using System;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000012 RID: 18
	internal static class Program
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x0000244B File Offset: 0x0000064B
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
