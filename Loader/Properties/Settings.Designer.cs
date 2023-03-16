using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace KeyAuth.Properties
{
	// Token: 0x02000014 RID: 20
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000071D8 File Offset: 0x000053D8
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000063 RID: 99
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
