#region UnityEngine.VirtualTexturingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VirtualTexturingModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.VirtualTexturing
{
    [NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
    [Obsolete("Procedural Virtual Texturing is experimental, not ready for production use and Unity does not currently support it. The feature might be changed or removed in the future.", False)]
    [StaticAccessor("VirtualTexturing::Procedural", StaticAccessorType.DoubleColon)]
    public static class Procedural
    {
        [NativeThrows]
        public static void SetCPUCacheSize(int sizeInMegabytes);
        [NativeThrows]
        public static int GetCPUCacheSize();
        [NativeThrows]
        public static void SetGPUCacheSettings(GPUCacheSetting[] cacheSettings);
        [NativeThrows]
        public static GPUCacheSetting[] GetGPUCacheSettings();

        [NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
        public struct CreationParameters
        {
            public int width;
            public int height;
            public int maxActiveRequests;
            public int tilesize;
            public GraphicsFormat[] layers;
            public FilterMode filterMode;
            public const int MaxNumLayers = 4;
            public const int MaxRequestsPerFrameSupported = 4095;
        }
        public struct TextureStackRequestHandle<T> : IEquatable<TextureStackRequestHandle<T>> where T : struct
        {
            public override bool Equals(object obj);
            public bool Equals(TextureStackRequestHandle<T> other);
            public override int GetHashCode();
            public void CompleteRequest(RequestStatus status);
            public void CompleteRequest(RequestStatus status, CommandBuffer fenceBuffer);
            public static void CompleteRequests(NativeSlice<TextureStackRequestHandle<T>> requestHandles, NativeSlice<RequestStatus> status);
            public static void CompleteRequests(NativeSlice<TextureStackRequestHandle<T>> requestHandles, NativeSlice<RequestStatus> status, CommandBuffer fenceBuffer);
            public T GetRequestParameters();
            public static void GetRequestParameters(NativeSlice<TextureStackRequestHandle<T>> handles, NativeSlice<T> requests);

            public static bool operator !=(TextureStackRequestHandle<T> h1, TextureStackRequestHandle<T> h2);
            public static bool operator ==(TextureStackRequestHandle<T> h1, TextureStackRequestHandle<T> h2);
        }
        [NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
        [UsedByNativeCode]
        public struct GPUTextureStackRequestLayerParameters
        {
            public int destX;
            public int destY;
            public RenderTargetIdentifier dest;

            public int GetWidth();
            public int GetHeight();
        }
        [NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
        [UsedByNativeCode]
        public struct CPUTextureStackRequestLayerParameters
        {
            public int scanlineSize { get; }
            public int mipScanlineSize { get; }
            public bool requiresCachedMip { get; }

            public NativeArray<T> GetData<T>() where T : struct;
            public NativeArray<T> GetMipData<T>() where T : struct;
        }
        [NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
        [UsedByNativeCode]
        public struct GPUTextureStackRequestParameters
        {
            public int level;
            public int x;
            public int y;
            public int width;
            public int height;
            public int numLayers;

            public GPUTextureStackRequestLayerParameters GetLayer(int index);
        }
        [NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
        [UsedByNativeCode]
        public struct CPUTextureStackRequestParameters
        {
            public int level;
            public int x;
            public int y;
            public int width;
            public int height;
            public int numLayers;

            public CPUTextureStackRequestLayerParameters GetLayer(int index);
        }
        public enum RequestStatus
        {
            Dropped = 65539,
            Generated = 65538
        }
        public class TextureStackBase<T> : IDisposable where T : struct
        {
            public static readonly int borderSize;
            public const int AllMips = 2147483647;

            public TextureStackBase(string _name, CreationParameters _creationParams, bool gpuGeneration);

            public int PopRequests(NativeSlice<TextureStackRequestHandle<T>> requestHandles);
            public bool IsValid();
            public void Dispose();
            public void BindToMaterialPropertyBlock(MaterialPropertyBlock mpb);
            public void BindToMaterial(Material mat);
            public void BindGlobally();
            public void RequestRegion(Rect r, int mipMap, int numMips);
            public void InvalidateRegion(Rect r, int mipMap, int numMips);
            public void EvictRegion(Rect r, int mipMap, int numMips);
        }
        public sealed class GPUTextureStack : TextureStackBase<GPUTextureStackRequestParameters>
        {
            public GPUTextureStack(string _name, CreationParameters creationParams);
        }
        public sealed class CPUTextureStack : TextureStackBase<CPUTextureStackRequestParameters>
        {
            public CPUTextureStack(string _name, CreationParameters creationParams);
        }
    }
}
