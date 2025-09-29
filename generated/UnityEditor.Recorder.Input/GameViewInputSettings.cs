#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor.Recorder.Input
{
    [DisplayName("Game View")]
    public class GameViewInputSettings : StandardImageInputSettings
    {
        public GameViewInputSettings();

        public bool FlipFinalOutput { get; set; }
        protected internal override Type InputType { get; }
        public override bool SupportsTransparent { get; }
    }
}
