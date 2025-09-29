#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    public abstract class Graphic : UIBehaviour, ICanvasElement
    {

        [FormerlySerializedAs("m_Mat")]
        [SerializeField]
        protected Material m_Material;
        [NonSerialized]
        protected bool m_SkipLayoutUpdate;
        [NonSerialized]
        protected bool m_SkipMaterialUpdate;
        [NonSerialized]
        protected UnityAction m_OnDirtyLayoutCallback;
        [NonSerialized]
        protected UnityAction m_OnDirtyVertsCallback;
        [NonSerialized]
        protected UnityAction m_OnDirtyMaterialCallback;
        [NonSerialized]
        protected Mesh m_CachedMesh;
        [NonSerialized]
        protected Vector2[] m_CachedUvs;
        protected static Material s_DefaultUI;
        protected static Texture2D s_WhiteTexture;
        [NonSerialized]
        protected static Mesh s_Mesh;

        protected Graphic();

        public static Material defaultGraphicMaterial { get; }
        public virtual Color color { get; set; }
        public virtual bool raycastTarget { get; set; }
        public Vector4 raycastPadding { get; set; }
        protected bool useLegacyMeshGeneration { get; set; }
        public int depth { get; }
        public RectTransform rectTransform { get; }
        public Canvas canvas { get; }
        public CanvasRenderer canvasRenderer { get; }
        public virtual Material defaultMaterial { get; }
        public virtual Material material { get; set; }
        public virtual Material materialForRendering { get; }
        public virtual Texture mainTexture { get; }
        protected static Mesh workerMesh { get; }

        public virtual void SetAllDirty();
        public virtual void SetLayoutDirty();
        public virtual void SetVerticesDirty();
        public virtual void SetMaterialDirty();
        public void SetRaycastDirty();
        protected override void OnRectTransformDimensionsChange();
        protected override void OnBeforeTransformParentChanged();
        protected override void OnTransformParentChanged();
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnDestroy();
        protected override void OnCanvasHierarchyChanged();
        public virtual void OnCullingChanged();
        public virtual void Rebuild(CanvasUpdate update);
        public virtual void LayoutComplete();
        public virtual void GraphicUpdateComplete();
        protected virtual void UpdateMaterial();
        protected virtual void UpdateGeometry();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use OnPopulateMesh instead.", True)]
        protected virtual void OnFillVBO(List<UIVertex> vbo);
        [Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", False)]
        protected virtual void OnPopulateMesh(Mesh m);
        protected virtual void OnPopulateMesh(VertexHelper vh);
        public virtual void OnRebuildRequested();
        protected override void Reset();
        protected override void OnDidApplyAnimationProperties();
        public virtual void SetNativeSize();
        public virtual bool Raycast(Vector2 sp, Camera eventCamera);
        protected override void OnValidate();
        public Vector2 PixelAdjustPoint(Vector2 point);
        public Rect GetPixelAdjustedRect();
        public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB);
        public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        public void RegisterDirtyLayoutCallback(UnityAction action);
        public void UnregisterDirtyLayoutCallback(UnityAction action);
        public void RegisterDirtyVerticesCallback(UnityAction action);
        public void UnregisterDirtyVerticesCallback(UnityAction action);
        public void RegisterDirtyMaterialCallback(UnityAction action);
        public void UnregisterDirtyMaterialCallback(UnityAction action);
    }
}
