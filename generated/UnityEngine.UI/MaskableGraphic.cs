#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Events;

namespace UnityEngine.UI
{
    public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
    {
        [NonSerialized]
        protected bool m_ShouldRecalculateStencil;
        [NonSerialized]
        protected Material m_MaskMaterial;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [NonSerialized]
        [Obsolete("Not used anymore.", True)]
        protected bool m_IncludeForMasking;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [NonSerialized]
        [Obsolete("Not used anymore", True)]
        protected bool m_ShouldRecalculate;
        [NonSerialized]
        protected int m_StencilValue;

        protected MaskableGraphic();

        public CullStateChangedEvent onCullStateChanged { get; set; }
        public bool maskable { get; set; }
        public bool isMaskingGraphic { get; set; }

        public virtual Material GetModifiedMaterial(Material baseMaterial);
        public virtual void Cull(Rect clipRect, bool validRect);
        public virtual void SetClipRect(Rect clipRect, bool validRect);
        public virtual void SetClipSoftness(Vector2 clipSoftness);
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnValidate();
        protected override void OnTransformParentChanged();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Not used anymore.", True)]
        public virtual void ParentMaskStateChanged();
        protected override void OnCanvasHierarchyChanged();
        public virtual void RecalculateClipping();
        public virtual void RecalculateMasking();

        public class CullStateChangedEvent : UnityEvent<bool>
        {
            public CullStateChangedEvent();
        }
    }
}
