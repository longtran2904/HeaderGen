#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class ShortcutHandler : Manipulator
    {

        public ShortcutHandler(Dictionary<Event, ShortcutDelegate> dictionary);

        protected override void RegisterCallbacksOnTarget();
        protected override void UnregisterCallbacksFromTarget();
    }
}
