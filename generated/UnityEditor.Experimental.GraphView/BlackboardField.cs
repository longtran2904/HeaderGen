#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class BlackboardField : GraphElement
    {

        public BlackboardField();
        public BlackboardField(Texture icon, string text, string typeText);

        public string text { get; set; }
        public string typeText { get; set; }
        public Texture icon { get; set; }
        public bool highlighted { get; set; }
        public Blackboard blackboard { get; }

        protected override void ExecuteDefaultAction(EventBase evt);
        public void OpenTextEditor();
        protected virtual void BuildFieldContextualMenu(ContextualMenuPopulateEvent evt);
    }
}
