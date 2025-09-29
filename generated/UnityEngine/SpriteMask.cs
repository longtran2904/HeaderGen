#region UnityEngine.SpriteMaskModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SpriteMaskModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeType(Header = "Modules/SpriteMask/Public/SpriteMask.h")]
    [RejectDragAndDropMaterial]
    public sealed class SpriteMask : Renderer
    {
        public SpriteMask();

        public int frontSortingLayerID { get; set; }
        public int frontSortingOrder { get; set; }
        public int backSortingLayerID { get; set; }
        public int backSortingOrder { get; set; }
        public float alphaCutoff { get; set; }
        public Sprite sprite { get; set; }
        public bool isCustomRangeActive { get; set; }
        public SpriteSortPoint spriteSortPoint { get; set; }
    }
}
