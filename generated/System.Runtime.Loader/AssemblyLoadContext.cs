#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace System.Runtime.Loader
{
    public class AssemblyLoadContext
    {

        protected AssemblyLoadContext();
        protected AssemblyLoadContext(bool isCollectible);
        public AssemblyLoadContext(string name, bool isCollectible = False);

        ~AssemblyLoadContext();

        public IEnumerable<Assembly> Assemblies { get; }
        public static AssemblyLoadContext Default { get; }
        public bool IsCollectible { get; }
        public string Name { get; }
        public static IEnumerable<AssemblyLoadContext> All { get; }
        public static AssemblyLoadContext CurrentContextualReflectionContext { get; }

        public event Func<Assembly, string, nint> ResolvingUnmanagedDll;
        public event Func<AssemblyLoadContext, AssemblyName, Assembly> Resolving;
        public event Action<AssemblyLoadContext> Unloading;

        public static AssemblyLoadContext GetLoadContext(Assembly assembly);
        public void SetProfileOptimizationRoot(string directoryPath);
        public void StartProfileOptimization(string profile);
        public override string ToString();
        public static AssemblyName GetAssemblyName(string assemblyPath);
        protected virtual Assembly Load(AssemblyName assemblyName);
        public Assembly LoadFromAssemblyName(AssemblyName assemblyName);
        public Assembly LoadFromAssemblyPath(string assemblyPath);
        public Assembly LoadFromNativeImagePath(string nativeImagePath, string assemblyPath);
        public Assembly LoadFromStream(Stream assembly);
        public Assembly LoadFromStream(Stream assembly, Stream assemblySymbols);
        protected nint LoadUnmanagedDllFromPath(string unmanagedDllPath);
        protected virtual nint LoadUnmanagedDll(string unmanagedDllName);
        public void Unload();
        public ContextualReflectionScope EnterContextualReflection();
        public static ContextualReflectionScope EnterContextualReflection(Assembly activating);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public struct ContextualReflectionScope : IDisposable
        {

            public void Dispose();
        }
    }
}
