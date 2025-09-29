#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Threading.Tasks
{
    public class Task : IAsyncResult, IDisposable
    {

        public Task(Action action);
        public Task(Action action, CancellationToken cancellationToken);
        public Task(Action action, TaskCreationOptions creationOptions);
        public Task(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions);
        public Task(Action<object> action, object state);
        public Task(Action<object> action, object state, CancellationToken cancellationToken);
        public Task(Action<object> action, object state, TaskCreationOptions creationOptions);
        public Task(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions);

        public int Id { get; }
        public static int? CurrentId { get; }
        public AggregateException Exception { get; }
        public TaskStatus Status { get; }
        public bool IsCanceled { get; }
        public bool IsCompleted { get; }
        public bool IsCompletedSuccessfully { get; }
        public TaskCreationOptions CreationOptions { get; }
        public object AsyncState { get; }
        public static TaskFactory Factory { get; }
        public static Task CompletedTask { get; }
        public bool IsFaulted { get; }

        public void Start();
        public void Start(TaskScheduler scheduler);
        public void RunSynchronously();
        public void RunSynchronously(TaskScheduler scheduler);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public TaskAwaiter GetAwaiter();
        public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext);
        public ConfiguredTaskAwaitable ConfigureAwait(ConfigureAwaitOptions options);
        public static YieldAwaitable Yield();
        public void Wait();
        public bool Wait(TimeSpan timeout);
        public bool Wait(TimeSpan timeout, CancellationToken cancellationToken);
        public void Wait(CancellationToken cancellationToken);
        public bool Wait(int millisecondsTimeout);
        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken);
        public Task WaitAsync(CancellationToken cancellationToken);
        public Task WaitAsync(TimeSpan timeout);
        public Task WaitAsync(TimeSpan timeout, TimeProvider timeProvider);
        public Task WaitAsync(TimeSpan timeout, CancellationToken cancellationToken);
        public Task WaitAsync(TimeSpan timeout, TimeProvider timeProvider, CancellationToken cancellationToken);
        public Task ContinueWith(Action<Task> continuationAction);
        public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken);
        public Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler);
        public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions);
        public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
        public Task ContinueWith(Action<Task, object> continuationAction, object state);
        public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken);
        public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler);
        public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskContinuationOptions continuationOptions);
        public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction);
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken);
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler);
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions);
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state);
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken);
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskScheduler scheduler);
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskContinuationOptions continuationOptions);
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);
        [UnsupportedOSPlatform("browser")]
        public static void WaitAll(params Task[] tasks);
        [UnsupportedOSPlatform("browser")]
        public static bool WaitAll(Task[] tasks, TimeSpan timeout);
        [UnsupportedOSPlatform("browser")]
        public static bool WaitAll(Task[] tasks, int millisecondsTimeout);
        [UnsupportedOSPlatform("browser")]
        public static void WaitAll(Task[] tasks, CancellationToken cancellationToken);
        [UnsupportedOSPlatform("browser")]
        public static bool WaitAll(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken);
        public static int WaitAny(params Task[] tasks);
        public static int WaitAny(Task[] tasks, TimeSpan timeout);
        public static int WaitAny(Task[] tasks, CancellationToken cancellationToken);
        public static int WaitAny(Task[] tasks, int millisecondsTimeout);
        public static int WaitAny(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken);
        public static Task<TResult> FromResult<TResult>(TResult result);
        public static Task FromException(Exception exception);
        public static Task<TResult> FromException<TResult>(Exception exception);
        public static Task FromCanceled(CancellationToken cancellationToken);
        public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken);
        public static Task Run(Action action);
        public static Task Run(Action action, CancellationToken cancellationToken);
        public static Task<TResult> Run<TResult>(Func<TResult> function);
        public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken);
        public static Task Run(Func<Task> function);
        public static Task Run(Func<Task> function, CancellationToken cancellationToken);
        public static Task<TResult> Run<TResult>(Func<Task<TResult>> function);
        public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken);
        public static Task Delay(TimeSpan delay);
        public static Task Delay(TimeSpan delay, TimeProvider timeProvider);
        public static Task Delay(TimeSpan delay, CancellationToken cancellationToken);
        public static Task Delay(TimeSpan delay, TimeProvider timeProvider, CancellationToken cancellationToken);
        public static Task Delay(int millisecondsDelay);
        public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken);
        public static Task WhenAll(IEnumerable<Task> tasks);
        public static Task WhenAll(params Task[] tasks);
        public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks);
        public static Task<TResult[]> WhenAll<TResult>(params Task<TResult>[] tasks);
        public static Task<Task> WhenAny(params Task[] tasks);
        public static Task<Task> WhenAny(Task task1, Task task2);
        public static Task<Task> WhenAny(IEnumerable<Task> tasks);
        public static Task<Task<TResult>> WhenAny<TResult>(params Task<TResult>[] tasks);
        public static Task<Task<TResult>> WhenAny<TResult>(Task<TResult> task1, Task<TResult> task2);
        public static Task<Task<TResult>> WhenAny<TResult>(IEnumerable<Task<TResult>> tasks);
    }
}
