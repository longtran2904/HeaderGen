#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.Security;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeClass("GraphicsBuffer")]
    [NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
    [NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
    [UsedByNativeCode]
    public sealed class ComputeBuffer : IDisposable
    {
        public ComputeBuffer(int count, int stride);
        public ComputeBuffer(int count, int stride, ComputeBufferType type);
        public ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage);

        ~ComputeBuffer();

        public int count { get; }
        public int stride { get; }
        public string name { set; }

        public void Dispose();
        public void Release();
        public bool IsValid();
        [SecuritySafeCritical]
        public void SetData(Array data);
        [SecuritySafeCritical]
        public void SetData<T>(List<T> data) where T : struct;
        [SecuritySafeCritical]
        public void SetData<T>(NativeArray<T> data) where T : struct;
        [SecuritySafeCritical]
        public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count);
        [SecuritySafeCritical]
        public void SetData<T>(List<T> data, int managedBufferStartIndex, int computeBufferStartIndex, int count) where T : struct;
        [SecuritySafeCritical]
        public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) where T : struct;
        [SecurityCritical]
        public void GetData(Array data);
        [SecurityCritical]
        public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count);
        public NativeArray<T> BeginWrite<T>(int computeBufferStartIndex, int count) where T : struct;
        public void EndWrite<T>(int countWritten) where T : struct;
        public void SetCounterValue(uint counterValue);
        public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes);
        public nint GetNativeBufferPtr();
    }
}
