#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Flags]
    [Obsolete("This has turned into the more explicit APIs, SavePrefabAsset, SaveAsPrefabAsset, SaveAsPrefabAssetAndConnect")]
    public enum ReplacePrefabOptions
    {

        Default = 0,
        ConnectToPrefab = 1,
        ReplaceNameBased = 2
    }
}
