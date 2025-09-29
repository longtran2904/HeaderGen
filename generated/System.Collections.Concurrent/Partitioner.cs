#region System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Collections.Concurrent.dll
#endregion

using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    public static class Partitioner
    {
        public static OrderablePartitioner<TSource> Create<TSource>(IList<TSource> list, bool loadBalance);
        public static OrderablePartitioner<TSource> Create<TSource>(TSource[] array, bool loadBalance);
        public static OrderablePartitioner<TSource> Create<TSource>(IEnumerable<TSource> source);
        public static OrderablePartitioner<TSource> Create<TSource>(IEnumerable<TSource> source, EnumerablePartitionerOptions partitionerOptions);
        public static OrderablePartitioner<Tuple<long, long>> Create(long fromInclusive, long toExclusive);
        public static OrderablePartitioner<Tuple<long, long>> Create(long fromInclusive, long toExclusive, long rangeSize);
        public static OrderablePartitioner<Tuple<int, int>> Create(int fromInclusive, int toExclusive);
        public static OrderablePartitioner<Tuple<int, int>> Create(int fromInclusive, int toExclusive, int rangeSize);
    }
}
