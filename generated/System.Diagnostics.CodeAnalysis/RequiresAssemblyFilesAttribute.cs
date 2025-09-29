#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event, AllowMultiple = False, Inherited = False)]
    public sealed class RequiresAssemblyFilesAttribute : Attribute
    {

        public RequiresAssemblyFilesAttribute();
        public RequiresAssemblyFilesAttribute(string message);

        public string Message { get; }
        public string Url { get; set; }
    }
}
