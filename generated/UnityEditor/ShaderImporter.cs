#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/AssetPipeline/ShaderImporter.h")]
    public sealed class ShaderImporter : AssetImporter
    {

        public ShaderImporter();

        [NativeProperty("PreprocessorOverride")]
        public PreprocessorOverride preprocessorOverride { get; set; }

        public Shader GetShader();
        public void SetDefaultTextures(string[] name, Texture[] textures);
        public Texture GetDefaultTexture(string name);
        public void SetNonModifiableTextures(string[] name, Texture[] textures);
        public Texture GetNonModifiableTexture(string name);
    }
}
