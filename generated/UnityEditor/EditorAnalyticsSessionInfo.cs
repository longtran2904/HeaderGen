#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeHeader("Modules/UnityEditorAnalyticsEditor/UnityEditorAnalytics.h")]
    [RequiredByNativeCode]
    public static class EditorAnalyticsSessionInfo
    {

        public static long id { get; }
        public static long sessionCount { get; }
        public static long elapsedTime { get; }
        public static long focusedElapsedTime { get; }
        public static long playbackElapsedTime { get; }
        public static long activeElapsedTime { get; }
        public static string userId { get; }
    }
}
