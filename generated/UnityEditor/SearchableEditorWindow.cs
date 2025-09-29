#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor
{
    public class SearchableEditorWindow : EditorWindow
    {
        protected int m_SearchGroup;

        public SearchableEditorWindow();

        public virtual void OnEnable();
        public virtual void OnDisable();

        public enum SearchMode
        {
            All = 0,
            Name = 1,
            Type = 2,
            Label = 3,
            AssetBundleName = 4
        }
        public enum SearchModeHierarchyWindow
        {
            All = 0,
            Name = 1,
            Type = 2
        }
    }
}
