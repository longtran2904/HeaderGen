#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
    [ExcludeFromPreset]
    [NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
    [UsedByNativeCode]
    public sealed class GameObject : Object
    {
        public GameObject(string name);
        public GameObject();
        public GameObject(string name, params Type[] components);

        public Transform transform { get; }
        public int layer { get; set; }
        [Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
        public bool active { get; set; }
        public bool activeSelf { get; }
        public bool activeInHierarchy { get; }
        public bool isStatic { get; set; }
        public string tag { get; set; }
        public Scene scene { get; }
        public ulong sceneCullingMask { get; }
        public GameObject gameObject { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property rigidbody has been deprecated. Use GetComponent<Rigidbody>() instead. (UnityUpgradable)", True)]
        public Component rigidbody { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property rigidbody2D has been deprecated. Use GetComponent<Rigidbody2D>() instead. (UnityUpgradable)", True)]
        public Component rigidbody2D { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property camera has been deprecated. Use GetComponent<Camera>() instead. (UnityUpgradable)", True)]
        public Component camera { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property light has been deprecated. Use GetComponent<Light>() instead. (UnityUpgradable)", True)]
        public Component light { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property animation has been deprecated. Use GetComponent<Animation>() instead. (UnityUpgradable)", True)]
        public Component animation { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property constantForce has been deprecated. Use GetComponent<ConstantForce>() instead. (UnityUpgradable)", True)]
        public Component constantForce { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property renderer has been deprecated. Use GetComponent<Renderer>() instead. (UnityUpgradable)", True)]
        public Component renderer { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property audio has been deprecated. Use GetComponent<AudioSource>() instead. (UnityUpgradable)", True)]
        public Component audio { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property networkView has been deprecated. Use GetComponent<NetworkView>() instead. (UnityUpgradable)", True)]
        public Component networkView { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property collider has been deprecated. Use GetComponent<Collider>() instead. (UnityUpgradable)", True)]
        public Component collider { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property collider2D has been deprecated. Use GetComponent<Collider2D>() instead. (UnityUpgradable)", True)]
        public Component collider2D { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property hingeJoint has been deprecated. Use GetComponent<HingeJoint>() instead. (UnityUpgradable)", True)]
        public Component hingeJoint { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property particleSystem has been deprecated. Use GetComponent<ParticleSystem>() instead. (UnityUpgradable)", True)]
        public Component particleSystem { get; }

        [FreeFunction("GameObjectBindings::CreatePrimitive")]
        public static GameObject CreatePrimitive(PrimitiveType type);
        [SecuritySafeCritical]
        public T GetComponent<T>();
        [FreeFunction(Name = "GameObjectBindings::GetComponentFromType", ThrowsException = True, HasExplicitThis = True)]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponent(Type type);
        public Component GetComponent(string type);
        [FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", ThrowsException = True, HasExplicitThis = True)]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInChildren(Type type, bool includeInactive);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInChildren(Type type);
        [ExcludeFromDocs]
        public T GetComponentInChildren<T>();
        public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive);
        [FreeFunction(Name = "GameObjectBindings::GetComponentInParent", ThrowsException = True, HasExplicitThis = True)]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInParent(Type type, bool includeInactive);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInParent(Type type);
        [ExcludeFromDocs]
        public T GetComponentInParent<T>();
        public T GetComponentInParent<T>([DefaultValue("false")] bool includeInactive);
        public Component[] GetComponents(Type type);
        public T[] GetComponents<T>();
        public void GetComponents(Type type, List<Component> results);
        public void GetComponents<T>(List<T> results);
        [ExcludeFromDocs]
        public Component[] GetComponentsInChildren(Type type);
        public Component[] GetComponentsInChildren(Type type, [DefaultValue("false")] bool includeInactive);
        public T[] GetComponentsInChildren<T>(bool includeInactive);
        public void GetComponentsInChildren<T>(bool includeInactive, List<T> results);
        public T[] GetComponentsInChildren<T>();
        public void GetComponentsInChildren<T>(List<T> results);
        [ExcludeFromDocs]
        public Component[] GetComponentsInParent(Type type);
        public Component[] GetComponentsInParent(Type type, [DefaultValue("false")] bool includeInactive);
        public void GetComponentsInParent<T>(bool includeInactive, List<T> results);
        public T[] GetComponentsInParent<T>(bool includeInactive);
        public T[] GetComponentsInParent<T>();
        [SecuritySafeCritical]
        public bool TryGetComponent<T>(out T component);
        public bool TryGetComponent(Type type, out Component component);
        public static GameObject FindWithTag(string tag);
        public void SendMessageUpwards(string methodName, SendMessageOptions options);
        public void SendMessage(string methodName, SendMessageOptions options);
        public void BroadcastMessage(string methodName, SendMessageOptions options);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component AddComponent(Type componentType);
        public T AddComponent<T>() where T : Component;
        [NativeMethod(Name = "SetSelfActive")]
        public void SetActive(bool value);
        [NativeMethod(Name = "SetActiveRecursivelyDeprecated")]
        [Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
        public void SetActiveRecursively(bool state);
        [FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = True)]
        public bool CompareTag(string tag);
        [FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = True)]
        public static GameObject FindGameObjectWithTag(string tag);
        [FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = True)]
        public static GameObject[] FindGameObjectsWithTag(string tag);
        [FreeFunction(Name = "Scripting::SendScriptingMessageUpwards", HasExplicitThis = True)]
        public void SendMessageUpwards(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);
        [ExcludeFromDocs]
        public void SendMessageUpwards(string methodName, object value);
        [ExcludeFromDocs]
        public void SendMessageUpwards(string methodName);
        [FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
        public void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);
        [ExcludeFromDocs]
        public void SendMessage(string methodName, object value);
        [ExcludeFromDocs]
        public void SendMessage(string methodName);
        [FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = True)]
        public void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);
        [ExcludeFromDocs]
        public void BroadcastMessage(string methodName, object parameter);
        [ExcludeFromDocs]
        public void BroadcastMessage(string methodName);
        [FreeFunction(Name = "GameObjectBindings::Find")]
        public static GameObject Find(string name);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("GameObject.SampleAnimation(AnimationClip, float) has been deprecated. Use AnimationClip.SampleAnimation(GameObject, float) instead (UnityUpgradable).", True)]
        public void SampleAnimation(Object clip, float time);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("GameObject.AddComponent with string argument has been deprecated. Use GameObject.AddComponent<T>() instead. (UnityUpgradable).", True)]
        public Component AddComponent(string className);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("gameObject.PlayAnimation is not supported anymore. Use animation.Play()", True)]
        public void PlayAnimation(Object animation);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("gameObject.StopAnimation is not supported anymore. Use animation.Stop()", True)]
        public void StopAnimation();
    }
}
