#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor;

namespace Unity.Profiling.Editor
{
    public abstract class ProfilerModule
    {
        protected ProfilerModule(ProfilerCounterDescriptor[] chartCounters, ProfilerModuleChartType defaultChartType = ProfilerModuleChartType.Line, string[] autoEnabledCategoryNames = null);

        public string DisplayName { get; }
        protected ProfilerWindow ProfilerWindow { get; }

        public virtual ProfilerModuleViewController CreateDetailsViewController();
    }
}
