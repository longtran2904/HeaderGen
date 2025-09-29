#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class Hash128Field : TextInputBaseField<Hash128>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public Hash128Field();
        public Hash128Field(int maxLength);
        public Hash128Field(string label, int maxLength = -1);

        public override Hash128 value { get; set; }

        public override void SetValueWithoutNotify(Hash128 newValue);

        public class UxmlFactory : UxmlFactory<Hash128Field, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : TextValueFieldTraits<Hash128, UxmlHash128AttributeDescription>
        {
            public UxmlTraits();
        }
    }
}
