#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.Recorder
{
    public abstract class RecorderInputSettings
    {

        protected RecorderInputSettings();

        protected internal abstract Type InputType { get; }

        [Obsolete("Please use methods CheckForErrors() and CheckForWarnings()")]
        protected internal virtual bool ValidityCheck(List<string> errors);
        protected internal virtual void CheckForWarnings(List<string> warnings);
        protected internal virtual void CheckForErrors(List<string> errors);
    }
}
