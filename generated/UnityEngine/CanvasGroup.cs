#region UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeClass("UI::CanvasGroup")]
    [NativeHeader("Modules/UI/CanvasGroup.h")]
    public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
    {
        public CanvasGroup();

        [NativeProperty("Alpha", False, TargetType.Function)]
        public float alpha { get; set; }
        [NativeProperty("Interactable", False, TargetType.Function)]
        public bool interactable { get; set; }
        [NativeProperty("BlocksRaycasts", False, TargetType.Function)]
        public bool blocksRaycasts { get; set; }
        [NativeProperty("IgnoreParentGroups", False, TargetType.Function)]
        public bool ignoreParentGroups { get; set; }

        public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
    }
}
