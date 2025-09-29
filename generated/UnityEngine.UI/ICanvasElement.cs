#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.UI
{
    public interface ICanvasElement
    {

        Transform transform { get; }

        void Rebuild(CanvasUpdate executing);
        void LayoutComplete();
        void GraphicUpdateComplete();
        bool IsDestroyed();
    }
}
