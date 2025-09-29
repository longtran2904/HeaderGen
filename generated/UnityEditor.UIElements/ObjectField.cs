#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class ObjectField : BaseField<UnityEngine.Object>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string objectUssClassName;
        public static readonly string selectorUssClassName;

        public ObjectField();
        public ObjectField(string label);

        public Type objectType { get; set; }
        public bool allowSceneObjects { get; set; }

        public override void SetValueWithoutNotify(UnityEngine.Object newValue);
        protected override void UpdateMixedValueContent();

        public class UxmlFactory : UxmlFactory<ObjectField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<UnityEngine.Object>.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
