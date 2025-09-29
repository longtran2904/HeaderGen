#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Recorder.Input
{
    public class CameraInput : BaseRenderTextureInput
    {

        public CameraInput();

        protected Camera TargetCamera { get; set; }

        protected internal override void BeginRecording(RecordingSession session);
        protected internal override void NewFrameStarting(RecordingSession session);
        protected internal override void NewFrameReady(RecordingSession session);
        protected override void Dispose(bool disposing);
        protected internal override void EndRecording(RecordingSession session);
    }
}
