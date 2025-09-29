#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditorInternal
{
    [NativeHeader("Editor/Mono/AssetStore.bindings.h")]
    [StaticAccessor("AssetStoreScriptBindings", StaticAccessorType.DoubleColon)]
    public sealed class AssetStoreToolUtils
    {

        public AssetStoreToolUtils();

        public static bool BuildAssetStoreAssetBundle(UnityEngine.Object targetObject, string targetPath);
    }
}
