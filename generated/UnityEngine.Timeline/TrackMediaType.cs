#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System;

namespace UnityEngine.Timeline
{
    [AttributeUsage(AttributeTargets.Class)]
    [Obsolete("TrackMediaType has been deprecated. It is no longer required, and will be removed in a future release.", False)]
    public class TrackMediaType : Attribute
    {
        public readonly TimelineAsset.MediaType m_MediaType;

        public TrackMediaType(TimelineAsset.MediaType mt);
    }
}
