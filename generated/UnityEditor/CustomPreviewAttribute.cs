#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = False, Inherited = False)]
    public sealed class CustomPreviewAttribute : Attribute
    {

        public CustomPreviewAttribute(Type type);
    }
}
