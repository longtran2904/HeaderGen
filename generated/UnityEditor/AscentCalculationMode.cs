#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public enum AscentCalculationMode
    {
        [InspectorName("Legacy version 2 mode (glyph bounding boxes)")]
        Legacy2x = 0,
        [InspectorName("Face ascender metric")]
        FaceAscender = 1,
        [InspectorName("Face bounding box metric")]
        FaceBoundingBox = 2
    }
}
