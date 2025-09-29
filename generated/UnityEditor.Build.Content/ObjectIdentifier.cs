#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Content
{
    [NativeHeader("Modules/BuildPipeline/Editor/Public/ObjectIdentifier.h")]
    [StaticAccessor("BuildPipeline", StaticAccessorType.DoubleColon)]
    [UsedByNativeCode]
    public struct ObjectIdentifier : IEquatable<ObjectIdentifier>
    {
        public GUID guid { get; }
        public long localIdentifierInFile { get; }
        public FileType fileType { get; }
        public string filePath { get; }

        public override string ToString();
        public override bool Equals(object obj);
        public bool Equals(ObjectIdentifier other);
        public override int GetHashCode();
        [FreeFunction("GetObjectFromObjectIdentifier")]
        public static UnityEngine.Object ToObject(ObjectIdentifier objectId);
        [FreeFunction("GetInstanceIDFromObjectIdentifier")]
        public static int ToInstanceID(ObjectIdentifier objectId);
        public static bool TryGetObjectIdentifier(UnityEngine.Object targetObject, out ObjectIdentifier objectId);
        public static bool TryGetObjectIdentifier(int instanceID, out ObjectIdentifier objectId);

        public static bool operator ==(ObjectIdentifier a, ObjectIdentifier b);
        public static bool operator !=(ObjectIdentifier a, ObjectIdentifier b);
        public static bool operator <(ObjectIdentifier a, ObjectIdentifier b);
        public static bool operator >(ObjectIdentifier a, ObjectIdentifier b);
    }
}
