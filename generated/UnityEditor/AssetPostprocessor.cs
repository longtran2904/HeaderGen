#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.Internal;

namespace UnityEditor
{
    public class AssetPostprocessor
    {

        public AssetPostprocessor();

        public string assetPath { get; set; }
        public AssetImportContext context { get; }
        public AssetImporter assetImporter { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("To set or get the preview, call EditorUtility.SetAssetPreview or AssetPreview.GetAssetPreview instead", True)]
        public Texture2D preview { get; set; }

        [ExcludeFromDocs]
        public void LogWarning(string warning);
        public void LogWarning(string warning, [DefaultValue("null")] UnityEngine.Object context);
        [ExcludeFromDocs]
        public void LogError(string warning);
        public void LogError(string warning, [DefaultValue("null")] UnityEngine.Object context);
        public virtual uint GetVersion();
        public virtual int GetPostprocessOrder();
    }
}
