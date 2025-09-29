#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Timeline
{
    public struct TrackDrawOptions
    {
        public string errorText { get; set; }
        public Color trackColor { get; set; }
        public float minimumHeight { get; set; }
        public Texture2D icon { get; set; }

        public override bool Equals(object obj);
        public bool Equals(TrackDrawOptions other);
        public override int GetHashCode();

        public static bool operator ==(TrackDrawOptions options1, TrackDrawOptions options2);
        public static bool operator !=(TrackDrawOptions options1, TrackDrawOptions options2);
    }
}
