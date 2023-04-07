//Copyright 2023 (c) Floppydisk
//GPL 3.0-only
using PulsarModLoader;
using PulsarModLoader.Keybinds;

namespace ReactorTempDisplay
{
    public class Mod : PulsarMod, IKeybind
	{

		public override string Version
		{
			get
			{
				return "1.13";
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

        public override string HarmonyIdentifier()
        {
            return $"{Author}.{Name}";
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
        public void RegisterBinds(KeybindManager manager)
        {
            manager.NewBind("Toggle Display Mode", "ToggleDisplayMode", "Basics", "Y");
        }
    }
}
