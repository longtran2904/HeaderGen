#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

namespace UnityEditor.Recorder
{
    public class RecorderController
    {
        public RecorderController(RecorderControllerSettings settings);

        public RecorderControllerSettings Settings { get; }

        public void PrepareRecording();
        public bool StartRecording();
        public bool IsRecording();
        public void StopRecording();
    }
}
