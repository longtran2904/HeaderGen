#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Experimental.GlobalIllumination
{
    public static class LightmapperUtils
    {
        public static LightMode Extract(LightmapBakeType baketype);
        public static LinearColor ExtractIndirect(Light l);
        public static float ExtractInnerCone(Light l);
        public static void Extract(Light l, ref DirectionalLight dir);
        public static void Extract(Light l, ref PointLight point);
        public static void Extract(Light l, ref SpotLight spot);
        public static void Extract(Light l, ref RectangleLight rect);
        public static void Extract(Light l, ref DiscLight disc);
        public static void Extract(Light l, out Cookie cookie);
    }
}
