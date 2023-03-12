using HarmonyLib;
using UnityEngine;

namespace ReactorTempDisplay
{

    [HarmonyPatch(typeof(PLInGameUI), "Update")]
	internal class ReactorTempDisplay
	{
		public static void Postfix(PLInGameUI __instance)
		{
			//If we are in a game then override the temp bar
			if (PLServer.Instance && PLGlobal.Instance && PLNetworkManager.Instance && PLNetworkManager.Instance.ViewedPawn)
			{
				__instance.TempFill.rectTransform.SetSizeWithCurrentAnchors(0, 110f);
				int Stability = Mathf.RoundToInt(Mathf.Clamp01(1f - PLEncounterManager.Instance.PlayerShip.CoreInstability) * 100f);
				bool IsStable = Stability < 100;
				string DisplayText;
				if (IsStable)
				{
					DisplayText = "S:" + Stability.ToString("000") + "%";
				}
				else
				{
					DisplayText = "T:" + Mathf.RoundToInt(PLEncounterManager.Instance.PlayerShip.MyStats.ReactorTempCurrent / PLEncounterManager.Instance.PlayerShip.MyStats.ReactorTempMax * 100f).ToString("000") + "%";
				}
				PLGlobal.SafeLabelSetText(__instance.TempValueLabel, DisplayText);
			}
		}
	}
}
