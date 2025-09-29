#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = True, Inherited = False)]
    public sealed class MemberNotNullAttribute : Attribute
    {

        public MemberNotNullAttribute(string member);
        public MemberNotNullAttribute(params string[] members);

        public string[] Members { get; }
    }
}
