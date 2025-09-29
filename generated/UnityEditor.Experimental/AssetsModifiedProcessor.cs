#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.Experimental
{
    public abstract class AssetsModifiedProcessor
    {

        protected AssetsModifiedProcessor();

        public HashSet<string> assetsReportedChanged { get; set; }

        protected void ReportAssetChanged(string assetChanged);
        protected abstract void OnAssetsModified(string[] changedAssets, string[] addedAssets, string[] deletedAssets, AssetMoveInfo[] movedAssets);
    }
}
