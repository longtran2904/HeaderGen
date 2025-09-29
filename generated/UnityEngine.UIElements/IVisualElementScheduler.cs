#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public interface IVisualElementScheduler
    {

        IVisualElementScheduledItem Execute(Action<TimerState> timerUpdateEvent);
        IVisualElementScheduledItem Execute(Action updateEvent);
    }
}
