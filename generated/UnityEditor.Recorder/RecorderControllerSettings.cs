#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Recorder
{
    public class RecorderControllerSettings : ScriptableObject
    {

        public RecorderControllerSettings();

        public FrameRatePlayback FrameRatePlayback { get; set; }
        public float FrameRate { get; set; }
        public bool CapFrameRate { get; set; }
        public IEnumerable<RecorderSettings> RecorderSettings { get; }

        public void SetRecordModeToManual();
        public void SetRecordModeToSingleFrame(int frameNumber);
        public void SetRecordModeToFrameInterval(int startFrame, int endFrame);
        public void SetRecordModeToTimeInterval(float startTime, float endTime);
        public static RecorderControllerSettings LoadOrCreate(string path);
        public static RecorderControllerSettings GetGlobalSettings();
        public void AddRecorderSettings(RecorderSettings recorder);
        public void RemoveRecorder(RecorderSettings recorder);
        public void Save();
    }
}
