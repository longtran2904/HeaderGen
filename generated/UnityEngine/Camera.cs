#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Shaders/Shader.h")]
    [NativeHeader("Runtime/Misc/GameObjectUtility.h")]
    [NativeHeader("Runtime/Graphics/RenderTexture.h")]
    [NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
    [NativeHeader("Runtime/Camera/RenderManager.h")]
    [NativeHeader("Runtime/Camera/Camera.h")]
    [NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
    [RequireComponent(typeof(Transform))]
    [UsedByNativeCode]
    public sealed class Camera : Behaviour
    {
        public static CameraCallback onPreCull;
        public static CameraCallback onPreRender;
        public static CameraCallback onPostRender;

        public Camera();

        [NativeProperty("Near")]
        public float nearClipPlane { get; set; }
        [NativeProperty("Far")]
        public float farClipPlane { get; set; }
        [NativeProperty("VerticalFieldOfView")]
        public float fieldOfView { get; set; }
        public RenderingPath renderingPath { get; set; }
        public RenderingPath actualRenderingPath { get; }
        public bool allowHDR { get; set; }
        public bool allowMSAA { get; set; }
        public bool allowDynamicResolution { get; set; }
        [NativeProperty("ForceIntoRT")]
        public bool forceIntoRenderTexture { get; set; }
        public float orthographicSize { get; set; }
        public bool orthographic { get; set; }
        public OpaqueSortMode opaqueSortMode { get; set; }
        public TransparencySortMode transparencySortMode { get; set; }
        public Vector3 transparencySortAxis { get; set; }
        public float depth { get; set; }
        public float aspect { get; set; }
        public Vector3 velocity { get; }
        public int cullingMask { get; set; }
        public int eventMask { get; set; }
        public bool layerCullSpherical { get; set; }
        public CameraType cameraType { get; set; }
        [NativeConditional("UNITY_EDITOR")]
        public ulong overrideSceneCullingMask { get; set; }
        public float[] layerCullDistances { get; set; }
        public bool useOcclusionCulling { get; set; }
        public Matrix4x4 cullingMatrix { get; set; }
        public Color backgroundColor { get; set; }
        public CameraClearFlags clearFlags { get; set; }
        public DepthTextureMode depthTextureMode { get; set; }
        public bool clearStencilAfterLightingPass { get; set; }
        public bool usePhysicalProperties { get; set; }
        public Vector2 sensorSize { get; set; }
        public Vector2 lensShift { get; set; }
        public float focalLength { get; set; }
        public GateFitMode gateFit { get; set; }
        [NativeProperty("NormalizedViewportRect")]
        public Rect rect { get; set; }
        [NativeProperty("ScreenViewportRect")]
        public Rect pixelRect { get; set; }
        public int pixelWidth { get; }
        public int pixelHeight { get; }
        public int scaledPixelWidth { get; }
        public int scaledPixelHeight { get; }
        public RenderTexture targetTexture { get; set; }
        public RenderTexture activeTexture { get; }
        public int targetDisplay { get; set; }
        public Matrix4x4 cameraToWorldMatrix { get; }
        public Matrix4x4 worldToCameraMatrix { get; set; }
        public Matrix4x4 projectionMatrix { get; set; }
        public Matrix4x4 nonJitteredProjectionMatrix { get; set; }
        [NativeProperty("UseJitteredProjectionMatrixForTransparent")]
        public bool useJitteredProjectionMatrixForTransparentRendering { get; set; }
        public Matrix4x4 previousViewProjectionMatrix { get; }
        public static Camera main { get; }
        public static Camera current { get; }
        public Scene scene { get; set; }
        public bool stereoEnabled { get; }
        public float stereoSeparation { get; set; }
        public float stereoConvergence { get; set; }
        public bool areVRStereoViewMatricesWithinSingleCullTolerance { get; }
        public StereoTargetEyeMask stereoTargetEye { get; set; }
        public MonoOrStereoscopicEye stereoActiveEye { get; }
        public static int allCamerasCount { get; }
        public static Camera[] allCameras { get; }
        [NativeConditional("UNITY_EDITOR")]
        public SceneViewFilterMode sceneViewFilterMode { get; }
        public int commandBufferCount { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property isOrthoGraphic has been deprecated. Use orthographic (UnityUpgradable) -> orthographic", True)]
        public bool isOrthoGraphic { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property mainCamera has been deprecated. Use Camera.main instead (UnityUpgradable) -> main", True)]
        public static Camera mainCamera { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property near has been deprecated. Use Camera.nearClipPlane instead (UnityUpgradable) -> UnityEngine.Camera.nearClipPlane", False)]
        public float near { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property far has been deprecated. Use Camera.farClipPlane instead (UnityUpgradable) -> UnityEngine.Camera.farClipPlane", False)]
        public float far { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property fov has been deprecated. Use Camera.fieldOfView instead (UnityUpgradable) -> UnityEngine.Camera.fieldOfView", False)]
        public float fov { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property hdr has been deprecated. Use Camera.allowHDR instead (UnityUpgradable) -> UnityEngine.Camera.allowHDR", False)]
        public bool hdr { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property stereoMirrorMode is no longer supported. Please use single pass stereo rendering instead.", True)]
        public bool stereoMirrorMode { get; set; }

        public void Reset();
        public void ResetTransparencySortSettings();
        public void ResetAspect();
        public void ResetCullingMatrix();
        public void SetReplacementShader(Shader shader, string replacementTag);
        public void ResetReplacementShader();
        public float GetGateFittedFieldOfView();
        public Vector2 GetGateFittedLensShift();
        public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer);
        public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer);
        public void ResetWorldToCameraMatrix();
        public void ResetProjectionMatrix();
        [FreeFunction("CameraScripting::CalculateObliqueMatrix", HasExplicitThis = True)]
        public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane);
        public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye);
        public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye);
        public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye);
        public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye);
        public Vector3 WorldToScreenPoint(Vector3 position);
        public Vector3 WorldToViewportPoint(Vector3 position);
        public Vector3 ViewportToWorldPoint(Vector3 position);
        public Vector3 ScreenToWorldPoint(Vector3 position);
        public Vector3 ScreenToViewportPoint(Vector3 position);
        public Vector3 ViewportToScreenPoint(Vector3 position);
        public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye);
        public Ray ViewportPointToRay(Vector3 pos);
        public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye);
        public Ray ScreenPointToRay(Vector3 pos);
        public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners);
        public static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters = null);
        [NativeName("FocalLengthToFieldOfView_Safe")]
        public static float FocalLengthToFieldOfView(float focalLength, float sensorSize);
        [NativeName("FieldOfViewToFocalLength_Safe")]
        public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize);
        [NativeName("HorizontalToVerticalFieldOfView_Safe")]
        public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio);
        public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio);
        public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye);
        [FreeFunction("CameraScripting::GetStereoViewMatrix", HasExplicitThis = True)]
        public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye);
        public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye);
        [FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = True)]
        public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye);
        public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix);
        public void ResetStereoProjectionMatrices();
        public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix);
        public void ResetStereoViewMatrices();
        public static int GetAllCameras(Camera[] cameras);
        public bool RenderToCubemap(Cubemap cubemap, int faceMask);
        public bool RenderToCubemap(Cubemap cubemap);
        public bool RenderToCubemap(RenderTexture cubemap, int faceMask);
        public bool RenderToCubemap(RenderTexture cubemap);
        public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye);
        [FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
        public void Render();
        [FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = True)]
        public void RenderWithShader(Shader shader, string replacementTag);
        [FreeFunction("CameraScripting::RenderDontRestore", HasExplicitThis = True)]
        public void RenderDontRestore();
        public void SubmitRenderRequests(List<RenderRequest> renderRequests);
        [FreeFunction("CameraScripting::SetupCurrent")]
        public static void SetupCurrent(Camera cur);
        [FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = True)]
        public void CopyFrom(Camera other);
        public void RemoveCommandBuffers(CameraEvent evt);
        public void RemoveAllCommandBuffers();
        public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer);
        public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType);
        public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer);
        [FreeFunction("CameraScripting::GetCommandBuffers", HasExplicitThis = True)]
        public CommandBuffer[] GetCommandBuffers(CameraEvent evt);
        public bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters);
        public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Camera.GetScreenWidth has been deprecated. Use Screen.width instead (UnityUpgradable) -> System.Int32 Screen.width", True)]
        public float GetScreenWidth();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Camera.GetScreenHeight has been deprecated. Use Screen.height instead (UnityUpgradable) -> System.Int32 Screen.height", True)]
        public float GetScreenHeight();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Camera.DoClear has been deprecated (UnityUpgradable).", True)]
        public void DoClear();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Camera.ResetFieldOfView has been deprecated in Unity 5.6 and will be removed in the future. Please replace it by explicitly setting the camera's FOV to 60 degrees.", False)]
        public void ResetFieldOfView();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Camera.SetStereoViewMatrices has been deprecated. Use SetStereoViewMatrix(StereoscopicEye eye) instead.", False)]
        public void SetStereoViewMatrices(Matrix4x4 leftMatrix, Matrix4x4 rightMatrix);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Camera.SetStereoProjectionMatrices has been deprecated. Use SetStereoProjectionMatrix(StereoscopicEye eye) instead.", False)]
        public void SetStereoProjectionMatrices(Matrix4x4 leftMatrix, Matrix4x4 rightMatrix);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Camera.GetStereoViewMatrices has been deprecated. Use GetStereoViewMatrix(StereoscopicEye eye) instead.", False)]
        public Matrix4x4[] GetStereoViewMatrices();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Camera.GetStereoProjectionMatrices has been deprecated. Use GetStereoProjectionMatrix(StereoscopicEye eye) instead.", False)]
        public Matrix4x4[] GetStereoProjectionMatrices();

        public enum GateFitMode
        {
            Vertical = 1,
            Horizontal = 2,
            Fill = 3,
            Overscan = 4,
            None = 0
        }
        public enum FieldOfViewAxis
        {
            Vertical = 0,
            Horizontal = 1
        }
        public struct GateFitParameters
        {
            public GateFitParameters(GateFitMode mode, float aspect);

            public GateFitMode mode { get; set; }
            public float aspect { get; set; }
        }
        public enum StereoscopicEye
        {
            Left = 0,
            Right = 1
        }
        public enum MonoOrStereoscopicEye
        {
            Left = 0,
            Right = 1,
            Mono = 2
        }
        public enum SceneViewFilterMode
        {
            Off = 0,
            ShowFiltered = 1
        }
        public enum RenderRequestMode
        {
            None = 0,
            ObjectId = 1,
            Depth = 2,
            VertexNormal = 3,
            WorldPosition = 4,
            EntityId = 5,
            BaseColor = 6,
            SpecularColor = 7,
            Metallic = 8,
            Emission = 9,
            Normal = 10,
            Smoothness = 11,
            Occlusion = 12,
            DiffuseColor = 13
        }
        public enum RenderRequestOutputSpace
        {
            ScreenSpace = -1,
            UV0 = 0,
            UV1 = 1,
            UV2 = 2,
            UV3 = 3,
            UV4 = 4,
            UV5 = 5,
            UV6 = 6,
            UV7 = 7,
            UV8 = 8
        }
        public struct RenderRequest
        {
            public RenderRequest(RenderRequestMode mode, RenderTexture rt);
            public RenderRequest(RenderRequestMode mode, RenderRequestOutputSpace space, RenderTexture rt);

            public bool isValid { get; }
            public RenderRequestMode mode { get; }
            public RenderTexture result { get; }
            public RenderRequestOutputSpace outputSpace { get; }
        }
        public delegate void CameraCallback(Camera cam);
    }
}
