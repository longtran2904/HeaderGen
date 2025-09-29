#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Events;

namespace UnityEngine.Device
{
    public static class Application
    {
        public static string absoluteURL { get; }
        public static ThreadPriority backgroundLoadingPriority { get; set; }
        public static string buildGUID { get; }
        public static string cloudProjectId { get; }
        public static string companyName { get; }
        public static string consoleLogPath { get; }
        public static string dataPath { get; }
        public static bool genuine { get; }
        public static bool genuineCheckAvailable { get; }
        public static string identifier { get; }
        public static string installerName { get; }
        public static ApplicationInstallMode installMode { get; }
        public static NetworkReachability internetReachability { get; }
        public static bool isBatchMode { get; }
        public static bool isConsolePlatform { get; }
        public static bool isEditor { get; }
        public static bool isFocused { get; }
        public static bool isMobilePlatform { get; }
        public static bool isPlaying { get; }
        public static string persistentDataPath { get; }
        public static RuntimePlatform platform { get; }
        public static string productName { get; }
        public static bool runInBackground { get; set; }
        public static ApplicationSandboxType sandboxType { get; }
        public static string streamingAssetsPath { get; }
        public static SystemLanguage systemLanguage { get; }
        public static int targetFrameRate { get; set; }
        public static string temporaryCachePath { get; }
        public static string unityVersion { get; }
        public static string version { get; }

        public static event Action<string> deepLinkActivated;
        public static event Action<bool> focusChanged;
        public static event UnityEngine.Application.LogCallback logMessageReceived;
        public static event UnityEngine.Application.LogCallback logMessageReceivedThreaded;
        public static event UnityEngine.Application.LowMemoryCallback lowMemory;
        public static event UnityAction onBeforeRender;
        public static event Action quitting;
        public static event Func<bool> wantsToQuit;
        public static event Action unloading;

        public static bool CanStreamedLevelBeLoaded(int levelIndex);
        public static bool CanStreamedLevelBeLoaded(string levelName);
        public static string[] GetBuildTags();
        public static StackTraceLogType GetStackTraceLogType(LogType logType);
        public static bool HasProLicense();
        public static bool HasUserAuthorization(UserAuthorization mode);
        public static bool IsPlaying(Object obj);
        public static void OpenURL(string url);
        public static void Quit();
        public static void Quit(int exitCode);
        public static bool RequestAdvertisingIdentifierAsync(UnityEngine.Application.AdvertisingIdentifierCallback delegateMethod);
        public static AsyncOperation RequestUserAuthorization(UserAuthorization mode);
        public static void SetBuildTags(string[] buildTags);
        public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType);
        public static void Unload();
    }
}
