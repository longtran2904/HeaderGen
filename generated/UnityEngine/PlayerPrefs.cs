#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
    public class PlayerPrefs
    {
        public PlayerPrefs();

        public static void SetInt(string key, int value);
        public static int GetInt(string key, int defaultValue);
        public static int GetInt(string key);
        public static void SetFloat(string key, float value);
        public static float GetFloat(string key, float defaultValue);
        public static float GetFloat(string key);
        public static void SetString(string key, string value);
        public static string GetString(string key, string defaultValue);
        public static string GetString(string key);
        public static bool HasKey(string key);
        public static void DeleteKey(string key);
        [NativeMethod("DeleteAllWithCallback")]
        public static void DeleteAll();
        [NativeMethod("Sync")]
        public static void Save();
    }
}
