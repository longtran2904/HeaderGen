#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEditor.Recorder.Input
{
    [DisplayName("Targeted Camera")]
    public class CameraInputSettings : StandardImageInputSettings
    {
        public CameraInputSettings();

        public ImageSource Source { get; set; }
        public string CameraTag { get; set; }
        public bool FlipFinalOutput { get; set; }
        public bool CaptureUI { get; set; }
        protected internal override Type InputType { get; }

        protected internal override void CheckForErrors(List<string> errors);
    }
}
