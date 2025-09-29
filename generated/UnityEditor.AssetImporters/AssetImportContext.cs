#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AssetImporters
{
    [MovedFrom("UnityEditor.Experimental.AssetImporters")]
    [NativeHeader("Editor/Src/AssetPipeline/AssetImportContext.h")]
    [RequiredByNativeCode]
    public class AssetImportContext
    {
        public string assetPath { get; }
        public BuildTarget selectedBuildTarget { get; }
        public UnityEngine.Object mainObject { get; }

        [NativeName("GetOutputArtifactFilePath")]
        [Obsolete("GetResultPath has been deprecated. Use GetOutputArtifactFilePath(string) instead (UnityUpgradable) -> GetOutputArtifactFilePath(*)")]
        public string GetResultPath(string extension);
        [NativeThrows]
        public void SetMainObject(UnityEngine.Object obj);
        public void AddObjectToAsset(string identifier, UnityEngine.Object obj);
        [FreeFunction("AssetImportContextBindings::GetObjects", HasExplicitThis = True)]
        public void GetObjects([NotNull("ArgumentNullException")] List<UnityEngine.Object> objects);
        [NativeThrows]
        public void AddObjectToAsset(string identifier, UnityEngine.Object obj, Texture2D thumbnail);
        public void DependsOnSourceAsset(string path);
        public void DependsOnSourceAsset(GUID guid);
        public string GetArtifactFilePath(string path, string fileName);
        public string GetArtifactFilePath(GUID guid, string fileName);
        public string GetArtifactFilePath(ArtifactKey key, string fileName);
        public string GetOutputArtifactFilePath(string fileName);
        public void DependsOnArtifact(ArtifactKey key);
        public void DependsOnArtifact(GUID guid);
        public void DependsOnArtifact(string path);
        public void DependsOnCustomDependency(string dependency);
        public void LogImportError(string msg, UnityEngine.Object obj = null);
        public void LogImportWarning(string msg, UnityEngine.Object obj = null);
    }
}
