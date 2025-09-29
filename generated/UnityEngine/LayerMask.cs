#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeClass("BitField", "struct BitField;")]
    [NativeHeader("Runtime/BaseClasses/BitField.h")]
    [NativeHeader("Runtime/BaseClasses/TagManager.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct LayerMask
    {
        public int value { get; set; }

        [NativeMethod("LayerToString")]
        [StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
        public static string LayerToName(int layer);
        [NativeMethod("StringToLayer")]
        [StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
        public static int NameToLayer(string layerName);
        public static int GetMask(params string[] layerNames);

        public static implicit operator int(LayerMask mask);
        public static implicit operator LayerMask(int intVal);
    }
}
