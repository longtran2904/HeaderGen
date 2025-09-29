#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal.Profiling
{
    public static class NetworkingOperationsProfilerOverrides
    {

        public static Action<Rect, int> drawDetailsViewOverride;
        public static Func<List<NetworkCounterData>> getCustomChartCounters;
    }
}
