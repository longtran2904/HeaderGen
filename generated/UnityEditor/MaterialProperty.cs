#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor
{
    public sealed class MaterialProperty
    {

        public MaterialProperty();

        public UnityEngine.Object[] targets { get; }
        public PropType type { get; }
        public string name { get; }
        public string displayName { get; }
        public PropFlags flags { get; }
        public TextureDimension textureDimension { get; }
        public Vector2 rangeLimits { get; }
        public bool hasMixedValue { get; }
        public ApplyPropertyCallback applyPropertyCallback { get; set; }
        public Color colorValue { get; set; }
        public Vector4 vectorValue { get; set; }
        public float floatValue { get; set; }
        public int intValue { get; set; }
        public Texture textureValue { get; set; }
        public Vector4 textureScaleAndOffset { get; set; }

        public void ReadFromMaterialPropertyBlock(MaterialPropertyBlock block);
        public void WriteToMaterialPropertyBlock(MaterialPropertyBlock materialblock, int changedPropertyMask);
        public delegate bool ApplyPropertyCallback(MaterialProperty prop, int changeMask, object previousValue);
        public enum PropType
        {

            Color = 0,
            Vector = 1,
            Float = 2,
            Range = 3,
            Texture = 4,
            Int = 5
        }
        [Flags]
        public enum PropFlags
        {

            None = 0,
            HideInInspector = 1,
            PerRendererData = 2,
            NoScaleOffset = 4,
            Normal = 8,
            HDR = 16,
            Gamma = 32,
            NonModifiableTextureData = 64
        }
        [Obsolete("Use UnityEngine.Rendering.TextureDimension instead.", False)]
        public enum TexDim
        {

            Unknown = -1,
            None = 0,
            Tex2D = 2,
            Tex3D = 3,
            Cube = 4,
            Any = 6
        }
    }
}
