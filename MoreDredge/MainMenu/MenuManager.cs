using System;
using MoreDredge.Attributes;
using MoreDredge.UI;
using UnityEngine;
using Winch.Core;

namespace MoreDredge.MainMenu
{
    [AddToMainMenuScene]
    internal class MenuManager : MonoBehaviour
    {
        public void Start()
        {
            try {
            }
            catch (Exception e)
            {
                WinchCore.Log.Error(e);
            }
        }
        private static void LogOutput()
        {
            WinchCore.Log.Info("caca");
        }
    }
}
