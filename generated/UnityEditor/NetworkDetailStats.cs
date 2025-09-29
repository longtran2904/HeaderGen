#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Obsolete("This profiler helper class is deprecated, it's here to support the high level API package until it no longer depends on it and will then be removed.")]
    public class NetworkDetailStats
    {

        public NetworkDetailStats();

        public static void NewProfilerTick(float newTime);
        public static void SetStat(NetworkDirection direction, short msgId, string entryName, int amount);
        public static void IncrementStat(NetworkDirection direction, short msgId, string entryName, int amount);
        public static void ResetAll();
        public enum NetworkDirection
        {

            Incoming = 0,
            Outgoing = 1
        }
    }
}
