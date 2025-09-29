#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System.Collections.Generic;
using System.Reflection;

namespace UnityEditor.ShaderGraph.Internal
{
    [DefaultMember("Item")]
    public abstract class KeywordDependentCollection<TStorage, TAll, TAllPermutations, TForPermutation, TBase, TIInstance, TISet> where TStorage : new() where TAll : TISet where TAllPermutations : TISet where TForPermutation : TISet, TIInstance where TBase : TISet, TIInstance where TIInstance : KeywordDependentCollection.IInstance where TISet : KeywordDependentCollection.ISet<TIInstance>
    {
        protected KeywordDependentCollection();

        public TForPermutation this[int index] { get; }
        public int permutationCount { get; }
        public TAll all { get; }
        public TAllPermutations allPermutations { get; }
        public TBase baseInstance { get; }
        protected TStorage baseStorage { get; set; }
        protected IEnumerable<TStorage> permutationStorages { get; }

        protected TStorage GetOrCreateForPermutationIndex(int index);
        protected void SetForPermutationIndex(int index, TStorage value);
        protected abstract TAll CreateAllSmartPointer();
        protected abstract TAllPermutations CreateAllPermutationsSmartPointer();
        protected abstract TForPermutation CreateForPermutationSmartPointer(int index);
        protected abstract TBase CreateBaseSmartPointer();
    }
}
