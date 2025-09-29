#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
    public class Debug
    {
        public Debug();

        public static ILogger unityLogger { get; }
        public static bool developerConsoleVisible { get; set; }
        [NativeProperty(TargetType = TargetType.Field)]
        [StaticAccessor("GetBuildSettings()", StaticAccessorType.Dot)]
        public static bool isDebugBuild { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Debug.logger is obsolete. Please use Debug.unityLogger instead (UnityUpgradable) -> unityLogger")]
        public static ILogger logger { get; }

        [ExcludeFromDocs]
        public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration);
        [ExcludeFromDocs]
        public static void DrawLine(Vector3 start, Vector3 end, Color color);
        [ExcludeFromDocs]
        public static void DrawLine(Vector3 start, Vector3 end);
        [FreeFunction("DebugDrawLine", IsThreadSafe = True)]
        public static void DrawLine(Vector3 start, Vector3 end, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest);
        [ExcludeFromDocs]
        public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration);
        [ExcludeFromDocs]
        public static void DrawRay(Vector3 start, Vector3 dir, Color color);
        [ExcludeFromDocs]
        public static void DrawRay(Vector3 start, Vector3 dir);
        public static void DrawRay(Vector3 start, Vector3 dir, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest);
        [FreeFunction("PauseEditor")]
        public static void Break();
        public static void DebugBreak();
        [ThreadSafe]
        public static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder);
        public static void Log(object message);
        public static void Log(object message, Object context);
        public static void LogFormat(string format, params object[] args);
        public static void LogFormat(Object context, string format, params object[] args);
        public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args);
        public static void LogError(object message);
        public static void LogError(object message, Object context);
        public static void LogErrorFormat(string format, params object[] args);
        public static void LogErrorFormat(Object context, string format, params object[] args);
        public static void ClearDeveloperConsole();
        public static void LogException(Exception exception);
        public static void LogException(Exception exception, Object context);
        public static void LogWarning(object message);
        public static void LogWarning(object message, Object context);
        public static void LogWarningFormat(string format, params object[] args);
        public static void LogWarningFormat(Object context, string format, params object[] args);
        [Conditional("UNITY_ASSERTIONS")]
        public static void Assert(bool condition);
        [Conditional("UNITY_ASSERTIONS")]
        public static void Assert(bool condition, Object context);
        [Conditional("UNITY_ASSERTIONS")]
        public static void Assert(bool condition, object message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void Assert(bool condition, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void Assert(bool condition, object message, Object context);
        [Conditional("UNITY_ASSERTIONS")]
        public static void Assert(bool condition, string message, Object context);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AssertFormat(bool condition, string format, params object[] args);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AssertFormat(bool condition, Object context, string format, params object[] args);
        [Conditional("UNITY_ASSERTIONS")]
        public static void LogAssertion(object message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void LogAssertion(object message, Object context);
        [Conditional("UNITY_ASSERTIONS")]
        public static void LogAssertionFormat(string format, params object[] args);
        [Conditional("UNITY_ASSERTIONS")]
        public static void LogAssertionFormat(Object context, string format, params object[] args);
        [Conditional("UNITY_ASSERTIONS")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Assert(bool, string, params object[]) is obsolete. Use AssertFormat(bool, string, params object[]) (UnityUpgradable) -> AssertFormat(*)", True)]
        public static void Assert(bool condition, string format, params object[] args);
    }
}
