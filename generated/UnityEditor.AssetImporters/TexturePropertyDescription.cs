#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.AssetImporters
{
    [NativeType(Header = "Editor/Src/AssetPipeline/ModelImporting/MaterialDescription.h")]
    public struct TexturePropertyDescription
    {
        public Vector2 offset;
        public Vector2 scale;
        public Texture texture;
        public string relativePath;
        public string path;
    }
}
