#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;

namespace UnityEditor.Recorder
{
    public class RecorderInput : IDisposable
    {

        public RecorderInput();

        ~RecorderInput();

        public RecorderInputSettings settings { get; set; }

        public void Dispose();
        protected virtual void Dispose(bool disposing);
        protected internal virtual void SessionCreated(RecordingSession session);
        protected internal virtual void BeginRecording(RecordingSession session);
        protected internal virtual void NewFrameStarting(RecordingSession session);
        protected internal virtual void NewFrameReady(RecordingSession session);
        protected internal virtual void FrameDone(RecordingSession session);
        protected internal virtual void EndRecording(RecordingSession session);
    }
}
