//Copyright 2023 (c) Floppydisk
//GPL 3.0-only
using PulsarModLoader.Chat.Commands.CommandRouter;
using PulsarModLoader.Keybinds;

namespace ReactorTempDisplay
{
    internal class Command : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[]
            {
                "rtdmode"
            };
        }

        public override string Description()
        {
            return "Toggle the mode of Reactor temp display";
        }

        public override void Execute(string arguments)
        {
            ReactorTempDisplay.DisplayType = !ReactorTempDisplay.DisplayType;
            ReactorTempDisplay.SavedDisplayType.Value = ReactorTempDisplay.DisplayType;
        }
    }
}
