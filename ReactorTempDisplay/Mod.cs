//Copyright 2023 (c) Floppydisk
//GPL 3.0-only
using PulsarModLoader;

namespace ReactorTempDisplay
{
    public class Mod : PulsarMod
	{
		public override string Version => "1.14";
		public override string Author => "FloppyDisk";
		public override string Name => "ReactorTempDisplay";
        public override string HarmonyIdentifier() => $"{Author}.{Name}";
        public override string ShortDescription => "Reactor Temperature & Stability Display";
		public override string LongDescription => "Licence: GPL 3.0 only";
    }
}
