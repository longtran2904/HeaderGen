#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Obsolete("AssetsItem class is not used anymore (Asset Server has been removed)")]
    public sealed class AssetsItem
    {
        public string guid;
        public string pathName;
        public string message;
        public string exportedAssetPath;
        public string guidFolder;
        public int enabled;
        public int assetIsDir;
        public int changeFlags;
        public string previewPath;
        public int exists;

        public AssetsItem();
    }
}
