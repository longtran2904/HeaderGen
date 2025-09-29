#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.U2D
{
    [NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
    [NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
    [StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType.Dot)]
    public class SpriteAtlasManager
    {
        public SpriteAtlasManager();

        public static event Action<string, Action<SpriteAtlas>> atlasRequested;
        public static event Action<SpriteAtlas> atlasRegistered;
    }
}
