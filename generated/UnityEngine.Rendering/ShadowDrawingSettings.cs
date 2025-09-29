#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [UsedByNativeCode]
    public struct ShadowDrawingSettings : IEquatable<ShadowDrawingSettings>
    {

        public ShadowDrawingSettings(CullingResults cullingResults, int lightIndex);

        public CullingResults cullingResults { get; set; }
        public int lightIndex { get; set; }
        public bool useRenderingLayerMaskTest { get; set; }
        public ShadowSplitData splitData { get; set; }
        public ShadowObjectsFilter objectsFilter { get; set; }

        public bool Equals(ShadowDrawingSettings other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(ShadowDrawingSettings left, ShadowDrawingSettings right);
        public static bool operator !=(ShadowDrawingSettings left, ShadowDrawingSettings right);
    }
}
