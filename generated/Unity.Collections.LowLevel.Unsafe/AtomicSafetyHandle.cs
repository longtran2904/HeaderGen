#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Diagnostics;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Collections.LowLevel.Unsafe
{
    [NativeHeader("Runtime/Jobs/JobsDebugger.h")]
    [NativeHeader("Runtime/Jobs/AtomicSafetyHandle.h")]
    [UsedByNativeCode]
    public struct AtomicSafetyHandle
    {
        [ThreadSafe]
        public static AtomicSafetyHandle Create();
        [ThreadSafe]
        public static AtomicSafetyHandle GetTempUnsafePtrSliceHandle();
        [ThreadSafe]
        public static AtomicSafetyHandle GetTempMemoryHandle();
        [ThreadSafe]
        public static bool IsTempMemoryHandle(AtomicSafetyHandle handle);
        [ThreadSafe]
        public static void Release(AtomicSafetyHandle handle);
        [ThreadSafe]
        public static bool IsDefaultValue(in AtomicSafetyHandle handle);
        [ThreadSafe]
        public static void PrepareUndisposable(ref AtomicSafetyHandle handle);
        [ThreadSafe]
        public static void UseSecondaryVersion(ref AtomicSafetyHandle handle);
        [ThreadSafe]
        public static void SetAllowSecondaryVersionWriting(AtomicSafetyHandle handle, bool allowWriting);
        [ThreadSafe]
        public static void SetBumpSecondaryVersionOnScheduleWrite(AtomicSafetyHandle handle, bool value);
        [NativeMethod(IsThreadSafe = True, IsFreeFunction = True)]
        public static void SetAllowReadOrWriteAccess(AtomicSafetyHandle handle, bool allowReadWriteAccess);
        [NativeMethod(IsThreadSafe = True, IsFreeFunction = True)]
        public static bool GetAllowReadOrWriteAccess(AtomicSafetyHandle handle);
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        public static void CheckWriteAndBumpSecondaryVersion(AtomicSafetyHandle handle);
        [ThreadSafe]
        public static EnforceJobResult EnforceAllBufferJobsHaveCompleted(AtomicSafetyHandle handle);
        [ThreadSafe]
        public static EnforceJobResult EnforceAllBufferJobsHaveCompletedAndRelease(AtomicSafetyHandle handle);
        [ThreadSafe]
        public static EnforceJobResult EnforceAllBufferJobsHaveCompletedAndDisableReadWrite(AtomicSafetyHandle handle);
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        [ThreadSafe(ThrowsException = True)]
        public static void CheckDeallocateAndThrow(AtomicSafetyHandle handle);
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        [ThreadSafe(ThrowsException = True)]
        public static void CheckGetSecondaryDataPointerAndThrow(AtomicSafetyHandle handle);
        [ThreadSafe]
        public static int GetReaderArray(AtomicSafetyHandle handle, int maxCount, nint output);
        [ThreadSafe]
        public static JobHandle GetWriter(AtomicSafetyHandle handle);
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        public static void CheckReadAndThrow(AtomicSafetyHandle handle);
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        public static void CheckWriteAndThrow(AtomicSafetyHandle handle);
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        public static void ValidateNonDefaultHandle(in AtomicSafetyHandle handle);
        public static bool IsValidNonDefaultHandle(in AtomicSafetyHandle handle);
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        public static void CheckExistsAndThrow(in AtomicSafetyHandle handle);
        public static bool IsHandleValid(in AtomicSafetyHandle handle);
        [ThreadSafe]
        public static string GetReaderName(AtomicSafetyHandle handle, int readerIndex);
        [ThreadSafe]
        public static string GetWriterName(AtomicSafetyHandle handle);
        [ThreadSafe]
        public static int NewStaticSafetyId(byte* ownerTypeNameBytes, int byteCount);
        public static int NewStaticSafetyId<T>();
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        [NativeThrows]
        [ThreadSafe]
        public static void SetCustomErrorMessage(int staticSafetyId, AtomicSafetyErrorType errorType, byte* messageBytes, int byteCount);
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        public static void SetStaticSafetyId(ref AtomicSafetyHandle handle, int staticSafetyId);
    }
}
