#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor;
using UnityEditor.VersionControl;

namespace UnityEditorInternal.VersionControl
{
    public class AssetModificationHook
    {
        public AssetModificationHook();

        public static void FileModeChanged(string[] assets, FileMode mode);
        public static AssetMoveResult OnWillMoveAsset(string from, string to);
        public static AssetDeleteResult OnWillDeleteAsset(string assetPath, RemoveAssetOptions option);
        public static void OnWillDeleteAssets(string[] assetPaths, AssetDeleteResult[] deletionResults, RemoveAssetOptions option);
        public static bool IsOpenForEdit(string assetPath, out string message, StatusQueryOptions statusOptions);
    }
}
