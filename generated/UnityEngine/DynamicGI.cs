#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/GI/DynamicGI.h")]
    public sealed class DynamicGI
    {

        public DynamicGI();

        public static float indirectScale { get; set; }
        public static float updateThreshold { get; set; }
        public static int materialUpdateTimeSlice { get; set; }
        public static bool synchronousMode { get; set; }
        public static bool isConverged { get; }

        public static void SetEmissive(Renderer renderer, Color color);
        [NativeThrows]
        public static void SetEnvironmentData([NotNull("ArgumentNullException")] float[] input);
        public static void UpdateEnvironment();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("DynamicGI.UpdateMaterials(Renderer) is deprecated; instead, use extension method from RendererExtensions: 'renderer.UpdateGIMaterials()' (UnityUpgradable).", True)]
        public static void UpdateMaterials(Renderer renderer);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("DynamicGI.UpdateMaterials(Terrain) is deprecated; instead, use extension method from TerrainExtensions: 'terrain.UpdateGIMaterials()' (UnityUpgradable).", True)]
        public static void UpdateMaterials(Object renderer);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("DynamicGI.UpdateMaterials(Terrain, int, int, int, int) is deprecated; instead, use extension method from TerrainExtensions: 'terrain.UpdateGIMaterials(x, y, width, height)' (UnityUpgradable).", True)]
        public static void UpdateMaterials(Object renderer, int x, int y, int width, int height);
    }
}
