#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEditor.Recorder.Input;

namespace UnityEditor.Recorder.FrameCapturer
{
    [Obsolete("The legacy recorders are deprecated")]
    public abstract class BaseFCRecorderSettings : RecorderSettings
    {

        protected BaseFCRecorderSettings();

        public ImageInputSettings imageInputSettings { get; set; }
        public override IEnumerable<RecorderInputSettings> InputsSettings { get; }
    }
}
