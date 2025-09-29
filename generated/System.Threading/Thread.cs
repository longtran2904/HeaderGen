#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Versioning;
using System.Security.Principal;

namespace System.Threading
{
    public sealed class Thread : CriticalFinalizerObject
    {

        public Thread(ThreadStart start);
        public Thread(ThreadStart start, int maxStackSize);
        public Thread(ParameterizedThreadStart start);
        public Thread(ParameterizedThreadStart start, int maxStackSize);

        ~Thread();

        public int ManagedThreadId { get; }
        public bool IsAlive { get; }
        public bool IsBackground { get; set; }
        public bool IsThreadPoolThread { get; }
        public ThreadPriority Priority { get; set; }
        public ThreadState ThreadState { get; }
        public CultureInfo CurrentCulture { get; set; }
        public CultureInfo CurrentUICulture { get; set; }
        public static IPrincipal CurrentPrincipal { get; set; }
        public static Thread CurrentThread { get; }
        public ExecutionContext ExecutionContext { get; }
        public string Name { get; set; }
        [Obsolete("The ApartmentState property has been deprecated. Use GetApartmentState, SetApartmentState or TrySetApartmentState instead.")]
        public ApartmentState ApartmentState { get; set; }

        public static void SpinWait(int iterations);
        public static bool Yield();
        public ApartmentState GetApartmentState();
        public void DisableComObjectEagerCleanup();
        public void Interrupt();
        public bool Join(int millisecondsTimeout);
        [UnsupportedOSPlatform("browser")]
        public void Start(object parameter);
        [UnsupportedOSPlatform("browser")]
        public void UnsafeStart(object parameter);
        [UnsupportedOSPlatform("browser")]
        public void Start();
        [UnsupportedOSPlatform("browser")]
        public void UnsafeStart();
        public static void Sleep(int millisecondsTimeout);
        [Obsolete("Thread.Abort is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0006", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public void Abort();
        [Obsolete("Thread.Abort is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0006", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public void Abort(object stateInfo);
        [Obsolete("Thread.ResetAbort is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0006", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void ResetAbort();
        [Obsolete("Thread.Suspend has been deprecated. Use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.")]
        public void Suspend();
        [Obsolete("Thread.Resume has been deprecated. Use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.")]
        public void Resume();
        public static void BeginCriticalRegion();
        public static void EndCriticalRegion();
        public static void BeginThreadAffinity();
        public static void EndThreadAffinity();
        public static LocalDataStoreSlot AllocateDataSlot();
        public static LocalDataStoreSlot AllocateNamedDataSlot(string name);
        public static LocalDataStoreSlot GetNamedDataSlot(string name);
        public static void FreeNamedDataSlot(string name);
        public static object GetData(LocalDataStoreSlot slot);
        public static void SetData(LocalDataStoreSlot slot, object data);
        [SupportedOSPlatform("windows")]
        public void SetApartmentState(ApartmentState state);
        public bool TrySetApartmentState(ApartmentState state);
        [Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public CompressedStack GetCompressedStack();
        [Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public void SetCompressedStack(CompressedStack stack);
        public static AppDomain GetDomain();
        public static int GetDomainID();
        public override int GetHashCode();
        public void Join();
        public bool Join(TimeSpan timeout);
        public static void MemoryBarrier();
        public static void Sleep(TimeSpan timeout);
        public static byte VolatileRead(ref byte address);
        public static double VolatileRead(ref double address);
        public static short VolatileRead(ref short address);
        public static int VolatileRead(ref int address);
        public static long VolatileRead(ref long address);
        public static nint VolatileRead(ref nint address);
        public static object VolatileRead(ref object address);
        [CLSCompliant(False)]
        public static sbyte VolatileRead(ref sbyte address);
        public static float VolatileRead(ref float address);
        [CLSCompliant(False)]
        public static ushort VolatileRead(ref ushort address);
        [CLSCompliant(False)]
        public static uint VolatileRead(ref uint address);
        [CLSCompliant(False)]
        public static ulong VolatileRead(ref ulong address);
        [CLSCompliant(False)]
        public static nuint VolatileRead(ref nuint address);
        public static void VolatileWrite(ref byte address, byte value);
        public static void VolatileWrite(ref double address, double value);
        public static void VolatileWrite(ref short address, short value);
        public static void VolatileWrite(ref int address, int value);
        public static void VolatileWrite(ref long address, long value);
        public static void VolatileWrite(ref nint address, nint value);
        public static void VolatileWrite(ref object address, object value);
        [CLSCompliant(False)]
        public static void VolatileWrite(ref sbyte address, sbyte value);
        public static void VolatileWrite(ref float address, float value);
        [CLSCompliant(False)]
        public static void VolatileWrite(ref ushort address, ushort value);
        [CLSCompliant(False)]
        public static void VolatileWrite(ref uint address, uint value);
        [CLSCompliant(False)]
        public static void VolatileWrite(ref ulong address, ulong value);
        [CLSCompliant(False)]
        public static void VolatileWrite(ref nuint address, nuint value);
        public static int GetCurrentProcessorId();
    }
}
