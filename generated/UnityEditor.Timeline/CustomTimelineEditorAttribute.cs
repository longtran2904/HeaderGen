#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System;

namespace UnityEditor.Timeline
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = False, Inherited = True)]
    public sealed class CustomTimelineEditorAttribute : Attribute
    {

        public CustomTimelineEditorAttribute(Type type);

        public Type classToEdit { get; }
    }
}
