#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Rendering
{
    [DefaultMember("Item")]
    public struct BitArray64 : IBitArray
    {

        public BitArray64(ulong initValue);
        public BitArray64(IEnumerable<uint> bitIndexTrue);

        public bool this[uint index] { get; set; }
        public uint capacity { get; }
        public bool allFalse { get; }
        public bool allTrue { get; }
        public string humanizedData { get; }

        public IBitArray BitAnd(IBitArray other);
        public IBitArray BitOr(IBitArray other);
        public IBitArray BitNot();
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static BitArray64 operator ~(BitArray64 a);
        public static BitArray64 operator |(BitArray64 a, BitArray64 b);
        public static BitArray64 operator &(BitArray64 a, BitArray64 b);
        public static bool operator ==(BitArray64 a, BitArray64 b);
        public static bool operator !=(BitArray64 a, BitArray64 b);
    }
}
