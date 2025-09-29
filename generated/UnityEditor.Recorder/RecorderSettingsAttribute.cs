#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;

namespace UnityEditor.Recorder
{
    [AttributeUsage(AttributeTargets.Class, Inherited = False)]
    public class RecorderSettingsAttribute : Attribute
    {
        public RecorderSettingsAttribute(Type recorderType, string displayName);
        public RecorderSettingsAttribute(Type recorderType, string displayName, bool deprecated);
        public RecorderSettingsAttribute(Type recorderType, string displayName, string iconName);
        public RecorderSettingsAttribute(Type recorderType, string displayName, string iconName, bool deprecated);
    }
}
