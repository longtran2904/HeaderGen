#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ExcludeFromObjectFactory]
    [ExcludeFromPreset]
    [Obsolete("GUITexture has been removed. Use UI.Image instead.", True)]
    public sealed class GUITexture
    {

        public GUITexture();

        [Obsolete("GUITexture has been removed. Use UI.Image instead.", True)]
        public Color color { get; set; }
        [Obsolete("GUITexture has been removed. Use UI.Image instead.", True)]
        public Texture texture { get; set; }
        [Obsolete("GUITexture has been removed. Use UI.Image instead.", True)]
        public Rect pixelInset { get; set; }
        [Obsolete("GUITexture has been removed. Use UI.Image instead.", True)]
        public RectOffset border { get; set; }
    }
}
