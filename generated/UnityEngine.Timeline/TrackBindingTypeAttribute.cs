#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System;

namespace UnityEngine.Timeline
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TrackBindingTypeAttribute : Attribute
    {

        public readonly Type type;
        public readonly TrackBindingFlags flags;

        public TrackBindingTypeAttribute(Type type);
        public TrackBindingTypeAttribute(Type type, TrackBindingFlags flags);
    }
}
