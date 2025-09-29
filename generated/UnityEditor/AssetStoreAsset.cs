#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public sealed class AssetStoreAsset
    {
        public int id;
        public string name;
        public string displayName;
        public string staticPreviewURL;
        public string dynamicPreviewURL;
        public string className;
        public string price;
        public int packageID;
        public Texture2D previewImage;

        public AssetStoreAsset();

        public UnityEngine.Object Preview { get; }
        public bool HasLivePreview { get; }

        public void Dispose();
    }
}
