#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe
{
    [NativeAsStruct]
    [NativeConditional("ENABLE_PROFILER")]
    [RequiredByNativeCode]
    public class AsyncReadManagerMetricsFilters
    {
        public AsyncReadManagerMetricsFilters();
        public AsyncReadManagerMetricsFilters(ulong typeID);
        public AsyncReadManagerMetricsFilters(ProcessingState state);
        public AsyncReadManagerMetricsFilters(FileReadType readType);
        public AsyncReadManagerMetricsFilters(Priority priorityLevel);
        public AsyncReadManagerMetricsFilters(AssetLoadingSubsystem subsystem);
        public AsyncReadManagerMetricsFilters(ulong[] typeIDs);
        public AsyncReadManagerMetricsFilters(ProcessingState[] states);
        public AsyncReadManagerMetricsFilters(FileReadType[] readTypes);
        public AsyncReadManagerMetricsFilters(Priority[] priorityLevels);
        public AsyncReadManagerMetricsFilters(AssetLoadingSubsystem[] subsystems);
        public AsyncReadManagerMetricsFilters(ulong[] typeIDs, ProcessingState[] states, FileReadType[] readTypes, Priority[] priorityLevels, AssetLoadingSubsystem[] subsystems);

        public void SetTypeIDFilter(ulong[] _typeIDs);
        public void SetStateFilter(ProcessingState[] _states);
        public void SetReadTypeFilter(FileReadType[] _readTypes);
        public void SetPriorityFilter(Priority[] _priorityLevels);
        public void SetSubsystemFilter(AssetLoadingSubsystem[] _subsystems);
        public void SetTypeIDFilter(ulong _typeID);
        public void SetStateFilter(ProcessingState _state);
        public void SetReadTypeFilter(FileReadType _readType);
        public void SetPriorityFilter(Priority _priorityLevel);
        public void SetSubsystemFilter(AssetLoadingSubsystem _subsystem);
        public void RemoveTypeIDFilter();
        public void RemoveStateFilter();
        public void RemoveReadTypeFilter();
        public void RemovePriorityFilter();
        public void RemoveSubsystemFilter();
        public void ClearFilters();
    }
}
