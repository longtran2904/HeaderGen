#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<string>
    {

        public UxmlStringAttributeDescription();

        public override string defaultValueAsString { get; }

        public override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
        public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value);
    }
}
