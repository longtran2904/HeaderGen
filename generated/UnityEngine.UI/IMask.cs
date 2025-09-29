#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine.UI
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Not supported anymore.", True)]
    public interface IMask
    {
        RectTransform rectTransform { get; }

        bool Enabled();
    }
}
