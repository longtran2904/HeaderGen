#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    public class AspectRatioFitter : UIBehaviour, ILayoutController, ILayoutSelfController
    {

        protected AspectRatioFitter();

        public AspectMode aspectMode { get; set; }
        public float aspectRatio { get; set; }

        protected override void OnEnable();
        protected override void Start();
        protected override void OnDisable();
        protected override void OnTransformParentChanged();
        protected virtual void Update();
        protected override void OnRectTransformDimensionsChange();
        public virtual void SetLayoutHorizontal();
        public virtual void SetLayoutVertical();
        protected void SetDirty();
        public bool IsComponentValidOnObject();
        public bool IsAspectModeValid();
        protected override void OnValidate();
        public enum AspectMode
        {

            None = 0,
            WidthControlsHeight = 1,
            HeightControlsWidth = 2,
            FitInParent = 3,
            EnvelopeParent = 4
        }
    }
}
