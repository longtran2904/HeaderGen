#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public class IESEngine
    {

        public IESEngine();

        public TextureImporterType TextureGenerationType { set; }

        public string ReadFile(string iesFilePath);
        public string GetKeywordValue(string keyword);
        public string GetPhotometricType();
        public (float, string) GetMaximumIntensity();
        public (string, Texture) GenerateCubeCookie(TextureImporterCompression compression, int textureSize);
        public (string, Texture) Generate2DCookie(TextureImporterCompression compression, float coneAngle, int textureSize, bool applyLightAttenuation);
    }
}
