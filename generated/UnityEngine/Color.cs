#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [NativeClass("ColorRGBAf")]
    [NativeHeader("Runtime/Math/Color.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct Color : IEquatable<Color>, IFormattable
    {
        public float r;
        public float g;
        public float b;
        public float a;

        public Color(float r, float g, float b, float a);
        public Color(float r, float g, float b);

        public float this[int index] { get; set; }
        public static Color red { get; }
        public static Color green { get; }
        public static Color blue { get; }
        public static Color white { get; }
        public static Color black { get; }
        public static Color yellow { get; }
        public static Color cyan { get; }
        public static Color magenta { get; }
        public static Color gray { get; }
        public static Color grey { get; }
        public static Color clear { get; }
        public float grayscale { get; }
        public Color linear { get; }
        public Color gamma { get; }
        public float maxColorComponent { get; }

        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(Color other);
        public static Color Lerp(Color a, Color b, float t);
        public static Color LerpUnclamped(Color a, Color b, float t);
        public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V);
        public static Color HSVToRGB(float H, float S, float V);
        public static Color HSVToRGB(float H, float S, float V, bool hdr);

        public static Color operator +(Color a, Color b);
        public static Color operator -(Color a, Color b);
        public static Color operator *(Color a, Color b);
        public static Color operator *(Color a, float b);
        public static Color operator *(float b, Color a);
        public static Color operator /(Color a, float b);
        public static bool operator ==(Color lhs, Color rhs);
        public static bool operator !=(Color lhs, Color rhs);

        public static implicit operator Vector4(Color c);
        public static implicit operator Color(Vector4 v);
    }
}
