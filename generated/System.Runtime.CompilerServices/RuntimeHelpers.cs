#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    public static class RuntimeHelpers
    {

        [Obsolete("OffsetToStringData has been deprecated. Use string.GetPinnableReference() instead.")]
        public static int OffsetToStringData { get; }

        public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle);
        public static object GetObjectValue(object obj);
        public static void RunClassConstructor(RuntimeTypeHandle type);
        public static void RunModuleConstructor(ModuleHandle module);
        public static void PrepareMethod(RuntimeMethodHandle method);
        public static void PrepareMethod(RuntimeMethodHandle method, RuntimeTypeHandle[] instantiation);
        public static void PrepareDelegate(Delegate d);
        public static int GetHashCode(object o);
        public static bool Equals(object o1, object o2);
        public static void EnsureSufficientExecutionStack();
        public static bool TryEnsureSufficientExecutionStack();
        public static object GetUninitializedObject(Type type);
        public static bool IsReferenceOrContainsReferences<T>();
        public static nint AllocateTypeAssociatedMemory(Type type, int size);
        public static T[] GetSubArray<T>(T[] array, Range range);
        [Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void ExecuteCodeWithGuaranteedCleanup(TryCode code, CleanupCode backoutCode, object userData);
        [Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void PrepareContractedDelegate(Delegate d);
        [Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void ProbeForSufficientStack();
        [Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void PrepareConstrainedRegions();
        [Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void PrepareConstrainedRegionsNoOP();
        public static ReadOnlySpan<T> CreateSpan<T>(RuntimeFieldHandle fldHandle);
        public delegate void TryCode(object userData);
        public delegate void CleanupCode(object userData, bool exceptionThrown);
    }
}
