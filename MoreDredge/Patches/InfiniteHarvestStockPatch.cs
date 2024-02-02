using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Winch.Core;

namespace MoreDredge.Patches
{
    [HarmonyPatch(typeof(HarvestPOI),nameof(HarvestPOI.OnHarvested))]
    internal class InfiniteHarvestStockPatch
    {
        // A cheat to never run of fishes in harvest point of interest
        public static bool Prefix(HarvestPOI __instance)
        {
            if(__instance.Stock < 10)
            {
                WinchCore.Log.Info("Refilling HarvestPOI");
                __instance.AddStock(10-__instance.Stock);
                FishItemData fishItemData = __instance.harvestable.GetFirstHarvestableItem() as FishItemData;
                WinchCore.Log.Info(fishItemData.GetSize());
            }
            return false;
        }
    }
}
