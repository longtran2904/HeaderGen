#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
    [NativeHeader("TerrainScriptingClasses.h")]
    [UsedByNativeCode]
    public sealed class DetailPrototype
    {

        public DetailPrototype();
        public DetailPrototype(DetailPrototype other);

        public GameObject prototype { get; set; }
        public Texture2D prototypeTexture { get; set; }
        public float minWidth { get; set; }
        public float maxWidth { get; set; }
        public float minHeight { get; set; }
        public float maxHeight { get; set; }
        public int noiseSeed { get; set; }
        public float noiseSpread { get; set; }
        [Obsolete("bendFactor has no effect and is deprecated.", False)]
        public float bendFactor { get; set; }
        public float holeEdgePadding { get; set; }
        public Color healthyColor { get; set; }
        public Color dryColor { get; set; }
        public DetailRenderMode renderMode { get; set; }
        public bool usePrototypeMesh { get; set; }
        public bool useInstancing { get; set; }

        public override bool Equals(object obj);
        public override int GetHashCode();
        public bool Validate();
        public bool Validate(out string errorMessage);
    }
}
