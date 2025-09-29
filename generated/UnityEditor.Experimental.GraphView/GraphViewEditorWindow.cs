#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.Experimental.GraphView
{
    public abstract class GraphViewEditorWindow : EditorWindow
    {
        protected GraphViewEditorWindow();

        public virtual IEnumerable<GraphView> graphViews { get; }

        public override IEnumerable<Type> GetExtraPaneTypes();
        public static List<EditorWindow> ShowGraphViewWindowWithTools<T>() where T : GraphViewEditorWindow;
    }
}
