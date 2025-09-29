#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace UnityEditor.Recorder.Input
{
    [DisplayName("Texture Sampling")]
    public class RenderTextureSamplerSettings : ImageInputSettings
    {
        public RenderTextureSamplerSettings();

        public SuperSamplingCount SuperSampling { get; set; }
        public string CameraTag { get; set; }
        public ColorSpace ColorSpace { get; set; }
        public bool FlipFinalOutput { get; set; }
        protected internal override Type InputType { get; }
        public override int OutputWidth { get; set; }
        public override int OutputHeight { get; set; }
        public int RenderWidth { get; set; }
        public int RenderHeight { get; set; }

        protected internal override void CheckForWarnings(List<string> warnings);
    }
}
