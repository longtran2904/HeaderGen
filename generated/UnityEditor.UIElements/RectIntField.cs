#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class RectIntField : BaseCompositeField<RectInt, IntegerField, int>
    {

        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public RectIntField();
        public RectIntField(string label);
        public class UxmlFactory : UxmlFactory<RectIntField, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<RectInt>.UxmlTraits
        {

            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
