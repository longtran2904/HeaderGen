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
    [NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
    [NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
    [UsedByNativeCode]
    public sealed class GraphicsBuffer : IDisposable
    {
        public GraphicsBuffer(Target target, int count, int stride);

        ~GraphicsBuffer();

        public int count { get; }
        public int stride { get; }
        public Target target { get; }
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
        public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
        [SecuritySafeCritical]
        public void SetData<T>(List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct;
        [SecuritySafeCritical]
        public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct;
        [SecurityCritical]
        public void GetData(Array data);
        [SecurityCritical]
        public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count);
        [FreeFunction(Name = "GraphicsBuffer_Bindings::InternalGetNativeBufferPtr", HasExplicitThis = True)]
        public nint GetNativeBufferPtr();
        public void SetCounterValue(uint counterValue);
        public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes);
        public static void CopyCount(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes);
        public static void CopyCount(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes);
        public static void CopyCount(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes);

        [Flags]
        public enum Target
        {
            Vertex = 1,
            Index = 2,
            CopySource = 4,
            CopyDestination = 8,
            Structured = 16,
            Raw = 32,
            Append = 64,
            Counter = 128,
            IndirectArguments = 256,
            Constant = 512
        }
        public struct IndirectDrawArgs
        {
            public const int size = 16;

            public uint vertexCountPerInstance { get; set; }
            public uint instanceCount { get; set; }
            public uint startVertex { get; set; }
            public uint startInstance { get; set; }
        }
        public struct IndirectDrawIndexedArgs
        {
            public const int size = 20;

            public uint indexCountPerInstance { get; set; }
            public uint instanceCount { get; set; }
            public uint startIndex { get; set; }
            public uint baseVertexIndex { get; set; }
            public uint startInstance { get; set; }
        }
    }
}
