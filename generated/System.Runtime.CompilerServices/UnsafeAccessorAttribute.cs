#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = False, Inherited = False)]
    public sealed class UnsafeAccessorAttribute : Attribute
    {
        public UnsafeAccessorAttribute(UnsafeAccessorKind kind);

        public UnsafeAccessorKind Kind { get; }
        public string Name { get; set; }
    }
}
