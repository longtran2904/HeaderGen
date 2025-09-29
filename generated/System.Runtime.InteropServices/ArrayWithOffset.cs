#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    public readonly struct ArrayWithOffset : IEquatable<ArrayWithOffset>
    {

        public ArrayWithOffset(object array, int offset);

        public object GetArray();
        public int GetOffset();
        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(ArrayWithOffset obj);

        public static bool operator ==(ArrayWithOffset a, ArrayWithOffset b);
        public static bool operator !=(ArrayWithOffset a, ArrayWithOffset b);
    }
}
