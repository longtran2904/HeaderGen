#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [DefaultMember("Item")]
    [NativeHeader("Runtime/Export/Math/SphericalHarmonicsL2.bindings.h")]
    [UsedByNativeCode]
    public struct SphericalHarmonicsL2 : IEquatable<SphericalHarmonicsL2>
    {
        public float this[int rgb, int coefficient] { get; set; }

        public void Clear();
        public void AddAmbientLight(Color color);
        public void AddDirectionalLight(Vector3 direction, Color color, float intensity);
        public void Evaluate(Vector3[] directions, Color[] results);
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(SphericalHarmonicsL2 other);

        public static SphericalHarmonicsL2 operator *(SphericalHarmonicsL2 lhs, float rhs);
        public static SphericalHarmonicsL2 operator *(float lhs, SphericalHarmonicsL2 rhs);
        public static SphericalHarmonicsL2 operator +(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs);
        public static bool operator ==(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs);
        public static bool operator !=(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs);
    }
}
