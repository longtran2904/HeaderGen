#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Media
{
    [NativeHeader("Editor/Mono/Media/Bindings/MediaEncoder.bindings.h")]
    public struct MediaRational
    {

        public int numerator;
        public int denominator;
        public static readonly MediaRational Invalid;

        public MediaRational(int numerator);
        public MediaRational(int numerator, int denominator);

        public MediaRational inverse { get; }
        public bool isValid { get; }
        public bool isZero { get; }
        public bool isNegative { get; }

        public void Set(int numerator, int denominator = 1);

        public static explicit operator double(MediaRational r);
    }
}
