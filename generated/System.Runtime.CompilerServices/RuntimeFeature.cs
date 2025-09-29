#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    public static class RuntimeFeature
    {
        public const string PortablePdb = "PortablePdb";
        public const string DefaultImplementationsOfInterfaces = "DefaultImplementationsOfInterfaces";
        public const string UnmanagedSignatureCallingConvention = "UnmanagedSignatureCallingConvention";
        public const string CovariantReturnsOfClasses = "CovariantReturnsOfClasses";
        public const string ByRefFields = "ByRefFields";
        public const string VirtualStaticsInInterfaces = "VirtualStaticsInInterfaces";
        public const string NumericIntPtr = "NumericIntPtr";

        public static bool IsDynamicCodeSupported { get; }
        public static bool IsDynamicCodeCompiled { get; }

        public static bool IsSupported(string feature);
    }
}
