using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Winch.Core;

namespace MoreDredge.Patches
{
    [HarmonyPatch(typeof(ShopData), nameof(ShopData.GetNewStock))]
    internal class ShopUpdatePatch
    {
        static void Postfix(ref List<SpatialItemData> __result, ref ShopData __instance)
        {
            __result.Add(GameManager.Instance._itemManager.GetItemDataById<EngineItemData>("moredredge.bigengine"));
        }
    }
}
