#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = True)]
    [RequiredByNativeCode]
    public sealed class ContextMenu : Attribute
    {
        public readonly string menuItem;
        public readonly bool validate;
        public readonly int priority;

        public ContextMenu(string itemName);
        public ContextMenu(string itemName, bool isValidateFunction);
        public ContextMenu(string itemName, bool isValidateFunction, int priority);
    }
}
