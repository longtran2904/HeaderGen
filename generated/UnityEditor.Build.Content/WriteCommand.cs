#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Content
{
    [NativeAsStruct]
    [NativeHeader("Modules/BuildPipeline/Editor/Shared/ContentBuildInterface.bindings.h")]
    [NativeType(CodegenOptions = CodegenOptions.Custom)]
    [UsedByNativeCode]
    public class WriteCommand
    {
        public WriteCommand();

        public string fileName { get; set; }
        public string internalName { get; set; }
        public List<SerializationInfo> serializeObjects { get; set; }
    }
}
