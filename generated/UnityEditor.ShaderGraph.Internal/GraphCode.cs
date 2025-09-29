#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.ShaderGraph.Internal
{
    public struct GraphCode
    {
        public IEnumerable<AbstractShaderProperty> properties;

        public string code { get; }
        public ShaderGraphRequirements requirements { get; }
    }
}
