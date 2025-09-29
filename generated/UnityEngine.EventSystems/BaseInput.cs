#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.EventSystems
{
    public class BaseInput : UIBehaviour
    {
        public BaseInput();

        public virtual string compositionString { get; }
        public virtual IMECompositionMode imeCompositionMode { get; set; }
        public virtual Vector2 compositionCursorPos { get; set; }
        public virtual bool mousePresent { get; }
        public virtual Vector2 mousePosition { get; }
        public virtual Vector2 mouseScrollDelta { get; }
        public virtual bool touchSupported { get; }
        public virtual int touchCount { get; }

        public virtual bool GetMouseButtonDown(int button);
        public virtual bool GetMouseButtonUp(int button);
        public virtual bool GetMouseButton(int button);
        public virtual Touch GetTouch(int index);
        public virtual float GetAxisRaw(string axisName);
        public virtual bool GetButtonDown(string buttonName);
    }
}
