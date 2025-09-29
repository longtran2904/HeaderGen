#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Utility/ObjectImages.h")]
    [NativeHeader("Editor/Mono/AssetDatabase/AssetPreview.bindings.h")]
    public sealed class AssetPreview
    {
        public AssetPreview();

        public static Texture2D GetAssetPreview(UnityEngine.Object asset);
        public static bool IsLoadingAssetPreview(int instanceID);
        public static bool IsLoadingAssetPreviews();
        public static void SetPreviewTextureCacheSize(int size);
        public static Texture2D GetMiniThumbnail(UnityEngine.Object obj);
        public static Texture2D GetMiniTypeThumbnail(Type type);
    }
}
