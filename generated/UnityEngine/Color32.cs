#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [UsedByNativeCode]
    public struct Color32 : IFormattable
    {

        public byte r;
        public byte g;
        public byte b;
        public byte a;

        public Color32(byte r, byte g, byte b, byte a);

        public byte this[int index] { get; set; }

        public static Color32 Lerp(Color32 a, Color32 b, float t);
        public static Color32 LerpUnclamped(Color32 a, Color32 b, float t);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);

        public static implicit operator Color32(Color c);
        public static implicit operator Color(Color32 c);
    }
}
