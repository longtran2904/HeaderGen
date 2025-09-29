#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.PackageManager
{
    [NativeAsStruct]
    [RequiredByNativeCode]
    public class VersionsInfo
    {
        public string[] all { get; }
        public string[] compatible { get; }
        public string verified { get; }
        [Obsolete("'recommended' is obsolete; use 'verified' instead. (UnityUpgradable) -> verified", False)]
        public string recommended { get; }
        public string latest { get; }
        public string latestCompatible { get; }
    }
}
