#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Progress.h")]
    [StaticAccessor("Editor::Progress", StaticAccessorType.DoubleColon)]
    public static class Progress
    {

        public static bool running { get; }
        public static float globalProgress { get; }
        public static TimeSpan globalRemainingTime { get; }

        public static event Action<Item[]> added;
        public static event Action<Item[]> updated;
        public static event Action<Item[]> removed;

        public static int Start(string name, string description = null, Options options = Options.None, int parentId = -1);
        [ThreadSafe]
        public static void Finish(int id, Status status = Status.Succeeded);
        public static int Remove(int id);
        public static int Remove(int id, bool forceSynchronous);
        public static void Report(int id, float progress);
        public static void Report(int id, int currentStep, int totalSteps);
        public static void Report(int id, float progress, string description);
        public static void Report(int id, int currentStep, int totalSteps, string description);
        public static bool Cancel(int id);
        public static void RegisterCancelCallback(int id, Func<bool> callback);
        [ThreadSafe]
        public static void UnregisterCancelCallback(int id);
        public static bool Pause(int id);
        public static bool Resume(int id);
        public static void RegisterPauseCallback(int id, Func<bool, bool> callback);
        [ThreadSafe]
        public static void UnregisterPauseCallback(int id);
        public static int GetCount();
        public static int[] GetCountPerStatus();
        public static float GetProgress(int id);
        public static int GetCurrentStep(int id);
        public static int GetTotalSteps(int id);
        public static string GetName(int id);
        public static string GetDescription(int id);
        [ThreadSafe]
        public static void SetDescription(int id, string description);
        public static long GetStartDateTime(int id);
        public static long GetUpdateDateTime(int id);
        public static int GetParentId(int id);
        public static int GetId(int index);
        public static bool IsCancellable(int id);
        public static bool IsPausable(int id);
        public static Status GetStatus(int id);
        public static Options GetOptions(int id);
        [ThreadSafe]
        public static void SetTimeDisplayMode(int id, TimeDisplayMode displayMode);
        [ThreadSafe]
        public static void SetRemainingTime(int id, long seconds);
        public static void SetPriority(int id, int priority);
        public static void SetPriority(int id, Priority priority);
        public static TimeDisplayMode GetTimeDisplayMode(int id);
        public static bool Exists(int id);
        public static long GetRemainingTime(int id);
        public static int GetPriority(int id);
        public static void ClearRemainingTime(int id);
        [ThreadSafe]
        public static void SetStepLabel(int id, string label);
        public static string GetStepLabel(int id);
        public static void ShowDetails(bool shouldReposition = True);
        public static IEnumerable<Item> EnumerateItems();
        public static Item GetProgressById(int id);
        public static int GetRunningProgressCount();
        [NativeType(Header = "Editor/Src/Progress.h")]
        public enum Status
        {

            Running = 0,
            Succeeded = 1,
            Failed = 2,
            Canceled = 3,
            Paused = 4
        }
        [Flags]
        [NativeType(Header = "Editor/Src/Progress.h")]
        public enum Options
        {

            None = 0,
            Sticky = 1,
            Indefinite = 2,
            Synchronous = 4,
            Managed = 8,
            Unmanaged = 16
        }
        [NativeType(Header = "Editor/Src/Progress.h")]
        public enum TimeDisplayMode
        {

            NoTimeShown = 0,
            ShowRunningTime = 1,
            ShowRemainingTime = 2
        }
        [NativeType(Header = "Editor/Src/Progress.h")]
        public enum Priority
        {

            Unresponsive = 0,
            Idle = 1,
            Low = 2,
            Normal = 6,
            High = 10
        }
        public class Item
        {

            public string name { get; }
            public string description { get; }
            public int id { get; }
            public float progress { get; }
            public int currentStep { get; }
            public int totalSteps { get; }
            public string stepLabel { get; }
            public int parentId { get; }
            public DateTime startTime { get; }
            public DateTime updateTime { get; }
            public Status status { get; }
            public Options options { get; }
            public TimeDisplayMode timeDisplayMode { get; }
            public int priority { get; }
            public TimeSpan remainingTime { get; }
            public bool finished { get; }
            public bool running { get; }
            public bool paused { get; }
            public bool responding { get; }
            public bool cancellable { get; }
            public bool pausable { get; }
            public bool indefinite { get; }
            public float elapsedTime { get; }
            public bool exists { get; }

            public void Report(float newProgress);
            public void Report(int newCurrentStep, int newTotalSteps);
            public void Report(float newProgress, string newDescription);
            public void Report(int newCurrentStep, int newTotalSteps, string newDescription);
            public bool Cancel();
            public bool Pause();
            public bool Resume();
            public void Finish(Status finishedStatus = Status.Succeeded);
            public int Remove();
            public void RegisterCancelCallback(Func<bool> callback);
            public void UnregisterCancelCallback();
            public void RegisterPauseCallback(Func<bool, bool> callback);
            public void UnregisterPauseCallback();
            public void SetDescription(string newDescription);
            public void SetTimeDisplayMode(TimeDisplayMode mode);
            public void SetRemainingTime(long seconds);
            public void SetPriority(int priority);
            public void SetPriority(Priority priority);
            public void ClearRemainingTime();
            public void SetStepLabel(string label);
        }
    }
}
