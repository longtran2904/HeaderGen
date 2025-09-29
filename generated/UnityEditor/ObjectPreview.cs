#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public class ObjectPreview : IPreviewable
    {

        protected UnityEngine.Object[] m_Targets;
        protected int m_ReferenceTargetIndex;

        public ObjectPreview();

        ~ObjectPreview();

        public virtual UnityEngine.Object target { get; }

        public virtual void Cleanup();
        public virtual void Initialize(UnityEngine.Object[] targets);
        public virtual bool MoveNextTarget();
        public virtual void ResetTarget();
        public virtual bool HasPreviewGUI();
        public virtual GUIContent GetPreviewTitle();
        public virtual void OnPreviewGUI(Rect r, GUIStyle background);
        public virtual void OnInteractivePreviewGUI(Rect r, GUIStyle background);
        public virtual void OnPreviewSettings();
        public virtual string GetInfoString();
        public void DrawPreview(Rect previewArea);
        public virtual void ReloadPreviewInstances();
    }
}
