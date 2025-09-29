#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.UI
{
    public interface IClippable
    {

        GameObject gameObject { get; }
        RectTransform rectTransform { get; }

        void RecalculateClipping();
        void Cull(Rect clipRect, bool validRect);
        void SetClipRect(Rect value, bool validRect);
        void SetClipSoftness(Vector2 clipSoftness);
    }
}
