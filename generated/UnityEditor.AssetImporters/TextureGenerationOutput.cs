#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AssetImporters
{
    [MovedFrom("UnityEditor.Experimental.AssetImporters")]
    public struct TextureGenerationOutput
    {
        public Texture2D texture { get; }
        public Texture output { get; }
        public string importInspectorWarnings { get; }
        public string[] importWarnings { get; }
        public Texture2D thumbNail { get; }
        public Sprite[] sprites { get; }
    }
}
