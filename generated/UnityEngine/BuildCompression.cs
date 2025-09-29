#region UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AssetBundleModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public struct BuildCompression
    {

        public static readonly BuildCompression Uncompressed;
        public static readonly BuildCompression LZ4;
        public static readonly BuildCompression LZMA;
        public static readonly BuildCompression UncompressedRuntime;
        public static readonly BuildCompression LZ4Runtime;

        public CompressionType compression { get; }
        public CompressionLevel level { get; }
        public uint blockSize { get; }
    }
}
