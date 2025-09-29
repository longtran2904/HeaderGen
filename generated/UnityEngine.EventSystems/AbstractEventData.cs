#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.EventSystems
{
    public abstract class AbstractEventData
    {
        protected bool m_Used;

        protected AbstractEventData();

        public virtual bool used { get; }

        public virtual void Reset();
        public virtual void Use();
    }
}
