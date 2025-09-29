#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using System.Reflection;

namespace UnityEditor.Experimental.GraphView
{
    public class NodeAdapter
    {
        public NodeAdapter();

        public bool CanAdapt(object a, object b);
        public bool Connect(object a, object b);
        public MethodInfo GetAdapter(object a, object b);
        public MethodInfo GetTypeAdapter(Type from, Type to);
    }
}
