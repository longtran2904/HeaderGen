#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System;

namespace UnityEngine.Timeline
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = True)]
    public class TrackClipTypeAttribute : Attribute
    {

        public readonly Type inspectedType;
        public readonly bool allowAutoCreate;

        public TrackClipTypeAttribute(Type clipClass);
        public TrackClipTypeAttribute(Type clipClass, bool allowAutoCreate);
    }
}
