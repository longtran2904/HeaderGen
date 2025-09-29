#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEditor.Profiling
{
    public sealed class ProfilerTimeSampleSelection
    {

        public ProfilerTimeSampleSelection(long frameIndex, string threadGroupName, string threadName, ulong threadId, int rawSampleIndex, string sampleName = null);
        public ProfilerTimeSampleSelection(long frameIndex, string threadGroupName, string threadName, ulong threadId, IList<int> rawSampleIndices, string sampleName = null);
        public ProfilerTimeSampleSelection(ProfilerTimeSampleSelection selection);

        public long frameIndex { get; }
        public string threadGroupName { get; }
        public string threadName { get; }
        public ulong threadId { get; }
        public string sampleDisplayName { get; }
        public ReadOnlyCollection<string> markerNamePath { get; }
        public int markerPathDepth { get; }
        public ReadOnlyCollection<int> rawSampleIndices { get; }
        public int rawSampleIndex { get; }
    }
}
