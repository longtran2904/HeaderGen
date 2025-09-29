#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public interface IVisualElementScheduledItem
    {

        VisualElement element { get; }
        bool isActive { get; }

        void Resume();
        void Pause();
        void ExecuteLater(long delayMs);
        IVisualElementScheduledItem StartingIn(long delayMs);
        IVisualElementScheduledItem Every(long intervalMs);
        IVisualElementScheduledItem Until(Func<bool> stopCondition);
        IVisualElementScheduledItem ForDuration(long durationMs);
    }
}
