#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditorInternal
{
    public struct NativeProfilerTimeline_GetEntryPositionInfoArgs
    {

        public int frameIndex;
        public int threadIndex;
        public int sampleIndex;
        public float timeOffset;
        public Rect threadRect;
        public Rect shownAreaRect;
        public Vector2 out_Position;
        public Vector2 out_Size;
        public int out_Depth;

        public void Reset();
    }
}
