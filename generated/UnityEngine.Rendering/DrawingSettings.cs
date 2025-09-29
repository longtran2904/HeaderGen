#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct DrawingSettings : IEquatable<DrawingSettings>
    {

        public static readonly int maxShaderPasses;

        public DrawingSettings(ShaderTagId shaderPassName, SortingSettings sortingSettings);

        public SortingSettings sortingSettings { get; set; }
        public PerObjectData perObjectData { get; set; }
        public bool enableDynamicBatching { get; set; }
        public bool enableInstancing { get; set; }
        public Material overrideMaterial { get; set; }
        public int overrideMaterialPassIndex { get; set; }
        public Material fallbackMaterial { get; set; }
        public int mainLightIndex { get; set; }

        public ShaderTagId GetShaderPassName(int index);
        public void SetShaderPassName(int index, ShaderTagId shaderPassName);
        public bool Equals(DrawingSettings other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(DrawingSettings left, DrawingSettings right);
        public static bool operator !=(DrawingSettings left, DrawingSettings right);
    }
}
