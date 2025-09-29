#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.VersionControl
{
    public class AssetList : List<Asset>
    {
        public AssetList();
        public AssetList(AssetList src);

        public AssetList Filter(bool includeFolder, params Asset.States[] states);
        public int FilterCount(bool includeFolder, params Asset.States[] states);
        public AssetList FilterChildren();
    }
}
