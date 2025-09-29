#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Assertions.Comparers
{
    public class FloatComparer : IEqualityComparer<float>
    {
        public static readonly FloatComparer s_ComparerWithDefaultTolerance;
        public const float kEpsilon = 1E-05F;

        public FloatComparer();
        public FloatComparer(bool relative);
        public FloatComparer(float error);
        public FloatComparer(float error, bool relative);

        public bool Equals(float a, float b);
        public int GetHashCode(float obj);
        public static bool AreEqual(float expected, float actual, float error);
        public static bool AreEqualRelative(float expected, float actual, float error);
    }
}
