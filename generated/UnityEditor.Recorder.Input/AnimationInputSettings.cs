#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace UnityEditor.Recorder.Input
{
    [DisplayName("Animation")]
    public class AnimationInputSettings : RecorderInputSettings
    {

        public AnimationInputSettings();

        public GameObject gameObject { get; set; }
        public bool Recursive { get; set; }
        public bool ClampedTangents { get; set; }
        public CurveSimplificationOptions SimplyCurves { get; set; }
        protected internal override Type InputType { get; }

        public void AddComponentToRecord(Type componentType);
        protected internal override void CheckForErrors(List<string> errors);
        public void DuplicateExposedReference();
        public void ClearExposedReference();
        public enum CurveSimplificationOptions
        {

            Lossy = 0,
            Lossless = 1,
            Disabled = 2
        }
    }
}
