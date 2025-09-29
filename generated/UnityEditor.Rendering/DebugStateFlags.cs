#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    [DebugState(new[] {typeof(DebugUI.BitField) })]
    public sealed class DebugStateFlags : DebugState<Enum>
    {

        public DebugStateFlags();

        public override Enum value { get; set; }

        public override void SetValue(object value, DebugUI.IValueField field);
    }
}
