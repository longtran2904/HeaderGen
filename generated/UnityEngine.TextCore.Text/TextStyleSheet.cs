#region UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreTextEngineModule.dll
#endregion

namespace UnityEngine.TextCore.Text
{
    [ExcludeFromObjectFactory]
    [ExcludeFromPreset]
    public class TextStyleSheet : ScriptableObject
    {
        public TextStyleSheet();

        public TextStyle GetStyle(int hashCode);
        public TextStyle GetStyle(string name);
        public void RefreshStyles();
    }
}
