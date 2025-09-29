#region UnityEngine.ImageConversionModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ImageConversionModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
    [NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
    public static class ImageConversion
    {
        public static bool EnableLegacyPngGammaRuntimeLoadBehavior { get; set; }

        [NativeMethod(Name = "ImageConversionBindings::EncodeToTGA", IsFreeFunction = True, ThrowsException = True)]
        public static byte[] EncodeToTGA(this Texture2D tex);
        [NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = True, ThrowsException = True)]
        public static byte[] EncodeToPNG(this Texture2D tex);
        [NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = True, ThrowsException = True)]
        public static byte[] EncodeToJPG(this Texture2D tex, int quality);
        public static byte[] EncodeToJPG(this Texture2D tex);
        [NativeMethod(Name = "ImageConversionBindings::EncodeToEXR", IsFreeFunction = True, ThrowsException = True)]
        public static byte[] EncodeToEXR(this Texture2D tex, Texture2D.EXRFlags flags);
        public static byte[] EncodeToEXR(this Texture2D tex);
        [NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
        public static bool LoadImage([NotNull("ArgumentNullException")] this Texture2D tex, byte[] data, bool markNonReadable);
        public static bool LoadImage(this Texture2D tex, byte[] data);
        [FreeFunction("ImageConversionBindings::EncodeArrayToTGA", True)]
        public static byte[] EncodeArrayToTGA(Array array, GraphicsFormat format, uint width, uint height, uint rowBytes = 0);
        [FreeFunction("ImageConversionBindings::EncodeArrayToPNG", True)]
        public static byte[] EncodeArrayToPNG(Array array, GraphicsFormat format, uint width, uint height, uint rowBytes = 0);
        [FreeFunction("ImageConversionBindings::EncodeArrayToJPG", True)]
        public static byte[] EncodeArrayToJPG(Array array, GraphicsFormat format, uint width, uint height, uint rowBytes = 0, int quality = 75);
        [FreeFunction("ImageConversionBindings::EncodeArrayToEXR", True)]
        public static byte[] EncodeArrayToEXR(Array array, GraphicsFormat format, uint width, uint height, uint rowBytes = 0, Texture2D.EXRFlags flags = Texture2D.EXRFlags.None);
        public static NativeArray<byte> EncodeNativeArrayToTGA<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, uint rowBytes = 0) where T : struct;
        public static NativeArray<byte> EncodeNativeArrayToPNG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, uint rowBytes = 0) where T : struct;
        public static NativeArray<byte> EncodeNativeArrayToJPG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, uint rowBytes = 0, int quality = 75) where T : struct;
        public static NativeArray<byte> EncodeNativeArrayToEXR<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, uint rowBytes = 0, Texture2D.EXRFlags flags = Texture2D.EXRFlags.None) where T : struct;
    }
}
