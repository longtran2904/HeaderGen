#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public abstract class TextValueField<TValueType> : TextInputBaseField<TValueType>, IValueField<TValueType>
    {
        protected TextValueField(int maxLength, TextValueInput textValueInput);
        protected TextValueField(string label, int maxLength, TextValueInput textValueInput);

        public string formatString { get; set; }
        public override TValueType value { get; set; }

        public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue);
        public void StartDragging();
        public void StopDragging();
        protected void AddLabelDragger<TDraggerType>();
        public override void SetValueWithoutNotify(TValueType newValue);

        protected abstract class TextValueInput : TextInputBaseField<TValueType>.TextInputBase
        {
            protected TextValueInput();

            protected abstract string allowedCharacters { get; }
            public string formatString { get; set; }

            public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue);
            public void StartDragging();
            public void StopDragging();
            protected abstract string ValueToString(TValueType value);
            protected override TValueType StringToValue(string str);
            protected override void ExecuteDefaultActionAtTarget(EventBase evt);
            protected override void ExecuteDefaultAction(EventBase evt);
        }
    }
}
