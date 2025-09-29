#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

namespace UnityEditor.Recorder
{
    public abstract class RecorderEditor : Editor
    {

        protected RecorderEditor();

        protected virtual void OnEnable();
        protected static void DrawSeparator();
        public override void OnInspectorGUI();
        protected virtual void OnValidateSettingsGUI();
        protected virtual void NameAndPathGUI();
        protected virtual void ImageRenderOptionsGUI();
        protected virtual void ExtraOptionsGUI();
        protected virtual void FileTypeAndFormatGUI();
        protected virtual void OnEncodingGui();
        protected virtual void AOVGUI();
        protected virtual void AccumulationGUI();
    }
}
