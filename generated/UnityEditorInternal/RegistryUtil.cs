#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditorInternal
{
    [NativeType(Header = "Editor/Mono/RegistryUtil.bindings.h")]
    public class RegistryUtil
    {
        public RegistryUtil();

        public static uint GetRegistryUInt32Value(string subKey, string valueName, uint defaultValue, RegistryView view);
        public static string GetRegistryStringValue(string subKey, string valueName, string defaultValue, RegistryView view);
    }
}
