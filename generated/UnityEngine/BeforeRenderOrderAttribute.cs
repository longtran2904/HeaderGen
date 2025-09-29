#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Method)]
    public class BeforeRenderOrderAttribute : Attribute
    {
        public BeforeRenderOrderAttribute(int order);

        public int order { get; }
    }
}
