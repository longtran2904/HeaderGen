#region UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreTextEngineModule.dll
#endregion

namespace UnityEngine.TextCore.Text
{
    [ExcludeFromObjectFactory]
    [ExcludeFromPreset]
    public class TextColorGradient : ScriptableObject
    {

        public ColorGradientMode colorMode;
        public Color topLeft;
        public Color topRight;
        public Color bottomLeft;
        public Color bottomRight;

        public TextColorGradient();
        public TextColorGradient(Color color);
        public TextColorGradient(Color color0, Color color1, Color color2, Color color3);
    }
}
