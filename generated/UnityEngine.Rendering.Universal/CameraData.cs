#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
    public struct CameraData
    {

        public Camera camera;
        public CameraRenderType renderType;
        public RenderTexture targetTexture;
        public RenderTextureDescriptor cameraTargetDescriptor;
        public float renderScale;
        public bool clearDepth;
        public CameraType cameraType;
        public bool isDefaultViewport;
        public bool isHdrEnabled;
        public bool requiresDepthTexture;
        public bool requiresOpaqueTexture;
        public bool postProcessingRequiresDepthTexture;
        public bool xrRendering;
        public SortingCriteria defaultOpaqueSortFlags;
        [Obsolete("Please use xr.enabled instead.")]
        public bool isStereoEnabled;
        public float maxShadowDistance;
        public bool postProcessEnabled;
        public IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> captureActions;
        public LayerMask volumeLayerMask;
        public Transform volumeTrigger;
        public bool isStopNaNEnabled;
        public bool isDitheringEnabled;
        public AntialiasingMode antialiasing;
        public AntialiasingQuality antialiasingQuality;
        public ScriptableRenderer renderer;
        public bool resolveFinalTarget;
        public Vector3 worldSpaceCameraPos;

        public bool isSceneViewCamera { get; }
        public bool isPreviewCamera { get; }

        public Matrix4x4 GetViewMatrix(int viewIndex = 0);
        public Matrix4x4 GetProjectionMatrix(int viewIndex = 0);
        public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0);
        public bool IsCameraProjectionMatrixFlipped();
    }
}
