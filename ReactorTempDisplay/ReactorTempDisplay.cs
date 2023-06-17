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
using HarmonyLib;
using PulsarModLoader;
using UnityEngine;

namespace ReactorTempDisplay
{
    [HarmonyPatch(typeof(PLInGameUI), "Update")]
    internal class ReactorTempDisplay
    {
        //Init mode save and create a copy
        public static SaveValue<bool> SavedDisplayType = new SaveValue<bool>("DisplayType", false);
        public static bool DisplayType = SavedDisplayType.Value;

        private static float BarLength;
        private static string DisplayText;
        private static int Stability;
        private static int Temperature;

        public static void Postfix(PLInGameUI __instance)
        {
            //If we are in a game modify the UI
            if (PLServer.Instance && PLGlobal.Instance && PLNetworkManager.Instance && PLNetworkManager.Instance.ViewedPawn)
            {
                //Check we have a claimed ship else display 0
                if (PLEncounterManager.Instance.PlayerShip)
                {
                    Temperature = Mathf.RoundToInt(PLEncounterManager.Instance.PlayerShip.MyStats.ReactorTempCurrent / PLEncounterManager.Instance.PlayerShip.MyStats.ReactorTempMax * 100f);
                    Stability = Mathf.RoundToInt((1f - PLEncounterManager.Instance.PlayerShip.CoreInstability) * 100f);
                }
                else
                {
                    Stability = 0;
                    Temperature = 0;
                }

                //Put the temperature and stability values in to a string format
                string StabilityText = "S:" + Stability.ToString("000") + "%";
                string TempText = "T:" + Temperature.ToString("000") + "%";
                bool IsNotStable = Stability < 100;

                //Display mode from selection.
                if (DisplayType)
                    {
                        //Display short mode
                        BarLength = 115f;
                        if (IsNotStable)
                        {
                            DisplayText = StabilityText;
                        }
                        else
                        {
                            DisplayText = TempText;
                        }
                    }
                    else
                    {
                        //Display full mode
                        BarLength = 235f;
                        DisplayText = TempText + " | " + StabilityText;
                    }

                //Modify UI element size and text
                __instance.TempFill.rectTransform.SetSizeWithCurrentAnchors(0, BarLength);
                PLGlobal.SafeLabelSetText(__instance.TempValueLabel, DisplayText);
            }
        }
    }
}
