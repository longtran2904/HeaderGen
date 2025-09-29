#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

namespace UnityEditor.Recorder
{
    public class RecorderWindow : EditorWindow
    {
        public const string MenuRoot = "Window/General/Recorder/";
        public const int MenuRootIndex = 1000;

        public RecorderWindow();

        public void SetRecorderControllerSettings(RecorderControllerSettings settings);
        public void StartRecording();
        public bool IsRecording();
        public void StopRecording();
        public void ApplyPreset(RecorderControllerSettingsPreset preset);
    }
}
