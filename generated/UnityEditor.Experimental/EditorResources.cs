#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEditor.Experimental
{
    [ExcludeFromDocs]
    [NativeHeader("Editor/Src/EditorResources.h")]
    [StaticAccessor("EditorResources", StaticAccessorType.DoubleColon)]
    public class EditorResources
    {

        public EditorResources();

        [NativeProperty("k_NormalSkinIndex", True, TargetType.Field)]
        public static int normalSkinIndex { get; }
        [NativeProperty("k_DarkSkinIndex", True, TargetType.Field)]
        public static int darkSkinIndex { get; }
        [NativeProperty("k_LightSkinSourcePath", True, TargetType.Field)]
        public static string lightSkinSourcePath { get; }
        [NativeProperty("k_DarkSkinSourcePath", True, TargetType.Field)]
        public static string darkSkinSourcePath { get; }
        [NativeProperty("k_FontsPath", True, TargetType.Field)]
        public static string fontsPath { get; }
        [NativeProperty("k_BrushesPath", True, TargetType.Field)]
        public static string brushesPath { get; }
        [NativeProperty("k_IconsPath", True, TargetType.Field)]
        public static string iconsPath { get; }
        [NativeProperty("k_GeneratedIconsPath", True, TargetType.Field)]
        public static string generatedIconsPath { get; }
        [NativeProperty("k_FolderIconName", True, TargetType.Field)]
        public static string folderIconName { get; }
        [NativeProperty("k_EmptyFolderIconName", True, TargetType.Field)]
        public static string emptyFolderIconName { get; }
        [NativeProperty("k_EditorDefaultResourcesPath", True, TargetType.Field)]
        public static string editorDefaultResourcesPath { get; }
        [NativeProperty("k_LibraryBundlePath", True, TargetType.Field)]
        public static string libraryBundlePath { get; }
        public static string dataPath { get; }

        public static UnityEngine.Object Load(string assetPath, [UnityType] Type type);
        public static string GetAssetPath(UnityEngine.Object obj);
        public static string ExpandPath(string path);
        public static string GetFullPath(string path);
        public static bool Exists(string path);
        public static T Load<T>(string assetPath, bool isRequired = True) where T : UnityEngine.Object;
    }
}
