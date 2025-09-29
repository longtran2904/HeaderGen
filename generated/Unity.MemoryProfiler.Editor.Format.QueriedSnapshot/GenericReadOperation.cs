#region Unity.MemoryProfiler.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.MemoryProfiler.Editor.dll
#endregion

using Unity.MemoryProfiler.Editor.Containers;
using UnityEngine;

namespace Unity.MemoryProfiler.Editor.Format.QueriedSnapshot
{
    public class GenericReadOperation : CustomYieldInstruction
    {

        public override bool keepWaiting { get; }
        public ReadError Error { get; }
        public DynamicArray<byte> Result { get; }
        public bool IsDone { get; }

        public void Complete();
        public void Dispose();
    }
}
