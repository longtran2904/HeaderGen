#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEditor.Recorder.Input;

namespace UnityEditor.Recorder
{
    [RecorderSettings(typeof(ImageRecorder), "Image Sequence", "imagesequence_16")]
    public class ImageRecorderSettings : RecorderSettings, IAccumulation
    {

        public ImageRecorderSettings();

        public ImageRecorderOutputFormat OutputFormat { get; set; }
        public bool CaptureAlpha { get; set; }
        public bool CaptureHDR { get; }
        protected internal override string Extension { get; }
        public EXRCompressionType EXRCompression { get; set; }
        public ColorSpaceType OutputColorSpace { get; set; }
        public ImageInputSettings imageInputSettings { get; set; }
        public override IEnumerable<RecorderInputSettings> InputsSettings { get; }
        public AccumulationSettings AccumulationSettings { get; set; }

        public AccumulationSettings GetAccumulationSettings();
        public override bool IsAccumulationSupported();
        public enum ImageRecorderOutputFormat
        {

            PNG = 0,
            JPEG = 1,
            EXR = 2
        }
        public enum EXRCompressionType
        {

            None = 0,
            RLE = 1,
            Zip = 2
        }
        public enum ColorSpaceType
        {

            sRGB_sRGB = 0,
            Unclamped_linear_sRGB = 1
        }
    }
}
