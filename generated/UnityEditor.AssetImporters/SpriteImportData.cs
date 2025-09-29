#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AssetImporters
{
    [MovedFrom("UnityEditor.Experimental.AssetImporters")]
    public struct SpriteImportData
    {

        public string name { get; set; }
        public Rect rect { get; set; }
        public SpriteAlignment alignment { get; set; }
        public Vector2 pivot { get; set; }
        public Vector4 border { get; set; }
        public List<Vector2[]> outline { get; set; }
        public float tessellationDetail { get; set; }
        public string spriteID { get; set; }
    }
}
