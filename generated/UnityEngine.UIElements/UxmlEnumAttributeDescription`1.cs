#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class UxmlEnumAttributeDescription<T> : TypedUxmlAttributeDescription<T> where T : IConvertible, struct
    {

        public UxmlEnumAttributeDescription();

        public override string defaultValueAsString { get; }

        public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
        public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref T value);
    }
}
