#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Internal;

namespace UnityEditor
{
    [ExcludeFromDocs]
    [Flags]
    public enum CommandHint
    {
        Undefined = -1,
        None = 0,
        Event = 1,
        Menu = 2,
        Shortcut = 4,
        Shelf = 8,
        UI = 1048576,
        OnGUI = 3145728,
        UIElements = 5242880,
        Validate = 1073741824,
        UserDefined = -2147483648,
        Any = -1
    }
}
