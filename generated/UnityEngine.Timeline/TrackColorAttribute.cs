#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System;

namespace UnityEngine.Timeline
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TrackColorAttribute : Attribute
    {

        public TrackColorAttribute(float r, float g, float b);

        public Color color { get; }
    }
}
