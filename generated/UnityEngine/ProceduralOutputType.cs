#region UnityEngine.SubstanceModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubstanceModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.", True)]
    public enum ProceduralOutputType
    {
        Unknown = 0,
        Diffuse = 1,
        Normal = 2,
        Height = 3,
        Emissive = 4,
        Specular = 5,
        Opacity = 6,
        Smoothness = 7,
        AmbientOcclusion = 8,
        DetailMask = 9,
        Metallic = 10,
        Roughness = 11
    }
}
