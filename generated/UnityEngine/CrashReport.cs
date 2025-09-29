#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/CrashReport/CrashReport.bindings.h")]
    public sealed class CrashReport
    {
        public readonly DateTime time;
        public readonly string text;

        public static CrashReport[] reports { get; }
        public static CrashReport lastReport { get; }

        public static void RemoveAll();
        public void Remove();
    }
}
