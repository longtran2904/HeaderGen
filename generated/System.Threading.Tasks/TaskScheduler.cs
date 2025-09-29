#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Threading.Tasks
{
    public abstract class TaskScheduler
    {

        protected TaskScheduler();

        public virtual int MaximumConcurrencyLevel { get; }
        public static TaskScheduler Default { get; }
        public static TaskScheduler Current { get; }
        public int Id { get; }

        public static event EventHandler<UnobservedTaskExceptionEventArgs> UnobservedTaskException;

        protected internal abstract void QueueTask(Task task);
        protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);
        protected abstract IEnumerable<Task> GetScheduledTasks();
        protected internal virtual bool TryDequeue(Task task);
        public static TaskScheduler FromCurrentSynchronizationContext();
        protected bool TryExecuteTask(Task task);
    }
}
