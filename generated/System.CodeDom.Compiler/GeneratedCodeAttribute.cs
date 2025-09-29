#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.CodeDom.Compiler
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = False, Inherited = False)]
    public sealed class GeneratedCodeAttribute : Attribute
    {

        public GeneratedCodeAttribute(string tool, string version);

        public string Tool { get; }
        public string Version { get; }
    }
}
