using HarmonyLib;
using UnityEngine;

namespace ReactorTempDisplay
{
    // Token: 0x02000002 RID: 2
    [HarmonyPatch(typeof(PLInGameUI), "Update")]
	internal class TempBarSize
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void Postfix(PLInGameUI __instance)
		{
			bool flag = PLServer.Instance != null;
			if (flag)
			{
				bool flag2 = PLGlobal.Instance != null && PLNetworkManager.Instance != null && PLNetworkManager.Instance.ViewedPawn != null;
				if (flag2)
				{
					__instance.TempFill.rectTransform.SetSizeWithCurrentAnchors(0, 110f);
					int num = Mathf.RoundToInt(Mathf.Clamp01(1f - PLEncounterManager.Instance.PlayerShip.CoreInstability) * 100f);
					bool flag3 = num < 100;
					string text;
					if (flag3)
					{
						text = "S:" + num.ToString("000") + "%";
					}
					else
					{
						text = "T:" + Mathf.RoundToInt(PLEncounterManager.Instance.PlayerShip.MyStats.ReactorTempCurrent / PLEncounterManager.Instance.PlayerShip.MyStats.ReactorTempMax * 100f).ToString("000") + "%";
					}
					PLGlobal.SafeLabelSetText(__instance.TempValueLabel, text);
				}
			}
		}
	}
}
