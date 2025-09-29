#region System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.dll
#endregion

using System.Reflection;

namespace System.Collections
{
    [DefaultMember("Item")]
    public sealed class BitArray : ICloneable, ICollection, IEnumerable
    {

        public BitArray(int length);
        public BitArray(int length, bool defaultValue);
        public BitArray(byte[] bytes);
        public BitArray(bool[] values);
        public BitArray(int[] values);
        public BitArray(BitArray bits);

        public bool this[int index] { get; set; }
        public int Length { get; set; }
        public int Count { get; }
        public object SyncRoot { get; }
        public bool IsSynchronized { get; }
        public bool IsReadOnly { get; }

        public bool Get(int index);
        public void Set(int index, bool value);
        public void SetAll(bool value);
        public BitArray And(BitArray value);
        public BitArray Or(BitArray value);
        public BitArray Xor(BitArray value);
        public BitArray Not();
        public BitArray RightShift(int count);
        public BitArray LeftShift(int count);
        public void CopyTo(Array array, int index);
        public bool HasAllSet();
        public bool HasAnySet();
        public object Clone();
        public IEnumerator GetEnumerator();
    }
}
