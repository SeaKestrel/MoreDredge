using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace MoreDredge.Patches
{
    [HarmonyPatch(typeof(RestDestinationUI), nameof(RestDestinationUI.ShowMainUI))]
    internal class RestDestinationUIPatch
    {
        public static bool Prefix(ref RestDestinationUI __instance)
        {
            return true;
        }
    }
}
