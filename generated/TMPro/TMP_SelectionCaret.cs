#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
    [RequireComponent(typeof(CanvasRenderer))]
    public class TMP_SelectionCaret : MaskableGraphic
    {

        public TMP_SelectionCaret();

        public override void Cull(Rect clipRect, bool validRect);
        protected override void UpdateGeometry();
    }
}
