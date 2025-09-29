#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace Unity.Profiling.Editor
{
    public readonly struct ProfilerCounterDescriptor
    {
        public ProfilerCounterDescriptor(string name, ProfilerCategory category);
        public ProfilerCounterDescriptor(string name, string categoryName);

        public string Name { get; }
        public string CategoryName { get; }

        public override string ToString();
    }
}
