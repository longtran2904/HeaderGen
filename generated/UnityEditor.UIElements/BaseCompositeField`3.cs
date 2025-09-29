#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public abstract class BaseCompositeField<TValueType, TField, TFieldValue> : BaseField<TValueType> where TField : TextValueField<TFieldValue>, new()
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string spacerUssClassName;
        public static readonly string multilineVariantUssClassName;
        public static readonly string fieldGroupUssClassName;
        public static readonly string fieldUssClassName;
        public static readonly string firstFieldVariantUssClassName;
        public static readonly string twoLinesVariantUssClassName;

        protected BaseCompositeField(string label, int fieldsByLine);

        public override void SetValueWithoutNotify(TValueType newValue);
        protected override void UpdateMixedValueContent();
    }
}
