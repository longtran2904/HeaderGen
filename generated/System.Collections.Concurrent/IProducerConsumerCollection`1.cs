#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    public interface IProducerConsumerCollection<T> : ICollection, IEnumerable, IEnumerable<T>
    {

        void CopyTo(T[] array, int index);
        bool TryAdd(T item);
        bool TryTake(out T item);
        T[] ToArray();
    }
}
