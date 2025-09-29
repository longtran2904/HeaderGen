#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Raw Image", 12)]
    [RequireComponent(typeof(CanvasRenderer))]
    public class RawImage : MaskableGraphic
    {
        protected RawImage();

        public override Texture mainTexture { get; }
        public Texture texture { get; set; }
        public Rect uvRect { get; set; }

        public override void SetNativeSize();
        protected override void OnPopulateMesh(VertexHelper vh);
        protected override void OnDidApplyAnimationProperties();
    }
}
