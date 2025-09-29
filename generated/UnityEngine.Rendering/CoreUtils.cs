#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Rendering
{
    public static class CoreUtils
    {

        public static readonly Vector3[] lookAtList;
        public static readonly Vector3[] upVectorList;
        [Obsolete("Use CoreUtils.Priorities instead", False)]
        public const int editMenuPriority1 = 320;
        [Obsolete("Use CoreUtils.Priorities instead", False)]
        public const int editMenuPriority2 = 331;
        [Obsolete("Use CoreUtils.Priorities instead", False)]
        public const int editMenuPriority3 = 342;
        [Obsolete("Use CoreUtils.Priorities instead", False)]
        public const int editMenuPriority4 = 353;
        [Obsolete("Use CoreUtils.Priorities instead", False)]
        public const int assetCreateMenuPriority1 = 230;
        [Obsolete("Use CoreUtils.Priorities instead", False)]
        public const int assetCreateMenuPriority2 = 241;
        [Obsolete("Use CoreUtils.Priorities instead", False)]
        public const int assetCreateMenuPriority3 = 300;
        [Obsolete("Use CoreUtils.Priorities instead", False)]
        public const int gameObjectMenuPriority = 10;

        public static Cubemap blackCubeTexture { get; }
        public static Cubemap magentaCubeTexture { get; }
        public static CubemapArray magentaCubeTextureArray { get; }
        public static Cubemap whiteCubeTexture { get; }
        public static RenderTexture emptyUAV { get; }
        public static Texture3D blackVolumeTexture { get; }

        public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, Color clearColor);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = ClearFlag.None, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = ClearFlag.None);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag);
        public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1);
        public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = ClearFlag.None, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1);
        public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1);
        public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1);
        public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = ClearFlag.None);
        public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor);
        public static void SetViewport(CommandBuffer cmd, RTHandle target);
        public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = MSAASamples.None);
        public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = MSAASamples.None);
        public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, TextureDimension dim, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = MSAASamples.None, bool dynamicRes = False);
        public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = False, int depth = 0);
        public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = False, int depth = 0);
        public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, Color clearColor, bool clearMips = False);
        public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties = null, int shaderPassId = 0);
        public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0);
        public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0);
        public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0);
        public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, MaterialPropertyBlock properties = null, int shaderPassId = 0);
        public static Color ConvertSRGBToActiveColorSpace(Color color);
        public static Color ConvertLinearToActiveColorSpace(Color color);
        public static Material CreateEngineMaterial(string shaderPath);
        public static Material CreateEngineMaterial(Shader shader);
        public static bool HasFlag<T>(T mask, T flag) where T : IConvertible;
        public static void Swap<T>(ref T a, ref T b);
        public static void SetKeyword(CommandBuffer cmd, string keyword, bool state);
        public static void SetKeyword(Material material, string keyword, bool state);
        public static void SetKeyword(ComputeShader cs, string keyword, bool state);
        public static void Destroy(Object obj);
        public static IEnumerable<Type> GetAllAssemblyTypes();
        public static IEnumerable<Type> GetAllTypesDerivedFrom<T>();
        public static void SafeRelease(ComputeBuffer buffer);
        public static Mesh CreateCubeMesh(Vector3 min, Vector3 max);
        public static bool ArePostProcessesEnabled(Camera camera);
        public static bool AreAnimatedMaterialsEnabled(Camera camera);
        public static bool IsSceneLightingDisabled(Camera camera);
        public static bool IsLightOverlapDebugEnabled(Camera camera);
        public static bool IsSceneViewFogEnabled(Camera camera);
        public static bool IsSceneFilteringEnabled();
        public static bool IsSceneViewPrefabStageContextHidden();
        [Obsolete("Use the updated RendererList API in the UnityEngine.Rendering.RendererUtils namespace.")]
        public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, RendererList rendererList);
        public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, RendererList rendererList);
        public static int GetTextureHash(Texture texture);
        public static int PreviousPowerOfTwo(int size);
        public static T GetLastEnumValue<T>() where T : Enum;
        public static IEnumerable<T> LoadAllAssets<T>(string extension = "asset", bool allowSubTypes = True) where T : class;
        public static void EnsureFolderTreeInAssetFilePath(string filePath);
        public static class Sections
        {

            public const int section1 = 10000;
            public const int section2 = 20000;
            public const int section3 = 30000;
            public const int section4 = 40000;
            public const int section5 = 50000;
            public const int section6 = 60000;
            public const int section7 = 70000;
            public const int section8 = 80000;
        }
        public static class Priorities
        {

            public const int assetsCreateShaderMenuPriority = 83;
            public const int assetsCreateRenderingMenuPriority = 308;
            public const int editMenuPriority = 320;
            public const int gameObjectMenuPriority = 10;
            public const int srpLensFlareMenuPriority = 303;
        }
    }
}
