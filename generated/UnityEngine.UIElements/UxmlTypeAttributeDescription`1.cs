#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class UxmlTypeAttributeDescription<TBase> : TypedUxmlAttributeDescription<Type>
    {
        public UxmlTypeAttributeDescription();

        public override string defaultValueAsString { get; }

        public override Type GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
        public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref Type value);
    }
}
