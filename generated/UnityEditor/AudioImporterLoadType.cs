#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("UnityEditor.AudioImporterLoadType has been deprecated. Use UnityEngine.AudioClipLoadType instead (UnityUpgradable) -> [UnityEngine] UnityEngine.AudioClipLoadType", True)]
    public enum AudioImporterLoadType
    {

        DecompressOnLoad = -1,
        CompressedInMemory = -1,
        [Obsolete("UnityEditor.AudioImporterLoadType.StreamFromDisc has been deprecated. Use UnityEngine.AudioClipLoadType.Streaming instead (UnityUpgradable) -> UnityEngine.AudioClipLoadType.Streaming", True)]
        StreamFromDisc = -1
    }
}
