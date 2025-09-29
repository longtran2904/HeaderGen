#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEditor
{
    [NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
    public sealed class EditorPrefs
    {

        public EditorPrefs();

        public static void SetInt(string key, int value);
        public static int GetInt(string key, [DefaultValue("0")] int defaultValue);
        public static int GetInt(string key);
        public static void SetFloat(string key, float value);
        public static float GetFloat(string key, [DefaultValue("0.0F")] float defaultValue);
        public static float GetFloat(string key);
        public static void SetString(string key, string value);
        public static string GetString(string key, [DefaultValue("\"\"")] string defaultValue);
        public static string GetString(string key);
        public static void SetBool(string key, bool value);
        public static bool GetBool(string key, [DefaultValue("false")] bool defaultValue);
        public static bool GetBool(string key);
        public static bool HasKey(string key);
        public static void DeleteKey(string key);
        public static void DeleteAll();
    }
}
