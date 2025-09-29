#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace UnityEditor.Timeline.Actions
{
    public class TimelineShortcutAttribute : ShortcutAttribute
    {
        public TimelineShortcutAttribute(string id, KeyCode defaultKeyCode, ShortcutModifiers defaultShortcutModifiers = ShortcutModifiers.None);
    }
}
