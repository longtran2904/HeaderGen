#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Recorder
{
    public abstract class Recorder : ScriptableObject
    {
        protected List<RecorderInput> m_Inputs;

        protected Recorder();

        protected internal int RecordedFramesCount { get; }
        public bool Recording { get; protected set; }

        protected internal virtual void Reset();
        protected internal void ConsoleLogMessage(string message, LogType logType);
        protected internal virtual void SessionCreated(RecordingSession session);
        protected internal virtual bool BeginRecording(RecordingSession session);
        protected internal virtual void EndRecording(RecordingSession session);
        protected internal abstract void RecordFrame(RecordingSession ctx);
        protected internal virtual void PrepareNewFrame(RecordingSession ctx);
        protected internal virtual bool SkipFrame(RecordingSession ctx);
        protected internal virtual bool SkipSubFrame(RecordingSession ctx);
    }
}
