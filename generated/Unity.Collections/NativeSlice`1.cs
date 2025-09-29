#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Internal;

namespace Unity.Collections
{
    [DefaultMember("Item")]
    [NativeContainer]
    [NativeContainerSupportsMinMaxWriteRestriction]
    public struct NativeSlice<T> : IEnumerable, IEnumerable<T>, IEquatable<NativeSlice<T>> where T : struct
    {
        public NativeSlice(NativeSlice<T> slice, int start);
        public NativeSlice(NativeSlice<T> slice, int start, int length);
        public NativeSlice(NativeArray<T> array);
        public NativeSlice(NativeArray<T> array, int start);
        public NativeSlice(NativeArray<T> array, int start, int length);

        public T this[int index] { get; set; }
        public int Stride { get; }
        public int Length { get; }

        public NativeSlice<U> SliceConvert<U>() where U : struct;
        public NativeSlice<U> SliceWithStride<U>(int offset) where U : struct;
        public NativeSlice<U> SliceWithStride<U>() where U : struct;
        [WriteAccessRequired]
        public void CopyFrom(NativeSlice<T> slice);
        [WriteAccessRequired]
        public void CopyFrom(T[] array);
        public void CopyTo(NativeArray<T> array);
        public void CopyTo(T[] array);
        public T[] ToArray();
        public Enumerator GetEnumerator();
        public bool Equals(NativeSlice<T> other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(NativeSlice<T> left, NativeSlice<T> right);
        public static bool operator !=(NativeSlice<T> left, NativeSlice<T> right);

        public static implicit operator NativeSlice<T>(NativeArray<T> array);

        [ExcludeFromDocs]
        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T>
        {
            public Enumerator(ref NativeSlice<T> array);

            public T Current { get; }

            public void Dispose();
            public bool MoveNext();
            public void Reset();
        }
    }
}
