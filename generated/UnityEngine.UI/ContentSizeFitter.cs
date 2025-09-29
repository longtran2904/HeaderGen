#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("Layout/Content Size Fitter", 141)]
    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    public class ContentSizeFitter : UIBehaviour, ILayoutController, ILayoutSelfController
    {

        [SerializeField]
        protected FitMode m_HorizontalFit;
        [SerializeField]
        protected FitMode m_VerticalFit;

        protected ContentSizeFitter();

        public FitMode horizontalFit { get; set; }
        public FitMode verticalFit { get; set; }

        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnRectTransformDimensionsChange();
        public virtual void SetLayoutHorizontal();
        public virtual void SetLayoutVertical();
        protected void SetDirty();
        protected override void OnValidate();
        public enum FitMode
        {

            Unconstrained = 0,
            MinSize = 1,
            PreferredSize = 2
        }
    }
}
