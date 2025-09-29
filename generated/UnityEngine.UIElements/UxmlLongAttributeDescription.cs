#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<long>
    {

        public UxmlLongAttributeDescription();

        public override string defaultValueAsString { get; }

        public override long GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
        public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref long value);
    }
}
