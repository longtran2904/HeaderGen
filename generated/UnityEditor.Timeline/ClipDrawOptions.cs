#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Timeline
{
    public struct ClipDrawOptions
    {
        public string errorText { get; set; }
        public bool displayClipName { get; set; }
        public bool hideScaleIndicator { get; set; }
        public string tooltip { get; set; }
        public Color highlightColor { get; set; }
        public IEnumerable<Texture2D> icons { get; set; }

        public override bool Equals(object obj);
        public bool Equals(ClipDrawOptions other);
        public override int GetHashCode();

        public static bool operator ==(ClipDrawOptions options1, ClipDrawOptions options2);
        public static bool operator !=(ClipDrawOptions options1, ClipDrawOptions options2);
    }
}
