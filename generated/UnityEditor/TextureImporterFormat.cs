#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor
{
    public enum TextureImporterFormat
    {

        Automatic = -1,
        [Obsolete("Use textureCompression property instead")]
        AutomaticCompressed = -1,
        [Obsolete("Use textureCompression property instead")]
        Automatic16bit = -2,
        [Obsolete("Use textureCompression property instead")]
        AutomaticTruecolor = -3,
        [Obsolete("Use crunchedCompression property instead")]
        AutomaticCrunched = -5,
        [Obsolete("HDR is handled automatically now")]
        AutomaticHDR = -6,
        [Obsolete("HDR is handled automatically now")]
        AutomaticCompressedHDR = -7,
        DXT1 = 10,
        DXT5 = 12,
        RGB16 = 7,
        RGB24 = 3,
        Alpha8 = 1,
        R16 = 9,
        R8 = 63,
        RG16 = 62,
        ARGB16 = 2,
        RGBA32 = 4,
        ARGB32 = 5,
        RGBA16 = 13,
        RHalf = 15,
        RGHalf = 16,
        RGBAHalf = 17,
        RFloat = 18,
        RGFloat = 19,
        RGBAFloat = 20,
        RGB9E5 = 22,
        BC4 = 26,
        BC5 = 27,
        BC6H = 24,
        BC7 = 25,
        DXT1Crunched = 28,
        DXT5Crunched = 29,
        PVRTC_RGB2 = 30,
        PVRTC_RGBA2 = 31,
        PVRTC_RGB4 = 32,
        PVRTC_RGBA4 = 33,
        ETC_RGB4 = 34,
        [Obsolete("Use ETC_RGB4 (UnityUpgradable) -> ETC_RGB4")]
        ATC_RGB4 = 35,
        [Obsolete("Use ETC2_RGBA8 (UnityUpgradable) -> ETC2_RGBA8")]
        ATC_RGBA8 = 36,
        EAC_R = 41,
        EAC_R_SIGNED = 42,
        EAC_RG = 43,
        EAC_RG_SIGNED = 44,
        ETC2_RGB4 = 45,
        ETC2_RGB4_PUNCHTHROUGH_ALPHA = 46,
        ETC2_RGBA8 = 47,
        ASTC_4x4 = 48,
        ASTC_5x5 = 49,
        ASTC_6x6 = 50,
        ASTC_8x8 = 51,
        ASTC_10x10 = 52,
        ASTC_12x12 = 53,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_4x4 (UnityUpgradable) -> ASTC_4x4")]
        ASTC_RGB_4x4 = 48,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_5x5 (UnityUpgradable) -> ASTC_5x5")]
        ASTC_RGB_5x5 = 49,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_6x6 (UnityUpgradable) -> ASTC_6x6")]
        ASTC_RGB_6x6 = 50,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_8x8 (UnityUpgradable) -> ASTC_8x8")]
        ASTC_RGB_8x8 = 51,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_10x10 (UnityUpgradable) -> ASTC_10x10")]
        ASTC_RGB_10x10 = 52,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_12x12 (UnityUpgradable) -> ASTC_12x12")]
        ASTC_RGB_12x12 = 53,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_4x4 (UnityUpgradable) -> ASTC_4x4")]
        ASTC_RGBA_4x4 = 54,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_5x5 (UnityUpgradable) -> ASTC_5x5")]
        ASTC_RGBA_5x5 = 55,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_6x6 (UnityUpgradable) -> ASTC_6x6")]
        ASTC_RGBA_6x6 = 56,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_8x8 (UnityUpgradable) -> ASTC_8x8")]
        ASTC_RGBA_8x8 = 57,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_10x10 (UnityUpgradable) -> ASTC_10x10")]
        ASTC_RGBA_10x10 = 58,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use ASTC_12x12 (UnityUpgradable) -> ASTC_12x12")]
        ASTC_RGBA_12x12 = 59,
        [Obsolete("Nintendo 3DS is no longer supported.")]
        ETC_RGB4_3DS = 60,
        [Obsolete("Nintendo 3DS is no longer supported.")]
        ETC_RGBA8_3DS = 61,
        ETC_RGB4Crunched = 64,
        ETC2_RGBA8Crunched = 65,
        ASTC_HDR_4x4 = 66,
        ASTC_HDR_5x5 = 67,
        ASTC_HDR_6x6 = 68,
        ASTC_HDR_8x8 = 69,
        ASTC_HDR_10x10 = 70,
        ASTC_HDR_12x12 = 71,
        RG32 = 72,
        RGB48 = 73,
        RGBA64 = 74
    }
}
