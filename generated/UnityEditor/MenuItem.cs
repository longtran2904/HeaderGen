#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = True)]
    [RequiredByNativeCode]
    public sealed class MenuItem : Attribute
    {
        public string menuItem;
        public bool validate;
        public int priority;
        public string[] editorModes;

        public MenuItem(string itemName);
        public MenuItem(string itemName, bool isValidateFunction);
        public MenuItem(string itemName, bool isValidateFunction, int priority);
    }
}
