#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Modules/JSONSerializeEditor/EditorJsonUtility.bindings.h")]
    public static class EditorJsonUtility
    {

        public static string ToJson(object obj);
        public static string ToJson(object obj, bool prettyPrint);
        public static void FromJsonOverwrite(string json, object objectToOverwrite);
    }
}
