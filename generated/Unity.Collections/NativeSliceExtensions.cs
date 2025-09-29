#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace Unity.Collections
{
    public static class NativeSliceExtensions
    {
        public static NativeSlice<T> Slice<T>(this NativeArray<T> thisArray) where T : struct;
        public static NativeSlice<T> Slice<T>(this NativeArray<T> thisArray, int start) where T : struct;
        public static NativeSlice<T> Slice<T>(this NativeArray<T> thisArray, int start, int length) where T : struct;
        public static NativeSlice<T> Slice<T>(this NativeSlice<T> thisSlice) where T : struct;
        public static NativeSlice<T> Slice<T>(this NativeSlice<T> thisSlice, int start) where T : struct;
        public static NativeSlice<T> Slice<T>(this NativeSlice<T> thisSlice, int start, int length) where T : struct;
    }
}
