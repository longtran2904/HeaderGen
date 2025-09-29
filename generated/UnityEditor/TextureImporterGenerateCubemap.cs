#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    public enum TextureImporterGenerateCubemap
    {
        [Obsolete("This value is deprecated (use TextureImporter.textureShape instead).")]
        None = 0,
        Spheremap = 1,
        Cylindrical = 2,
        [Obsolete("Obscure shperemap modes are not supported any longer (use TextureImporterGenerateCubemap.Spheremap instead).")]
        SimpleSpheremap = 3,
        [Obsolete("Obscure shperemap modes are not supported any longer (use TextureImporterGenerateCubemap.Spheremap instead).")]
        NiceSpheremap = 4,
        FullCubemap = 5,
        AutoCubemap = 6
    }
}
