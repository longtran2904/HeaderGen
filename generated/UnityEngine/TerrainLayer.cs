#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("TerrainScriptingClasses.h")]
    [NativeHeader("Modules/Terrain/Public/TerrainLayerScriptingInterface.h")]
    [UsedByNativeCode]
    public sealed class TerrainLayer : Object
    {
        public TerrainLayer();

        public Texture2D diffuseTexture { get; set; }
        public Texture2D normalMapTexture { get; set; }
        public Texture2D maskMapTexture { get; set; }
        public Vector2 tileSize { get; set; }
        public Vector2 tileOffset { get; set; }
        [NativeProperty("SpecularColor")]
        public Color specular { get; set; }
        public float metallic { get; set; }
        public float smoothness { get; set; }
        public float normalScale { get; set; }
        public Vector4 diffuseRemapMin { get; set; }
        public Vector4 diffuseRemapMax { get; set; }
        public Vector4 maskMapRemapMin { get; set; }
        public Vector4 maskMapRemapMax { get; set; }
    }
}
