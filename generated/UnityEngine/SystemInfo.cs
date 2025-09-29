#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
    [NativeHeader("Runtime/Input/GetInput.h")]
    [NativeHeader("Runtime/Misc/SystemInfo.h")]
    [NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
    [NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
    [NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
    [NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
    public sealed class SystemInfo
    {
        public const string unsupportedIdentifier = "n/a";

        public SystemInfo();

        [NativeProperty]
        public static float batteryLevel { get; }
        public static BatteryStatus batteryStatus { get; }
        public static string operatingSystem { get; }
        public static OperatingSystemFamily operatingSystemFamily { get; }
        public static string processorType { get; }
        public static int processorFrequency { get; }
        public static int processorCount { get; }
        public static int systemMemorySize { get; }
        public static string deviceUniqueIdentifier { get; }
        public static string deviceName { get; }
        public static string deviceModel { get; }
        public static bool supportsAccelerometer { get; }
        public static bool supportsGyroscope { get; }
        public static bool supportsLocationService { get; }
        public static bool supportsVibration { get; }
        public static bool supportsAudio { get; }
        public static DeviceType deviceType { get; }
        public static int graphicsMemorySize { get; }
        public static string graphicsDeviceName { get; }
        public static string graphicsDeviceVendor { get; }
        public static int graphicsDeviceID { get; }
        public static int graphicsDeviceVendorID { get; }
        public static GraphicsDeviceType graphicsDeviceType { get; }
        public static bool graphicsUVStartsAtTop { get; }
        public static string graphicsDeviceVersion { get; }
        public static int graphicsShaderLevel { get; }
        public static bool graphicsMultiThreaded { get; }
        public static RenderingThreadingMode renderingThreadingMode { get; }
        public static bool hasHiddenSurfaceRemovalOnGPU { get; }
        public static bool hasDynamicUniformArrayIndexingInFragmentShaders { get; }
        public static bool supportsShadows { get; }
        public static bool supportsRawShadowDepthSampling { get; }
        [Obsolete("supportsRenderTextures always returns true, no need to call it")]
        public static bool supportsRenderTextures { get; }
        public static bool supportsMotionVectors { get; }
        [Obsolete("supportsRenderToCubemap always returns true, no need to call it")]
        public static bool supportsRenderToCubemap { get; }
        [Obsolete("supportsImageEffects always returns true, no need to call it")]
        public static bool supportsImageEffects { get; }
        public static bool supports3DTextures { get; }
        public static bool supportsCompressed3DTextures { get; }
        public static bool supports2DArrayTextures { get; }
        public static bool supports3DRenderTextures { get; }
        public static bool supportsCubemapArrayTextures { get; }
        public static bool supportsAnisotropicFilter { get; }
        public static CopyTextureSupport copyTextureSupport { get; }
        public static bool supportsComputeShaders { get; }
        public static bool supportsGeometryShaders { get; }
        public static bool supportsTessellationShaders { get; }
        public static bool supportsRenderTargetArrayIndexFromVertexShader { get; }
        public static bool supportsInstancing { get; }
        public static bool supportsHardwareQuadTopology { get; }
        public static bool supports32bitsIndexBuffer { get; }
        public static bool supportsSparseTextures { get; }
        public static int supportedRenderTargetCount { get; }
        public static bool supportsSeparatedRenderTargetsBlend { get; }
        public static int supportedRandomWriteTargetCount { get; }
        public static int supportsMultisampledTextures { get; }
        public static bool supportsMultisampled2DArrayTextures { get; }
        public static bool supportsMultisampleAutoResolve { get; }
        public static int supportsTextureWrapMirrorOnce { get; }
        public static bool usesReversedZBuffer { get; }
        [Obsolete("supportsStencil always returns true, no need to call it")]
        public static int supportsStencil { get; }
        public static NPOTSupport npotSupport { get; }
        public static int maxTextureSize { get; }
        public static int maxTexture3DSize { get; }
        public static int maxTextureArraySlices { get; }
        public static int maxCubemapSize { get; }
        public static int maxAnisotropyLevel { get; }
        public static int maxComputeBufferInputsVertex { get; }
        public static int maxComputeBufferInputsFragment { get; }
        public static int maxComputeBufferInputsGeometry { get; }
        public static int maxComputeBufferInputsDomain { get; }
        public static int maxComputeBufferInputsHull { get; }
        public static int maxComputeBufferInputsCompute { get; }
        public static int maxComputeWorkGroupSize { get; }
        public static int maxComputeWorkGroupSizeX { get; }
        public static int maxComputeWorkGroupSizeY { get; }
        public static int maxComputeWorkGroupSizeZ { get; }
        public static int computeSubGroupSize { get; }
        public static bool supportsAsyncCompute { get; }
        public static bool supportsGpuRecorder { get; }
        public static bool supportsGraphicsFence { get; }
        public static bool supportsAsyncGPUReadback { get; }
        public static bool supportsRayTracing { get; }
        public static bool supportsSetConstantBuffer { get; }
        public static int constantBufferOffsetAlignment { get; }
        public static long maxGraphicsBufferSize { get; }
        [Obsolete("Use SystemInfo.constantBufferOffsetAlignment instead.")]
        public static bool minConstantBufferOffsetAlignment { get; }
        public static bool hasMipMaxLevel { get; }
        public static bool supportsMipStreaming { get; }
        [Obsolete("graphicsPixelFillrate is no longer supported in Unity 5.0+.")]
        public static int graphicsPixelFillrate { get; }
        public static bool usesLoadStoreActions { get; }
        public static HDRDisplaySupportFlags hdrDisplaySupportFlags { get; }
        public static bool supportsConservativeRaster { get; }
        public static bool supportsMultiview { get; }
        public static bool supportsStoreAndResolveAction { get; }
        public static bool supportsMultisampleResolveDepth { get; }
        [Obsolete("Vertex program support is required in Unity 5.0+")]
        public static bool supportsVertexPrograms { get; }
        [Obsolete("SystemInfo.supportsGPUFence has been deprecated, use SystemInfo.supportsGraphicsFence instead (UnityUpgradable) ->  supportsGraphicsFence", True)]
        public static bool supportsGPUFence { get; }

        public static bool SupportsRenderTextureFormat(RenderTextureFormat format);
        public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format);
        public static bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format);
        public static bool SupportsTextureFormat(TextureFormat format);
        public static bool SupportsVertexAttributeFormat(VertexAttributeFormat format, int dimension);
        [FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
        public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage);
        [FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
        public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage);
        [FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
        public static GraphicsFormat GetGraphicsFormat(DefaultFormat format);
        [FreeFunction("ScriptingGraphicsCaps::GetRenderTextureSupportedMSAASampleCount")]
        public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc);
    }
}
