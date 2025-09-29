#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    [DebugState(new[] {typeof(DebugUI.Vector4Field) })]
    public sealed class DebugStateVector4 : DebugState<Vector4>
    {

        public DebugStateVector4();
    }
}
