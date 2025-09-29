#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEditor.Recorder.Input;

namespace UnityEditor.Recorder.AOV
{
    [RecorderSettings(typeof(AOVRecorder), "AOV Image Sequence", "aovimagesequence_16")]
    public class AOVRecorderSettings : RecorderSettings
    {
        public AOVRecorderSettings();

        protected internal override string Extension { get; }
        public AOVType AOVSelection { get; set; }
        public ImageRecorderSettings.ColorSpaceType OutputColorSpace { get; set; }
        public ImageRecorderSettings.EXRCompressionType EXRCompression { get; set; }
        public ImageRecorderSettings.ImageRecorderOutputFormat OutputFormat { get; set; }
        public bool CaptureHDR { get; }
        public ImageInputSettings imageInputSettings { get; set; }
        public override IEnumerable<RecorderInputSettings> InputsSettings { get; }

        protected internal override void GetErrors(List<string> errors);
        protected internal override bool HasErrors();
    }
}
