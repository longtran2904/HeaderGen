#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;

namespace UnityEditor
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [NativeClass(null)]
    [Obsolete("DDSImporter is obsolete. Use IHVImageFormatImporter instead (UnityUpgradable) -> IHVImageFormatImporter", True)]
    public sealed class DDSImporter : AssetImporter
    {
        public DDSImporter();

        public bool isReadable { get; set; }
    }
}
