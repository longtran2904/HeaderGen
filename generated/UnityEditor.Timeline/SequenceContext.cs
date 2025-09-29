#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    public readonly struct SequenceContext : IEquatable<SequenceContext>
    {

        public SequenceContext(PlayableDirector director, TimelineClip clip);

        public PlayableDirector director { get; }
        public TimelineClip clip { get; }

        public bool IsValid();
        public bool Equals(SequenceContext other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(SequenceContext left, SequenceContext right);
        public static bool operator !=(SequenceContext left, SequenceContext right);
    }
}
