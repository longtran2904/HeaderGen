#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AssetImporters
{
    [ExtensionOfNativeClass]
    [MovedFrom("UnityEditor.Experimental.AssetImporters")]
    [Preserve]
    [UsedByNativeCode]
    public abstract class ScriptedImporter : AssetImporter
    {

        protected ScriptedImporter();

        public abstract void OnImportAsset(AssetImportContext ctx);
        public virtual bool SupportsRemappedAssetType(Type type);
    }
}
