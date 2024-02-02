using HarmonyLib;
using MoreDredge.Libs;
using MoreDredge.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using Winch.Core;

namespace MoreDredge
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(MoreDredge));
			gameObject.AddComponent<MoreDredge>();
			gameObject.AddComponent<CustomSceneManager>();
			gameObject.AddComponent<UIHelper>();
            GameObject.DontDestroyOnLoad(gameObject);
			GameManager.Instance._prodGameConfigData.hourDurationInSeconds = 24;
            new Harmony("com.dredge.moredredge").PatchAll();
        }
	}
}