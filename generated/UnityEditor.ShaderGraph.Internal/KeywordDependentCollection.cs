#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.ShaderGraph.Internal
{
    public static class KeywordDependentCollection
    {
        public enum KeywordPermutationInstanceType
        {

            Base = 0,
            Permutation = 1
        }
        public interface ISet<IInstance>
        {

            int instanceCount { get; }
            IEnumerable<IInstance> instances { get; }
        }
        public interface IInstance
        {

            KeywordPermutationInstanceType type { get; }
            int permutationIndex { get; }
        }
    }
}
