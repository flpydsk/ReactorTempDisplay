/*
    Reactor Temp Display, Displays the reactor temperature and stability in the HUD for Pulsar Lost Colony.
    Copyright (C) 2023 FloppyDisk
    https://github.com/flpydsk/ReactorTempDisplay.git

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
using PulsarModLoader;

namespace ReactorTempDisplay
{
    public class Mod : PulsarMod
	{
		public override string Version => "1.16";
		public override string Author => "FloppyDisk";
		public override string Name => "ReactorTempDisplay";
        public override string HarmonyIdentifier() => $"{Author}.{Name}";
        public override string ShortDescription => "Reactor Temperature & Stability Display";
		public override string LongDescription => "Licence: GNU GPL-3.0";
    }
}
