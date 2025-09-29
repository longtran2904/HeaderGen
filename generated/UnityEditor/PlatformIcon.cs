#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public class PlatformIcon
    {

        public int layerCount { get; set; }
        public int maxLayerCount { get; }
        public int minLayerCount { get; }
        public int width { get; }
        public int height { get; }
        public PlatformIconKind kind { get; }

        public Texture2D GetTexture(int layer = 0);
        public Texture2D[] GetTextures();
        public void SetTexture(Texture2D texture, int layer = 0);
        public void SetTextures(params Texture2D[] textures);
        public override string ToString();
    }
}
