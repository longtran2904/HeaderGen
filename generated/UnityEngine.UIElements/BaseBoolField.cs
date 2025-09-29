#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class BaseBoolField : BaseField<bool>
    {

        protected Label m_Label;
        protected readonly VisualElement m_CheckMark;

        public BaseBoolField(string label);

        public string text { get; set; }

        protected virtual void InitLabel();
        public override void SetValueWithoutNotify(bool newValue);
        protected virtual void ToggleValue();
        protected override void UpdateMixedValueContent();
    }
}
