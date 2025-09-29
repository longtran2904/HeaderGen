#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;

namespace UnityEditor.Experimental.GraphView
{
    [Flags]
    public enum Capabilities
    {

        Selectable = 1,
        Collapsible = 2,
        Resizable = 4,
        Movable = 8,
        Deletable = 16,
        Droppable = 32,
        Ascendable = 64,
        Renamable = 128,
        Copiable = 256,
        Snappable = 512,
        Groupable = 1024,
        Stackable = 2048
    }
}
