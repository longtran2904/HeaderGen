#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeAsStruct]
    [RequiredByNativeCode]
    public sealed class PropertyModification
    {
        public UnityEngine.Object target;
        public string propertyPath;
        public string value;
        public UnityEngine.Object objectReference;

        public PropertyModification();
    }
}
