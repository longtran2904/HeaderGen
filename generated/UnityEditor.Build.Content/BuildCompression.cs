#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor.Build.Content
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("UnityEditor.Build.Content.BuildCompression has been deprecated. Use UnityEngine.BuildCompression instead (UnityUpgradable) -> [UnityEngine] UnityEngine.BuildCompression", True)]
    public struct BuildCompression
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("DefaultUncompressed has been deprecated. Use Uncompressed instead (UnityUpgradable) -> [UnityEngine] UnityEngine.BuildCompression.Uncompressed", True)]
        public static readonly BuildCompression DefaultUncompressed;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("DefaultLZ4 has been deprecated. Use LZ4 instead (UnityUpgradable) -> [UnityEngine] UnityEngine.BuildCompression.LZ4", True)]
        public static readonly BuildCompression DefaultLZ4;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("DefaultLZMA has been deprecated. Use LZMA instead (UnityUpgradable) -> [UnityEngine] UnityEngine.BuildCompression.LZMA", True)]
        public static readonly BuildCompression DefaultLZMA;
    }
}
