#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEditor.Recorder.Input;

namespace UnityEditor.Recorder
{
    [RecorderSettings(typeof(AnimationRecorder), "Animation Clip", "animation_recorder")]
    public class AnimationRecorderSettings : RecorderSettings
    {

        public AnimationRecorderSettings();

        public AnimationInputSettings AnimationInputSettings { get; set; }
        public override bool IsPlatformSupported { get; }
        public override IEnumerable<RecorderInputSettings> InputsSettings { get; }
        protected internal override string Extension { get; }

        protected internal override void GetErrors(List<string> errors);
        public override void OnAfterDuplicate();
    }
}
