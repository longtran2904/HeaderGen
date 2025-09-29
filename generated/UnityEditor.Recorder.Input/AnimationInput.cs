#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using UnityEditor.Animations;

namespace UnityEditor.Recorder.Input
{
    public class AnimationInput : RecorderInput
    {

        public AnimationInput();

        public GameObjectRecorder GameObjectRecorder { get; }

        protected internal override void BeginRecording(RecordingSession session);
        protected internal override void NewFrameReady(RecordingSession session);
    }
}
