#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditorInternal
{
    public struct NativeProfilerTimeline_GetEntryInstanceInfoArgs
    {
        public int frameIndex;
        public int threadIndex;
        public int entryIndex;
        public int out_Id;
        public string out_Path;
        public int[] out_PathMarkerIds;
        public string out_CallstackInfo;
        public string out_MetaData;

        public void Reset();
    }
}
