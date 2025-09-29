#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Experimental.Rendering.Universal
{
    [AddComponentMenu("Rendering/2D/Pixel Perfect Camera")]
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2d-pixelperfect.html%23properties")]
    [MovedFrom("UnityEngine.Experimental.Rendering")]
    [RequireComponent(typeof(Camera))]
    public class PixelPerfectCamera : MonoBehaviour, IPixelPerfectCamera, ISerializationCallbackReceiver
    {

        public PixelPerfectCamera();

        public CropFrame cropFrame { get; set; }
        public GridSnapping gridSnapping { get; set; }
        public float orthographicSize { get; }
        public int assetsPPU { get; set; }
        public int refResolutionX { get; set; }
        public int refResolutionY { get; set; }
        [Obsolete("Use gridSnapping instead", False)]
        public bool upscaleRT { get; set; }
        [Obsolete("Use gridSnapping instead", False)]
        public bool pixelSnapping { get; set; }
        [Obsolete("Use cropFrame instead", False)]
        public bool cropFrameX { get; set; }
        [Obsolete("Use cropFrame instead", False)]
        public bool cropFrameY { get; set; }
        [Obsolete("Use cropFrame instead", False)]
        public bool stretchFill { get; set; }
        public int pixelRatio { get; }

        public Vector3 RoundToPixel(Vector3 position);
        public float CorrectCinemachineOrthoSize(float targetOrthoSize);
        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
        public enum CropFrame
        {

            None = 0,
            Pillarbox = 1,
            Letterbox = 2,
            Windowbox = 3,
            StretchFill = 4
        }
        public enum GridSnapping
        {

            None = 0,
            PixelSnapping = 1,
            UpscaleRenderTexture = 2
        }
    }
}
