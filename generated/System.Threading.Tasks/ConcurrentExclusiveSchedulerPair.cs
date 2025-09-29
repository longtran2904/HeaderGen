#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading.Tasks
{
    public class ConcurrentExclusiveSchedulerPair
    {

        public ConcurrentExclusiveSchedulerPair();
        public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler);
        public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler, int maxConcurrencyLevel);
        public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler, int maxConcurrencyLevel, int maxItemsPerTask);

        public Task Completion { get; }
        public TaskScheduler ConcurrentScheduler { get; }
        public TaskScheduler ExclusiveScheduler { get; }

        public void Complete();
    }
}
