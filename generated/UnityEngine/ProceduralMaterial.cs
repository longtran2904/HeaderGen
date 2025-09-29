#region UnityEngine.SubstanceModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubstanceModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ExcludeFromPreset]
    [Obsolete("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.", True)]
    public sealed class ProceduralMaterial : Material
    {
        public ProceduralCacheSize cacheSize { get; set; }
        public int animationUpdateRate { get; set; }
        public bool isProcessing { get; }
        public bool isCachedDataAvailable { get; }
        public bool isLoadTimeGenerated { get; set; }
        public ProceduralLoadingBehavior loadingBehavior { get; }
        public static bool isSupported { get; }
        public static ProceduralProcessorUsage substanceProcessorUsage { get; set; }
        public string preset { get; set; }
        public bool isReadable { get; set; }
        public bool isFrozen { get; }

        public ProceduralPropertyDescription[] GetProceduralPropertyDescriptions();
        public bool HasProceduralProperty(string inputName);
        public bool GetProceduralBoolean(string inputName);
        public bool IsProceduralPropertyVisible(string inputName);
        public void SetProceduralBoolean(string inputName, bool value);
        public float GetProceduralFloat(string inputName);
        public void SetProceduralFloat(string inputName, float value);
        public Vector4 GetProceduralVector(string inputName);
        public void SetProceduralVector(string inputName, Vector4 value);
        public Color GetProceduralColor(string inputName);
        public void SetProceduralColor(string inputName, Color value);
        public int GetProceduralEnum(string inputName);
        public void SetProceduralEnum(string inputName, int value);
        public Texture2D GetProceduralTexture(string inputName);
        public void SetProceduralTexture(string inputName, Texture2D value);
        public string GetProceduralString(string inputName);
        public void SetProceduralString(string inputName, string value);
        public bool IsProceduralPropertyCached(string inputName);
        public void CacheProceduralProperty(string inputName, bool value);
        public void ClearCache();
        public void RebuildTextures();
        public void RebuildTexturesImmediately();
        public static void StopRebuilds();
        public Texture[] GetGeneratedTextures();
        public ProceduralTexture GetGeneratedTexture(string textureName);
        public void FreezeAndReleaseSourceData();
    }
}
