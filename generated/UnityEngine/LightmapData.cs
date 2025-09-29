#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/LightmapData.h")]
    [UsedByNativeCode]
    public sealed class LightmapData
    {
        public LightmapData();

        [Obsolete("Use lightmapColor property (UnityUpgradable) -> lightmapColor", False)]
        public Texture2D lightmapLight { get; set; }
        public Texture2D lightmapColor { get; set; }
        public Texture2D lightmapDir { get; set; }
        public Texture2D shadowMask { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property LightmapData.lightmap has been deprecated. Use LightmapData.lightmapColor instead (UnityUpgradable) -> lightmapColor", True)]
        public Texture2D lightmap { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property LightmapData.lightmapFar has been deprecated. Use LightmapData.lightmapColor instead (UnityUpgradable) -> lightmapColor", True)]
        public Texture2D lightmapFar { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property LightmapData.lightmapNear has been deprecated. Use LightmapData.lightmapDir instead (UnityUpgradable) -> lightmapDir", True)]
        public Texture2D lightmapNear { get; set; }
    }
}
