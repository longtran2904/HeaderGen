#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public interface IKeyboardEvent
    {

        EventModifiers modifiers { get; }
        char character { get; }
        KeyCode keyCode { get; }
        bool shiftKey { get; }
        bool ctrlKey { get; }
        bool commandKey { get; }
        bool altKey { get; }
        bool actionKey { get; }
    }
}
