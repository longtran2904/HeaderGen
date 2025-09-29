#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditorInternal
{
    public struct NativeProfilerTimeline_GetEntryTimingInfoArgs
    {

        public int frameIndex;
        public int threadIndex;
        public int entryIndex;
        public bool calculateFrameData;
        public float out_LocalStartTime;
        public float out_Duration;
        public float out_TotalDurationForFrame;
        public int out_InstanceCountForFrame;

        public void Reset();
    }
}
