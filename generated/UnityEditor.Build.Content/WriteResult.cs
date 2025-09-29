#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.ObjectModel;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Content
{
    [UsedByNativeCode]
    public struct WriteResult
    {

        public ReadOnlyCollection<ObjectSerializedInfo> serializedObjects { get; }
        public ReadOnlyCollection<ResourceFile> resourceFiles { get; }
        public ReadOnlyCollection<Type> includedTypes { get; }
        public ReadOnlyCollection<string> includedSerializeReferenceFQN { get; }
    }
}
