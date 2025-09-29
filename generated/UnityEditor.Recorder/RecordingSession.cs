#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;

namespace UnityEditor.Recorder
{
    public class RecordingSession : IDisposable
    {

        public Recorder recorder;

        public RecordingSession();

        public RecorderSettings settings { get; }
        public int frameIndex { get; }
        public float recorderTime { get; }

        public void Dispose();
    }
}
