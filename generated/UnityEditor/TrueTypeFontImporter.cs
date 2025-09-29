#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Modules/TextRenderingEditor/TrueTypeFontImporter.h")]
    public sealed class TrueTypeFontImporter : AssetImporter
    {

        public TrueTypeFontImporter();

        public int fontSize { get; set; }
        public bool includeFontData { get; set; }
        public AscentCalculationMode ascentCalculationMode { get; set; }
        public string customCharacters { get; set; }
        public int characterSpacing { get; set; }
        public int characterPadding { get; set; }
        public FontRenderingMode fontRenderingMode { get; set; }
        public bool shouldRoundAdvanceValue { get; set; }
        [NativeProperty("FontNameFromTTFData", False, TargetType.Function)]
        public string fontTTFName { get; }
        [NativeProperty("ForceTextureCase", False, TargetType.Function)]
        public FontTextureCase fontTextureCase { get; set; }
        [NativeProperty("MarshalledFontReferences", False, TargetType.Function)]
        public Font[] fontReferences { get; set; }
        [NativeProperty("MarshalledFontNames", False, TargetType.Function)]
        public string[] fontNames { get; set; }

        public Font GenerateEditableFont(string path);
    }
}
