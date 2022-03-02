using PulsarModLoader;

namespace ReactorTempDisplay
{
    // Token: 0x02000003 RID: 3
    public class Mod : PulsarMod
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002180 File Offset: 0x00000380
		public override string HarmonyIdentifier()
		{
			return "FLoppyDisk.ReactorTempDisplay";
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002197 File Offset: 0x00000397
		public override string Version
		{
			get
			{
				return "0.1.10";
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000219E File Offset: 0x0000039E
		public override string Author
		{
			get
			{
				return "FloppyDisk";
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000021A5 File Offset: 0x000003A5
		public override string Name
		{
			get
			{
				return "ReactorTempDisplay";
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000021AC File Offset: 0x000003AC
		public override string ShortDescription
		{
			get
			{
				return "Reactor Temperature & Stability Display";
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000021B3 File Offset: 0x000003B3
		public override string LongDescription
		{
			get
			{
				return "Licence: Anyone may use this mod or re-distribute this mod in its origional form with credit. Modification is allowed with concent from FloppyDisk via discord or email flpydsk@pm.me";
			}
		}
	}
}
