#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Build.Reporting
{
    [NativeClass("BuildReporting::PackedAssets")]
    [NativeType(Header = "Modules/BuildReportingEditor/Public/PackedAssets.h")]
    public sealed class PackedAssets : UnityEngine.Object
    {

        public PackedAssets();

        [Obsolete("Report file index is no longer available. To find the matching report file for a particular asset the recommended way is to do a filename lookup in the report.", True)]
        public uint file { get; }
        public string shortPath { get; }
        public ulong overhead { get; }
        public PackedAssetInfo[] contents { get; }
    }
}
