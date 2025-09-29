#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = False, Inherited = True)]
    public sealed class ColorUsageAttribute : PropertyAttribute
    {

        public readonly bool showAlpha;
        public readonly bool hdr;
        [Obsolete("This field is no longer used for anything.")]
        public readonly float minBrightness;
        [Obsolete("This field is no longer used for anything.")]
        public readonly float maxBrightness;
        [Obsolete("This field is no longer used for anything.")]
        public readonly float minExposureValue;
        [Obsolete("This field is no longer used for anything.")]
        public readonly float maxExposureValue;

        public ColorUsageAttribute(bool showAlpha);
        public ColorUsageAttribute(bool showAlpha, bool hdr);
        [Obsolete("Brightness and exposure parameters are no longer used for anything. Use ColorUsageAttribute(bool showAlpha, bool hdr)")]
        public ColorUsageAttribute(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue);
    }
}
