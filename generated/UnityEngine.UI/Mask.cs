#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Mask", 13)]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
    {
        protected Mask();

        public RectTransform rectTransform { get; }
        public bool showMaskGraphic { get; set; }
        public Graphic graphic { get; }

        public virtual bool MaskEnabled();
        [Obsolete("Not used anymore.")]
        public virtual void OnSiblingGraphicEnabledDisabled();
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnValidate();
        public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
        public virtual Material GetModifiedMaterial(Material baseMaterial);
    }
}
