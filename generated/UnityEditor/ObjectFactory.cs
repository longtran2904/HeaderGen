#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/ObjectFactory.h")]
    public static class ObjectFactory
    {
        public static event Action<Component> componentWasAdded;

        public static T CreateInstance<T>() where T : UnityEngine.Object;
        public static UnityEngine.Object CreateInstance(Type type);
        public static T AddComponent<T>(GameObject gameObject) where T : Component;
        public static Component AddComponent(GameObject gameObject, Type type);
        public static GameObject CreateGameObject(Scene scene, HideFlags hideFlags, string name, params Type[] types);
        public static GameObject CreateGameObject(string name, params Type[] types);
        public static GameObject CreatePrimitive(PrimitiveType type);
    }
}
