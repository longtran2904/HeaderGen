#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = False)]
    public sealed class AssemblyFlagsAttribute : Attribute
    {
        [CLSCompliant(False)]
        [Obsolete("This constructor has been deprecated. Use AssemblyFlagsAttribute(AssemblyNameFlags) instead.")]
        public AssemblyFlagsAttribute(uint flags);
        [Obsolete("This constructor has been deprecated. Use AssemblyFlagsAttribute(AssemblyNameFlags) instead.")]
        public AssemblyFlagsAttribute(int assemblyFlags);
        public AssemblyFlagsAttribute(AssemblyNameFlags assemblyFlags);

        [CLSCompliant(False)]
        [Obsolete("AssemblyFlagsAttribute.Flags has been deprecated. Use AssemblyFlags instead.")]
        public uint Flags { get; }
        public int AssemblyFlags { get; }
    }
}
