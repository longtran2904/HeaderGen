#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

namespace UnityEditor.Recorder.Input
{
    public abstract class ImageInputSettings : RecorderInputSettings
    {
        protected ImageInputSettings();

        public abstract int OutputWidth { get; set; }
        public abstract int OutputHeight { get; set; }
        public virtual bool SupportsTransparent { get; }
        public bool RecordTransparency { get; set; }
    }
}
