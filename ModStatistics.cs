using System;
using UnityEngine;

namespace ModStatistics
{
    [KSPAddon(KSPAddon.Startup.Instantly, true)]
    internal class ModStatistics : MonoBehaviour
    {
        // The implementation with the highest version number will be allowed to run.
        private static int _version = int.MaxValue;

        static ModStatistics()
        {

        }

        public void Start()
        {
            Debug.Log(String.Format("[ModStatisticsBlocker] Running version {0}", _version));
            DontDestroyOnLoad(this);
        }
   }
}