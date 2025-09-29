#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    public enum EventType
    {
        MouseDown = 0,
        MouseUp = 1,
        MouseMove = 2,
        MouseDrag = 3,
        KeyDown = 4,
        KeyUp = 5,
        ScrollWheel = 6,
        Repaint = 7,
        Layout = 8,
        DragUpdated = 9,
        DragPerform = 10,
        DragExited = 15,
        Ignore = 11,
        Used = 12,
        ValidateCommand = 13,
        ExecuteCommand = 14,
        ContextClick = 16,
        MouseEnterWindow = 20,
        MouseLeaveWindow = 21,
        TouchDown = 30,
        TouchUp = 31,
        TouchMove = 32,
        TouchEnter = 33,
        TouchLeave = 34,
        TouchStationary = 35,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use MouseDown instead (UnityUpgradable) -> MouseDown", True)]
        mouseDown = 0,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use MouseUp instead (UnityUpgradable) -> MouseUp", True)]
        mouseUp = 1,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use MouseMove instead (UnityUpgradable) -> MouseMove", True)]
        mouseMove = 2,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use MouseDrag instead (UnityUpgradable) -> MouseDrag", True)]
        mouseDrag = 3,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use KeyDown instead (UnityUpgradable) -> KeyDown", True)]
        keyDown = 4,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use KeyUp instead (UnityUpgradable) -> KeyUp", True)]
        keyUp = 5,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ScrollWheel instead (UnityUpgradable) -> ScrollWheel", True)]
        scrollWheel = 6,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use Repaint instead (UnityUpgradable) -> Repaint", True)]
        repaint = 7,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use Layout instead (UnityUpgradable) -> Layout", True)]
        layout = 8,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use DragUpdated instead (UnityUpgradable) -> DragUpdated", True)]
        dragUpdated = 9,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use DragPerform instead (UnityUpgradable) -> DragPerform", True)]
        dragPerform = 10,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use Ignore instead (UnityUpgradable) -> Ignore", True)]
        ignore = 11,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use Used instead (UnityUpgradable) -> Used", True)]
        used = 12
    }
}
