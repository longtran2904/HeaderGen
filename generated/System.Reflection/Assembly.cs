#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Security;

namespace System.Reflection
{
    public abstract class Assembly : ICustomAttributeProvider, ISerializable
    {
        protected Assembly();

        public virtual IEnumerable<TypeInfo> DefinedTypes { get; }
        public virtual IEnumerable<Type> ExportedTypes { get; }
        [Obsolete("Assembly.CodeBase and Assembly.EscapedCodeBase are only included for .NET Framework compatibility. Use Assembly.Location.", DiagnosticId = "SYSLIB0012", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual string CodeBase { get; }
        public virtual MethodInfo EntryPoint { get; }
        public virtual string FullName { get; }
        public virtual string ImageRuntimeVersion { get; }
        public virtual bool IsDynamic { get; }
        public virtual string Location { get; }
        public virtual bool ReflectionOnly { get; }
        public virtual bool IsCollectible { get; }
        public bool IsFullyTrusted { get; }
        public virtual IEnumerable<CustomAttributeData> CustomAttributes { get; }
        [Obsolete("Assembly.CodeBase and Assembly.EscapedCodeBase are only included for .NET Framework compatibility. Use Assembly.Location.", DiagnosticId = "SYSLIB0012", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual string EscapedCodeBase { get; }
        public virtual Module ManifestModule { get; }
        public virtual IEnumerable<Module> Modules { get; }
        [Obsolete("The Global Assembly Cache is not supported.", DiagnosticId = "SYSLIB0005", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual bool GlobalAssemblyCache { get; }
        public virtual long HostContext { get; }
        public virtual SecurityRuleSet SecurityRuleSet { get; }

        public virtual event ModuleResolveEventHandler ModuleResolve;

        public static Assembly Load(string assemblyString);
        [Obsolete("Assembly.LoadWithPartialName has been deprecated. Use Assembly.Load() instead.")]
        public static Assembly LoadWithPartialName(string partialName);
        public static Assembly Load(AssemblyName assemblyRef);
        public static Assembly GetExecutingAssembly();
        public static Assembly GetCallingAssembly();
        public virtual Type[] GetTypes();
        public virtual Type[] GetExportedTypes();
        public virtual Type[] GetForwardedTypes();
        public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName);
        public virtual string[] GetManifestResourceNames();
        public virtual Stream GetManifestResourceStream(string name);
        public virtual Stream GetManifestResourceStream(Type type, string name);
        public virtual AssemblyName GetName();
        public virtual AssemblyName GetName(bool copiedName);
        public virtual Type GetType(string name);
        public virtual Type GetType(string name, bool throwOnError);
        public virtual Type GetType(string name, bool throwOnError, bool ignoreCase);
        public virtual bool IsDefined(Type attributeType, bool inherit);
        public virtual IList<CustomAttributeData> GetCustomAttributesData();
        public virtual object[] GetCustomAttributes(bool inherit);
        public virtual object[] GetCustomAttributes(Type attributeType, bool inherit);
        public object CreateInstance(string typeName);
        public object CreateInstance(string typeName, bool ignoreCase);
        public virtual object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
        public virtual Module GetModule(string name);
        public Module[] GetModules();
        public virtual Module[] GetModules(bool getResourceModules);
        public Module[] GetLoadedModules();
        public virtual Module[] GetLoadedModules(bool getResourceModules);
        public virtual AssemblyName[] GetReferencedAssemblies();
        public virtual Assembly GetSatelliteAssembly(CultureInfo culture);
        public virtual Assembly GetSatelliteAssembly(CultureInfo culture, Version version);
        public virtual FileStream GetFile(string name);
        public virtual FileStream[] GetFiles();
        public virtual FileStream[] GetFiles(bool getResourceModules);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
        public override string ToString();
        public override bool Equals(object o);
        public override int GetHashCode();
        public static string CreateQualifiedName(string assemblyName, string typeName);
        public static Assembly GetAssembly(Type type);
        public static void SetEntryAssembly(Assembly assembly);
        public static Assembly GetEntryAssembly();
        public static Assembly Load(byte[] rawAssembly);
        public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
        public static Assembly LoadFile(string path);
        public static Assembly LoadFrom(string assemblyFile);
        public static Assembly LoadFrom(string assemblyFile, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
        public static Assembly UnsafeLoadFrom(string assemblyFile);
        public Module LoadModule(string moduleName, byte[] rawModule);
        public virtual Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore);
        [Obsolete("ReflectionOnly loading is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0018", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static Assembly ReflectionOnlyLoad(byte[] rawAssembly);
        [Obsolete("ReflectionOnly loading is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0018", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static Assembly ReflectionOnlyLoad(string assemblyString);
        [Obsolete("ReflectionOnly loading is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0018", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static Assembly ReflectionOnlyLoadFrom(string assemblyFile);

        public static bool operator ==(Assembly left, Assembly right);
        public static bool operator !=(Assembly left, Assembly right);
    }
}
