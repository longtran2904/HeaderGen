#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Configuration.Assemblies;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = False)]
    public sealed class AssemblyAlgorithmIdAttribute : Attribute
    {

        public AssemblyAlgorithmIdAttribute(AssemblyHashAlgorithm algorithmId);
        [CLSCompliant(False)]
        public AssemblyAlgorithmIdAttribute(uint algorithmId);

        [CLSCompliant(False)]
        public uint AlgorithmId { get; }
    }
}
