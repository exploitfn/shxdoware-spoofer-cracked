using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace KeyAuth.Properties
{
	// Token: 0x02000013 RID: 19
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00002462 File Offset: 0x00000662
		internal Resources()
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00007178 File Offset: 0x00005378
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("KeyAuth.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000071C0 File Offset: 0x000053C0
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000246C File Offset: 0x0000066C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000061 RID: 97
		private static ResourceManager resourceMan;

		// Token: 0x04000062 RID: 98
		private static CultureInfo resourceCulture;
	}
}
