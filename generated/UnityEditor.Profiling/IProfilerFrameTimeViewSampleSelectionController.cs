#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Profiling
{
    public interface IProfilerFrameTimeViewSampleSelectionController
    {
        ProfilerTimeSampleSelection selection { get; }
        string sampleNameSearchFilter { get; set; }
        int focusedThreadIndex { get; set; }

        event Action<IProfilerFrameTimeViewSampleSelectionController, ProfilerTimeSampleSelection> selectionChanged;

        bool SetSelection(ProfilerTimeSampleSelection selection);
        void ClearSelection();
    }
}
