#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
    [NativeClass("Unity::Component")]
    [NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
    [RequiredByNativeCode]
    public class Component : Object
    {

        public Component();

        public Transform transform { get; }
        public GameObject gameObject { get; }
        public string tag { get; set; }
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

        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponent(Type type);
        [SecuritySafeCritical]
        public T GetComponent<T>();
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public bool TryGetComponent(Type type, out Component component);
        [SecuritySafeCritical]
        public bool TryGetComponent<T>(out T component);
        [FreeFunction(HasExplicitThis = True)]
        public Component GetComponent(string type);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInChildren(Type t, bool includeInactive);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInChildren(Type t);
        public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive);
        [ExcludeFromDocs]
        public T GetComponentInChildren<T>();
        public Component[] GetComponentsInChildren(Type t, bool includeInactive);
        [ExcludeFromDocs]
        public Component[] GetComponentsInChildren(Type t);
        public T[] GetComponentsInChildren<T>(bool includeInactive);
        public void GetComponentsInChildren<T>(bool includeInactive, List<T> result);
        public T[] GetComponentsInChildren<T>();
        public void GetComponentsInChildren<T>(List<T> results);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInParent(Type t, bool includeInactive);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInParent(Type t);
        public T GetComponentInParent<T>([DefaultValue("false")] bool includeInactive);
        public T GetComponentInParent<T>();
        public Component[] GetComponentsInParent(Type t, [DefaultValue("false")] bool includeInactive);
        [ExcludeFromDocs]
        public Component[] GetComponentsInParent(Type t);
        public T[] GetComponentsInParent<T>(bool includeInactive);
        public void GetComponentsInParent<T>(bool includeInactive, List<T> results);
        public T[] GetComponentsInParent<T>();
        public Component[] GetComponents(Type type);
        public void GetComponents(Type type, List<Component> results);
        public void GetComponents<T>(List<T> results);
        public T[] GetComponents<T>();
        public bool CompareTag(string tag);
        [FreeFunction(HasExplicitThis = True)]
        public void SendMessageUpwards(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);
        [ExcludeFromDocs]
        public void SendMessageUpwards(string methodName, object value);
        [ExcludeFromDocs]
        public void SendMessageUpwards(string methodName);
        public void SendMessageUpwards(string methodName, SendMessageOptions options);
        public void SendMessage(string methodName, object value);
        public void SendMessage(string methodName);
        [FreeFunction("SendMessage", HasExplicitThis = True)]
        public void SendMessage(string methodName, object value, SendMessageOptions options);
        public void SendMessage(string methodName, SendMessageOptions options);
        [FreeFunction("BroadcastMessage", HasExplicitThis = True)]
        public void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);
        [ExcludeFromDocs]
        public void BroadcastMessage(string methodName, object parameter);
        [ExcludeFromDocs]
        public void BroadcastMessage(string methodName);
        public void BroadcastMessage(string methodName, SendMessageOptions options);
    }
}
