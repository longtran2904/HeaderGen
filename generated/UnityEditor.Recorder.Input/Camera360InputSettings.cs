#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEditor.Recorder.Input
{
    [DisplayName("360 View")]
    public class Camera360InputSettings : ImageInputSettings
    {
        public Camera360InputSettings();

        public ImageSource Source { get; set; }
        public string CameraTag { get; set; }
        public bool FlipFinalOutput { get; set; }
        public bool RenderStereo { get; set; }
        public float StereoSeparation { get; set; }
        public int MapSize { get; set; }
        protected internal override Type InputType { get; }
        public override int OutputWidth { get; set; }
        public override int OutputHeight { get; set; }

        protected internal override void CheckForErrors(List<string> errors);
    }
}
