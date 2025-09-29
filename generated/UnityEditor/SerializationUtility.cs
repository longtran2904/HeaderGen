#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Utility/EditorSerializationUtility.h")]
    public sealed class SerializationUtility
    {

        public const long RefIdUnknown = -1;
        public const long RefIdNull = -2;

        public SerializationUtility();

        public static bool SetManagedReferenceIdForObject(UnityEngine.Object obj, object scriptObj, long refId);
        public static long GetManagedReferenceIdForObject(UnityEngine.Object obj, object scriptObj);
        public static object GetManagedReference(UnityEngine.Object obj, long id);
        public static long[] GetManagedReferenceIds(UnityEngine.Object obj);
        public static bool HasManagedReferencesWithMissingTypes(UnityEngine.Object obj);
        public static ManagedReferenceMissingType[] GetManagedReferencesWithMissingTypes(UnityEngine.Object obj);
        public static bool ClearAllManagedReferencesWithMissingTypes(UnityEngine.Object obj);
        public static bool ClearManagedReferenceWithMissingType(UnityEngine.Object obj, long id);
    }
}
