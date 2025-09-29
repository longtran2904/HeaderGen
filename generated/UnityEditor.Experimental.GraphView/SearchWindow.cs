#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{
    [InitializeOnLoad]
    public class SearchWindow : EditorWindow
    {

        public SearchWindow();

        public static bool Open<T>(SearchWindowContext context, T provider) where T : ScriptableObject, ISearchWindowProvider;
    }
}
