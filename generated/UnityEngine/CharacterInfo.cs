#region UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextRenderingModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public struct CharacterInfo
    {
        public int index;
        [Obsolete("CharacterInfo.uv is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead.")]
        public Rect uv;
        [Obsolete("CharacterInfo.vert is deprecated. Use minX, maxX, minY, maxY instead.")]
        public Rect vert;
        [NativeName("advance")]
        [Obsolete("CharacterInfo.width is deprecated. Use advance instead.")]
        public float width;
        public int size;
        public FontStyle style;
        [Obsolete("CharacterInfo.flipped is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead, which will be correct regardless of orientation.")]
        public bool flipped;

        public int advance { get; set; }
        public int glyphWidth { get; set; }
        public int glyphHeight { get; set; }
        public int bearing { get; set; }
        public int minY { get; set; }
        public int maxY { get; set; }
        public int minX { get; set; }
        public int maxX { get; set; }
        public Vector2 uvBottomLeft { get; set; }
        public Vector2 uvBottomRight { get; set; }
        public Vector2 uvTopRight { get; set; }
        public Vector2 uvTopLeft { get; set; }
    }
}
