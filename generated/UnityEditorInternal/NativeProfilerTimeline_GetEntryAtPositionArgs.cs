#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditorInternal
{
    public struct NativeProfilerTimeline_GetEntryAtPositionArgs
    {
        public int frameIndex;
        public int threadIndex;
        public float timeOffset;
        public Rect threadRect;
        public Rect shownAreaRect;
        public Vector2 position;
        public int out_EntryIndex;
        public float out_EntryYMaxPos;
        public string out_EntryName;

        public void Reset();
    }
}
