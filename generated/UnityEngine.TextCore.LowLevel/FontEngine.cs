#region UnityEngine.TextCoreFontEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreFontEngineModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.TextCore.LowLevel
{
    [NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
    public sealed class FontEngine
    {

        public static FontEngineError InitializeFontEngine();
        public static FontEngineError DestroyFontEngine();
        public static FontEngineError LoadFontFace(string filePath);
        public static FontEngineError LoadFontFace(string filePath, int pointSize);
        public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex);
        public static FontEngineError LoadFontFace(byte[] sourceFontFile);
        public static FontEngineError LoadFontFace(byte[] sourceFontFile, int pointSize);
        public static FontEngineError LoadFontFace(byte[] sourceFontFile, int pointSize, int faceIndex);
        public static FontEngineError LoadFontFace(Font font);
        public static FontEngineError LoadFontFace(Font font, int pointSize);
        public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex);
        public static FontEngineError LoadFontFace(string familyName, string styleName);
        public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize);
        public static FontEngineError UnloadFontFace();
        public static FontEngineError UnloadAllFontFaces();
        public static string[] GetSystemFontNames();
        public static FontEngineError SetFaceSize(int pointSize);
        public static FaceInfo GetFaceInfo();
        public static string[] GetFontFaces();
        [NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
        public static bool TryGetGlyphIndex(uint unicode, out uint glyphIndex);
        public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph);
        public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph);
    }
}
