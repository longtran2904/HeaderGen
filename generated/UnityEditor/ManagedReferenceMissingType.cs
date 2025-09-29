#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Editor/Src/Utility/EditorSerializationUtility.h")]
    public readonly struct ManagedReferenceMissingType : IComparable<ManagedReferenceMissingType>, IEquatable<ManagedReferenceMissingType>
    {

        public string assemblyName { get; }
        public string className { get; }
        public string namespaceName { get; }
        public long referenceId { get; }
        public string serializedData { get; }

        public bool Equals(ManagedReferenceMissingType other);
        public int CompareTo(ManagedReferenceMissingType other);
    }
}
