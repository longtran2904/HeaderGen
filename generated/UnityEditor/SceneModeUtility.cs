#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor
{
    public static class SceneModeUtility
    {

        public static T[] GetSelectedObjectsOfType<T>(out GameObject[] gameObjects, params Type[] types) where T : UnityEngine.Object;
        public static void SearchForType(Type type);
        public static Type SearchBar(params Type[] types);
        public static bool StaticFlagField(string label, SerializedProperty property, int flag);
        public static bool SetStaticFlags(UnityEngine.Object[] targetObjects, int changedFlags, bool flagValue);
        public static GameObject[] GetObjects(UnityEngine.Object[] gameObjects, bool includeChildren);
    }
}
