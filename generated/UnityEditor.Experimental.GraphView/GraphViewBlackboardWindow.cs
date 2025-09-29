#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

namespace UnityEditor.Experimental.GraphView
{
    [EditorWindowTitle(title = "Blackboard")]
    public class GraphViewBlackboardWindow : GraphViewToolWindow
    {

        public GraphViewBlackboardWindow();

        protected override string ToolName { get; }

        protected override void OnGraphViewChanging();
        protected override void OnGraphViewChanged();
        protected override bool IsGraphViewSupported(GraphView gv);
    }
}
