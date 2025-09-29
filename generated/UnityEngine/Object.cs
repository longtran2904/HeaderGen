#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Security;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
    [NativeHeader("Runtime/SceneManager/SceneManager.h")]
    [NativeHeader("Runtime/GameCode/CloneObject.h")]
    [NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
    [RequiredByNativeCode(GenerateProxy = True)]
    public class Object
    {

        public Object();

        public string name { get; set; }
        public HideFlags hideFlags { get; set; }

        [SecuritySafeCritical]
        public int GetInstanceID();
        public override int GetHashCode();
        public override bool Equals(object other);
        [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
        public static Object Instantiate(Object original, Vector3 position, Quaternion rotation);
        [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
        public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent);
        [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
        public static Object Instantiate(Object original);
        [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
        public static Object Instantiate(Object original, Transform parent);
        [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
        public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace);
        public static T Instantiate<T>(T original) where T : Object;
        public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object;
        public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object;
        public static T Instantiate<T>(T original, Transform parent) where T : Object;
        public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object;
        [NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
        public static void Destroy(Object obj, [DefaultValue("0.0F")] float t);
        [ExcludeFromDocs]
        public static void Destroy(Object obj);
        [NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
        public static void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets);
        [ExcludeFromDocs]
        public static void DestroyImmediate(Object obj);
        public static Object[] FindObjectsOfType(Type type);
        [FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
        [TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
        public static Object[] FindObjectsOfType(Type type, bool includeInactive);
        public static Object[] FindObjectsByType(Type type, FindObjectsSortMode sortMode);
        [FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
        [TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
        public static Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode);
        [FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
        public static void DontDestroyOnLoad([NotNull("NullExceptionObject")] Object target);
        [Obsolete("use Object.Destroy instead.")]
        public static void DestroyObject(Object obj, [DefaultValue("0.0F")] float t);
        [ExcludeFromDocs]
        [Obsolete("use Object.Destroy instead.")]
        public static void DestroyObject(Object obj);
        [Obsolete("warning use Object.FindObjectsByType instead.")]
        public static Object[] FindSceneObjectsOfType(Type type);
        [FreeFunction("UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets")]
        [Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
        public static Object[] FindObjectsOfTypeIncludingAssets(Type type);
        public static T[] FindObjectsOfType<T>() where T : Object;
        public static T[] FindObjectsByType<T>(FindObjectsSortMode sortMode) where T : Object;
        public static T[] FindObjectsOfType<T>(bool includeInactive) where T : Object;
        public static T[] FindObjectsByType<T>(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) where T : Object;
        public static T FindObjectOfType<T>() where T : Object;
        public static T FindObjectOfType<T>(bool includeInactive) where T : Object;
        public static T FindFirstObjectByType<T>() where T : Object;
        public static T FindAnyObjectByType<T>() where T : Object;
        public static T FindFirstObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object;
        public static T FindAnyObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object;
        [Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
        public static Object[] FindObjectsOfTypeAll(Type type);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public static Object FindObjectOfType(Type type);
        public static Object FindFirstObjectByType(Type type);
        public static Object FindAnyObjectByType(Type type);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public static Object FindObjectOfType(Type type, bool includeInactive);
        public static Object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive);
        public static Object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive);
        public override string ToString();

        public static bool operator ==(Object x, Object y);
        public static bool operator !=(Object x, Object y);

        public static implicit operator bool(Object exists);
    }
}
