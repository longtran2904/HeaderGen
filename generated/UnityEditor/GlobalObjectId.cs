#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/GlobalObjectId.h")]
    public struct GlobalObjectId : IEquatable<GlobalObjectId>
    {
        public ulong targetObjectId { get; }
        public ulong targetPrefabId { get; }
        public GUID assetGUID { get; }
        public int identifierType { get; }

        [FreeFunction]
        public static GlobalObjectId GetGlobalObjectIdSlow(UnityEngine.Object targetObject);
        [FreeFunction]
        public static void GetGlobalObjectIdsSlow(UnityEngine.Object[] objects, out GlobalObjectId[] outputIdentifiers);
        public static GlobalObjectId GetGlobalObjectIdSlow(int instanceId);
        public static void GetGlobalObjectIdsSlow(int[] instanceIds, out GlobalObjectId[] outputIdentifiers);
        public override string ToString();
        public bool Equals(GlobalObjectId other);
        public static bool TryParse(string stringValue, out GlobalObjectId id);
        [FreeFunction]
        public static UnityEngine.Object GlobalObjectIdentifierToObjectSlow(GlobalObjectId id);
        [FreeFunction]
        public static void GlobalObjectIdentifiersToObjectsSlow(GlobalObjectId[] identifiers, out UnityEngine.Object[] outputObjects);
        [FreeFunction]
        public static int GlobalObjectIdentifierToInstanceIDSlow(GlobalObjectId id);
        [FreeFunction]
        public static void GlobalObjectIdentifiersToInstanceIDsSlow(GlobalObjectId[] identifiers, out int[] outputInstanceIDs);
    }
}
