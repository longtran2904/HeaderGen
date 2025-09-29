#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Content
{
    [NativeAsStruct]
    [NativeType(CodegenOptions = CodegenOptions.Custom)]
    [UsedByNativeCode]
    public class SerializationInfo
    {
        public SerializationInfo();

        public ObjectIdentifier serializationObject { get; set; }
        public long serializationIndex { get; set; }
    }
}
