#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class Vector3Field : BaseCompositeField<Vector3, FloatField, float>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public Vector3Field();
        public Vector3Field(string label);

        public class UxmlFactory : UxmlFactory<Vector3Field, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<Vector3>.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
