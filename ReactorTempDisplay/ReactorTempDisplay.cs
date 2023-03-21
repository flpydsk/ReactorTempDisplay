using HarmonyLib;
using PulsarModLoader;
using PulsarModLoader.Keybinds;
using UnityEngine;

namespace ReactorTempDisplay
{

    [HarmonyPatch(typeof(PLInGameUI), "Update")]
	internal class ReactorTempDisplay
	{
        static SaveValue<bool> SavedDisplayType = new SaveValue<bool>("DisplayType", false);
        private static bool DisplayType = SavedDisplayType.Value;
        public static void Postfix(PLInGameUI __instance)
		{

            //If we are in a game then override the temp bar
            if (PLServer.Instance && PLGlobal.Instance && PLNetworkManager.Instance && PLNetworkManager.Instance.ViewedPawn)
			{
                string TempText = "T:" + Mathf.Clamp(Mathf.RoundToInt(PLEncounterManager.Instance.PlayerShip.MyStats.ReactorTempCurrent / PLEncounterManager.Instance.PlayerShip.MyStats.ReactorTempMax * 100f), 0, 100).ToString("000") + "%";
                int Stability = Mathf.RoundToInt(Mathf.Clamp01(1f - PLEncounterManager.Instance.PlayerShip.CoreInstability) * 100f);
                string StabilityText = "S:" + Stability.ToString("000") + "%";
                bool IsNotStable = Stability < 100;
				string DisplayText;

                // If player presses display mode toggle bind then switch mode
                if (KeybindManager.Instance.GetButtonDown("ToggleDisplayMode"))
				{
					DisplayType = !DisplayType;
					SavedDisplayType.Value = DisplayType;
				}

				//Depending on display mode, display correct option
				if (DisplayType)
				{
					//Displays in short mode, switches baste on status of reactor
					BarLength = 110f;
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
					//display all at the same time
					BarLength = 230f;
					DisplayText = TempText + " | " + StabilityText;

                }

                // set size of bar baste on 
                __instance.TempFill.rectTransform.SetSizeWithCurrentAnchors(0, BarLength);
				PLGlobal.SafeLabelSetText(__instance.TempValueLabel, DisplayText);
			}
		}
		private static float BarLength;
    }
}
