#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditorInternal
{
    [NativeHeader("Modules/ProfilerEditor/Timeline/NativeProfilerTimeline.h")]
    public class NativeProfilerTimeline
    {

        public NativeProfilerTimeline();

        [FreeFunction]
        public static void Initialize(ref NativeProfilerTimeline_InitializeArgs args);
        [FreeFunction]
        public static void Draw(ref NativeProfilerTimeline_DrawArgs args);
        [FreeFunction]
        public static bool GetEntryAtPosition(ref NativeProfilerTimeline_GetEntryAtPositionArgs args);
        [FreeFunction]
        public static bool GetEntryInstanceInfo(ref NativeProfilerTimeline_GetEntryInstanceInfoArgs args);
        [FreeFunction]
        public static bool GetEntryTimingInfo(ref NativeProfilerTimeline_GetEntryTimingInfoArgs args);
        [FreeFunction]
        public static bool GetEntryPositionInfo(ref NativeProfilerTimeline_GetEntryPositionInfoArgs args);
    }
}
