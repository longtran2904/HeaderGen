#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor
{
    [Flags]
    public enum StaticEditorFlags
    {

        [Description("Contribute Global Illumination")]
        ContributeGI = 1,
        OccluderStatic = 2,
        OccludeeStatic = 16,
        BatchingStatic = 4,
        NavigationStatic = 8,
        OffMeshLinkGeneration = 32,
        ReflectionProbeStatic = 64,
        [Obsolete("Enum member StaticEditorFlags.LightmapStatic has been deprecated. Use StaticEditorFlags.ContributeGI instead. (UnityUpgradable) -> ContributeGI", False)]
        LightmapStatic = 1
    }
}
