#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine.Internal;

namespace Unity.Collections
{
    [DefaultMember("Item")]
    [NativeContainer]
    [NativeContainerSupportsDeallocateOnJobCompletion]
    [NativeContainerSupportsDeferredConvertListToArray]
    [NativeContainerSupportsMinMaxWriteRestriction]
    public struct NativeArray<T> : IDisposable, IEnumerable, IEnumerable<T>, IEquatable<NativeArray<T>> where T : struct
    {

        public NativeArray(int length, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory);
        public NativeArray(T[] array, Allocator allocator);
        public NativeArray(NativeArray<T> array, Allocator allocator);

        public T this[int index] { get; set; }
        public int Length { get; }
        public bool IsCreated { get; }

        [WriteAccessRequired]
        public void Dispose();
        public JobHandle Dispose(JobHandle inputDeps);
        [WriteAccessRequired]
        public void CopyFrom(T[] array);
        [WriteAccessRequired]
        public void CopyFrom(NativeArray<T> array);
        public void CopyTo(T[] array);
        public void CopyTo(NativeArray<T> array);
        public T[] ToArray();
        public Enumerator GetEnumerator();
        public bool Equals(NativeArray<T> other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static void Copy(NativeArray<T> src, NativeArray<T> dst);
        public static void Copy(ReadOnly src, NativeArray<T> dst);
        public static void Copy(T[] src, NativeArray<T> dst);
        public static void Copy(NativeArray<T> src, T[] dst);
        public static void Copy(ReadOnly src, T[] dst);
        public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length);
        public static void Copy(ReadOnly src, NativeArray<T> dst, int length);
        public static void Copy(T[] src, NativeArray<T> dst, int length);
        public static void Copy(NativeArray<T> src, T[] dst, int length);
        public static void Copy(ReadOnly src, T[] dst, int length);
        public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length);
        public static void Copy(ReadOnly src, int srcIndex, NativeArray<T> dst, int dstIndex, int length);
        public static void Copy(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length);
        public static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
        public static void Copy(ReadOnly src, int srcIndex, T[] dst, int dstIndex, int length);
        public U ReinterpretLoad<U>(int sourceIndex) where U : struct;
        public void ReinterpretStore<U>(int destIndex, U data) where U : struct;
        public NativeArray<U> Reinterpret<U>() where U : struct;
        public NativeArray<U> Reinterpret<U>(int expectedTypeSize) where U : struct;
        public NativeArray<T> GetSubArray(int start, int length);
        public ReadOnly AsReadOnly();

        public static bool operator ==(NativeArray<T> left, NativeArray<T> right);
        public static bool operator !=(NativeArray<T> left, NativeArray<T> right);
        [ExcludeFromDocs]
        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T>
        {

            public Enumerator(ref NativeArray<T> array);

            public T Current { get; }

            public void Dispose();
            public bool MoveNext();
            public void Reset();
        }
        [DefaultMember("Item")]
        [NativeContainer]
        [NativeContainerIsReadOnly]
        public struct ReadOnly : IEnumerable, IEnumerable<T>
        {

            public T this[int index] { get; }
            public int Length { get; }
            public bool IsCreated { get; }

            public void CopyTo(T[] array);
            public void CopyTo(NativeArray<T> array);
            public T[] ToArray();
            public NativeArray<U>.ReadOnly Reinterpret<U>() where U : struct;
            public Enumerator GetEnumerator();
            [ExcludeFromDocs]
            public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T>
            {

                public Enumerator(in ReadOnly array);

                public T Current { get; }

                public void Dispose();
                public bool MoveNext();
                public void Reset();
            }
        }
    }
}
