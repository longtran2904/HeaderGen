#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{
    public readonly struct ProfilerCategoryDescription
    {

        public readonly ushort Id;
        public readonly ushort Flags;
        public readonly Color32 Color;
        public readonly int NameUtf8Len;
        public readonly byte* NameUtf8;

        public string Name { get; }
    }
}
