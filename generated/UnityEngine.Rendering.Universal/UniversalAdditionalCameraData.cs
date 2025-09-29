#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
    [DisallowMultipleComponent]
    [ImageEffectAllowedInSceneView]
    [RequireComponent(typeof(Camera))]
    [URPHelpURL("universal-additional-camera-data")]
    public class UniversalAdditionalCameraData : MonoBehaviour, IAdditionalData, ISerializationCallbackReceiver
    {
        public UniversalAdditionalCameraData();

        public float version { get; }
        public bool renderShadows { get; set; }
        public CameraOverrideOption requiresDepthOption { get; set; }
        public CameraOverrideOption requiresColorOption { get; set; }
        public CameraRenderType renderType { get; set; }
        public List<Camera> cameraStack { get; }
        public bool clearDepth { get; }
        public bool requiresDepthTexture { get; set; }
        public bool requiresColorTexture { get; set; }
        public ScriptableRenderer scriptableRenderer { get; }
        public LayerMask volumeLayerMask { get; set; }
        public Transform volumeTrigger { get; set; }
        public bool requiresVolumeFrameworkUpdate { get; }
        public VolumeStack volumeStack { get; set; }
        public bool renderPostProcessing { get; set; }
        public AntialiasingMode antialiasing { get; set; }
        public AntialiasingQuality antialiasingQuality { get; set; }
        public bool stopNaN { get; set; }
        public bool dithering { get; set; }
        public bool allowXRRendering { get; set; }

        public void SetRenderer(int index);
        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
        public void OnDrawGizmos();
        public void OnDestroy();
    }
}
