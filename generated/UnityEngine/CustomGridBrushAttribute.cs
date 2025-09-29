#region UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll
#endregion

using System;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CustomGridBrushAttribute : Attribute
    {

        public CustomGridBrushAttribute();
        public CustomGridBrushAttribute(bool hideAssetInstances, bool hideDefaultInstance, bool defaultBrush, string defaultName);

        public bool hideAssetInstances { get; }
        public bool hideDefaultInstance { get; }
        public bool defaultBrush { get; }
        public string defaultName { get; }
    }
}
