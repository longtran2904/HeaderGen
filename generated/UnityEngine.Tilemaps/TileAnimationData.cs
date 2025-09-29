#region UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
    [NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
    [RequiredByNativeCode]
    public struct TileAnimationData
    {
        public Sprite[] animatedSprites { get; set; }
        public float animationSpeed { get; set; }
        public float animationStartTime { get; set; }
    }
}
