#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor.Profiling;
using UnityEditorInternal;

namespace UnityEditor
{
    [EditorWindowTitle(title = "Profiler", icon = "UnityEditor.ProfilerWindow")]
    public sealed class ProfilerWindow : EditorWindow, IHasCustomMenu, IProfilerWindowController, ProfilerModulesDropdownWindow.IResponder
    {

        [Obsolete("cpuModuleName is deprecated. Use cpuModuleIdentifier instead. (UnityUpgradable) -> cpuModuleIdentifier")]
        public const string cpuModuleName = "UnityEditorInternal.Profiling.CPUProfilerModule, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";
        [Obsolete("gpuModuleName is deprecated. Use gpuModuleIdentifier instead. (UnityUpgradable) -> gpuModuleIdentifier")]
        public const string gpuModuleName = "UnityEditorInternal.Profiling.GPUProfilerModule, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";
        public const string cpuModuleIdentifier = "UnityEditorInternal.Profiling.CPUProfilerModule, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";
        public const string gpuModuleIdentifier = "UnityEditorInternal.Profiling.GPUProfilerModule, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";

        [Obsolete("selectedModuleName is deprecated. Use selectedModuleIdentifier instead. (UnityUpgradable) -> selectedModuleIdentifier")]
        public string selectedModuleName { get; }
        public string selectedModuleIdentifier { get; }
        public long selectedFrameIndex { get; set; }
        public long firstAvailableFrameIndex { get; }
        public long lastAvailableFrameIndex { get; }

        public event Action<long> SelectedFrameIndexChanged;

        public IProfilerFrameTimeViewSampleSelectionController GetFrameTimeViewSampleSelectionController(string moduleIdentifier);
        public void SelectAndStayOnLatestFrame();
    }
}
