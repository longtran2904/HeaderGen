#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.EventSystems
{
    public class AxisEventData : BaseEventData
    {
        public AxisEventData(EventSystem eventSystem);

        public Vector2 moveVector { get; set; }
        public MoveDirection moveDir { get; set; }
    }
}
