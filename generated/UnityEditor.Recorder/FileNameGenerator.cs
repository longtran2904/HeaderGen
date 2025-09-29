#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;

namespace UnityEditor.Recorder
{
    public class FileNameGenerator
    {

        public string FileName { get; set; }
        public OutputPath.Root Root { get; set; }
        public string Leaf { get; set; }
        public bool ForceAssetsFolder { get; set; }

        public void AddWildcard(string tag, Func<RecordingSession, string> resolver);
        public string BuildAbsolutePath(RecordingSession session);
        public void CreateDirectory(RecordingSession session);
        public static string SanitizePath(string fullPath);
    }
}
