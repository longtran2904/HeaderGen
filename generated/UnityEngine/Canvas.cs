#region UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeClass("UI::Canvas")]
    [NativeHeader("Modules/UI/UIStructs.h")]
    [NativeHeader("Modules/UI/CanvasManager.h")]
    [NativeHeader("Modules/UI/Canvas.h")]
    [RequireComponent(typeof(RectTransform))]
    public sealed class Canvas : Behaviour
    {
        public Canvas();

        public RenderMode renderMode { get; set; }
        public bool isRootCanvas { get; }
        public Rect pixelRect { get; }
        public float scaleFactor { get; set; }
        public float referencePixelsPerUnit { get; set; }
        public bool overridePixelPerfect { get; set; }
        public bool vertexColorAlwaysGammaSpace { get; set; }
        public bool pixelPerfect { get; set; }
        public float planeDistance { get; set; }
        public int renderOrder { get; }
        public bool overrideSorting { get; set; }
        public int sortingOrder { get; set; }
        public int targetDisplay { get; set; }
        public int sortingLayerID { get; set; }
        public int cachedSortingLayerValue { get; }
        public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
        public string sortingLayerName { get; set; }
        public Canvas rootCanvas { get; }
        public Vector2 renderingDisplaySize { get; }
        [NativeProperty("Camera", False, TargetType.Function)]
        public Camera worldCamera { get; set; }
        [NativeProperty("SortingBucketNormalizedSize", False, TargetType.Function)]
        public float normalizedSortingGridSize { get; set; }
        [NativeProperty("SortingBucketNormalizedSize", False, TargetType.Function)]
        [Obsolete("Setting normalizedSize via a int is not supported. Please use normalizedSortingGridSize", False)]
        public int sortingGridNormalizedSize { get; set; }

        public static event WillRenderCanvases preWillRenderCanvases;
        public static event WillRenderCanvases willRenderCanvases;

        [FreeFunction("UI::GetDefaultUIMaterial")]
        [Obsolete("Shared default material now used for text and general UI elements, call Canvas.GetDefaultCanvasMaterial()", False)]
        public static Material GetDefaultCanvasTextMaterial();
        [FreeFunction("UI::GetDefaultUIMaterial")]
        public static Material GetDefaultCanvasMaterial();
        [FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
        public static Material GetETC1SupportedCanvasMaterial();
        public static void ForceUpdateCanvases();

        public delegate void WillRenderCanvases();
    }
}
