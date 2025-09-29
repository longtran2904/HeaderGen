#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    [HelpURL("UIE-USS")]
    public class StyleSheet : ScriptableObject
    {
        public StyleSheet();

        public bool importedWithErrors { get; }
        public bool importedWithWarnings { get; }
        public int contentHash { get; set; }
    }
}
