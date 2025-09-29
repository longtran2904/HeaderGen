#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

namespace UnityEditor.Timeline
{
    public struct MarkerDrawOptions
    {

        public string tooltip { get; set; }
        public string errorText { get; set; }

        public override bool Equals(object obj);
        public bool Equals(MarkerDrawOptions other);
        public override int GetHashCode();

        public static bool operator ==(MarkerDrawOptions options1, MarkerDrawOptions options2);
        public static bool operator !=(MarkerDrawOptions options1, MarkerDrawOptions options2);
    }
}
