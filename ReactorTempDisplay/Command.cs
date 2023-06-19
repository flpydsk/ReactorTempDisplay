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
using PulsarModLoader.Chat.Commands.CommandRouter;

namespace ReactorTempDisplay
{
    internal class Command : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[]
            {
                "rtdmode",
                "rtd"
            };
        }
        public override string Description()
        {
            return "Toggle Reactor Temp Display Mode";
        }
        public override void Execute(string arguments)
        {
            //Toggle mode
            ReactorTempDisplay.DisplayType = !ReactorTempDisplay.DisplayType;
            //Save mode to disk
            ReactorTempDisplay.SavedDisplayType.Value = ReactorTempDisplay.DisplayType;
        }
    }
}
