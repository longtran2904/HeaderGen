#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Configuration.Assemblies;
using System.Globalization;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Principal;

namespace System
{
    public sealed class AppDomain : MarshalByRefObject
    {
        public static AppDomain CurrentDomain { get; }
        public string BaseDirectory { get; }
        public string RelativeSearchPath { get; }
        public AppDomainSetup SetupInformation { get; }
        [Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public PermissionSet PermissionSet { get; }
        public string DynamicDirectory { get; }
        public string FriendlyName { get; }
        public int Id { get; }
        public bool IsFullyTrusted { get; }
        public bool IsHomogenous { get; }
        public static bool MonitoringIsEnabled { get; set; }
        public long MonitoringSurvivedMemorySize { get; }
        public static long MonitoringSurvivedProcessMemorySize { get; }
        public long MonitoringTotalAllocatedMemorySize { get; }
        public bool ShadowCopyFiles { get; }
        public TimeSpan MonitoringTotalProcessorTime { get; }

        public event UnhandledExceptionEventHandler UnhandledException;
        public event EventHandler DomainUnload;
        public event EventHandler<FirstChanceExceptionEventArgs> FirstChanceException;
        public event EventHandler ProcessExit;
        public event AssemblyLoadEventHandler AssemblyLoad;
        public event ResolveEventHandler AssemblyResolve;
        public event ResolveEventHandler ReflectionOnlyAssemblyResolve;
        public event ResolveEventHandler TypeResolve;
        public event ResolveEventHandler ResourceResolve;

        [Obsolete("AppDomain.SetDynamicBase has been deprecated and is not supported.")]
        public void SetDynamicBase(string path);
        public string ApplyPolicy(string assemblyName);
        [Obsolete("Creating and unloading AppDomains is not supported and throws an exception.", DiagnosticId = "SYSLIB0024", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static AppDomain CreateDomain(string friendlyName);
        public int ExecuteAssembly(string assemblyFile);
        public int ExecuteAssembly(string assemblyFile, string[] args);
        [Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public int ExecuteAssembly(string assemblyFile, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
        public int ExecuteAssemblyByName(AssemblyName assemblyName, params string[] args);
        public int ExecuteAssemblyByName(string assemblyName);
        public int ExecuteAssemblyByName(string assemblyName, params string[] args);
        public object GetData(string name);
        public void SetData(string name, object data);
        public bool? IsCompatibilitySwitchSet(string value);
        public bool IsDefaultAppDomain();
        public bool IsFinalizingForUnload();
        public override string ToString();
        [Obsolete("Creating and unloading AppDomains is not supported and throws an exception.", DiagnosticId = "SYSLIB0024", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void Unload(AppDomain domain);
        public Assembly Load(byte[] rawAssembly);
        public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
        public Assembly Load(AssemblyName assemblyRef);
        public Assembly Load(string assemblyString);
        public Assembly[] ReflectionOnlyGetAssemblies();
        [Obsolete("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread instead.")]
        public static int GetCurrentThreadId();
        [Obsolete("AppDomain.AppendPrivatePath has been deprecated and is not supported.")]
        public void AppendPrivatePath(string path);
        [Obsolete("AppDomain.ClearPrivatePath has been deprecated and is not supported.")]
        public void ClearPrivatePath();
        [Obsolete("AppDomain.ClearShadowCopyPath has been deprecated and is not supported.")]
        public void ClearShadowCopyPath();
        [Obsolete("AppDomain.SetCachePath has been deprecated and is not supported.")]
        public void SetCachePath(string path);
        [Obsolete("AppDomain.SetShadowCopyFiles has been deprecated and is not supported.")]
        public void SetShadowCopyFiles();
        [Obsolete("AppDomain.SetShadowCopyPath has been deprecated and is not supported.")]
        public void SetShadowCopyPath(string path);
        public Assembly[] GetAssemblies();
        public void SetPrincipalPolicy(PrincipalPolicy policy);
        public void SetThreadPrincipal(IPrincipal principal);
        public ObjectHandle CreateInstance(string assemblyName, string typeName);
        public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
        public ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes);
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName);
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes);
        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName);
        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes);
        public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName);
        public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
        public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, object[] activationAttributes);
    }
}
