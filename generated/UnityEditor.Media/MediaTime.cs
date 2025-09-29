#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Media
{
    public struct MediaTime
    {

        public static readonly MediaTime Invalid;

        public MediaTime(long seconds);
        public MediaTime(long count, uint rateNumerator, uint rateDenominator = 1);

        public long count { get; set; }
        public MediaRational rate { get; set; }

        public static explicit operator double(MediaTime t);
    }
}
