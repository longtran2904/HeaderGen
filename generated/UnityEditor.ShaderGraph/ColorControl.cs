#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

namespace UnityEditor.ShaderGraph
{
    public class ColorControl : IControl
    {
        public ColorControl(Color value, bool hdr);

        public Color value { get; }
        public bool hdr { get; }

        public ShaderGraphRequirements GetRequirements();
    }
}
