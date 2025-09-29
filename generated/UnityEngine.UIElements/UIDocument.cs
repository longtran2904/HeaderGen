#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    [AddComponentMenu("UI Toolkit/UI Document")]
    [DefaultExecutionOrder(-100)]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [HelpURL("UIE-get-started-with-runtime-ui")]
    public sealed class UIDocument : MonoBehaviour
    {
        public PanelSettings panelSettings { get; set; }
        public UIDocument parentUI { get; }
        public VisualTreeAsset visualTreeAsset { get; set; }
        public VisualElement rootVisualElement { get; }
        public float sortingOrder { get; set; }
    }
}
