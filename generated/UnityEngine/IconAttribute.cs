#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Diagnostics;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = False, Inherited = True)]
    [Conditional("UNITY_EDITOR")]
    public class IconAttribute : Attribute
    {
        public IconAttribute(string path);

        public string path { get; }
    }
}
