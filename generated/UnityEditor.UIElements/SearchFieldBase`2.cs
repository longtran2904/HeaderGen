#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public abstract class SearchFieldBase<TextInputType, T> : VisualElement, INotifyValueChanged<T> where TextInputType : TextInputBaseField<T>, new()
    {

        public static readonly string ussClassName;
        public static readonly string textUssClassName;
        public static readonly string textInputUssClassName;
        public static readonly string searchButtonUssClassName;
        public static readonly string cancelButtonUssClassName;
        public static readonly string cancelButtonOffVariantUssClassName;
        public static readonly string popupVariantUssClassName;

        protected SearchFieldBase();

        protected TextInputType textInputField { get; }
        protected Button searchButton { get; }
        public T value { get; set; }

        protected abstract void ClearTextField();
        public virtual void SetValueWithoutNotify(T newValue);
        protected abstract bool FieldIsEmpty(T fieldValue);
    }
}
