#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    [HelpURL("UIE-VisualTree-landing")]
    public class VisualTreeAsset : ScriptableObject
    {
        public VisualTreeAsset();

        public bool importedWithErrors { get; }
        public bool importedWithWarnings { get; }
        public IEnumerable<VisualTreeAsset> templateDependencies { get; }
        public IEnumerable<StyleSheet> stylesheets { get; }
        public int contentHash { get; set; }

        public TemplateContainer Instantiate();
        public TemplateContainer Instantiate(string bindingPath);
        public TemplateContainer CloneTree();
        public TemplateContainer CloneTree(string bindingPath);
        public void CloneTree(VisualElement target);
        public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount);
    }
}
