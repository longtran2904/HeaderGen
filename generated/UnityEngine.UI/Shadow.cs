#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Effects/Shadow", 80)]
    public class Shadow : BaseMeshEffect
    {
        protected Shadow();

        public Color effectColor { get; set; }
        public Vector2 effectDistance { get; set; }
        public bool useGraphicAlpha { get; set; }

        protected override void OnValidate();
        protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y);
        protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y);
        public override void ModifyMesh(VertexHelper vh);
    }
}
