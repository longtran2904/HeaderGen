#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AssetImporters
{
    [MovedFrom("UnityEditor.Experimental.AssetImporters")]
    [NativeAsStruct]
    public class SourceTextureInformation
    {

        public SourceTextureInformation();

        public int width { get; set; }
        public int height { get; set; }
        public bool containsAlpha { get; set; }
        public bool hdr { get; set; }
    }
}
