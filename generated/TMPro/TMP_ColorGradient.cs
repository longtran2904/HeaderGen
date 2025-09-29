#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    [ExcludeFromPreset]
    public class TMP_ColorGradient : ScriptableObject
    {

        public ColorMode colorMode;
        public Color topLeft;
        public Color topRight;
        public Color bottomLeft;
        public Color bottomRight;

        public TMP_ColorGradient();
        public TMP_ColorGradient(Color color);
        public TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3);
    }
}
