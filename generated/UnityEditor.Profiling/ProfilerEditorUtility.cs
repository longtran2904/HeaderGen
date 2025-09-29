#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.Profiling
{
    public static class ProfilerEditorUtility
    {
        public static bool SetSelection(this IProfilerFrameTimeViewSampleSelectionController controller, long frameIndex, string threadGroupName, string threadName, string sampleName, string markerNamePath = null, ulong threadId = 0);
        public static bool SetSelection(this IProfilerFrameTimeViewSampleSelectionController controller, long frameIndex, string threadGroupName, string threadName, int sampleMarkerId, List<int> markerIdPath = null, ulong threadId = 0);
        public static bool SetSelection(this IProfilerFrameTimeViewSampleSelectionController controller, string markerNameOrMarkerNamePath, long frameIndex = -1, string threadGroupName = "", string threadName = "Main Thread", ulong threadId = 0);
    }
}
