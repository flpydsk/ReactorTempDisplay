using PulsarModLoader;

namespace ReactorTempDisplay
{
    public class Mod : PulsarMod
	{

		public override string HarmonyIdentifier()
		{
			return "FoppyDisk.ReactorTempDisplay";
		}

		public override string Version
		{
			get
			{
				return "0.1.11";
			}
		}

		public override string Author
		{
			get
			{
				return "FloppyDisk";
			}
		}

		public override string Name
		{
			get
			{
				return "ReactorTempDisplay";
			}
		}

		public override string ShortDescription
		{
			get
			{
				return "Reactor Temperature & Stability Display";
			}
		}

		public override string LongDescription
		{
			get
			{
				return "Licence: GPL 3.0 only";
			}
		}
	}
}
