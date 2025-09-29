#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    public class UniversalRenderPipelineEditorResources : ScriptableObject
    {
        public ShaderResources shaders;
        public MaterialResources materials;

        public UniversalRenderPipelineEditorResources();

        [ReloadGroup]
        public sealed class ShaderResources
        {
            [Reload("Shaders/Autodesk Interactive/Autodesk Interactive.shadergraph", ReloadAttribute.Package.Root)]
            public Shader autodeskInteractivePS;
            [Reload("Shaders/Autodesk Interactive/Autodesk Interactive Transparent.shadergraph", ReloadAttribute.Package.Root)]
            public Shader autodeskInteractiveTransparentPS;
            [Reload("Shaders/Autodesk Interactive/Autodesk Interactive Masked.shadergraph", ReloadAttribute.Package.Root)]
            public Shader autodeskInteractiveMaskedPS;
            [Reload("Shaders/Terrain/TerrainDetailLit.shader", ReloadAttribute.Package.Root)]
            public Shader terrainDetailLitPS;
            [Reload("Shaders/Terrain/WavingGrass.shader", ReloadAttribute.Package.Root)]
            public Shader terrainDetailGrassPS;
            [Reload("Shaders/Terrain/WavingGrassBillboard.shader", ReloadAttribute.Package.Root)]
            public Shader terrainDetailGrassBillboardPS;
            [Reload("Shaders/Nature/SpeedTree7.shader", ReloadAttribute.Package.Root)]
            public Shader defaultSpeedTree7PS;
            [Reload("Shaders/Nature/SpeedTree8.shader", ReloadAttribute.Package.Root)]
            public Shader defaultSpeedTree8PS;

            public ShaderResources();
        }
        [ReloadGroup]
        public sealed class MaterialResources
        {
            [Reload("Runtime/Materials/Lit.mat", ReloadAttribute.Package.Root)]
            public Material lit;
            [Reload("Runtime/Materials/ParticlesLit.mat", ReloadAttribute.Package.Root)]
            public Material particleLit;
            [Reload("Runtime/Materials/TerrainLit.mat", ReloadAttribute.Package.Root)]
            public Material terrainLit;
            [Reload("Runtime/Materials/Decal.mat", ReloadAttribute.Package.Root)]
            public Material decal;

            public MaterialResources();
        }
    }
}
