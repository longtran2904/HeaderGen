#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public class Random
    {

        public Random();
        public Random(int Seed);

        public static Random Shared { get; }

        public virtual int Next();
        public virtual int Next(int maxValue);
        public virtual int Next(int minValue, int maxValue);
        public virtual long NextInt64();
        public virtual long NextInt64(long maxValue);
        public virtual long NextInt64(long minValue, long maxValue);
        public virtual float NextSingle();
        public virtual double NextDouble();
        public virtual void NextBytes(byte[] buffer);
        public virtual void NextBytes(Span<byte> buffer);
        public void GetItems<T>(ReadOnlySpan<T> choices, Span<T> destination);
        public T[] GetItems<T>(T[] choices, int length);
        public T[] GetItems<T>(ReadOnlySpan<T> choices, int length);
        public void Shuffle<T>(T[] values);
        public void Shuffle<T>(Span<T> values);
        protected virtual double Sample();
    }
}
