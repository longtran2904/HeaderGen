#region UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ParticleSystemModule.dll
#endregion

using System;

namespace UnityEngine
{
    public enum ParticleSystemShapeType
    {

        Sphere = 0,
        [Obsolete("SphereShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
        SphereShell = 1,
        Hemisphere = 2,
        [Obsolete("HemisphereShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
        HemisphereShell = 3,
        Cone = 4,
        Box = 5,
        Mesh = 6,
        [Obsolete("ConeShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
        ConeShell = 7,
        ConeVolume = 8,
        [Obsolete("ConeVolumeShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
        ConeVolumeShell = 9,
        Circle = 10,
        [Obsolete("CircleEdge is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
        CircleEdge = 11,
        SingleSidedEdge = 12,
        MeshRenderer = 13,
        SkinnedMeshRenderer = 14,
        BoxShell = 15,
        BoxEdge = 16,
        Donut = 17,
        Rectangle = 18,
        Sprite = 19,
        SpriteRenderer = 20
    }
}
