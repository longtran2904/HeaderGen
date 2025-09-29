#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = False)]
    public sealed class StructLayoutAttribute : Attribute
    {
        public int Pack;
        public int Size;
        public CharSet CharSet;

        public StructLayoutAttribute(LayoutKind layoutKind);
        public StructLayoutAttribute(short layoutKind);

        public LayoutKind Value { get; }
    }
}
