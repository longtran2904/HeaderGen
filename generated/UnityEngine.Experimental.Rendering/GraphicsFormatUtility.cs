#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
    [NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
    [NativeHeader("Runtime/Graphics/TextureFormat.h")]
    [NativeHeader("Runtime/Graphics/Format.h")]
    public class GraphicsFormatUtility
    {

        public GraphicsFormatUtility();

        public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB);
        public static TextureFormat GetTextureFormat(GraphicsFormat format);
        public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB);
        public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite);
        [FreeFunction(IsThreadSafe = True)]
        public static int GetDepthBits(GraphicsFormat format);
        public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsSRGBFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsSwizzleFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static GraphicsFormat GetSRGBFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static GraphicsFormat GetLinearFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static uint GetColorComponentCount(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static uint GetAlphaComponentCount(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static uint GetComponentCount(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static string GetFormatString(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsCompressedFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsPackedFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool Is16BitPackedFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static GraphicsFormat ConvertToAlphaFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsAlphaOnlyFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsAlphaTestFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool HasAlphaChannel(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsDepthFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsStencilFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsIEEE754Format(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsFloatFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsHalfFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsUnsignedFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsSignedFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsNormFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsUNormFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsSNormFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsIntegerFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsUIntFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsSIntFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsXRFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsDXTCFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsRGTCFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsBPTCFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsBCFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsPVRTCFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsETCFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsEACFormat(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsASTCFormat(GraphicsFormat format);
        public static bool IsCrunchFormat(TextureFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static FormatSwizzle GetSwizzleR(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static FormatSwizzle GetSwizzleG(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static FormatSwizzle GetSwizzleB(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static FormatSwizzle GetSwizzleA(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static uint GetBlockSize(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static uint GetBlockWidth(GraphicsFormat format);
        [FreeFunction(IsThreadSafe = True)]
        public static uint GetBlockHeight(GraphicsFormat format);
        public static uint ComputeMipmapSize(int width, int height, GraphicsFormat format);
        public static uint ComputeMipmapSize(int width, int height, int depth, GraphicsFormat format);
    }
}
