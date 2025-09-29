#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering
{
    public static class CoreUnsafeUtils
    {

        public static void CopyTo<T>(this List<T> list, void* dest, int count) where T : struct;
        public static void CopyTo<T>(this T[] list, void* dest, int count) where T : struct;
        public static void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray);
        public static void MergeSort(NativeArray<uint> arr, int sortSize, ref NativeArray<uint> supportArray);
        public static void InsertionSort(uint[] arr, int sortSize);
        public static void InsertionSort(NativeArray<uint> arr, int sortSize);
        public static void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits = 8);
        public static void RadixSort(NativeArray<uint> array, int sortSize, ref NativeArray<uint> supportArray, int radixBits = 8);
        public static void QuickSort(uint[] arr, int left, int right);
        public static void QuickSort<T>(int count, void* data) where T : IComparable<T>, struct;
        public static void QuickSort<TValue, TKey, TGetter>(int count, void* data) where TValue : struct where TKey : IComparable<TKey>, struct where TGetter : IKeyGetter<TValue, TKey>, struct;
        public static void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right) where TValue : struct where TKey : IComparable<TKey>, struct where TGetter : IKeyGetter<TValue, TKey>, struct;
        public static int IndexOf<T>(void* data, int count, T v) where T : IEquatable<T>, struct;
        public static int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) where TOldValue : struct where TOldGetter : IKeyGetter<TOldValue, Hash128>, struct where TNewValue : struct where TNewGetter : IKeyGetter<TNewValue, Hash128>, struct;
        public static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount);
        public static void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash) where TValue : struct where TGetter : IKeyGetter<TValue, Hash128>, struct;
        public static void CombineHashes(int count, Hash128* hashes, Hash128* outHash);
        public static bool HaveDuplicates(int[] arr);
        public struct FixedBufferStringQueue
        {

            public FixedBufferStringQueue(byte* ptr, int length);

            public int Count { get; }

            public bool TryPush(string v);
            public bool TryPop(out string v);
            public void Clear();
        }
        public interface IKeyGetter<TValue, TKey>
        {

            TKey Get(ref TValue v);
        }
    }
}
