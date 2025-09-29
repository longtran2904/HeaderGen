#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.Security;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Profiling;
using UnityEngine.Rendering.RendererUtils;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
    [NativeHeader("Runtime/Shaders/RayTracingShader.h")]
    [NativeHeader("Runtime/Shaders/ComputeShader.h")]
    [NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
    [UsedByNativeCode]
    public class CommandBuffer : IDisposable
    {
        public CommandBuffer();

        ~CommandBuffer();

        public string name { get; set; }
        public int sizeInBytes { get; }

        public void ConvertTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst);
        public void ConvertTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement);
        [NativeMethod("AddWaitAllAsyncReadbackRequests")]
        public void WaitAllAsyncReadbackRequests();
        public void RequestAsyncReadback(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadback(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadback(ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadback(GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadback(Texture src, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadback(Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadback(Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadback(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback);
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        public void RequestAsyncReadbackIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct;
        [NativeMethod("AddSetInvertCulling")]
        public void SetInvertCulling(bool invertCulling);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetComputeFloatParam", HasExplicitThis = True)]
        public void SetComputeFloatParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, float val);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetComputeIntParam", HasExplicitThis = True)]
        public void SetComputeIntParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, int val);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorParam", HasExplicitThis = True)]
        public void SetComputeVectorParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, Vector4 val);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorArrayParam", HasExplicitThis = True)]
        public void SetComputeVectorArrayParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, [Unmarshalled] Vector4[] values);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetComputeMatrixParam", HasExplicitThis = True)]
        public void SetComputeMatrixParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, Matrix4x4 val);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetComputeMatrixArrayParam", HasExplicitThis = True)]
        public void SetComputeMatrixArrayParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, [Unmarshalled] Matrix4x4[] values);
        [NativeMethod("AddSetRayTracingShaderPass")]
        public void SetRayTracingShaderPass([NotNull("ArgumentNullException")] RayTracingShader rayTracingShader, string passName);
        [NativeMethod("ClearCommands")]
        public void Clear();
        [FreeFunction("RenderingCommandBuffer_Bindings::ClearRandomWriteTargets", ThrowsException = True, HasExplicitThis = True)]
        public void ClearRandomWriteTargets();
        [FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", ThrowsException = True, HasExplicitThis = True)]
        public void SetViewport(Rect pixelRect);
        [FreeFunction("RenderingCommandBuffer_Bindings::EnableScissorRect", ThrowsException = True, HasExplicitThis = True)]
        public void EnableScissorRect(Rect scissor);
        [FreeFunction("RenderingCommandBuffer_Bindings::DisableScissorRect", ThrowsException = True, HasExplicitThis = True)]
        public void DisableScissorRect();
        [FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRT", HasExplicitThis = True)]
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter);
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer);
        public void GetTemporaryRT(int nameID, int width, int height);
        public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter);
        public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc);
        [FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRTArray", HasExplicitThis = True)]
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, bool useDynamicScale);
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite);
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing);
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, GraphicsFormat format);
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite);
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing);
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite);
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format);
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter);
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer);
        public void GetTemporaryRTArray(int nameID, int width, int height, int slices);
        [FreeFunction("RenderingCommandBuffer_Bindings::ReleaseTemporaryRT", HasExplicitThis = True)]
        public void ReleaseTemporaryRT(int nameID);
        [FreeFunction("RenderingCommandBuffer_Bindings::ClearRenderTarget", HasExplicitThis = True)]
        public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil);
        public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor);
        public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = True)]
        public void SetGlobalFloat(int nameID, float value);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInt", HasExplicitThis = True)]
        public void SetGlobalInt(int nameID, int value);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInteger", HasExplicitThis = True)]
        public void SetGlobalInteger(int nameID, int value);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = True)]
        public void SetGlobalVector(int nameID, Vector4 value);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalColor", HasExplicitThis = True)]
        public void SetGlobalColor(int nameID, Color value);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrix", HasExplicitThis = True)]
        public void SetGlobalMatrix(int nameID, Matrix4x4 value);
        [FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = True)]
        public void EnableShaderKeyword(string keyword);
        public void EnableKeyword(in GlobalKeyword keyword);
        public void EnableKeyword(Material material, in LocalKeyword keyword);
        public void EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword);
        [FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = True)]
        public void DisableShaderKeyword(string keyword);
        public void DisableKeyword(in GlobalKeyword keyword);
        public void DisableKeyword(Material material, in LocalKeyword keyword);
        public void DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword);
        public void SetKeyword(in GlobalKeyword keyword, bool value);
        public void SetKeyword(Material material, in LocalKeyword keyword, bool value);
        public void SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetViewMatrix", ThrowsException = True, HasExplicitThis = True)]
        public void SetViewMatrix(Matrix4x4 view);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetProjectionMatrix", ThrowsException = True, HasExplicitThis = True)]
        public void SetProjectionMatrix(Matrix4x4 proj);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetViewProjectionMatrices", ThrowsException = True, HasExplicitThis = True)]
        public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj);
        [NativeMethod("AddSetGlobalDepthBias")]
        public void SetGlobalDepthBias(float bias, float slopeBias);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetExecutionFlags", ThrowsException = True, HasExplicitThis = True)]
        public void SetExecutionFlags(CommandBufferExecutionFlags flags);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArray", ThrowsException = True, HasExplicitThis = True)]
        public void SetGlobalFloatArray(int nameID, [Unmarshalled] float[] values);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArray", ThrowsException = True, HasExplicitThis = True)]
        public void SetGlobalVectorArray(int nameID, [Unmarshalled] Vector4[] values);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArray", ThrowsException = True, HasExplicitThis = True)]
        public void SetGlobalMatrixArray(int nameID, [Unmarshalled] Matrix4x4[] values);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetLateLatchProjectionMatrices", ThrowsException = True, HasExplicitThis = True)]
        public void SetLateLatchProjectionMatrices([Unmarshalled] Matrix4x4[] projectionMat);
        [FreeFunction("RenderingCommandBuffer_Bindings::MarkLateLatchMatrixShaderPropertyID", HasExplicitThis = True)]
        public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
        [FreeFunction("RenderingCommandBuffer_Bindings::UnmarkLateLatchMatrix", HasExplicitThis = True)]
        public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType);
        [FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = True)]
        public void BeginSample(string name);
        [FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = True)]
        public void EndSample(string name);
        public void BeginSample(CustomSampler sampler);
        public void EndSample(CustomSampler sampler);
        [FreeFunction("RenderingCommandBuffer_Bindings::IncrementUpdateCount", HasExplicitThis = True)]
        public void IncrementUpdateCount(RenderTargetIdentifier dest);
        [FreeFunction("RenderingCommandBuffer_Bindings::SetInstanceMultiplier", HasExplicitThis = True)]
        public void SetInstanceMultiplier(uint multiplier);
        public void SetRenderTarget(RenderTargetIdentifier rt);
        public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction);
        public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction);
        public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel);
        public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace);
        public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice);
        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth);
        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel);
        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace);
        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice);
        public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction);
        public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth);
        public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice);
        public void SetRenderTarget(RenderTargetBinding binding, int mipLevel, CubemapFace cubemapFace, int depthSlice);
        public void SetRenderTarget(RenderTargetBinding binding);
        [SecuritySafeCritical]
        public void SetBufferData(ComputeBuffer buffer, Array data);
        [SecuritySafeCritical]
        public void SetBufferData<T>(ComputeBuffer buffer, List<T> data) where T : struct;
        [SecuritySafeCritical]
        public void SetBufferData<T>(ComputeBuffer buffer, NativeArray<T> data) where T : struct;
        [SecuritySafeCritical]
        public void SetBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
        [SecuritySafeCritical]
        public void SetBufferData<T>(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct;
        [SecuritySafeCritical]
        public void SetBufferData<T>(ComputeBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct;
        public void SetBufferCounterValue(ComputeBuffer buffer, uint counterValue);
        [SecuritySafeCritical]
        public void SetBufferData(GraphicsBuffer buffer, Array data);
        [SecuritySafeCritical]
        public void SetBufferData<T>(GraphicsBuffer buffer, List<T> data) where T : struct;
        [SecuritySafeCritical]
        public void SetBufferData<T>(GraphicsBuffer buffer, NativeArray<T> data) where T : struct;
        [SecuritySafeCritical]
        public void SetBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
        [SecuritySafeCritical]
        public void SetBufferData<T>(GraphicsBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct;
        [SecuritySafeCritical]
        public void SetBufferData<T>(GraphicsBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct;
        public void SetBufferCounterValue(GraphicsBuffer buffer, uint counterValue);
        public void Dispose();
        public void Release();
        public GraphicsFence CreateAsyncGraphicsFence();
        public GraphicsFence CreateAsyncGraphicsFence(SynchronisationStage stage);
        public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage);
        public void WaitOnAsyncGraphicsFence(GraphicsFence fence);
        public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage);
        public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage);
        public void SetComputeFloatParam(ComputeShader computeShader, string name, float val);
        public void SetComputeIntParam(ComputeShader computeShader, string name, int val);
        public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val);
        public void SetComputeVectorArrayParam(ComputeShader computeShader, string name, Vector4[] values);
        public void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val);
        public void SetComputeMatrixArrayParam(ComputeShader computeShader, string name, Matrix4x4[] values);
        public void SetComputeFloatParams(ComputeShader computeShader, string name, params float[] values);
        public void SetComputeFloatParams(ComputeShader computeShader, int nameID, params float[] values);
        public void SetComputeIntParams(ComputeShader computeShader, string name, params int[] values);
        public void SetComputeIntParams(ComputeShader computeShader, int nameID, params int[] values);
        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt);
        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt);
        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel);
        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel);
        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element);
        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element);
        public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer);
        public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer);
        public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer);
        public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBuffer buffer);
        public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size);
        public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, ComputeBuffer buffer, int offset, int size);
        public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size);
        public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, GraphicsBuffer buffer, int offset, int size);
        public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
        public void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset);
        public void DispatchCompute(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset);
        public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure);
        public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin);
        public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure);
        public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure);
        public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer);
        public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer);
        public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size);
        public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer, int offset, int size);
        public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size);
        public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer, int offset, int size);
        public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, RenderTargetIdentifier rt);
        public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, RenderTargetIdentifier rt);
        public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, string name, float val);
        public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, int nameID, float val);
        public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, string name, params float[] values);
        public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, int nameID, params float[] values);
        public void SetRayTracingIntParam(RayTracingShader rayTracingShader, string name, int val);
        public void SetRayTracingIntParam(RayTracingShader rayTracingShader, int nameID, int val);
        public void SetRayTracingIntParams(RayTracingShader rayTracingShader, string name, params int[] values);
        public void SetRayTracingIntParams(RayTracingShader rayTracingShader, int nameID, params int[] values);
        public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, string name, Vector4 val);
        public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, int nameID, Vector4 val);
        public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, string name, params Vector4[] values);
        public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, int nameID, params Vector4[] values);
        public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, string name, Matrix4x4 val);
        public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4 val);
        public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, string name, params Matrix4x4[] values);
        public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, int nameID, params Matrix4x4[] values);
        public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, Camera camera = null);
        public void GenerateMips(RenderTargetIdentifier rt);
        public void GenerateMips(RenderTexture rt);
        public void ResolveAntiAliasedSurface(RenderTexture rt, RenderTexture target = null);
        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties);
        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass);
        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex);
        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material);
        public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass);
        public void DrawRenderer(Renderer renderer, Material material, int submeshIndex);
        public void DrawRenderer(Renderer renderer, Material material);
        public void DrawRendererList(RendererList rendererList);
        public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties);
        public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount);
        public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount);
        public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties);
        public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount);
        public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount);
        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);
        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset);
        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs);
        public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);
        public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset);
        public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs);
        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);
        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset);
        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs);
        public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);
        public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset);
        public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs);
        public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties);
        public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count);
        public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices);
        public void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties = null);
        public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);
        public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset);
        public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs);
        public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);
        public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset);
        public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs);
        public void DrawOcclusionMesh(RectInt normalizedCamViewport);
        public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt);
        public void SetRandomWriteTarget(int index, ComputeBuffer buffer, bool preserveCounterValue);
        public void SetRandomWriteTarget(int index, ComputeBuffer buffer);
        public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue);
        public void SetRandomWriteTarget(int index, GraphicsBuffer buffer);
        public void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes);
        public void CopyCounterValue(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes);
        public void CopyCounterValue(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes);
        public void CopyCounterValue(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes);
        public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst);
        public void CopyTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement);
        public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip);
        public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY);
        public void Blit(Texture source, RenderTargetIdentifier dest);
        public void Blit(Texture source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset);
        public void Blit(Texture source, RenderTargetIdentifier dest, Material mat);
        public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass);
        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest);
        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset);
        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat);
        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass);
        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, int sourceDepthSlice, int destDepthSlice);
        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice);
        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass, int destDepthSlice);
        public void SetGlobalFloat(string name, float value);
        public void SetGlobalInt(string name, int value);
        public void SetGlobalInteger(string name, int value);
        public void SetGlobalVector(string name, Vector4 value);
        public void SetGlobalColor(string name, Color value);
        public void SetGlobalMatrix(string name, Matrix4x4 value);
        public void SetGlobalFloatArray(string propertyName, List<float> values);
        public void SetGlobalFloatArray(int nameID, List<float> values);
        public void SetGlobalFloatArray(string propertyName, float[] values);
        public void SetGlobalVectorArray(string propertyName, List<Vector4> values);
        public void SetGlobalVectorArray(int nameID, List<Vector4> values);
        public void SetGlobalVectorArray(string propertyName, Vector4[] values);
        public void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values);
        public void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values);
        public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values);
        public void SetGlobalTexture(string name, RenderTargetIdentifier value);
        public void SetGlobalTexture(int nameID, RenderTargetIdentifier value);
        public void SetGlobalTexture(string name, RenderTargetIdentifier value, RenderTextureSubElement element);
        public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element);
        public void SetGlobalBuffer(string name, ComputeBuffer value);
        public void SetGlobalBuffer(int nameID, ComputeBuffer value);
        public void SetGlobalBuffer(string name, GraphicsBuffer value);
        public void SetGlobalBuffer(int nameID, GraphicsBuffer value);
        public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size);
        public void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size);
        public void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size);
        public void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size);
        public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode);
        public void SetSinglePassStereo(SinglePassStereoMode mode);
        public void IssuePluginEvent(nint callback, int eventID);
        public void IssuePluginEventAndData(nint callback, int eventID, nint data);
        public void IssuePluginCustomBlit(nint callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
        [Obsolete("Use IssuePluginCustomTextureUpdateV2 to register TextureUpdate callbacks instead. Callbacks will be passed event IDs kUnityRenderingExtEventUpdateTextureBeginV2 or kUnityRenderingExtEventUpdateTextureEndV2, and data parameter of type UnityRenderingExtTextureUpdateParamsV2.", False)]
        public void IssuePluginCustomTextureUpdate(nint callback, Texture targetTexture, uint userData);
        [Obsolete("Use IssuePluginCustomTextureUpdateV2 to register TextureUpdate callbacks instead. Callbacks will be passed event IDs kUnityRenderingExtEventUpdateTextureBeginV2 or kUnityRenderingExtEventUpdateTextureEndV2, and data parameter of type UnityRenderingExtTextureUpdateParamsV2.", False)]
        public void IssuePluginCustomTextureUpdateV1(nint callback, Texture targetTexture, uint userData);
        public void IssuePluginCustomTextureUpdateV2(nint callback, Texture targetTexture, uint userData);
        public void ProcessVTFeedback(RenderTargetIdentifier rt, nint resolver, int slice, int x, int width, int y, int height, int mip);
        public void CopyBuffer(GraphicsBuffer source, GraphicsBuffer dest);
        [Obsolete("CommandBuffer.CreateGPUFence has been deprecated. Use CreateGraphicsFence instead (UnityUpgradable) -> CreateAsyncGraphicsFence(*)", False)]
        public GPUFence CreateGPUFence(SynchronisationStage stage);
        [Obsolete("CommandBuffer.CreateGPUFence has been deprecated. Use CreateGraphicsFence instead (UnityUpgradable) -> CreateAsyncGraphicsFence()", False)]
        public GPUFence CreateGPUFence();
        [Obsolete("CommandBuffer.WaitOnGPUFence has been deprecated. Use WaitOnGraphicsFence instead (UnityUpgradable) -> WaitOnAsyncGraphicsFence(*)", False)]
        public void WaitOnGPUFence(GPUFence fence, SynchronisationStage stage);
        [Obsolete("CommandBuffer.WaitOnGPUFence has been deprecated. Use WaitOnGraphicsFence instead (UnityUpgradable) -> WaitOnAsyncGraphicsFence(*)", False)]
        public void WaitOnGPUFence(GPUFence fence);
        [Obsolete("CommandBuffer.SetComputeBufferData has been deprecated. Use SetBufferData instead (UnityUpgradable) -> SetBufferData(*)", False)]
        public void SetComputeBufferData(ComputeBuffer buffer, Array data);
        [Obsolete("CommandBuffer.SetComputeBufferData has been deprecated. Use SetBufferData instead (UnityUpgradable) -> SetBufferData(*)", False)]
        public void SetComputeBufferData<T>(ComputeBuffer buffer, List<T> data) where T : struct;
        [Obsolete("CommandBuffer.SetComputeBufferData has been deprecated. Use SetBufferData instead (UnityUpgradable) -> SetBufferData(*)", False)]
        public void SetComputeBufferData<T>(ComputeBuffer buffer, NativeArray<T> data) where T : struct;
        [Obsolete("CommandBuffer.SetComputeBufferData has been deprecated. Use SetBufferData instead (UnityUpgradable) -> SetBufferData(*)", False)]
        public void SetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
        [Obsolete("CommandBuffer.SetComputeBufferData has been deprecated. Use SetBufferData instead (UnityUpgradable) -> SetBufferData(*)", False)]
        public void SetComputeBufferData<T>(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct;
        [Obsolete("CommandBuffer.SetComputeBufferData has been deprecated. Use SetBufferData instead (UnityUpgradable) -> SetBufferData(*)", False)]
        public void SetComputeBufferData<T>(ComputeBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct;
        [Obsolete("CommandBuffer.SetComputeBufferCounterValue has been deprecated. Use SetBufferCounterValue instead (UnityUpgradable) -> SetBufferCounterValue(*)", False)]
        public void SetComputeBufferCounterValue(ComputeBuffer buffer, uint counterValue);
    }
}
