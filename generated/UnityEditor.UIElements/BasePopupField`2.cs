#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public abstract class BasePopupField<TValueType, TValueChoice> : BaseField<TValueType>
    {

        public static readonly string ussClassName;
        public static readonly string textUssClassName;
        public static readonly string arrowUssClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        protected TextElement textElement { get; }
        public virtual List<TValueChoice> choices { get; set; }
        public string text { get; }

        public override void SetValueWithoutNotify(TValueType newValue);
        protected override void ExecuteDefaultActionAtTarget(EventBase evt);
        protected override void UpdateMixedValueContent();
    }
}
