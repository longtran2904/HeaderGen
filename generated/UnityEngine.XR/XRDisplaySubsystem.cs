#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_XR")]
    [NativeHeader("Modules/XR/XRPrefix.h")]
    [NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
    [UsedByNativeCode]
    public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
    {
        public XRDisplaySubsystem();

        [Obsolete("singlePassRenderingDisabled{get;set;} is deprecated. Use textureLayout and supportedTextureLayouts instead.", False)]
        public bool singlePassRenderingDisabled { get; set; }
        public bool displayOpaque { get; }
        public bool contentProtectionEnabled { get; set; }
        public float scaleOfAllViewports { get; set; }
        public float scaleOfAllRenderTargets { get; set; }
        public float zNear { get; set; }
        public float zFar { get; set; }
        public bool sRGB { get; set; }
        public float occlusionMaskScale { get; set; }
        public TextureLayout textureLayout { get; set; }
        public TextureLayout supportedTextureLayouts { get; }
        public ReprojectionMode reprojectionMode { get; set; }
        public bool disableLegacyRenderer { get; set; }

        public event Action<bool> displayFocusChanged;

        public void MarkTransformLateLatched(Transform transform, LateLatchNode nodeType);
        public void SetFocusPlane(Vector3 point, Vector3 normal, Vector3 velocity);
        public void SetMSAALevel(int level);
        public int GetRenderPassCount();
        public void GetRenderPass(int renderPassIndex, out XRRenderPass renderPass);
        public void EndRecordingIfLateLatched(Camera camera);
        public void BeginRecordingIfLateLatched(Camera camera);
        public void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters);
        [NativeMethod("TryGetAppGPUTimeLastFrame")]
        public bool TryGetAppGPUTimeLastFrame(out float gpuTimeLastFrame);
        [NativeMethod("TryGetCompositorGPUTimeLastFrame")]
        public bool TryGetCompositorGPUTimeLastFrame(out float gpuTimeLastFrameCompositor);
        [NativeMethod("TryGetDroppedFrameCount")]
        public bool TryGetDroppedFrameCount(out int droppedFrameCount);
        [NativeMethod("TryGetFramePresentCount")]
        public bool TryGetFramePresentCount(out int framePresentCount);
        [NativeMethod("TryGetDisplayRefreshRate")]
        public bool TryGetDisplayRefreshRate(out float displayRefreshRate);
        [NativeMethod("TryGetMotionToPhoton")]
        public bool TryGetMotionToPhoton(out float motionToPhoton);
        [NativeConditional("ENABLE_XR")]
        [NativeMethod(Name = "GetTextureForRenderPass", IsThreadSafe = False)]
        public RenderTexture GetRenderTextureForRenderPass(int renderPass);
        [NativeConditional("ENABLE_XR")]
        [NativeMethod(Name = "GetSharedDepthTextureForRenderPass", IsThreadSafe = False)]
        public RenderTexture GetSharedDepthTextureForRenderPass(int renderPass);
        [NativeConditional("ENABLE_XR")]
        [NativeMethod(Name = "GetPreferredMirrorViewBlitMode", IsThreadSafe = False)]
        public int GetPreferredMirrorBlitMode();
        [NativeConditional("ENABLE_XR")]
        [NativeMethod(Name = "SetPreferredMirrorViewBlitMode", IsThreadSafe = False)]
        public void SetPreferredMirrorBlitMode(int blitMode);
        [Obsolete("GetMirrorViewBlitDesc(RenderTexture, out XRMirrorViewBlitDesc) is deprecated. Use GetMirrorViewBlitDesc(RenderTexture, out XRMirrorViewBlitDesc, int) instead.", False)]
        public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc);
        [NativeConditional("ENABLE_XR")]
        [NativeMethod(Name = "QueryMirrorViewBlitDesc", IsThreadSafe = False)]
        public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode);
        [Obsolete("AddGraphicsThreadMirrorViewBlit(CommandBuffer, bool) is deprecated. Use AddGraphicsThreadMirrorViewBlit(CommandBuffer, bool, int) instead.", False)]
        public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate);
        [NativeConditional("ENABLE_XR")]
        [NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
        [NativeMethod(Name = "AddGraphicsThreadMirrorViewBlit", IsThreadSafe = False)]
        public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode);

        public enum LateLatchNode
        {
            Head = 0,
            LeftHand = 1,
            RightHand = 2
        }
        [Flags]
        public enum TextureLayout
        {
            Texture2DArray = 1,
            SingleTexture2D = 2,
            SeparateTexture2Ds = 4
        }
        public enum ReprojectionMode
        {
            Unspecified = 0,
            PositionAndOrientation = 1,
            OrientationOnly = 2,
            None = 3
        }
        [NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
        public struct XRRenderParameter
        {
            public Matrix4x4 view;
            public Matrix4x4 projection;
            public Rect viewport;
            public Mesh occlusionMesh;
            public int textureArraySlice;
            public Matrix4x4 previousView;
            public bool isPreviousViewValid;
        }
        [NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
        [NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
        [NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
        public struct XRRenderPass
        {
            public int renderPassIndex;
            public RenderTargetIdentifier renderTarget;
            public RenderTextureDescriptor renderTargetDesc;
            public bool hasMotionVectorPass;
            public RenderTargetIdentifier motionVectorRenderTarget;
            public RenderTextureDescriptor motionVectorRenderTargetDesc;
            public bool shouldFillOutDepth;
            public int cullingPassIndex;

            [NativeConditional("ENABLE_XR")]
            [NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameter", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
            public void GetRenderParameter(Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter);
            [NativeConditional("ENABLE_XR")]
            [NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameterCount", IsFreeFunction = True, HasExplicitThis = True)]
            public int GetRenderParameterCount();
        }
        [NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
        [NativeHeader("Runtime/Graphics/RenderTexture.h")]
        public struct XRBlitParams
        {
            public RenderTexture srcTex;
            public int srcTexArraySlice;
            public Rect srcRect;
            public Rect destRect;
        }
        [NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
        public struct XRMirrorViewBlitDesc
        {
            public bool nativeBlitAvailable;
            public bool nativeBlitInvalidStates;
            public int blitParamsCount;

            [NativeConditional("ENABLE_XR")]
            [NativeMethod(Name = "XRMirrorViewBlitDescScriptApi::GetBlitParameter", IsFreeFunction = True, HasExplicitThis = True)]
            public void GetBlitParameter(int blitParameterIndex, out XRBlitParams blitParameter);
        }
    }
}
