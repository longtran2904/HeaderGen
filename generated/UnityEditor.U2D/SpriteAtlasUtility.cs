#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.U2D;

namespace UnityEditor.U2D
{
    [NativeHeader("Editor/Src/2D/SpriteAtlas/SpriteAtlasPackingUtilities.h")]
    [NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
    public class SpriteAtlasUtility
    {
        public SpriteAtlasUtility();

        [FreeFunction("CollectAllSpriteAtlasesAndPack")]
        public static void PackAllAtlases(BuildTarget target, bool canCancel = True);
        public static void PackAtlases(SpriteAtlas[] atlases, BuildTarget target, bool canCancel = True);
    }
}
