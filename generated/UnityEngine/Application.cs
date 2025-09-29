#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Events;

namespace UnityEngine
{
    [NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
    [NativeHeader("Runtime/Misc/SystemInfo.h")]
    [NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
    [NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
    [NativeHeader("Runtime/Input/InputManager.h")]
    [NativeHeader("Runtime/Application/AdsIdHandler.h")]
    [NativeHeader("Runtime/Export/Application/Application.bindings.h")]
    [NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
    [NativeHeader("Runtime/Input/GetInput.h")]
    [NativeHeader("Runtime/Input/TargetFrameRate.h")]
    [NativeHeader("Runtime/Logging/LogSystem.h")]
    [NativeHeader("Runtime/Misc/BuildSettings.h")]
    [NativeHeader("Runtime/Misc/Player.h")]
    [NativeHeader("Runtime/Utilities/Argv.h")]
    [NativeHeader("Runtime/Utilities/URLUtility.h")]
    [NativeHeader("Runtime/Application/ApplicationInfo.h")]
    [NativeHeader("Runtime/Misc/PlayerSettings.h")]
    [NativeHeader("Runtime/Network/NetworkUtility.h")]
    public class Application
    {
        public Application();

        [Obsolete("This property is deprecated, please use LoadLevelAsync to detect if a specific scene is currently loading.")]
        public static bool isLoadingLevel { get; }
        [Obsolete("Streaming was a Unity Web Player feature, and is removed. This property is deprecated and always returns 0.")]
        public static int streamedBytes { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Application.webSecurityEnabled is no longer supported, since the Unity Web Player is no longer supported by Unity", True)]
        public static bool webSecurityEnabled { get; }
        public static bool isPlaying { get; }
        public static bool isFocused { get; }
        public static string buildGUID { get; }
        public static bool runInBackground { get; set; }
        public static bool isBatchMode { get; }
        public static string dataPath { get; }
        public static string streamingAssetsPath { get; }
        public static string persistentDataPath { get; }
        public static string temporaryCachePath { get; }
        public static string absoluteURL { get; }
        public static string unityVersion { get; }
        public static string version { get; }
        public static string installerName { get; }
        public static string identifier { get; }
        public static ApplicationInstallMode installMode { get; }
        public static ApplicationSandboxType sandboxType { get; }
        public static string productName { get; }
        public static string companyName { get; }
        public static string cloudProjectId { get; }
        public static int targetFrameRate { get; set; }
        [Obsolete("Use SetStackTraceLogType/GetStackTraceLogType instead")]
        public static StackTraceLogType stackTraceLogType { get; set; }
        public static string consoleLogPath { get; }
        public static ThreadPriority backgroundLoadingPriority { get; set; }
        public static bool genuine { get; }
        public static bool genuineCheckAvailable { get; }
        [Obsolete("This property is deprecated, please use SplashScreen.isFinished instead")]
        public static bool isShowingSplashScreen { get; }
        public static RuntimePlatform platform { get; }
        public static bool isMobilePlatform { get; }
        public static bool isConsolePlatform { get; }
        public static SystemLanguage systemLanguage { get; }
        public static NetworkReachability internetReachability { get; }
        [Obsolete("use Application.isEditor instead")]
        public static bool isPlayer { get; }
        [Obsolete("Use SceneManager.sceneCountInBuildSettings")]
        public static int levelCount { get; }
        [Obsolete("Use SceneManager to determine what scenes have been loaded")]
        public static int loadedLevel { get; }
        [Obsolete("Use SceneManager to determine what scenes have been loaded")]
        public static string loadedLevelName { get; }
        public static bool isEditor { get; }

        public static event LowMemoryCallback lowMemory;
        public static event LogCallback logMessageReceived;
        public static event LogCallback logMessageReceivedThreaded;
        public static event UnityAction onBeforeRender;
        public static event Action<bool> focusChanged;
        public static event Action<string> deepLinkActivated;
        public static event Func<bool> wantsToQuit;
        public static event Action quitting;
        public static event Action unloading;

        [FreeFunction("GetInputManager().QuitApplication")]
        public static void Quit(int exitCode);
        public static void Quit();
        [FreeFunction("GetInputManager().CancelQuitApplication")]
        [Obsolete("CancelQuit is deprecated. Use the wantsToQuit event instead.")]
        public static void CancelQuit();
        [FreeFunction("Application_Bindings::Unload")]
        public static void Unload();
        [Obsolete("Streaming was a Unity Web Player feature, and is removed. This function is deprecated and always returns 1.0 for valid level indices.")]
        public static float GetStreamProgressForLevel(int levelIndex);
        [Obsolete("Streaming was a Unity Web Player feature, and is removed. This function is deprecated and always returns 1.0.")]
        public static float GetStreamProgressForLevel(string levelName);
        public static bool CanStreamedLevelBeLoaded(int levelIndex);
        [FreeFunction("Application_Bindings::CanStreamedLevelBeLoaded")]
        public static bool CanStreamedLevelBeLoaded(string levelName);
        [FreeFunction]
        public static bool IsPlaying([NotNull("NullExceptionObject")] Object obj);
        [FreeFunction("GetBuildSettings().GetBuildTags")]
        public static string[] GetBuildTags();
        [FreeFunction("GetBuildSettings().SetBuildTags")]
        public static void SetBuildTags(string[] buildTags);
        [FreeFunction("GetBuildSettings().GetHasPROVersion")]
        public static bool HasProLicense();
        [Obsolete("Application.ExternalEval is deprecated. See https://docs.unity3d.com/Manual/webgl-interactingwithbrowserscripting.html for alternatives.")]
        public static void ExternalEval(string script);
        [FreeFunction("GetAdsIdHandler().RequestAdsIdAsync")]
        public static bool RequestAdvertisingIdentifierAsync(AdvertisingIdentifierCallback delegateMethod);
        [FreeFunction("OpenURL")]
        public static void OpenURL(string url);
        [Obsolete("Use UnityEngine.Diagnostics.Utils.ForceCrash")]
        public static void ForceCrash(int mode);
        [FreeFunction("GetStackTraceLogType")]
        public static StackTraceLogType GetStackTraceLogType(LogType logType);
        [FreeFunction("SetStackTraceLogType")]
        public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType);
        [FreeFunction("Application_Bindings::RequestUserAuthorization")]
        public static AsyncOperation RequestUserAuthorization(UserAuthorization mode);
        [FreeFunction("Application_Bindings::HasUserAuthorization")]
        public static bool HasUserAuthorization(UserAuthorization mode);
        [Obsolete("Application.ExternalCall is deprecated. See https://docs.unity3d.com/Manual/webgl-interactingwithbrowserscripting.html for alternatives.")]
        public static void ExternalCall(string functionName, params object[] args);
        [Obsolete("Use Object.DontDestroyOnLoad instead")]
        public static void DontDestroyOnLoad(Object o);
        [Obsolete("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead (UnityUpgradable) -> [UnityEngine] UnityEngine.ScreenCapture.CaptureScreenshot(*)", True)]
        public static void CaptureScreenshot(string filename, int superSize);
        [Obsolete("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead (UnityUpgradable) -> [UnityEngine] UnityEngine.ScreenCapture.CaptureScreenshot(*)", True)]
        public static void CaptureScreenshot(string filename);
        [Obsolete("Application.RegisterLogCallback is deprecated. Use Application.logMessageReceived instead.")]
        public static void RegisterLogCallback(LogCallback handler);
        [Obsolete("Application.RegisterLogCallbackThreaded is deprecated. Use Application.logMessageReceivedThreaded instead.")]
        public static void RegisterLogCallbackThreaded(LogCallback handler);
        [Obsolete("Use SceneManager.LoadScene")]
        public static void LoadLevel(int index);
        [Obsolete("Use SceneManager.LoadScene")]
        public static void LoadLevel(string name);
        [Obsolete("Use SceneManager.LoadScene")]
        public static void LoadLevelAdditive(int index);
        [Obsolete("Use SceneManager.LoadScene")]
        public static void LoadLevelAdditive(string name);
        [Obsolete("Use SceneManager.LoadSceneAsync")]
        public static AsyncOperation LoadLevelAsync(int index);
        [Obsolete("Use SceneManager.LoadSceneAsync")]
        public static AsyncOperation LoadLevelAsync(string levelName);
        [Obsolete("Use SceneManager.LoadSceneAsync")]
        public static AsyncOperation LoadLevelAdditiveAsync(int index);
        [Obsolete("Use SceneManager.LoadSceneAsync")]
        public static AsyncOperation LoadLevelAdditiveAsync(string levelName);
        [Obsolete("Use SceneManager.UnloadScene")]
        public static bool UnloadLevel(int index);
        [Obsolete("Use SceneManager.UnloadScene")]
        public static bool UnloadLevel(string scenePath);

        public delegate void AdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled, string errorMsg);
        public delegate void LowMemoryCallback();
        public delegate void LogCallback(string condition, string stackTrace, LogType type);
    }
}
