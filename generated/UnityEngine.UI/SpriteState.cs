#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;

namespace UnityEngine.UI
{
    public struct SpriteState : IEquatable<SpriteState>
    {

        public Sprite highlightedSprite { get; set; }
        public Sprite pressedSprite { get; set; }
        public Sprite selectedSprite { get; set; }
        public Sprite disabledSprite { get; set; }

        public bool Equals(SpriteState other);
    }
}
