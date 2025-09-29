#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.U2D
{
    [NativeHeader("Runtime/Graphics/SpriteFrame.h")]
    [NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
    public class SpriteAtlas : Object
    {
        public SpriteAtlas();

        public bool isVariant { get; }
        public string tag { get; }
        public int spriteCount { get; }

        public bool CanBindTo([NotNull("ArgumentNullException")] Sprite sprite);
        public Sprite GetSprite(string name);
        public int GetSprites(Sprite[] sprites);
        public int GetSprites(Sprite[] sprites, string name);
    }
}
