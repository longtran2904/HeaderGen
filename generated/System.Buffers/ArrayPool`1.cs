#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Buffers
{
    public abstract class ArrayPool<T>
    {
        protected ArrayPool();

        public static ArrayPool<T> Shared { get; }

        public static ArrayPool<T> Create();
        public static ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket);
        public abstract T[] Rent(int minimumLength);
        public abstract void Return(T[] array, bool clearArray = False);
    }
}
