#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
    public sealed class LightProbes : Object
    {
        public Vector3[] positions { get; }
        public SphericalHarmonicsL2[] bakedProbes { get; set; }
        public int count { get; }
        public int cellCount { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use bakedProbes instead.", True)]
        public float[] coefficients { get; set; }

        public static event Action tetrahedralizationCompleted;
        public static event Action needsRetetrahedralization;

        [FreeFunction]
        public static void Tetrahedralize();
        [FreeFunction]
        public static void TetrahedralizeAsync();
        [FreeFunction]
        public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe);
        public static void CalculateInterpolatedLightAndOcclusionProbes(Vector3[] positions, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes);
        public static void CalculateInterpolatedLightAndOcclusionProbes(List<Vector3> positions, List<SphericalHarmonicsL2> lightProbes, List<Vector4> occlusionProbes);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use GetInterpolatedProbe instead.", True)]
        public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, float[] coefficients);
    }
}
