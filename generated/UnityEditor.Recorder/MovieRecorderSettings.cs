#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEditor.Recorder.Input;

namespace UnityEditor.Recorder
{
    [RecorderSettings(typeof(MovieRecorder), "Movie", "movie_16")]
    public class MovieRecorderSettings : RecorderSettings, IAccumulation
    {
        public MovieRecorderSettings();

        public VideoRecorderOutputFormat OutputFormat { get; set; }
        public VideoBitrateMode VideoBitRateMode { get; set; }
        public bool CaptureAlpha { get; set; }
        public AccumulationSettings AccumulationSettings { get; set; }
        public ImageInputSettings ImageInputSettings { get; set; }
        public AudioInputSettings AudioInputSettings { get; }
        public override IEnumerable<RecorderInputSettings> InputsSettings { get; }
        protected internal override string Extension { get; }

        public void GetPresetsForEncoder(int indexEncoder, out List<string> presetNames, out List<string> presetOptions);
        public AccumulationSettings GetAccumulationSettings();
        public override bool IsAccumulationSupported();
        protected internal override void GetWarnings(List<string> warnings);
        protected internal override void GetErrors(List<string> errors);

        public enum VideoRecorderOutputFormat
        {
            MP4 = 0,
            WebM = 1,
            MOV = 2
        }
    }
}
