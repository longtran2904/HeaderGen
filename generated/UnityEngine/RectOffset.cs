#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/IMGUI/GUIStyle.h")]
    [UsedByNativeCode]
    public class RectOffset : IFormattable
    {
        public RectOffset();
        public RectOffset(int left, int right, int top, int bottom);

        ~RectOffset();

        [NativeProperty("left", False, TargetType.Field)]
        public int left { get; set; }
        [NativeProperty("right", False, TargetType.Field)]
        public int right { get; set; }
        [NativeProperty("top", False, TargetType.Field)]
        public int top { get; set; }
        [NativeProperty("bottom", False, TargetType.Field)]
        public int bottom { get; set; }
        public int horizontal { get; }
        public int vertical { get; }

        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        public Rect Add(Rect rect);
        public Rect Remove(Rect rect);
    }
}
