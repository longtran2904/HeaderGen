#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public class IESMetaData
    {
        public string FileFormatVersion;
        public string IESPhotometricType;
        public float IESMaximumIntensity;
        public string IESMaximumIntensityUnit;
        public string Manufacturer;
        public string LuminaireCatalogNumber;
        public string LuminaireDescription;
        public string LampCatalogNumber;
        public string LampDescription;
        public IESLightType PrefabLightType;
        [Range(1, 179)]
        public float SpotAngle;
        public IESResolution iesSize;
        public bool ApplyLightAttenuation;
        public bool UseIESMaximumIntensity;
        public TextureImporterCompression CookieCompression;
        [Range(-180, 180)]
        public float LightAimAxisRotation;

        public IESMetaData();

        public override int GetHashCode();
    }
}
