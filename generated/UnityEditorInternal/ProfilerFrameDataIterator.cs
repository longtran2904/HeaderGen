#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditorInternal
{
    [NativeHeader("Modules/ProfilerEditor/ProfilerHistory/ProfilerFrameData.h")]
    public class ProfilerFrameDataIterator : IDisposable
    {

        public ProfilerFrameDataIterator();

        ~ProfilerFrameDataIterator();

        public int group { get; }
        public int depth { get; }
        public int maxDepth { get; }
        public string path { get; }
        public string name { get; }
        public int sampleId { get; }
        [Obsolete("Use instanceId instead", False)]
        public int id { get; }
        public int instanceId { get; }
        public float frameTimeMS { get; }
        public float frameGpuTimeMS { get; }
        public float startTimeMS { get; }
        public float durationMS { get; }
        public string extraTooltipInfo { get; }

        public void Dispose();
        [NativeMethod("GetNext")]
        public bool Next(bool enterChildren);
        public int GetThreadCount(int frame);
        public double GetFrameStartS(int frame);
        public int GetGroupCount(int frame);
        public string GetGroupName();
        public string GetThreadName();
        public void SetRoot(int frame, int threadIdx);
    }
}
