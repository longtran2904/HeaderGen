#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Events;

namespace UnityEngine
{
    [NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
    [RequireComponent(typeof(Transform))]
    public sealed class SpriteRenderer : Renderer
    {
        public SpriteRenderer();

        public Sprite sprite { get; set; }
        public SpriteDrawMode drawMode { get; set; }
        public Vector2 size { get; set; }
        public float adaptiveModeThreshold { get; set; }
        public SpriteTileMode tileMode { get; set; }
        public Color color { get; set; }
        public SpriteMaskInteraction maskInteraction { get; set; }
        public bool flipX { get; set; }
        public bool flipY { get; set; }
        public SpriteSortPoint spriteSortPoint { get; set; }

        public void RegisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback);
        public void UnregisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback);
    }
}
