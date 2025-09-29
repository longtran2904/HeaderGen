#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Mono/GameObjectUtility.bindings.h")]
    public sealed class GameObjectUtility
    {

        public GameObjectUtility();

        public static StaticEditorFlags GetStaticEditorFlags(GameObject go);
        public static void SetStaticEditorFlags(GameObject go, StaticEditorFlags flags);
        public static bool AreStaticEditorFlagsSet(GameObject go, StaticEditorFlags flags);
        public static int GetNavMeshArea(GameObject go);
        public static void SetNavMeshArea(GameObject go, int areaIndex);
        public static int GetNavMeshAreaFromName(string name);
        public static string[] GetNavMeshAreaNames();
        public static string GetUniqueNameForSibling(Transform parent, string name);
        public static void EnsureUniqueNameForSibling(GameObject self);
        public static void SetParentAndAlign(GameObject child, GameObject parent);
        [FreeFunction]
        public static int GetMonoBehavioursWithMissingScriptCount([NotNull("NullExceptionObject")] GameObject go);
        [FreeFunction]
        public static int RemoveMonoBehavioursWithMissingScript([NotNull("NullExceptionObject")] GameObject go);
        public static ulong ModifyMaskIfGameObjectIsHiddenForPrefabModeInContext(ulong sceneCullingMask, GameObject gameObject);
        [Obsolete("GetNavMeshArea instead.")]
        public static int GetNavMeshLayer(GameObject go);
        [Obsolete("SetNavMeshArea instead.")]
        public static void SetNavMeshLayer(GameObject go, int areaIndex);
        [Obsolete("GetNavMeshAreaFromName instead.")]
        public static int GetNavMeshLayerFromName(string name);
        [Obsolete("GetNavMeshAreaNames instead.")]
        public static string[] GetNavMeshLayerNames();
    }
}
