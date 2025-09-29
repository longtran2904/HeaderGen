#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    public struct Ray2D : IFormattable
    {

        public Ray2D(Vector2 origin, Vector2 direction);

        public Vector2 origin { get; set; }
        public Vector2 direction { get; set; }

        public Vector2 GetPoint(float distance);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
    }
}
