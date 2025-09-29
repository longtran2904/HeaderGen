#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Overlays
{
    public abstract class Overlay
    {

        public static readonly string ussClassName;

        protected Overlay();

        public EditorWindow containerWindow { get; }
        public string id { get; }
        public Layout layout { get; }
        public bool collapsed { get; set; }
        public string displayName { get; set; }
        public bool displayed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected internal virtual Layout supportedLayouts { get; }
        public bool isInToolbar { get; }
        public Vector2 floatingPosition { get; set; }
        public bool floating { get; }

        public event Action<Layout> layoutChanged;
        public event Action<bool> collapsedChanged;
        public event Action<bool> displayedChanged;
        public event Action<bool> floatingChanged;
        public event Action<Vector3> floatingPositionChanged;

        public abstract VisualElement CreatePanelContent();
        public virtual void OnCreated();
        public virtual void OnWillBeDestroyed();
        public void Undock();
    }
}
