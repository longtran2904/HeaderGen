#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using Unity.Profiling;
using UnityEngine;
using UnityEngine.Scripting;

namespace UnityEditor.Profiling
{
    [RequiredByNativeCode]
    public struct ProfilerCategoryInfo
    {
        public ushort id { get; }
        public Color32 color { get; }
        public string name { get; }
        public ProfilerCategoryFlags flags { get; }
    }
}
