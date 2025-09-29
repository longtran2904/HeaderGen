#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public static class Interlocked
    {

        public static int Increment(ref int location);
        public static long Increment(ref long location);
        public static int Decrement(ref int location);
        public static long Decrement(ref long location);
        public static int Exchange(ref int location1, int value);
        public static long Exchange(ref long location1, long value);
        public static object Exchange(ref object location1, object value);
        public static T Exchange<T>(ref T location1, T value) where T : class;
        public static int CompareExchange(ref int location1, int value, int comparand);
        public static long CompareExchange(ref long location1, long value, long comparand);
        public static object CompareExchange(ref object location1, object value, object comparand);
        public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class;
        public static int Add(ref int location1, int value);
        public static long Add(ref long location1, long value);
        public static long Read(in long location);
        public static void MemoryBarrierProcessWide();
        [CLSCompliant(False)]
        public static uint Increment(ref uint location);
        [CLSCompliant(False)]
        public static ulong Increment(ref ulong location);
        [CLSCompliant(False)]
        public static uint Decrement(ref uint location);
        [CLSCompliant(False)]
        public static ulong Decrement(ref ulong location);
        [CLSCompliant(False)]
        public static uint Exchange(ref uint location1, uint value);
        [CLSCompliant(False)]
        public static ulong Exchange(ref ulong location1, ulong value);
        public static float Exchange(ref float location1, float value);
        public static double Exchange(ref double location1, double value);
        public static nint Exchange(ref nint location1, nint value);
        [CLSCompliant(False)]
        public static nuint Exchange(ref nuint location1, nuint value);
        [CLSCompliant(False)]
        public static uint CompareExchange(ref uint location1, uint value, uint comparand);
        [CLSCompliant(False)]
        public static ulong CompareExchange(ref ulong location1, ulong value, ulong comparand);
        public static float CompareExchange(ref float location1, float value, float comparand);
        public static double CompareExchange(ref double location1, double value, double comparand);
        public static nint CompareExchange(ref nint location1, nint value, nint comparand);
        [CLSCompliant(False)]
        public static nuint CompareExchange(ref nuint location1, nuint value, nuint comparand);
        [CLSCompliant(False)]
        public static uint Add(ref uint location1, uint value);
        [CLSCompliant(False)]
        public static ulong Add(ref ulong location1, ulong value);
        [CLSCompliant(False)]
        public static ulong Read(in ulong location);
        public static int And(ref int location1, int value);
        [CLSCompliant(False)]
        public static uint And(ref uint location1, uint value);
        public static long And(ref long location1, long value);
        [CLSCompliant(False)]
        public static ulong And(ref ulong location1, ulong value);
        public static int Or(ref int location1, int value);
        [CLSCompliant(False)]
        public static uint Or(ref uint location1, uint value);
        public static long Or(ref long location1, long value);
        [CLSCompliant(False)]
        public static ulong Or(ref ulong location1, ulong value);
        public static void MemoryBarrier();
    }
}
