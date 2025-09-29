#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/IMGUI/GUIContent.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public class GUIContent
    {

        public static GUIContent none;

        public GUIContent();
        public GUIContent(string text);
        public GUIContent(Texture image);
        public GUIContent(string text, Texture image);
        public GUIContent(string text, string tooltip);
        public GUIContent(Texture image, string tooltip);
        public GUIContent(string text, Texture image, string tooltip);
        public GUIContent(GUIContent src);

        public string text { get; set; }
        public Texture image { get; set; }
        public string tooltip { get; set; }

        public override string ToString();
    }
}
