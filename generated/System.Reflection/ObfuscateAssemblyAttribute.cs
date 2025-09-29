#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = False, Inherited = False)]
    public sealed class ObfuscateAssemblyAttribute : Attribute
    {

        public ObfuscateAssemblyAttribute(bool assemblyIsPrivate);

        public bool AssemblyIsPrivate { get; }
        public bool StripAfterObfuscation { get; set; }
    }
}
