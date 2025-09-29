#region UnityEngine.TextCoreFontEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreFontEngineModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.TextCore
{
    [UsedByNativeCode]
    public struct FaceInfo
    {
        public string familyName { get; set; }
        public string styleName { get; set; }
        public int pointSize { get; set; }
        public float scale { get; set; }
        public float lineHeight { get; set; }
        public float ascentLine { get; set; }
        public float capLine { get; set; }
        public float meanLine { get; set; }
        public float baseline { get; set; }
        public float descentLine { get; set; }
        public float superscriptOffset { get; set; }
        public float superscriptSize { get; set; }
        public float subscriptOffset { get; set; }
        public float subscriptSize { get; set; }
        public float underlineOffset { get; set; }
        public float underlineThickness { get; set; }
        public float strikethroughOffset { get; set; }
        public float strikethroughThickness { get; set; }
        public float tabWidth { get; set; }

        public bool Compare(FaceInfo other);
    }
}
