#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class ContextualMenuManipulator : MouseManipulator
    {
        public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder);

        protected override void RegisterCallbacksOnTarget();
        protected override void UnregisterCallbacksFromTarget();
    }
}
