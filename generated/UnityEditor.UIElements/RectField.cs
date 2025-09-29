#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class RectField : BaseCompositeField<Rect, FloatField, float>
    {

        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public RectField();
        public RectField(string label);
        public class UxmlFactory : UxmlFactory<RectField, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<Rect>.UxmlTraits
        {

            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
