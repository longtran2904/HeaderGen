#region UnityEngine.JSONSerializeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.JSONSerializeModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
    public static class JsonUtility
    {

        public static string ToJson(object obj);
        public static string ToJson(object obj, bool prettyPrint);
        public static T FromJson<T>(string json);
        public static object FromJson(string json, Type type);
        public static void FromJsonOverwrite(string json, object objectToOverwrite);
    }
}
