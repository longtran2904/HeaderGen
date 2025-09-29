#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/InspectorExpandedState.h")]
    [StaticAccessor("GetInspectorExpandedState().GetSessionState()", StaticAccessorType.Dot)]
    public class SessionState
    {

        [ExcludeFromDocs]
        public SessionState();

        public static void SetBool(string key, bool value);
        public static bool GetBool(string key, bool defaultValue);
        public static void EraseBool(string key);
        public static void SetFloat(string key, float value);
        public static float GetFloat(string key, float defaultValue);
        public static void EraseFloat(string key);
        public static void SetInt(string key, int value);
        public static int GetInt(string key, int defaultValue);
        public static void EraseInt(string key);
        public static void SetString(string key, string value);
        public static string GetString(string key, string defaultValue);
        public static void EraseString(string key);
        public static void SetVector3(string key, Vector3 value);
        public static Vector3 GetVector3(string key, Vector3 defaultValue);
        public static void EraseVector3(string key);
        public static void EraseIntArray(string key);
        public static void SetIntArray(string key, int[] value);
        public static int[] GetIntArray(string key, [Unmarshalled] int[] defaultValue);
    }
}
