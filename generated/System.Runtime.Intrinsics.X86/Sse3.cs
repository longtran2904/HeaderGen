#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Sse3 : Sse2
    {
        public static bool IsSupported { get; }

        public static Vector128<float> AddSubtract(Vector128<float> left, Vector128<float> right);
        public static Vector128<double> AddSubtract(Vector128<double> left, Vector128<double> right);
        public static Vector128<float> HorizontalAdd(Vector128<float> left, Vector128<float> right);
        public static Vector128<double> HorizontalAdd(Vector128<double> left, Vector128<double> right);
        public static Vector128<float> HorizontalSubtract(Vector128<float> left, Vector128<float> right);
        public static Vector128<double> HorizontalSubtract(Vector128<double> left, Vector128<double> right);
        public static Vector128<double> LoadAndDuplicateToVector128(double* address);
        public static Vector128<sbyte> LoadDquVector128(sbyte* address);
        public static Vector128<byte> LoadDquVector128(byte* address);
        public static Vector128<short> LoadDquVector128(short* address);
        public static Vector128<ushort> LoadDquVector128(ushort* address);
        public static Vector128<int> LoadDquVector128(int* address);
        public static Vector128<uint> LoadDquVector128(uint* address);
        public static Vector128<long> LoadDquVector128(long* address);
        public static Vector128<ulong> LoadDquVector128(ulong* address);
        public static Vector128<double> MoveAndDuplicate(Vector128<double> source);
        public static Vector128<float> MoveHighAndDuplicate(Vector128<float> source);
        public static Vector128<float> MoveLowAndDuplicate(Vector128<float> source);

        public abstract class X64 : Sse2.X64
        {
            public static bool IsSupported { get; }
        }
    }
}
