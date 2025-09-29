#region UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityAnalyticsModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeHeader("UnityAnalyticsScriptingClasses.h")]
    [NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
    public static class RemoteSettings
    {

        public static event UpdatedEventHandler Updated;
        public static event Action BeforeFetchFromServer;
        public static event Action<bool, bool, int> Completed;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Calling CallOnUpdate() is not necessary any more and should be removed. Use RemoteSettingsUpdated instead", True)]
        public static void CallOnUpdate();
        public static void ForceUpdate();
        public static bool WasLastUpdatedFromServer();
        [ExcludeFromDocs]
        public static int GetInt(string key);
        public static int GetInt(string key, [DefaultValue("0")] int defaultValue);
        [ExcludeFromDocs]
        public static long GetLong(string key);
        public static long GetLong(string key, [DefaultValue("0")] long defaultValue);
        [ExcludeFromDocs]
        public static float GetFloat(string key);
        public static float GetFloat(string key, [DefaultValue("0.0F")] float defaultValue);
        [ExcludeFromDocs]
        public static string GetString(string key);
        public static string GetString(string key, [DefaultValue("\"\"")] string defaultValue);
        [ExcludeFromDocs]
        public static bool GetBool(string key);
        public static bool GetBool(string key, [DefaultValue("false")] bool defaultValue);
        public static bool HasKey(string key);
        public static int GetCount();
        public static string[] GetKeys();
        public static T GetObject<T>(string key = "");
        public static object GetObject(Type type, string key = "");
        public static object GetObject(string key, object defaultValue);
        public static IDictionary<string, object> GetDictionary(string key = "");
        public delegate void UpdatedEventHandler();
    }
}
