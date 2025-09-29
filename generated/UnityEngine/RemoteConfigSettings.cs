#region UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityAnalyticsModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [ExcludeFromDocs]
    [NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
    [NativeHeader("UnityAnalyticsScriptingClasses.h")]
    public class RemoteConfigSettings : IDisposable
    {

        public RemoteConfigSettings(string configKey);

        ~RemoteConfigSettings();

        public event Action<bool> Updated;

        public void Dispose();
        public static bool QueueConfig(string name, object param, int ver = 1, string prefix = "");
        public static bool SendDeviceInfoInConfigRequest();
        public static void AddSessionTag(string tag);
        public void ForceUpdate();
        public bool WasLastUpdatedFromServer();
        [ExcludeFromDocs]
        public int GetInt(string key);
        public int GetInt(string key, [DefaultValue("0")] int defaultValue);
        [ExcludeFromDocs]
        public long GetLong(string key);
        public long GetLong(string key, [DefaultValue("0")] long defaultValue);
        [ExcludeFromDocs]
        public float GetFloat(string key);
        public float GetFloat(string key, [DefaultValue("0.0F")] float defaultValue);
        [ExcludeFromDocs]
        public string GetString(string key);
        public string GetString(string key, [DefaultValue("\"\"")] string defaultValue);
        [ExcludeFromDocs]
        public bool GetBool(string key);
        public bool GetBool(string key, [DefaultValue("false")] bool defaultValue);
        public bool HasKey(string key);
        public int GetCount();
        public string[] GetKeys();
        public T GetObject<T>(string key = "");
        public object GetObject(Type type, string key = "");
        public object GetObject(string key, object defaultValue);
        public IDictionary<string, object> GetDictionary(string key = "");
    }
}
