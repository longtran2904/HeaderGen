#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = True, Inherited = False)]
    public sealed class MemberNotNullWhenAttribute : Attribute
    {

        public MemberNotNullWhenAttribute(bool returnValue, string member);
        public MemberNotNullWhenAttribute(bool returnValue, params string[] members);

        public bool ReturnValue { get; }
        public string[] Members { get; }
    }
}
