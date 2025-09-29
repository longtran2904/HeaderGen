#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    [HelpURL("UIE-Runtime-Panel-Settings")]
    public class PanelSettings : ScriptableObject
    {
        [SerializeField]
        public PanelTextSettings textSettings;

        public ThemeStyleSheet themeStyleSheet { get; set; }
        public RenderTexture targetTexture { get; set; }
        public PanelScaleMode scaleMode { get; set; }
        public float scale { get; set; }
        public float referenceDpi { get; set; }
        public float fallbackDpi { get; set; }
        public Vector2Int referenceResolution { get; set; }
        public PanelScreenMatchMode screenMatchMode { get; set; }
        public float match { get; set; }
        public float sortingOrder { get; set; }
        public int targetDisplay { get; set; }
        public bool clearDepthStencil { get; set; }
        public float depthClearValue { get; }
        public bool clearColor { get; set; }
        public Color colorClearValue { get; set; }
        public DynamicAtlasSettings dynamicAtlasSettings { get; set; }

        public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction);
    }
}
