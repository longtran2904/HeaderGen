#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using Unity.Burst;
using UnityEngine.Bindings;

namespace Unity.Collections.LowLevel.Unsafe
{
    [NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
    [StaticAccessor("UnsafeUtility", StaticAccessorType.DoubleColon)]
    public static class UnsafeUtility
    {

        public static int GetFieldOffset(FieldInfo field);
        public static void* PinGCObjectAndGetAddress(object target, out ulong gcHandle);
        public static void* PinGCArrayAndGetDataAddress(Array target, out ulong gcHandle);
        [ThreadSafe]
        public static void ReleaseGCObject(ulong gcHandle);
        [ThreadSafe(ThrowsException = True)]
        public static void CopyObjectAddressToPtr(object target, void* dstPtr);
        public static bool IsBlittable<T>() where T : struct;
        [ThreadSafe(ThrowsException = False)]
        public static int CheckForLeaks();
        [ThreadSafe(ThrowsException = False)]
        public static int ForgiveLeaks();
        [BurstAuthorizedExternalMethod]
        [ThreadSafe(ThrowsException = False)]
        public static NativeLeakDetectionMode GetLeakDetectionMode();
        [BurstAuthorizedExternalMethod]
        [ThreadSafe(ThrowsException = False)]
        public static void SetLeakDetectionMode(NativeLeakDetectionMode value);
        [ThreadSafe(ThrowsException = True)]
        public static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip);
        [ThreadSafe(ThrowsException = True)]
        public static void FreeTracked(void* memory, Allocator allocator);
        [ThreadSafe(ThrowsException = True)]
        public static void* Malloc(long size, int alignment, Allocator allocator);
        [ThreadSafe(ThrowsException = True)]
        public static void Free(void* memory, Allocator allocator);
        public static bool IsValidAllocator(Allocator allocator);
        [ThreadSafe(ThrowsException = True)]
        public static void MemCpy(void* destination, void* source, long size);
        [ThreadSafe(ThrowsException = True)]
        public static void MemCpyReplicate(void* destination, void* source, int size, int count);
        [ThreadSafe(ThrowsException = True)]
        public static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count);
        [ThreadSafe(ThrowsException = True)]
        public static void MemMove(void* destination, void* source, long size);
        [ThreadSafe(ThrowsException = True)]
        public static void MemSet(void* destination, byte value, long size);
        public static void MemClear(void* destination, long size);
        [ThreadSafe(ThrowsException = True)]
        public static int MemCmp(void* ptr1, void* ptr2, long size);
        [ThreadSafe]
        public static int SizeOf(Type type);
        [ThreadSafe]
        public static bool IsBlittable(Type type);
        [ThreadSafe]
        public static bool IsUnmanaged(Type type);
        [ThreadSafe]
        public static bool IsValidNativeContainerElementType(Type type);
        public static bool IsUnmanaged<T>();
        public static bool IsValidNativeContainerElementType<T>();
        public static int AlignOf<T>() where T : struct;
        public static void CopyPtrToStructure<T>(void* ptr, out T output) where T : struct;
        public static void CopyStructureToPtr<T>(ref T input, void* ptr) where T : struct;
        public static T ReadArrayElement<T>(void* source, int index);
        public static T ReadArrayElementWithStride<T>(void* source, int index, int stride);
        public static void WriteArrayElement<T>(void* destination, int index, T value);
        public static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value);
        public static void* AddressOf<T>(ref T output) where T : struct;
        public static int SizeOf<T>() where T : struct;
        public static ref T As<U, T>(ref U from);
        public static ref T AsRef<T>(void* ptr) where T : struct;
        public static ref T ArrayElementAsRef<T>(void* ptr, int index) where T : struct;
        public static int EnumToInt<T>(T enumValue) where T : IConvertible, struct;
        public static bool EnumEquals<T>(T lhs, T rhs) where T : IConvertible, struct;
    }
}
