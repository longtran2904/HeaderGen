#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.UI
{
    public class LayoutRebuilder : ICanvasElement
    {

        public LayoutRebuilder();

        public Transform transform { get; }

        public bool IsDestroyed();
        public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot);
        public void Rebuild(CanvasUpdate executing);
        public static void MarkLayoutForRebuild(RectTransform rect);
        public void LayoutComplete();
        public void GraphicUpdateComplete();
        public override int GetHashCode();
        public override bool Equals(object obj);
        public override string ToString();
    }
}
