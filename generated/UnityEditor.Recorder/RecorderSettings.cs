#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Recorder
{
    public abstract class RecorderSettings : ScriptableObject
    {
        protected RecorderSettings();

        public string OutputFile { get; set; }
        public bool Enabled { get; set; }
        public int Take { get; set; }
        protected internal abstract string Extension { get; }
        public FileNameGenerator FileNameGenerator { get; }
        public RecordMode RecordMode { get; set; }
        public FrameRatePlayback FrameRatePlayback { get; set; }
        public float FrameRate { get; set; }
        public int StartFrame { get; set; }
        public int EndFrame { get; set; }
        public float StartTime { get; set; }
        public float EndTime { get; set; }
        public bool CapFrameRate { get; set; }
        public virtual bool IsPlatformSupported { get; }
        public abstract IEnumerable<RecorderInputSettings> InputsSettings { get; }

        [Obsolete("Please use methods GetErrors() and GetWarnings()")]
        protected internal virtual bool ValidityCheck(List<string> errors);
        protected internal virtual void GetErrors(List<string> errors);
        protected internal virtual void GetWarnings(List<string> warnings);
        public virtual void OnAfterDuplicate();
        protected internal virtual bool HasErrors();
        public virtual bool IsAccumulationSupported();
    }
}
