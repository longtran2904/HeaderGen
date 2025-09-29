#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public readonly struct GCMemoryInfo
    {

        public long HighMemoryLoadThresholdBytes { get; }
        public long MemoryLoadBytes { get; }
        public long TotalAvailableMemoryBytes { get; }
        public long HeapSizeBytes { get; }
        public long FragmentedBytes { get; }
        public long Index { get; }
        public int Generation { get; }
        public bool Compacted { get; }
        public bool Concurrent { get; }
        public long TotalCommittedBytes { get; }
        public long PromotedBytes { get; }
        public long PinnedObjectsCount { get; }
        public long FinalizationPendingCount { get; }
        public ReadOnlySpan<TimeSpan> PauseDurations { get; }
        public double PauseTimePercentage { get; }
        public ReadOnlySpan<GCGenerationInfo> GenerationInfo { get; }
    }
}
