#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor.Build.Content
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("UnityEditor.Build.Content.CompressionType has been deprecated. Use UnityEngine.CompressionType instead (UnityUpgradable) -> [UnityEngine] UnityEngine.CompressionType", True)]
    public enum CompressionType
    {

        None = 0,
        Lzma = 1,
        Lz4 = 2,
        Lz4HC = 3
    }
}
