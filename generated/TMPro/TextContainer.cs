#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
    [RequireComponent(typeof(RectTransform))]
    public class TextContainer : UIBehaviour
    {
        public TextContainer();

        public bool hasChanged { get; set; }
        public Vector2 pivot { get; set; }
        public TextContainerAnchors anchorPosition { get; set; }
        public Rect rect { get; set; }
        public Vector2 size { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public bool isDefaultWidth { get; }
        public bool isDefaultHeight { get; }
        public bool isAutoFitting { get; set; }
        public Vector3[] corners { get; }
        public Vector3[] worldCorners { get; }
        public Vector4 margins { get; set; }
        public RectTransform rectTransform { get; }
        public TextMeshPro textMeshPro { get; }

        protected override void Awake();
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnValidate();
        protected override void OnRectTransformDimensionsChange();
    }
}
