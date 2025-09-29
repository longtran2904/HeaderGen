#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor.Recorder.Input
{
    [DisplayName("Audio")]
    public class AudioInputSettings : RecorderInputSettings
    {

        public AudioInputSettings();

        public bool PreserveAudio { get; set; }
        protected internal override Type InputType { get; }
    }
}
