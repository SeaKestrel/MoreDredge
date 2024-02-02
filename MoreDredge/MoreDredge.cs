using UnityEngine;
using Winch.Core;

namespace MoreDredge
{
	public class MoreDredge : MonoBehaviour
	{
		public static MoreDredge Instance { get; private set; }
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(MoreDredge)} has loaded!");
			Instance = this;
		}
	}
}
