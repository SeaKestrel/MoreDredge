using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace MoreDredge.Patches
{
    [HarmonyPatch(typeof(PlayerSanity), nameof(PlayerSanity.Update))]
    internal class PlayerSanityPatch
    {
        // Using this patch to make the player sanity null when in peacefull mode
        public static bool Prefix(PlayerSanity __instance)
        {
            if(GameManager.Instance.SettingsSaveData.CurrentGameMode() == GameMode.PASSIVE)
            {
                __instance._sanity = 1;
                return false;
            }
            return true;
        }
    }
}
