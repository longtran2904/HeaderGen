#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.IO;

namespace System.Reflection.Emit
{
    public abstract class AssemblyBuilder : Assembly
    {

        protected AssemblyBuilder();

        [Obsolete("Assembly.CodeBase and Assembly.EscapedCodeBase are only included for .NET Framework compatibility. Use Assembly.Location instead.", DiagnosticId = "SYSLIB0012", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override string CodeBase { get; }
        public override string Location { get; }
        public override MethodInfo EntryPoint { get; }
        public override bool IsDynamic { get; }

        public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access);
        public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes);
        public ModuleBuilder DefineDynamicModule(string name);
        protected abstract ModuleBuilder DefineDynamicModuleCore(string name);
        public ModuleBuilder GetDynamicModule(string name);
        protected abstract ModuleBuilder GetDynamicModuleCore(string name);
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
        protected abstract void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
        public override Type[] GetExportedTypes();
        public override FileStream GetFile(string name);
        public override FileStream[] GetFiles(bool getResourceModules);
        public override ManifestResourceInfo GetManifestResourceInfo(string resourceName);
        public override string[] GetManifestResourceNames();
        public override Stream GetManifestResourceStream(string name);
        public override Stream GetManifestResourceStream(Type type, string name);
    }
}
