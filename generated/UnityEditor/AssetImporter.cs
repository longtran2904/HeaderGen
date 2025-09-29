#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [ExcludeFromObjectFactory]
    [NativeHeader("Editor/Src/AssetPipeline/AssetImporter.h")]
    [NativeHeader("Editor/Src/AssetPipeline/AssetImporter.bindings.h")]
    [Preserve]
    [UsedByNativeCode]
    public class AssetImporter : UnityEngine.Object
    {

        public AssetImporter();

        [NativeName("AssetPathName")]
        public string assetPath { get; }
        public bool importSettingsMissing { get; }
        public ulong assetTimeStamp { get; }
        public string userData { get; set; }
        public string assetBundleName { get; set; }
        public string assetBundleVariant { get; set; }

        [NativeName("SetAssetBundleName")]
        public void SetAssetBundleNameAndVariant(string assetBundleName, string assetBundleVariant);
        [FreeFunction("FindAssetImporterAtAssetPath")]
        public static AssetImporter GetAtPath(string path);
        public void SaveAndReimport();
        public void AddRemap(SourceAssetIdentifier identifier, UnityEngine.Object externalObject);
        public bool RemoveRemap(SourceAssetIdentifier identifier);
        public Dictionary<SourceAssetIdentifier, UnityEngine.Object> GetExternalObjectMap();
        [FreeFunction("AssetImporterBindings::SupportsRemappedAssetType", IsThreadSafe = True, HasExplicitThis = True)]
        public bool SupportsRemappedAssetType(Type type);
        [NativeType(CodegenOptions.Custom, "MonoSourceAssetIdentifier")]
        public struct SourceAssetIdentifier
        {

            public Type type;
            public string name;

            public SourceAssetIdentifier(UnityEngine.Object asset);
            public SourceAssetIdentifier(Type type, string name);
        }
    }
}
