#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.Recorder.Input
{
    public abstract class StandardImageInputSettings : ImageInputSettings
    {

        protected StandardImageInputSettings();

        public override int OutputWidth { get; set; }
        public override int OutputHeight { get; set; }

        protected internal override void CheckForWarnings(List<string> warnings);
        protected internal override void CheckForErrors(List<string> errors);
    }
}
