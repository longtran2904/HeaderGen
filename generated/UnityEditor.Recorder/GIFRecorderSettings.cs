#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using UnityEditor.Recorder.FrameCapturer;

namespace UnityEditor.Recorder
{
    [Obsolete("The GIFRecorder is deprecated")]
    [RecorderSettings(typeof(GIFRecorder), "GIF Animation", "imagesequence_16", True)]
    public class GIFRecorderSettings : BaseFCRecorderSettings
    {
        [Obsolete("The GIFRecorder is deprecated")]
        public GIFRecorderSettings();

        protected internal override string Extension { get; }
    }
}
