#region UnityEngine.SubstanceModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubstanceModule.dll
#endregion

using System;

namespace UnityEngine
{
    [ExcludeFromPreset]
    [Obsolete("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.", True)]
    public sealed class ProceduralTexture : Texture
    {
        public bool hasAlpha { get; }
        public TextureFormat format { get; }

        public ProceduralOutputType GetProceduralOutputType();
        public Color32[] GetPixels32(int x, int y, int blockWidth, int blockHeight);
    }
}
