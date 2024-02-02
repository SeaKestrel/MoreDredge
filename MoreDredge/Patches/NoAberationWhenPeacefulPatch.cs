using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Winch.Core;

namespace MoreDredge.Patches
{
    [HarmonyPatch(typeof(HarvestMinigameView), nameof(HarvestMinigameView.SpawnItem))]
    internal class NoAberationWhenPeacefulPatch
    {
        public static bool Prefix(HarvestMinigameView __instance, bool isTrophy)
        {
            if (GameManager.Instance.SettingsSaveData.CurrentGameMode() != GameMode.PASSIVE) return true;
            bool deductFromStock = true;
            SpatialItemInstance spatialItemInstance = null;
            if (__instance.itemDataToHarvest != null && __instance.itemDataToHarvest.itemSubtype == ItemSubtype.FISH)
            {
                FishAberrationGenerationMode aberrationGenerationMode = FishAberrationGenerationMode.FORBID;
                spatialItemInstance = GameManager.Instance.ItemManager.CreateFishItem(__instance.itemDataToHarvest.id, aberrationGenerationMode, __instance.currentPOI.IsCurrentlySpecial, (!isTrophy) ? FishSizeGenerationMode.NO_BIG_TROPHY : FishSizeGenerationMode.FORCE_BIG_TROPHY);
                deductFromStock = !__instance.itemDataToHarvest.affectedByFishingSustain || UnityEngine.Random.value > GameManager.Instance.PlayerStats.ResearchedFishingSustainModifier;
                if (spatialItemInstance.GetItemData<FishItemData>().IsAberration)
                {
                    __instance.currentPOI.SetIsCurrentlySpecial(val: false);
                }
                GameManager.Instance.SaveData.FishUntilNextTrophyNotch--;
                GameManager.Instance.SaveData.RodFishCaught++;
                __instance.currentPOI.OnHarvested(deductFromStock);
                GameManager.Instance.GridManager.AddItemOfTypeToCursor(spatialItemInstance, GridObjectState.BEING_HARVESTED);
                GameManager.Instance.ItemManager.SetItemSeen(spatialItemInstance);
                GameEvents.Instance.TriggerFishCaught();
                __instance.itemDataToHarvest = null;
                return false;
            }

            return true;
        }
    }
}