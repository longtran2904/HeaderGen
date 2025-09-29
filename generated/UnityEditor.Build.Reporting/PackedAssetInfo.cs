#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor.Build.Reporting
{
    [NativeType(Header = "Modules/BuildReportingEditor/Public/PackedAssets.h")]
    public struct PackedAssetInfo
    {
        [NativeName("fileID")]
        public long id { get; }
        public Type type { get; }
        public ulong packedSize { get; }
        public ulong offset { get; }
        public GUID sourceAssetGUID { get; }
        [NativeName("buildTimeAssetPath")]
        public string sourceAssetPath { get; }
    }
}
