#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Recorder
{
    public class RecorderControllerSettingsPreset : ScriptableObject
    {

        public RecorderControllerSettingsPreset();

        public static void SaveAtPath(RecorderControllerSettings model, string path);
        public void ApplyTo(RecorderControllerSettings prefs);
    }
}
