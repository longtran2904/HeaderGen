#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Recorder
{
    public abstract class BaseTextureRecorder<T> : GenericRecorder<T> where T : RecorderSettings
    {
        protected bool UseAsyncGPUReadback;

        protected BaseTextureRecorder();

        protected abstract TextureFormat ReadbackTextureFormat { get; }

        protected internal override bool BeginRecording(RecordingSession session);
        protected internal override void RecordFrame(RecordingSession session);
        protected internal override void PrepareNewFrame(RecordingSession ctx);
        protected internal override void EndRecording(RecordingSession session);
        protected virtual void WriteFrame(AsyncGPUReadbackRequest r);
        protected abstract void WriteFrame(Texture2D t);
        protected virtual void DisposeEncoder();
    }
}
