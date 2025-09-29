#region UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreTextEngineModule.dll
#endregion

namespace UnityEngine.TextCore.Text
{
    public class TextStyle
    {
        public static TextStyle NormalStyle { get; }
        public string name { get; set; }
        public int hashCode { get; set; }
        public string styleOpeningDefinition { get; }
        public string styleClosingDefinition { get; }
        public int[] styleOpeningTagArray { get; }
        public int[] styleClosingTagArray { get; }

        public void RefreshStyle();
    }
}
