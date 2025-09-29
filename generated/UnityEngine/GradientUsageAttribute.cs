#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = False, Inherited = True)]
    public sealed class GradientUsageAttribute : PropertyAttribute
    {

        public readonly bool hdr;
        public readonly ColorSpace colorSpace;

        public GradientUsageAttribute(bool hdr);
        public GradientUsageAttribute(bool hdr, ColorSpace colorSpace);
    }
}
