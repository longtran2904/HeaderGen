#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = True, Inherited = True)]
    public class ContextMenuItemAttribute : PropertyAttribute
    {
        public readonly string name;
        public readonly string function;

        public ContextMenuItemAttribute(string name, string function);
    }
}
