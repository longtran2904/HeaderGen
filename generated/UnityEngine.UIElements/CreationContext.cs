#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public struct CreationContext : IEquatable<CreationContext>
    {
        public static readonly CreationContext Default;

        public VisualElement target { get; }
        public VisualTreeAsset visualTreeAsset { get; }
        public Dictionary<string, VisualElement> slotInsertionPoints { get; }

        public override bool Equals(object obj);
        public bool Equals(CreationContext other);
        public override int GetHashCode();

        public static bool operator ==(CreationContext context1, CreationContext context2);
        public static bool operator !=(CreationContext context1, CreationContext context2);
    }
}
