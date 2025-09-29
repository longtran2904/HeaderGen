#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class Vector3IntField : BaseCompositeField<Vector3Int, IntegerField, int>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public Vector3IntField();
        public Vector3IntField(string label);

        public class UxmlFactory : UxmlFactory<Vector3IntField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<Vector3Int>.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
