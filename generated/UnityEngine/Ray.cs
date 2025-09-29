#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    public struct Ray : IFormattable
    {

        public Ray(Vector3 origin, Vector3 direction);

        public Vector3 origin { get; set; }
        public Vector3 direction { get; set; }

        public Vector3 GetPoint(float distance);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
    }
}
