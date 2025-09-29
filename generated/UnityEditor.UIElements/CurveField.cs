#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class CurveField : BaseField<AnimationCurve>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string contentUssClassName;
        [Obsolete("borderUssClass is not used anymore", False)]
        public static readonly string borderUssClassName;

        public CurveField();
        public CurveField(string label);

        public Rect ranges { get; set; }
        public RenderMode renderMode { get; set; }
        public override AnimationCurve value { get; set; }

        public override void SetValueWithoutNotify(AnimationCurve newValue);
        protected override void ExecuteDefaultAction(EventBase evt);
        protected override void UpdateMixedValueContent();

        public class UxmlFactory : UxmlFactory<CurveField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<AnimationCurve>.UxmlTraits
        {
            public UxmlTraits();
        }
        public enum RenderMode
        {
            Texture = 0,
            Mesh = 1,
            Default = 0
        }
    }
}
