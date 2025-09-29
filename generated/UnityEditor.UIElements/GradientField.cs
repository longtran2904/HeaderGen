#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class GradientField : BaseField<Gradient>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string contentUssClassName;
        [Obsolete("borderUssClass is not used anymore", False)]
        public static readonly string borderUssClassName;

        public GradientField();
        public GradientField(string label);

        public override Gradient value { get; set; }
        public ColorSpace colorSpace { get; set; }

        protected override void ExecuteDefaultAction(EventBase evt);
        public override void SetValueWithoutNotify(Gradient newValue);
        protected override void UpdateMixedValueContent();

        public class UxmlFactory : UxmlFactory<GradientField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<Gradient>.UxmlTraits
        {
            public UxmlTraits();
        }
    }
}
