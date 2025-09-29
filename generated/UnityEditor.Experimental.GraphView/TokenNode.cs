#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{
    public class TokenNode : Node
    {

        public TokenNode(Port input, Port output);

        public Texture icon { get; set; }
        public Port input { get; }
        public Port output { get; }
        public bool highlighted { get; set; }
    }
}
