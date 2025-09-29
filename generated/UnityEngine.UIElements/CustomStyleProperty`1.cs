#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct CustomStyleProperty<T> : IEquatable<CustomStyleProperty<T>>
    {
        public CustomStyleProperty(string propertyName);

        public string name { get; }

        public override bool Equals(object obj);
        public bool Equals(CustomStyleProperty<T> other);
        public override int GetHashCode();

        public static bool operator ==(CustomStyleProperty<T> a, CustomStyleProperty<T> b);
        public static bool operator !=(CustomStyleProperty<T> a, CustomStyleProperty<T> b);
    }
}
