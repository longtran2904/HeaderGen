#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting;

namespace Unity.Profiling
{
    [UsedByNativeCode]
    public readonly struct ProfilerCategory
    {
        public ProfilerCategory(string categoryName);
        public ProfilerCategory(string categoryName, ProfilerCategoryColor color);

        public string Name { get; }
        public Color32 Color { get; }
        public static ProfilerCategory Render { get; }
        public static ProfilerCategory Scripts { get; }
        public static ProfilerCategory Gui { get; }
        public static ProfilerCategory Physics { get; }
        public static ProfilerCategory Animation { get; }
        public static ProfilerCategory Ai { get; }
        public static ProfilerCategory Audio { get; }
        public static ProfilerCategory Video { get; }
        public static ProfilerCategory Particles { get; }
        public static ProfilerCategory Lighting { get; }
        public static ProfilerCategory Network { get; }
        public static ProfilerCategory Loading { get; }
        public static ProfilerCategory Vr { get; }
        public static ProfilerCategory Input { get; }
        public static ProfilerCategory Memory { get; }
        public static ProfilerCategory VirtualTexturing { get; }
        public static ProfilerCategory FileIO { get; }
        public static ProfilerCategory Internal { get; }

        public override string ToString();

        public static implicit operator ushort(ProfilerCategory category);
    }
}
