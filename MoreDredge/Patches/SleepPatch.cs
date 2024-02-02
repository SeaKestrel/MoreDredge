using MoreDredge.Attributes;
using UnityEngine;
using Winch.Core;

namespace MoreDredge.Patches
{
    [AddToGameScene]
    internal class SleepPatch : MonoBehaviour
    {
        /*void Awake()
        {
            GameEvents.Instance.OnTimeForcefullyPassingChanged += OnTimeForcefullyPassingChanged;

        }
        private void toTime(float hour)
        {
            float num = 0f;
            float time = GameManager.Instance.Time.Time;
            float num2 = hour / 24f;
            num = ((!(time >= num2)) ? (num2 - time) : (num2 + (1f - time)));
            float hours = num / (1f / 24f);
            WinchCore.Log.Info("Hours -> " + hours);
            WinchCore.Log.Info("num -> " + num);
            GameManager.Instance.Time.ForcefullyPassTime(hours, "feedback.pass-time-rest", TimePassageMode.SLEEP);
        }
        private void OnTimeForcefullyPassingChanged(bool isForcefullyPassing, string reason, TimePassageMode mode)
        {
            WinchCore.Log.Info($"TimeForcefullyPassingChanged {isForcefullyPassing} {mode}");
            if (isForcefullyPassing && mode == TimePassageMode.SLEEP)
            {
                if(GameManager.Instance.Time.Time < (20f / 24f))
                {
                    toTime(20f);
                }
                GameEvents.Instance.OnTimeForcefullyPassingChanged -= OnTimeForcefullyPassingChanged;
            }
        }*/
    }
}
