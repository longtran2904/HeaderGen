#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

namespace UnityEditor.Recorder
{
    public abstract class GenericRecorder<T> : Recorder where T : RecorderSettings
    {
        protected GenericRecorder();

        public T Settings { get; set; }
    }
}
