#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public static class Volatile
    {

        public static bool Read(in bool location);
        public static void Write(ref bool location, bool value);
        public static byte Read(in byte location);
        public static void Write(ref byte location, byte value);
        public static double Read(in double location);
        public static void Write(ref double location, double value);
        public static short Read(in short location);
        public static void Write(ref short location, short value);
        public static int Read(in int location);
        public static void Write(ref int location, int value);
        public static long Read(in long location);
        public static void Write(ref long location, long value);
        public static nint Read(in nint location);
        public static void Write(ref nint location, nint value);
        [CLSCompliant(False)]
        public static sbyte Read(in sbyte location);
        [CLSCompliant(False)]
        public static void Write(ref sbyte location, sbyte value);
        public static float Read(in float location);
        public static void Write(ref float location, float value);
        [CLSCompliant(False)]
        public static ushort Read(in ushort location);
        [CLSCompliant(False)]
        public static void Write(ref ushort location, ushort value);
        [CLSCompliant(False)]
        public static uint Read(in uint location);
        [CLSCompliant(False)]
        public static void Write(ref uint location, uint value);
        [CLSCompliant(False)]
        public static ulong Read(in ulong location);
        [CLSCompliant(False)]
        public static void Write(ref ulong location, ulong value);
        [CLSCompliant(False)]
        public static nuint Read(in nuint location);
        [CLSCompliant(False)]
        public static void Write(ref nuint location, nuint value);
        public static T Read<T>(in T location) where T : class;
        public static void Write<T>(ref T location, T value) where T : class;
    }
}
