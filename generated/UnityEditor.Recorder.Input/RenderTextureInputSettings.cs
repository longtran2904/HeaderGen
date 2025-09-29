#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace UnityEditor.Recorder.Input
{
    [DisplayName("Render Texture Asset")]
    public class RenderTextureInputSettings : ImageInputSettings
    {

        public RenderTextureInputSettings();

        public RenderTexture RenderTexture { get; set; }
        public bool FlipFinalOutput { get; set; }
        protected internal override Type InputType { get; }
        public override int OutputWidth { get; set; }
        public override int OutputHeight { get; set; }

        protected internal override void CheckForErrors(List<string> errors);
    }
}
