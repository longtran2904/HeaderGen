#region System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.Concurrent.dll
#endregion

using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    public abstract class Partitioner<TSource>
    {
        protected Partitioner();

        public virtual bool SupportsDynamicPartitions { get; }

        public abstract IList<IEnumerator<TSource>> GetPartitions(int partitionCount);
        public virtual IEnumerable<TSource> GetDynamicPartitions();
    }
}
