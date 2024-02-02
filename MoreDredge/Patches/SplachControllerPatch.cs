using HarmonyLib;
using Winch.Core;

namespace MoreDredge.Patches
{
    [HarmonyPatch(typeof(SplashController), nameof(SplashController.OnEnable))]
    internal class SplachControllerPatch
    {
        public static bool Prefix()
        {
            WinchCore.Log.Info("Skipping intro");
            GameManager.Instance.Loader.LoadTitleFromStartup();
            return false;
        }
    }
}
